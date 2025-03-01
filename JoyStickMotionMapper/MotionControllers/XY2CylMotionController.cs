﻿using JoyStickMotionMapper.TimingData;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyStickMotionMapper.MotionControllers
{
    class XY2CylMotionController : BaseMotionController
    {
        byte _Cylinder1 = 127;
        byte _Cylinder2 = 127;

        protected int Cylinder1
        {
            get
            {
                return _Cylinder1;
            }

            set
            {
                if (_Cylinder1 > byte.MaxValue)
                    _Cylinder1 = byte.MaxValue;
                else if (_Cylinder1 < 0)
                    _Cylinder1 = 0;
                else
                    _Cylinder1 = (byte)value;
            }
        }
        protected int Cylinder2
        {
            get
            {
                return _Cylinder2;
            }

            set
            {
                if (value > byte.MaxValue)
                    _Cylinder2 = byte.MaxValue;
                else if (value < 0)
                    _Cylinder2 = 0;
                else
                    _Cylinder2 = (byte)value;
            }
        }
        internal XY2CylMotionController(TaPa_XYCyl Owner) : base(Owner)
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
            AddedMotion.Add(new MomentaryPositionAndTimingFrameDataModel() { Time = TimeBetweenTicksMS, C1 = (byte)Cylinder1 });
            new PositionAndTimingDataModel() { PostionsAndTimings = AddedMotion.ToArray() }.SaveDataToFile(SavePath);
        }

        protected override void ResetCylinders()
        {
            Cylinder1 = 127;
            Cylinder2 = 127;
            SetCylinders();
        }

        protected override void SetCylinders()
        {
            MotionHardwareInterface.SetCylinderHeight(1, (byte)Cylinder1);
            MotionHardwareInterface.SetCylinderHeight(2, (byte)Cylinder2);
        }

        protected override void SetCylinders(MomentaryPositionAndTimingFrameDataModel DataFrame)
        {
            MotionHardwareInterface.SetCylinderHeight(1, DataFrame.C1);
            MotionHardwareInterface.SetCylinderHeight(2, DataFrame.C2);
        }

        protected override void Tick()
        {
            const byte SensitivtyBase = 127;

            int XAxis = 32767;
            int YAxis = 32767;
            int Sensitivity = 65534;

            Vector NormalizedVector;

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
                if (Axis == JoyAxisForMechYAxisTilt)
                    YAxis = Axiss[Num];
                if (Axis == JoyAxisForMechSensitivity)
                {
                    Sensitivity = Axiss[Num];
                    SensitivtyCalc = CalculateUnsighedNormal(Sensitivity);
                    Sensitivity = ClampCast(SensitivtyBase * SensitivtyCalc);
                }
                Num++;
            }

            NormalizedVector = CalculateNormalVector(new Vector() { X = (float)XAxis, Y = (float)YAxis});

            MoveForXY(NormalizedVector.X, NormalizedVector.Y, (byte)Sensitivity);


            DataFrame.C1 = (byte)Cylinder1;
            DataFrame.C2 = (byte)Cylinder2;

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
                DataFrame.C2 = ClampCast(DataFrame.C2 + SytheticNoiseEffectBaseHalfValue - RandomNumber.Next(0, SytheticNoiseEffectBaseValue));
            }


            AddedMotion.Add(DataFrame);
            SetCylinders(DataFrame);
        }

        void MoveForXY(float XAxis, float YAxis, byte Sensitivity)
        {
            Cylinder1 = ClampCast(Cylinder1 + (0 * Sensitivity * YAxis) + (-1 * Sensitivity * XAxis));
            Cylinder2 = ClampCast(Cylinder2 + (Sensitivity * YAxis) + (Sensitivity * XAxis));
        }
    }
}
