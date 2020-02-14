using JoyStickMotionMapper.TimingData;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JoyStickMotionMapper.MotionControllers
{
    class XYZ3CylMotionController : BaseMotionController
    {
        Random RandomNumber = new Random();

        internal bool AddSytheticNoiseEffect = false;

        const int SytheticNoiseEffectBaseValue = 10;
        int SytheticNoiseEffectBaseHalfValue = SytheticNoiseEffectBaseValue / 2;

        internal int Sensitivity { get; set; }

        byte _Cylinder1 = 127;
        byte _Cylinder2 = 127;
        byte _Cylinder3 = 127;

        float SensitivtyCalc = 0.25f;

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

        protected int Cylinder3
        {
            get
            {
                return _Cylinder3;
            }
            set
            {
                if (value > byte.MaxValue)
                    _Cylinder3 = byte.MaxValue;
                else if (value < 0)
                    _Cylinder3 = 0;
                else
                    _Cylinder3 = (byte)value;
            }
        }

        internal XYZ3CylMotionController(Form1 Owner) : base(Owner)
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
            AddedMotion.Add(new MomentaryPositionAndTimingFrameDataModel() { Time = 0, C1 = (byte)Cylinder1, C2 = (byte)Cylinder2, C3 = (byte)Cylinder3 });
            base.Start();
        }

        internal override void Stop()
        {
            base.Stop();
            ResetCylinders();
            AddedMotion.Add(new MomentaryPositionAndTimingFrameDataModel() { Time = TimeBetweenTicksMS, C1 = (byte)Cylinder1, C2 = (byte)Cylinder2, C3 = (byte)Cylinder3 });
            new PositionAndTimingDataModel() { PostionsAndTimings = AddedMotion.ToArray() }.SaveDataToFile(SavePath);
        }

        protected override void SetCylinders()
        {
            MotionHardwareInterface.SetCylinderHeight(0, (byte)Cylinder1);
            MotionHardwareInterface.SetCylinderHeight(1, (byte)Cylinder2);
            MotionHardwareInterface.SetCylinderHeight(2, (byte)Cylinder3);
        }

        protected void SetCylinders(MomentaryPositionAndTimingFrameDataModel DataFrame)
        {
            MotionHardwareInterface.SetCylinderHeight(0, DataFrame.C1);
            MotionHardwareInterface.SetCylinderHeight(1, DataFrame.C2);
            MotionHardwareInterface.SetCylinderHeight(2, DataFrame.C3);
        }

        protected override void ResetCylinders()
        {
            Cylinder1 = 127;
            Cylinder2 = 127;
            Cylinder3 = 127;
            SetCylinders();
        }

        protected override void Tick()
        {
            const byte SensitivtyBase = 127;

            int XAxis = 32767;
            int YAxis = 32767;
            int ZAxis = 32767;
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
                if (Axis == JoyAxisForMechBaseHeight)
                    ZAxis = Axiss[Num];
                if (Axis == JoyAxisForMechSensitivity)
                {
                    Sensitivity = Axiss[Num];
                    SensitivtyCalc = CalculateUnsighedNormal(Sensitivity);
                    Sensitivity = ClampCast(SensitivtyBase * SensitivtyCalc);
                }
                Num++;
            }

            NormalizedVector = CalculateNormalVector(new Vector() { X = (float)XAxis, Y = (float)YAxis, Z = (float)ZAxis });

            MoveForXY(NormalizedVector.X, NormalizedVector.Y, (byte)Sensitivity);


            DataFrame.C1 = (byte)Cylinder1;
            DataFrame.C2 = (byte)Cylinder2;
            DataFrame.C3 = (byte)Cylinder3;

            Num = 0;
            foreach (DeviceObjectInstance POV in Owner.POVInfos)
            {
                if (Data.Any(x => x.RawOffset == POV.Offset + POVOffsetOffset))
                    POVs[Num] = Data.Last(x => x.RawOffset == POV.Offset + POVOffsetOffset).Value;
                Num++;
            }

            DataFrame.Back = AddedMotion.Count() > 0 ? AddedMotion.Last().Back : false;
            DataFrame.Bubbles = AddedMotion.Count() > 0 ? AddedMotion.Last().Bubbles : false;
            DataFrame.Flame = AddedMotion.Count() > 0 ? AddedMotion.Last().Flame : false;
            DataFrame.Jet = AddedMotion.Count() > 0 ? AddedMotion.Last().Jet : false;
            DataFrame.Lightning = AddedMotion.Count() > 0 ? AddedMotion.Last().Lightning : false;
            DataFrame.Rain = AddedMotion.Count() > 0 ? AddedMotion.Last().Rain : false;
            DataFrame.Smoke = AddedMotion.Count() > 0 ? AddedMotion.Last().Smoke : false;
            DataFrame.Snowflakes = AddedMotion.Count() > 0 ? AddedMotion.Last().Snowflakes : false;
            DataFrame.Spare1 = AddedMotion.Count() > 0 ? AddedMotion.Last().Spare1 : false;
            DataFrame.Spare2 = AddedMotion.Count() > 0 ? AddedMotion.Last().Spare2 : false;
            DataFrame.Spare3 = AddedMotion.Count() > 0 ? AddedMotion.Last().Spare3 : false;
            DataFrame.SweepingLegs1 = AddedMotion.Count() > 0 ? AddedMotion.Last().SweepingLegs1 : false;
            DataFrame.SweepingLegs2 = AddedMotion.Count() > 0 ? AddedMotion.Last().SweepingLegs2 : false;
            DataFrame.Vibration = AddedMotion.Count() > 0 ? AddedMotion.Last().Vibration : false;
            DataFrame.WaterSpray = AddedMotion.Count() > 0 ? AddedMotion.Last().WaterSpray : false;
            DataFrame.Wind = AddedMotion.Count() > 0 ? AddedMotion.Last().Wind : false;

            Num = 0;
            foreach (DeviceObjectInstance Button in Owner.ButtonInfos)
            {
                if (Data.Any(x => x.RawOffset == Button.Offset + ButtonsOffsetOffset))
                    Buttons[Num] = Data.Last(x => x.RawOffset == Button.Offset + ButtonsOffsetOffset).Value != 0 ? true : false;

                if (Button == JoyButtonForMechBackStateTrigger && Buttons[Num])
                        DataFrame.Back = !DataFrame.Back;

                if (Button == JoyButtonForMechBubblesStateTrigger && Buttons[Num])
                        DataFrame.Bubbles = !DataFrame.Bubbles;

                if (Button == JoyButtonForMechFlameStateTrigger && Buttons[Num])
                        DataFrame.Flame = !DataFrame.Flame;

                if (Button == JoyButtonForMechJetStateTrigger && Buttons[Num])
                        DataFrame.Jet = !DataFrame.Jet;

                if (Button == JoyButtonForMechLightningStateTrigger && Buttons[Num])
                        DataFrame.Lightning = !DataFrame.Lightning;

                if (Button == JoyButtonForMechRainStateTrigger && Buttons[Num])
                        DataFrame.Rain = !DataFrame.Rain;

                if (Button == JoyButtonForMechSmokeStateTrigger && Buttons[Num])
                        DataFrame.Smoke = !DataFrame.Smoke;

                if (Button == JoyButtonForMechSnowflakeStateTrigger && Buttons[Num])
                        DataFrame.Snowflakes = !DataFrame.Snowflakes;

                if (Button == JoyButtonForMechSpare1StateTrigger && Buttons[Num])
                        DataFrame.Spare1 = !DataFrame.Spare1;

                if (Button == JoyButtonForMechSpare2StateTrigger && Buttons[Num])
                        DataFrame.Spare2 = !DataFrame.Spare2;

                if (Button == JoyButtonForMechSpare3StateTrigger && Buttons[Num])
                        DataFrame.Spare3 = !DataFrame.Spare3;

                if (Button == JoyButtonForMechSweepingLegs1StateTrigger && Buttons[Num])
                        DataFrame.SweepingLegs1 = !DataFrame.SweepingLegs1;

                if (Button == JoyButtonForMechSweepingLegs2StateTrigger && Buttons[Num])
                        DataFrame.SweepingLegs2 = !DataFrame.SweepingLegs2;

                if (Button == JoyButtonForMechVibrationStateTrigger && Buttons[Num])
                        DataFrame.Vibration = !DataFrame.Vibration;

                if (Button == JoyButtonForMechWaterSprayStateTrigger && Buttons[Num])
                        DataFrame.WaterSpray = !DataFrame.WaterSpray;

                if (Button == JoyButtonForMechWindStateTrigger && Buttons[Num])
                        DataFrame.Wind = !DataFrame.Wind;

                if (Button == JoyButtonForMechSytheticNoiseEffect && Buttons[Num])
                    AddSytheticNoiseEffect = !AddSytheticNoiseEffect;

                if(Button == JoyButtonForEnd && Buttons[Num])
                    Task.Run(()=>Owner.CaptureEnd.Invoke());

                Num++;
            }

            //add noise on top of the regualr movement
            if(AddSytheticNoiseEffect)
            {
                DataFrame.C1 = ClampCast(DataFrame.C1 + SytheticNoiseEffectBaseHalfValue - RandomNumber.Next(0, SytheticNoiseEffectBaseValue));
                DataFrame.C2 = ClampCast(DataFrame.C2 + SytheticNoiseEffectBaseHalfValue - RandomNumber.Next(0, SytheticNoiseEffectBaseValue));
                DataFrame.C3 = ClampCast(DataFrame.C3 + SytheticNoiseEffectBaseHalfValue - RandomNumber.Next(0, SytheticNoiseEffectBaseValue));
            }


            AddedMotion.Add(DataFrame);
            SetCylinders(DataFrame);
        }

        byte ClampCast(int Value)
        {
            if (Value < 0)
                return 0;
            if (Value > 255)
                return 255;
            return Convert.ToByte(Value);
        }

        byte ClampCast(float Value)
        {
            if(Value < 0)
             return 0;
            if (Value > 255)
                return 255;
            return Convert.ToByte(Value);
        }

        void MoveForXY(float XAxis, float YAxis, byte Sensitivity)
        {
            Cylinder1 = ClampCast(Cylinder1 + (0 * Sensitivity * YAxis) + (-1 * Sensitivity * XAxis));
            Cylinder2 = ClampCast(Cylinder2 + (Sensitivity * YAxis) + (Sensitivity * XAxis));
            Cylinder3 = ClampCast(Cylinder3 + (-1 * Sensitivity * YAxis) + (Sensitivity * XAxis));
        }
    }
}
