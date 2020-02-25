using JoyStickMotionMapper.TimingData;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyStickMotionMapper.MotionControllers
{
    class X1CylMotionController : BaseMotionController
    {
        byte _Cylinder1 = 127;

        protected int Cylinder1
        {
            get
            {
                return _Cylinder1;
            }
            set
            {
                if (value > byte.MaxValue)
                    _Cylinder1 = byte.MaxValue;
                else if (value < 0)
                    _Cylinder1 = 0;
                else
                    _Cylinder1 = (byte)value;
            }
        }

        internal X1CylMotionController(TaPa_XYCyl Owner) : base(Owner)
        { }

        internal override void Start()
        {
            AddedMotion = new List<MomentaryPositionAndTimingFrameDataModel>();

            Axiss = new int[Owner.AxisInfos.Count()];
            Buttons = new bool[Owner.ButtonInfos.Count()];
            POVs = new int[Owner.POVInfos.Count()];
            for (int i = 0; i < Axiss.Count(); i++)
            {
                Axiss[i] = 32767;
            }
            for (int i = 0; i < POVs.Count(); i++)
            {
                POVs[i] = -1;
            }
            ResetCylinders();
            AddedMotion.Add(new MomentaryPositionAndTimingFrameDataModel() { Time = 0, C1 = (byte)Cylinder1 });
            base.Start();
        }

        internal override void Stop()
        {
            base.Stop();
            ResetCylinders();
            AddedMotion.Add(new MomentaryPositionAndTimingFrameDataModel() { Time = TimeBetweenTicksMS, C1 = (byte)Cylinder1});
            new PositionAndTimingDataModel() { PostionsAndTimings = AddedMotion.ToArray() }.SaveDataToFile(SavePath);
        }

        protected override void SetCylinders()
        {
            MotionHardwareInterface.SetCylinderHeight(1, (byte)Cylinder1);
        }

        protected override void SetCylinders(MomentaryPositionAndTimingFrameDataModel DataFrame)
        {
            MotionHardwareInterface.SetCylinderHeight(1, DataFrame.C1);
        }

        protected override void ResetCylinders()
        {
            Cylinder1 = 127;
            SetCylinders();
        }

        protected override void Tick()
        {
            const byte SensitivtyBase = 127;

            int XAxis = 32767;
            int Sensitivity = 65534;

            float NormalizedAxis;

            MomentaryPositionAndTimingFrameDataModel DataFrame = new MomentaryPositionAndTimingFrameDataModel();
            DataFrame.Time = TimeBetweenTicksMS;

            JoyStick.Poll();
            JoystickUpdate[] Data = JoyStick.GetBufferedData();
            int Num = 0;

            Sensitivity = ClampCast(SensitivtyBase * SensitivtyCalc);

            foreach (DeviceObjectInstance Axis in Owner.AxisInfos)
            {
                if (Data.Any(x => x.RawOffset == Axis.Offset + OtherAxisOffsetOffset || x.RawOffset == Axis.Offset))
                    Axiss[Num] = Data.Last(x => x.RawOffset == Axis.Offset + OtherAxisOffsetOffset || x.RawOffset == Axis.Offset).Value;
                if (Axis == JoyAxisForMechXAxisTilt)
                    XAxis = Axiss[Num];
                if (Axis == JoyAxisForMechSensitivity)
                {
                    Sensitivity = Axiss[Num];
                    SensitivtyCalc = CalculateUnsighedNormal(Sensitivity);
                    Sensitivity = ClampCast(SensitivtyBase * SensitivtyCalc);
                }
                Num++;
            }

            NormalizedAxis = CalculateNormal((float)XAxis);

            MoveForX(NormalizedAxis, (byte)Sensitivity);

            DataFrame.C1 = (byte)Cylinder1;

            Num = 0;
            foreach (DeviceObjectInstance POV in Owner.POVInfos)
            {
                if (Data.Any(x => x.RawOffset == POV.Offset + POVOffsetOffset))
                    POVs[Num] = Data.Last(x => x.RawOffset == POV.Offset + POVOffsetOffset).Value;
                Num++;
            }

            DoButtons(Data, ref DataFrame);

            //add noise on top of the regualr movement
            if (AddSytheticNoiseEffect)
            {
                DataFrame.C1 = ClampCast(DataFrame.C1 + SytheticNoiseEffectBaseHalfValue - RandomNumber.Next(0, SytheticNoiseEffectBaseValue));
            }


            AddedMotion.Add(DataFrame);
            SetCylinders(DataFrame);
        }

        void MoveForX(float XAxis, byte Sensitivity)
        {
            Cylinder1 = ClampCast(Cylinder1 + ( Sensitivity * XAxis));
        }

    }
}
