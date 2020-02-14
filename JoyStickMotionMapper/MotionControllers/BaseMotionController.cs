using JoyStickMotionMapper.ComMotionSystem;
using JoyStickMotionMapper.MotionHardwareInterface;
using JoyStickMotionMapper.TimingData;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace JoyStickMotionMapper.MotionControllers
{
    abstract class BaseMotionController
    {
        internal string SavePath;

        internal List<MomentaryPositionAndTimingFrameDataModel> AddedMotion;

        protected const int ButtonsOffsetOffset = 24;
        protected const int POVOffsetOffset = 24;
        protected const int OtherAxisOffsetOffset = 8;

        protected Form1 Owner;

        public object LockObj { protected set; get; } = new object();

        protected Stopwatch TickTimer;

        internal ulong TimeBetweenTicksMS = 500;

        protected Thread ThreadLoop;

        public bool Run { protected set; get; } = false;

        public bool LoopFinished { protected set; get; } = true;

        public Joystick JoyStick { protected set; get; } = null;

        public AvalibleProtocols MotionDeviceProtocol { protected set; get; } = AvalibleProtocols.ComPort;

        protected IMotionHardwareInterface MotionHardwareInterface { get; private set; }

        const int TotalAxis = 65535;
        const int HalfOfAxis = 32767;
        const float DeadZone = 0.15f;
        static readonly float NDeadZone = DeadZone * -1.0f;


        protected struct Vector
        {
            internal float X;
            internal float Y;
            internal float Z;

            internal static readonly Vector IgnoreZ = new Vector() { X = 0, Y = 0, Z = 1 };
        }

#pragma warning disable CS0649
        internal int[] Axiss;
        internal bool[] Buttons;
        internal int[] POVs;
        internal DeviceObjectInstance JoyAxisForMechXAxisTilt,
                    JoyAxisForMechYAxisTilt,
                    JoyAxisForMechBaseHeight,
                    JoyAxisForMechSensitivity,
                    JoyButtonForMechBackStateTrigger,
                    JoyButtonForMechBubblesStateTrigger,
                    JoyButtonForMechFlameStateTrigger,
                    JoyButtonForMechJetStateTrigger,
                    JoyButtonForMechLightningStateTrigger,
                    JoyButtonForMechRainStateTrigger,
                    JoyButtonForMechSmokeStateTrigger,
                    JoyButtonForMechSnowflakeStateTrigger,
                    JoyButtonForMechSpare1StateTrigger,
                    JoyButtonForMechSpare2StateTrigger,
                    JoyButtonForMechSpare3StateTrigger,
                    JoyButtonForMechSweepingLegs1StateTrigger,
                    JoyButtonForMechSweepingLegs2StateTrigger,
                    JoyButtonForMechVibrationStateTrigger,
                    JoyButtonForMechWaterSprayStateTrigger,
                    JoyButtonForMechWindStateTrigger,
                    JoyButtonForMechSytheticNoiseEffect,
                    JoyButtonForEnd;
#pragma warning restore CS0649

        internal BaseMotionController(Form1 Owner)
        {
            this.Owner = Owner;
        }

        internal virtual void ReleaseHardware()
        {
            MotionHardwareInterface.ReleaseHardware();
        }

        internal virtual void GrabHardware()
        {
            MotionHardwareInterface.GrabHardware();
        }

        internal virtual void ChangeJoystick(Joystick JoyStick)
        {
            lock (LockObj)
            {
                this.JoyStick = JoyStick;
                JoyAxisForMechXAxisTilt = null;
                JoyAxisForMechYAxisTilt = null;
                JoyAxisForMechBaseHeight = null;
                JoyAxisForMechSensitivity = null;
                JoyButtonForMechBackStateTrigger = null;
                JoyButtonForMechBubblesStateTrigger = null;
                JoyButtonForMechFlameStateTrigger = null;
                JoyButtonForMechJetStateTrigger = null;
                JoyButtonForMechLightningStateTrigger = null;
                JoyButtonForMechRainStateTrigger = null;
                JoyButtonForMechSmokeStateTrigger = null;
                JoyButtonForMechSnowflakeStateTrigger = null;
                JoyButtonForMechSpare1StateTrigger = null;
                JoyButtonForMechSpare2StateTrigger = null;
                JoyButtonForMechSpare3StateTrigger = null;
                JoyButtonForMechSweepingLegs1StateTrigger = null;
                JoyButtonForMechSweepingLegs2StateTrigger = null;
                JoyButtonForMechVibrationStateTrigger = null;
                JoyButtonForMechWaterSprayStateTrigger = null;
                JoyButtonForMechWindStateTrigger = null;
            }
        }

        internal virtual void ChangeProtocol(AvalibleProtocols MotionDeviceProtocol, string ConnectonString)
        {
            lock (LockObj)
            {
                this.MotionDeviceProtocol = MotionDeviceProtocol;
                switch (MotionDeviceProtocol)
                {
                    case AvalibleProtocols.ComPort:
                        if (MotionHardwareInterface != null)
                            MotionHardwareInterface.Dispose();
                        MotionHardwareInterface = JMDM_CylinderPortControlUpdated.ConnectionFactory(ConnectonString);
                        break;
                    default:
                        throw new Exception("Error: not a valid Protocol.");
                }
            }
        }

        internal void ClearJoystickSelection()
        {
            lock (LockObj)
            {
                JoyStick = null;
                JoyAxisForMechXAxisTilt = null;
                JoyAxisForMechYAxisTilt = null;
                JoyAxisForMechBaseHeight = null;
                JoyAxisForMechSensitivity = null;
                JoyButtonForMechBackStateTrigger = null;
                JoyButtonForMechBubblesStateTrigger = null;
                JoyButtonForMechFlameStateTrigger = null;
                JoyButtonForMechJetStateTrigger = null;
                JoyButtonForMechLightningStateTrigger = null;
                JoyButtonForMechRainStateTrigger = null;
                JoyButtonForMechSmokeStateTrigger = null;
                JoyButtonForMechSnowflakeStateTrigger = null;
                JoyButtonForMechSpare1StateTrigger = null;
                JoyButtonForMechSpare2StateTrigger = null;
                JoyButtonForMechSpare3StateTrigger = null;
                JoyButtonForMechSweepingLegs1StateTrigger = null;
                JoyButtonForMechSweepingLegs2StateTrigger = null;
                JoyButtonForMechVibrationStateTrigger = null;
                JoyButtonForMechWaterSprayStateTrigger = null;
                JoyButtonForMechWindStateTrigger = null;
            }
        }

        protected virtual float CalculateNormal(float UnNormalizedField, bool LeaveDeadZone = true)
        {
            float NormalizedField = (UnNormalizedField - (float)HalfOfAxis) / (float)HalfOfAxis;
            if (NormalizedField > 1.0f)
                NormalizedField = 1.0f;
            if (DeadZone < NormalizedField && NormalizedField < NDeadZone)
                NormalizedField = 0;
            return NormalizedField;
        }

        protected virtual float CalculateUnsighedNormal(float UnNormalizedField)
        {
            return UnNormalizedField / TotalAxis;
        }

        protected virtual Vector CalculateNormalVector(Vector UnNormalizedVector, bool LeaveDeadZone = true)
        {
            //find a vector that is normalized (as 1 to 0 as a absolute value of the mid point) 
            Vector Return = new Vector()
            {
                X = (UnNormalizedVector.X - (float)HalfOfAxis) / (float)HalfOfAxis,
                Y = (UnNormalizedVector.Y - (float)HalfOfAxis)  / (float)HalfOfAxis,
                Z = (UnNormalizedVector.Z - (float)HalfOfAxis) / (float)HalfOfAxis
            };
            if (Return.X > 1.0f)
                Return.X = 1.0f;
            if (Return.Y > 1.0f)
                Return.Y = 1.0f;
            if (Return.Z > 1.0f)
                Return.Z = 1.0f;
            if (LeaveDeadZone)
            {
                if (DeadZone > Return.X && Return.X > NDeadZone)
                    Return.X = 0;
                if (DeadZone > Return.Y && Return.Y > NDeadZone)
                    Return.Y = 0;
                if (DeadZone > Return.Y && Return.Y > NDeadZone)
                    Return.Z = 0;
            }
            return Return;
        }

        protected virtual Vector CalculateNormalVector(Vector UnNormalizedVector, Vector IgnoreVectorDeadZone, bool LeaveDeadZone = true)
        {
            Vector Return = CalculateNormalVector(UnNormalizedVector, false);
            if (LeaveDeadZone)
            {
                if (IgnoreVectorDeadZone.X == 0 && DeadZone < Return.X && Return.X > NDeadZone)
                    Return.X = 0;
                if (IgnoreVectorDeadZone.Y == 0 && DeadZone < Return.Y && Return.Y > NDeadZone)
                    Return.Y = 0;
                if (IgnoreVectorDeadZone.Z == 0 && DeadZone < Return.Y && Return.Y > NDeadZone)
                    Return.Z = 0;
            }
            return Return;
        }

        protected abstract void SetCylinders();

        protected abstract void ResetCylinders();

        internal virtual void Start()
        {
            Run = true;
            ThreadLoop = new Thread(new ThreadStart(
                () =>
                {
                    lock (LockObj)
                    {
                        LoopFinished = false;
                        TickTimer = new Stopwatch();
                        TickTimer.Start();
                    }
                    while (Run)
                    {
                        bool Tick = false;
                        lock (LockObj)
                            if ((ulong)TickTimer.ElapsedMilliseconds > TimeBetweenTicksMS)
                                Tick = true;
                        if (Tick)
                        {
                            TickTimer.Restart();
                            this.Tick();
                        }
                    }
                    lock (LockObj)
                        LoopFinished = true;
                }));
            ThreadLoop.IsBackground = true;
            ThreadLoop.Start();
        }

        internal virtual void Stop()
        {
            Run = false;
        }

        protected abstract void Tick();
    }
}
