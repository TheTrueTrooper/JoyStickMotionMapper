using JoyStickMotionMapper.ComMotionSystem;
using JoyStickMotionMapper.ConfigHelper;
using JoyStickMotionMapper.MotionHardwareInterface;
using JoyStickMotionMapper.Resources;
using JoyStickMotionMapper.TimingData;
using JoyStickMotionMapper.Win32AndOSHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyStickMotionMapper.MotionPlayer
{
    abstract class BaseMotionPlayer
    {
        string GamePath;
        string StartOptionsRunArgs;
        string RuntimeProcess;
        string StartOptionsInput;

        public object LockObj { protected set; get; } = new object();

        TaPa_XYCyl Owner;

        protected Stopwatch FrameTimer;

        protected Thread ThreadLoop;

        protected PositionAndTimingDataModel FrameData;

        protected IMotionHardwareInterface MotionHardwareInterface { get; private set; }

        public bool Run { protected set; get; } = false;

        public bool LoopFinished { protected set; get; } = true;

        public bool StopedFromControl { protected set; get; } = false;

        public AvalibleProtocols MotionDeviceProtocol { protected set; get; } = AvalibleProtocols.ComPort;

        Process GameRunTime;

        internal BaseMotionPlayer(TaPa_XYCyl Owner, string MotionDataPath, string GamePath, string StartOptionsRunArgs, string RuntimeProcess, string StartOptionsInput, AvalibleProtocols MotionDeviceProtocol, string ConnectonString)
        {
            this.Owner = Owner;
            FrameData = PositionAndTimingDataModel.DataLoadFromFile(MotionDataPath);
            this.MotionDeviceProtocol = MotionDeviceProtocol;
            switch (MotionDeviceProtocol)
            {
                case AvalibleProtocols.ComPort:
                    if (MotionHardwareInterface != null)
                        MotionHardwareInterface.Dispose();
                    MotionHardwareInterface = JMDM_CylinderPortControlUpdated.ConnectionFactory(ConnectonString);
                    break;
                default:
                    Owner.PlayBacksEnd.Invoke();
                    throw new Exception("Error: not a valid Protocol.");
            }
            this.GamePath = GamePath;
            this.StartOptionsRunArgs = StartOptionsRunArgs;
            this.StartOptionsInput = StartOptionsInput;
            this.RuntimeProcess = RuntimeProcess;
            Start();
        }

        internal virtual void ReleaseHardware()
        {
            MotionHardwareInterface.ReleaseHardware();
        }

        internal virtual void GrabHardware()
        {
            MotionHardwareInterface.GrabHardware();
        }

        internal virtual void Start()
        {
            Run = true;
            ThreadLoop = new Thread(new ThreadStart(
                () =>
                {
                    GrabHardware();
                    lock (LockObj)
                    {
                        LoopFinished = false;
                        if (!StartGame())
                            return;
                        FrameTimer = new Stopwatch();
                        FrameTimer.Start();
                    }
                    int PosPointer = 0;
                    while (Run)
                    {
                        while ((ulong)FrameTimer.ElapsedMilliseconds < FrameData[PosPointer].Time) ;
                        AnimateFame(FrameData[PosPointer]);
                        FrameTimer.Restart();
                        PosPointer += 1;
                        if (PosPointer%10 == 0 && GameRunTime.HasExited)
                            Run = false;
                        if (PosPointer >= FrameData.Count)
                            Run = false;
                    }
                    ReleaseHardware();
                    lock (LockObj)
                        LoopFinished = true;
                    if (!GameRunTime.HasExited)
                        GameRunTime.Kill();
                    if (MotionHardwareInterface != null)
                        MotionHardwareInterface.Dispose();
                    if (!StopedFromControl)
                        Owner.PlayBacksEnd.Invoke();
                }));
            ThreadLoop.IsBackground = true;
            ThreadLoop.Start();
        }

        protected abstract void AnimateFame(MomentaryPositionAndTimingFrameDataModel Data);

        public void Stop()
        {
            StopedFromControl = true;
            Run = false;
        }

        bool StartGame()
        {
            if (!File.Exists(GamePath))
            {
                MessageBox.Show(EnglishText.HelpMessage_GameNotFoundHelpMessage);
                return false;
            }
            try
            {
                GameRunTime = new Process();
                GameRunTime.StartInfo = new ProcessStartInfo()
                {
                    FileName = GamePath,
                    WorkingDirectory = Path.GetDirectoryName(GamePath),
                    Arguments = StartOptionsRunArgs
                };
                GameRunTime.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{EnglishText.HelpMessage_GameLaunchErrorHelpMessage}\n{ex}");
                return false;
            }

            if (RuntimeProcess != null && RuntimeProcess != "")
            {
                Task FindGameTask = Task.Run(() => {
                    GameRunTime = null;
                    while (GameRunTime == null)
                    {
                        GameRunTime = Process.GetProcesses().FirstOrDefault(P => P.MainWindowHandle != IntPtr.Zero && P.ProcessName.ToLower() == RuntimeProcess);
                    }
                    while (!GameRunTime.Responding) ;
                });
                TimeSpan TimeoutSpan = TimeSpan.FromMilliseconds(1000);
                FindGameTask.Wait(TimeoutSpan);
            }

            WindowHandleInfo Window = new WindowHandleInfo(GameRunTime.MainWindowHandle);

            Task InputTask = new Task(() => {
                if (StartOptionsInput != null && StartOptionsInput != "")
                {
                    Thread.Sleep(50);
                    Action[] Commands = TaPa_XYCyl.GetCommands(StartOptionsInput, Window);
                    foreach (Action Command in Commands)
                    {
                        Command.Invoke();
                    }
                }
            });

            Window.SetForegroundWindow();

            InputTask.Start();
            return true;
        }
    }
}
