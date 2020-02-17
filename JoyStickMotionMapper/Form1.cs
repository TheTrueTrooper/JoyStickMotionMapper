using SharpDX;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoyStickMotionMapper.Resources;
using System.IO;
using JoyStickMotionMapper.ConfigHelper;
using JoyStickMotionMapper.MotionControllers;
using System.Diagnostics;
using System.Threading;
using JoyStickMotionMapper.Win32AndOSHelpers;
using System.IO.Ports;
using JoyStickMotionMapper.TimingData;
using JoyStickMotionMapper.MotionPlayer;

namespace JoyStickMotionMapper
{
    public partial class TaPa_XYCyl : Form
    {

        #region ConfigVars
        const string LastConfigName = "\\LastConfig.config";
        const string MotionOutPutPath = "\\MotionOutput";
        #endregion

        #region SharpDXJoystickDriectConnectVars
        static DirectInput DirectInputDriversInfo = new DirectInput();

        static DeviceInstance[] Devices = null;

        Guid DeviceGUID = Guid.Empty;

        EffectInfo[] EffectInfos = null;

        internal DeviceObjectInstance[] AxisInfos = null;
        internal DeviceObjectInstance[] ButtonInfos = null;
        internal DeviceObjectInstance[] POVInfos = null;
        #endregion

        #region ProtocolVars
        internal ulong Time = 0;
        #endregion

        #region MotionCaptureVars
        const ulong DefaultimeBetweenTicks = 250;
        int LastFrame = 0;
        BaseMotionController MotionController;
        Process GameRunTime;

        internal delegate void NotifyOfRecoderEnd();

        internal NotifyOfRecoderEnd CaptureEnd;
        #endregion

        #region PlayBackVars
        internal delegate void NotifyOfPlayersEnd();

        internal NotifyOfPlayersEnd PlayBacksEnd;

        BaseMotionPlayer Player;
        #endregion

        string RunErrors;

        public TaPa_XYCyl()
        {
            InitializeComponent();
            PlayBacksEnd += PlayBacksEndFunk;
            CaptureEnd += CaptureEndFunk;
            this.MaximumSize = new Size(10000, 10000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (AvalibleProtocols Protocol in (AvalibleProtocols[])Enum.GetValues(typeof(AvalibleProtocols)))
            {
                CoBo_Protocol.Items.Add(Protocol);
            }
            LoadConfigFile($"{Environment.CurrentDirectory}{LastConfigName}", EnglishText.Exception_CantFindLastConfigException, true);
            MotionController = new XYZ3CylMotionController(this);
            La_TimeBetweenTicksValue.Text = $"Value = {TrBa_TimeBetweenTicks.Value}";
            CheckForRunConditions();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfigFile($"{Environment.CurrentDirectory}{LastConfigName}");
        }

        #region SharpDXJoystickDriectConnectRelatedFuctionality

        private void CoBo_JoyStickList_DropDown(object sender, EventArgs e)
        {
            Devices = DirectInputDriversInfo.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AttachedOnly).ToArray();

            CoBo_JoyStickList.Items.Clear();

            foreach (DeviceInstance Device in Devices)
                CoBo_JoyStickList.Items.Add($"{Device.ProductName} - {Device.ProductGuid} - {Device.InstanceName} - {Device.InstanceGuid}");
        }

        private void CoBo_JoyStickList_DropDownClosed(object sender, EventArgs e)
        {
            const int MidValue = 32767;
            const string StartingButton = "Not Pressed";
            const int StartingPOV = -1;

            if (MotionController.JoyStick != null)
            {
                JoyStickPollCycle.Enabled = false;
                DeviceGUID = Guid.Empty;
                MotionController.JoyStick.Unacquire();
                MotionController.JoyStick.Dispose();
                MotionController.ClearJoystickSelection();
                EffectInfos = null;
                AxisInfos = null;
                ButtonInfos = null;
                POVInfos = null;
                TeBo_JoystickDevicesName.Text = "";
                TeBo_JoystickDevicesGUID.Text = "";
                TeBo_JoystickDeviceInstancesName.Text = "";
                TeBo_JoystickDeviceInstancesGUID.Text = "";
                TeBo_AxisCount.Text = "";
                TeBo_ButtonCount.Text = "";
                TeBo_POVCount.Text = "";
                DaGrVi_Effects.Rows.Clear();
                DaGrVi_Axis.Rows.Clear();
                DaGrVi_Buttons.Rows.Clear();
                DaGrVi_POVs.Rows.Clear();
            }
            if (CoBo_JoyStickList.SelectedIndex != -1)
            {
                DeviceGUID = Devices[CoBo_JoyStickList.SelectedIndex].InstanceGuid;
                MotionController.ChangeJoystick(new Joystick(DirectInputDriversInfo, DeviceGUID));
                MotionController.JoyStick.Properties.BufferSize = 128;
                MotionController.JoyStick.Acquire();
                TeBo_JoystickDevicesName.Text = Devices[CoBo_JoyStickList.SelectedIndex].ProductName;
                TeBo_JoystickDevicesGUID.Text = Devices[CoBo_JoyStickList.SelectedIndex].ProductGuid.ToString();
                TeBo_JoystickDeviceInstancesName.Text = Devices[CoBo_JoyStickList.SelectedIndex].InstanceName;
                TeBo_JoystickDeviceInstancesGUID.Text = Devices[CoBo_JoyStickList.SelectedIndex].InstanceGuid.ToString();
                TeBo_AxisCount.Text = MotionController.JoyStick.Capabilities.AxeCount.ToString();
                TeBo_ButtonCount.Text = MotionController.JoyStick.Capabilities.ButtonCount.ToString();
                TeBo_POVCount.Text = MotionController.JoyStick.Capabilities.PovCount.ToString();

                EffectInfos = MotionController.JoyStick.GetEffects().ToArray();
                foreach (EffectInfo E in EffectInfos)
                {
                    DaGrVi_Effects.Rows.Add(E.Name, E.Type.ToString(), E.Guid.ToString());
                }

                AxisInfos = MotionController.JoyStick.GetObjects(DeviceObjectTypeFlags.AbsoluteAxis).ToArray();
                foreach (DeviceObjectInstance Axis in AxisInfos)
                {
                    DaGrVi_Axis.Rows.Add(Axis.Name, MidValue);
                }

                ButtonInfos = MotionController.JoyStick.GetObjects(DeviceObjectTypeFlags.Button).ToArray();
                foreach (DeviceObjectInstance Button in ButtonInfos)
                {
                    DaGrVi_Buttons.Rows.Add(Button.Name, StartingButton);
                }

                POVInfos = MotionController.JoyStick.GetObjects(DeviceObjectTypeFlags.PointOfViewController).ToArray();
                foreach (DeviceObjectInstance POV in POVInfos)
                {
                    DaGrVi_POVs.Rows.Add(POV.Name, StartingPOV);
                }

                JoyStickPollCycle.Enabled = true;
                TaCo_MachinesSuportedForProtocol.Enabled = true;
            }
            else
            {
                foreach (ComboBox DropDown in new ComboBox[] {
                    CoBo_JoyAxisForMechXAxisTilt,
                    CoBo_JoyAxisForMechYAxisTilt,
                    CoBo_JoyButtonForMechSytheticNoiseEffect,
                    CoBo_JoyAxisForMechSensitivity,
                    CoBo_JoyButtonForMechBackStateTrigger,
                    CoBo_JoyButtonForMechBubblesStateTrigger,
                    CoBo_JoyButtonForMechFlameStateTrigger,
                    CoBo_JoyButtonForMechJetStateTrigger,
                    CoBo_JoyButtonForMechLightningStateTrigger,
                    CoBo_JoyButtonForMechRainStateTrigger,
                    CoBo_JoyButtonForMechSmokeStateTrigger,
                    CoBo_JoyButtonForEndTrigger,
                    CoBo_JoyButtonForMechSpare1StateTrigger,
                    CoBo_JoyButtonForMechSpare2StateTrigger,
                    CoBo_JoyButtonForMechSpare3StateTrigger,
                    CoBo_JoyButtonForMechSweepingLegs1StateTrigger,
                    CoBo_JoyButtonForMechSweepingLegs2StateTrigger,
                    CoBo_JoyButtonForMechVibrationStateTrigger,
                    CoBo_JoyButtonForMechWaterSprayStateTrigger,
                    CoBo_JoyButtonForMechWindStateTrigger
                })
                {
                    DropDown.SelectedIndex = -1;
                }
                TaCo_MachinesSuportedForProtocol.Enabled = false;
            }
            CheckForRunConditions();
        }

        private void JoyStickPollCycle_Tick(object sender, EventArgs e)
        {
            const int ButtonsOffsetOffset = 24;
            const int POVOffsetOffset = 24;
            const int OtherAxisOffsetOffset = 8;

            if (!MotionController.Run)
            {
                MotionController.JoyStick.Poll();
                JoystickUpdate[] Data = MotionController.JoyStick.GetBufferedData();
                int Row = 0;
                foreach (DeviceObjectInstance Axis in AxisInfos)
                {
                    if (Data.Any(x => x.RawOffset == Axis.Offset + OtherAxisOffsetOffset || x.RawOffset == Axis.Offset))
                        DaGrVi_Axis.Rows[Row].Cells[1].Value = Data.Last(x => x.RawOffset == Axis.Offset + OtherAxisOffsetOffset || x.RawOffset == Axis.Offset).Value;
                    Row++;
                }
                Row = 0;
                foreach (DeviceObjectInstance POV in POVInfos)
                {
                    if (Data.Any(x => x.RawOffset == POV.Offset + POVOffsetOffset))
                        DaGrVi_POVs.Rows[Row].Cells[1].Value = Data.Last(x => x.RawOffset == POV.Offset + POVOffsetOffset).Value;
                    Row++;
                }
                Row = 0;
                foreach (DeviceObjectInstance Button in ButtonInfos)
                {
                    if (Data.Any(x => x.RawOffset == Button.Offset + ButtonsOffsetOffset))
                        DaGrVi_Buttons.Rows[Row].Cells[1].Value = Data.Last(x => x.RawOffset == Button.Offset + ButtonsOffsetOffset).Value != 0 ? "Pressed" : "Not Pressed";
                    Row++;
                }
            }
            else
            {
                int Row = 0;
                foreach (DeviceObjectInstance Axis in AxisInfos)
                {
                    DaGrVi_Axis.Rows[Row].Cells[1].Value = MotionController.Axiss[Row];
                    Row++;
                }
                Row = 0;
                foreach (DeviceObjectInstance POV in POVInfos)
                {
                    DaGrVi_POVs.Rows[Row].Cells[1].Value = MotionController.POVs[Row];
                    Row++;
                }
                Row = 0;
                foreach (DeviceObjectInstance Button in ButtonInfos)
                {
                    DaGrVi_Buttons.Rows[Row].Cells[1].Value = MotionController.Buttons[Row] ? "Pressed" : "Not Pressed";
                    Row++;
                }
                for (; LastFrame < MotionController.AddedMotion.Count(); LastFrame++)
                {
                    Time += MotionController.AddedMotion[LastFrame].Time;
                    DaGrVi_DataOutput.Rows.Add(Time, MotionController.AddedMotion[LastFrame].Time, MotionController.AddedMotion[LastFrame].C1, MotionController.AddedMotion[LastFrame].C2, MotionController.AddedMotion[LastFrame].C3, MotionController.AddedMotion[LastFrame].C4, MotionController.AddedMotion[LastFrame].C5, MotionController.AddedMotion[LastFrame].C6, MotionController.AddedMotion[LastFrame].Snowflakes, MotionController.AddedMotion[LastFrame].Wind, MotionController.AddedMotion[LastFrame].Rain, MotionController.AddedMotion[LastFrame].Smoke, MotionController.AddedMotion[LastFrame].Bubbles, MotionController.AddedMotion[LastFrame].Lightning, MotionController.AddedMotion[LastFrame].Flame, MotionController.AddedMotion[LastFrame].Jet, MotionController.AddedMotion[LastFrame].WaterSpray, MotionController.AddedMotion[LastFrame].Vibration, MotionController.AddedMotion[LastFrame].Back, MotionController.AddedMotion[LastFrame].SweepingLegs1, MotionController.AddedMotion[LastFrame].SweepingLegs2, MotionController.AddedMotion[LastFrame].Spare1, MotionController.AddedMotion[LastFrame].Spare2, MotionController.AddedMotion[LastFrame].Spare3);
                }
            }
        }

        #endregion

        #region ConfigRelatedFuctionality 

        #region ConfigHelp
        private void But_StartOptionsInputHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EnglishText.Help_StartOptionsInputHelp, "Start Options Input Help");
        }

        private void But_RuntimeProcessNameHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EnglishText.Help_RuntimeProcessNameHelp, "Runtime Process Name Help");
        }

        private void But_StartOptionsRunArgsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EnglishText.Help_StartOptionsRunArgsHelp, "Start Options Run Args Help");
        }

        private void But_ProtocolConnectionStringHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EnglishText.Help_ProtocolConnectionStringHelp, "Protocol Connection String Help");
        }
        #endregion

        private void TeBo_GamePath_MouseClick(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog GamePathDialog = new OpenFileDialog())
            {
                GamePathDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
                if (GamePathDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(GamePathDialog.FileName))
                    {
                        TeBo_GamePath.Text = GamePathDialog.FileName;
                    }
                    else
                        MessageBox.Show(EnglishText.Exception_FileDoesentExistException);
                }

            }
        }

        private void TeBo_MotionOutputPath_MouseClick(object sender, MouseEventArgs e)
        {
            using (FolderBrowserDialog OutPutPath = new FolderBrowserDialog())
            {
                if (OutPutPath.ShowDialog() == DialogResult.OK)
                {
                    TeBo_MotionOutputPath.Text = $"{OutPutPath.SelectedPath}{MotionOutPutPath}";
                }
            }
        }

        private void LoadConfigFile(string Path, string ExceptionMessage, bool RevertToDefault = false)
        {
            try
            {
                SystemConfig Config = SystemConfig.ConfigFactory(Path);
                TeBo_MotionOutputPath.Text = Config.MotionOutPutPath;
                TeBo_GamePath.Text = Config.GamePath;
                TeBo_RuntimeProcess.Text = Config.RuntimeProcess;
                TeBo_StartOptionsInput.Text = Config.StartOptionsInput;
                TeBo_StartOptionsRunArgs.Text = Config.StartOptionsRunArgs;
                CoBo_Protocol.SelectedIndex = CoBo_Protocol.FindStringExact(Config.ProtocolType.ToString());
                TeBo_ProtocolConnectionString.Text = Config.ProtocolConnectionString;
                TrBa_TimeBetweenTicks.Value = (int)Config.TimeBetweenTicksMS;
            }
            catch (Exception e)
            {
                if (RevertToDefault)
                {
                    TeBo_MotionOutputPath.Text = $"{Environment.CurrentDirectory}{MotionOutPutPath}";
                    TrBa_TimeBetweenTicks.Value = (int)DefaultimeBetweenTicks;
                }
                MessageBox.Show($"{ExceptionMessage}\n{e}");
            }
        }

        private void SaveConfigFile(string Path)
        {
            try
            {
                SystemConfig Config = new SystemConfig()
                {
                    MotionOutPutPath = TeBo_MotionOutputPath.Text,
                    GamePath = TeBo_GamePath.Text,
                    RuntimeProcess = TeBo_RuntimeProcess.Text,
                    StartOptionsInput = TeBo_StartOptionsInput.Text,
                    StartOptionsRunArgs = TeBo_StartOptionsRunArgs.Text,
                    ProtocolType = (AvalibleProtocols)System.Enum.Parse(typeof(AvalibleProtocols), CoBo_Protocol.SelectedItem.ToString()),
                    ProtocolConnectionString = TeBo_ProtocolConnectionString.Text,
                    TimeBetweenTicksMS = (ulong)TrBa_TimeBetweenTicks.Value
                };
                Config.SaveConfig(Path);
            }
            catch (Exception e)
            {
                MessageBox.Show($"{EnglishText.Exception_GenaricOppsException}\n{e}");
            }
        }

        private void Bu_LoadConfigFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ConfigPathDialog = new OpenFileDialog())
            {
                ConfigPathDialog.Filter = "config files (*.config)|*.config";
                if (ConfigPathDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(ConfigPathDialog.FileName))
                    {
                        LoadConfigFile(ConfigPathDialog.FileName, EnglishText.Exception_CantFindUsableConfigException);
                    }
                    else
                        MessageBox.Show(EnglishText.Exception_FileDoesentExistException);
                }

            }
        }

        private void Bu_SaveConfigFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ConfigPathDialog = new SaveFileDialog())
            {
                ConfigPathDialog.Filter = "config files (*.config)|*.config";
                ConfigPathDialog.DefaultExt = "config";
                ConfigPathDialog.AddExtension = true;
                if (ConfigPathDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveConfigFile(ConfigPathDialog.FileName);
                }
            }
        }
        #endregion

        private void VScBa_3CylXYZ_Scroll(object sender, ScrollEventArgs e)
        {
            int ScrollValue = e.OldValue - e.NewValue;
            La_JoyAxisForMechXAxisTilt.Location = new Point(La_JoyAxisForMechXAxisTilt.Location.X, La_JoyAxisForMechXAxisTilt.Location.Y + ScrollValue);
            CoBo_JoyAxisForMechXAxisTilt.Location = new Point(CoBo_JoyAxisForMechXAxisTilt.Location.X, CoBo_JoyAxisForMechXAxisTilt.Location.Y + ScrollValue);

            La_JoyAxisForMechYAxisTilt.Location = new Point(La_JoyAxisForMechYAxisTilt.Location.X, La_JoyAxisForMechYAxisTilt.Location.Y + ScrollValue);
            CoBo_JoyAxisForMechYAxisTilt.Location = new Point(CoBo_JoyAxisForMechYAxisTilt.Location.X, CoBo_JoyAxisForMechYAxisTilt.Location.Y + ScrollValue);

            La_JoyButtonForMechSytheticNoiseEffect.Location = new Point(La_JoyButtonForMechSytheticNoiseEffect.Location.X, La_JoyButtonForMechSytheticNoiseEffect.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechSytheticNoiseEffect.Location = new Point(CoBo_JoyButtonForMechSytheticNoiseEffect.Location.X, CoBo_JoyButtonForMechSytheticNoiseEffect.Location.Y + ScrollValue);

            La_JoyAxisForMechSensitivity.Location = new Point(La_JoyAxisForMechSensitivity.Location.X, La_JoyAxisForMechSensitivity.Location.Y + ScrollValue);
            CoBo_JoyAxisForMechSensitivity.Location = new Point(CoBo_JoyAxisForMechSensitivity.Location.X, CoBo_JoyAxisForMechSensitivity.Location.Y + ScrollValue);

            La_JoyButtonForEndTrigger.Location = new Point(La_JoyButtonForEndTrigger.Location.X, La_JoyButtonForEndTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForEndTrigger.Location = new Point(CoBo_JoyButtonForEndTrigger.Location.X, CoBo_JoyButtonForEndTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechWindStateTrigger.Location = new Point(La_JoyButtonForMechWindStateTrigger.Location.X, La_JoyButtonForMechWindStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechWindStateTrigger.Location = new Point(CoBo_JoyButtonForMechWindStateTrigger.Location.X, CoBo_JoyButtonForMechWindStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechRainStateTrigger.Location = new Point(La_JoyButtonForMechRainStateTrigger.Location.X, La_JoyButtonForMechRainStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechRainStateTrigger.Location = new Point(CoBo_JoyButtonForMechRainStateTrigger.Location.X, CoBo_JoyButtonForMechRainStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechSmokeStateTrigger.Location = new Point(La_JoyButtonForMechSmokeStateTrigger.Location.X, La_JoyButtonForMechSmokeStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechSmokeStateTrigger.Location = new Point(CoBo_JoyButtonForMechSmokeStateTrigger.Location.X, CoBo_JoyButtonForMechSmokeStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechBubblesStateTrigger.Location = new Point(La_JoyButtonForMechBubblesStateTrigger.Location.X, La_JoyButtonForMechBubblesStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechBubblesStateTrigger.Location = new Point(CoBo_JoyButtonForMechBubblesStateTrigger.Location.X, CoBo_JoyButtonForMechBubblesStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechLightningStateTrigger.Location = new Point(La_JoyButtonForMechLightningStateTrigger.Location.X, La_JoyButtonForMechLightningStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechLightningStateTrigger.Location = new Point(CoBo_JoyButtonForMechLightningStateTrigger.Location.X, CoBo_JoyButtonForMechLightningStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechFlameStateTrigger.Location = new Point(La_JoyButtonForMechFlameStateTrigger.Location.X, La_JoyButtonForMechFlameStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechFlameStateTrigger.Location = new Point(CoBo_JoyButtonForMechFlameStateTrigger.Location.X, CoBo_JoyButtonForMechFlameStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechJetStateTrigger.Location = new Point(La_JoyButtonForMechJetStateTrigger.Location.X, La_JoyButtonForMechJetStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechJetStateTrigger.Location = new Point(CoBo_JoyButtonForMechJetStateTrigger.Location.X, CoBo_JoyButtonForMechJetStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechWaterSprayStateTrigger.Location = new Point(La_JoyButtonForMechWaterSprayStateTrigger.Location.X, La_JoyButtonForMechWaterSprayStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechWaterSprayStateTrigger.Location = new Point(CoBo_JoyButtonForMechWaterSprayStateTrigger.Location.X, CoBo_JoyButtonForMechWaterSprayStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechVibrationStateTrigger.Location = new Point(La_JoyButtonForMechVibrationStateTrigger.Location.X, La_JoyButtonForMechVibrationStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechVibrationStateTrigger.Location = new Point(CoBo_JoyButtonForMechVibrationStateTrigger.Location.X, CoBo_JoyButtonForMechVibrationStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechBackStateTrigger.Location = new Point(La_JoyButtonForMechBackStateTrigger.Location.X, La_JoyButtonForMechBackStateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechBackStateTrigger.Location = new Point(CoBo_JoyButtonForMechBackStateTrigger.Location.X, CoBo_JoyButtonForMechBackStateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechSweepingLegs1StateTrigger.Location = new Point(La_JoyButtonForMechSweepingLegs1StateTrigger.Location.X, La_JoyButtonForMechSweepingLegs1StateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechSweepingLegs1StateTrigger.Location = new Point(CoBo_JoyButtonForMechSweepingLegs1StateTrigger.Location.X, CoBo_JoyButtonForMechSweepingLegs1StateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechSweepingLegs2StateTrigger.Location = new Point(La_JoyButtonForMechSweepingLegs2StateTrigger.Location.X, La_JoyButtonForMechSweepingLegs2StateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechSweepingLegs2StateTrigger.Location = new Point(CoBo_JoyButtonForMechSweepingLegs2StateTrigger.Location.X, CoBo_JoyButtonForMechSweepingLegs2StateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechSpare1StateTrigger.Location = new Point(La_JoyButtonForMechSpare1StateTrigger.Location.X, La_JoyButtonForMechSpare1StateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechSpare1StateTrigger.Location = new Point(CoBo_JoyButtonForMechSpare1StateTrigger.Location.X, CoBo_JoyButtonForMechSpare1StateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechSpare2StateTrigger.Location = new Point(La_JoyButtonForMechSpare2StateTrigger.Location.X, La_JoyButtonForMechSpare2StateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechSpare2StateTrigger.Location = new Point(CoBo_JoyButtonForMechSpare2StateTrigger.Location.X, CoBo_JoyButtonForMechSpare2StateTrigger.Location.Y + ScrollValue);

            La_JoyButtonForMechSpare3StateTrigger.Location = new Point(La_JoyButtonForMechSpare3StateTrigger.Location.X, La_JoyButtonForMechSpare3StateTrigger.Location.Y + ScrollValue);
            CoBo_JoyButtonForMechSpare3StateTrigger.Location = new Point(CoBo_JoyButtonForMechSpare3StateTrigger.Location.X, CoBo_JoyButtonForMechSpare3StateTrigger.Location.Y + ScrollValue);
        }

        private void AddAxisToComboBox(ComboBox Target)
        {
            Target.Items.Clear();
            if (AxisInfos != null)
                foreach (DeviceObjectInstance Axis in AxisInfos)
                {
                    Target.Items.Add(Axis.Name);
                }
        }

        private void AddButtonsToComboBox(ComboBox Target)
        {
            Target.Items.Clear();
            if (AxisInfos != null)
                foreach (DeviceObjectInstance Buttons in ButtonInfos)
                {
                    Target.Items.Add(Buttons.Name);
                }
        }

        private void CoBo_JoyAxisForMechXAxisTilt_DropDown(object sender, EventArgs e)
        {
            AddAxisToComboBox(CoBo_JoyAxisForMechXAxisTilt);
        }

        private void CoBo_JoyAxisForMechXAxisTilt_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyAxisForMechXAxisTilt.SelectedIndex != -1)
                MotionController.JoyAxisForMechXAxisTilt = AxisInfos[CoBo_JoyAxisForMechXAxisTilt.SelectedIndex];
            else
                MotionController.JoyAxisForMechXAxisTilt = null;
        }

        private void CoBo_JoyAxisForMechYAxisTilt_DropDown(object sender, EventArgs e)
        {
            AddAxisToComboBox(CoBo_JoyAxisForMechYAxisTilt);
        }

        private void CoBo_JoyAxisForMechYAxisTilt_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyAxisForMechYAxisTilt.SelectedIndex != -1)
                MotionController.JoyAxisForMechYAxisTilt = AxisInfos[CoBo_JoyAxisForMechYAxisTilt.SelectedIndex];
            else
                MotionController.JoyAxisForMechYAxisTilt = null;
        }

        private void CoBo_JoyButtonForMechSytheticNoiseEffect_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechSytheticNoiseEffect);
        }

        private void CoBo_JoyButtonForMechSytheticNoiseEffect_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechSytheticNoiseEffect.SelectedIndex != -1)
                MotionController.JoyButtonForMechSytheticNoiseEffect = ButtonInfos[CoBo_JoyButtonForMechSytheticNoiseEffect.SelectedIndex];
            else
                MotionController.JoyButtonForMechSytheticNoiseEffect = null;
        }

        private void CoBo_JoyAxisForMechSensitivity_DropDown(object sender, EventArgs e)
        {
            AddAxisToComboBox(CoBo_JoyAxisForMechSensitivity);
        }

        private void CoBo_JoyAxisForMechSensitivity_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyAxisForMechSensitivity.SelectedIndex != -1)
                MotionController.JoyAxisForMechSensitivity = AxisInfos[CoBo_JoyAxisForMechSensitivity.SelectedIndex];
            else
                MotionController.JoyAxisForMechSensitivity = null;
        }

        private void CoBo_JoyButtonForMechSnowflakeStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForEndTrigger);
        }

        private void CoBo_JoyButtonForMechSnowflakeStateTrigger_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void CoBo_JoyButtonForMechWindStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechWindStateTrigger);
        }

        private void CoBo_JoyButtonForMechWindStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechWindStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechWindStateTrigger = ButtonInfos[CoBo_JoyButtonForMechWindStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechWindStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechSmokeStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechSmokeStateTrigger);
        }

        private void CoBo_JoyButtonForMechSmokeStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechSmokeStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechSmokeStateTrigger = ButtonInfos[CoBo_JoyButtonForMechSmokeStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechSmokeStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechRainStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechRainStateTrigger);
        }

        private void CoBo_JoyButtonForMechRainStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechRainStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechRainStateTrigger = ButtonInfos[CoBo_JoyButtonForMechRainStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechRainStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechJetStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechJetStateTrigger);
        }

        private void CoBo_JoyButtonForMechJetStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechJetStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechJetStateTrigger = ButtonInfos[CoBo_JoyButtonForMechJetStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechJetStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechFlameStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechFlameStateTrigger);
        }

        private void CoBo_JoyButtonForMechFlameStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechFlameStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechFlameStateTrigger = ButtonInfos[CoBo_JoyButtonForMechFlameStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechFlameStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechLightningStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechLightningStateTrigger);
        }

        private void CoBo_JoyButtonForMechLightningStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechLightningStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechLightningStateTrigger = ButtonInfos[CoBo_JoyButtonForMechLightningStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechLightningStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechBubblesStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechBubblesStateTrigger);
        }

        private void CoBo_JoyButtonForMechBubblesStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechBubblesStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechBubblesStateTrigger = ButtonInfos[CoBo_JoyButtonForMechBubblesStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechBubblesStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechBackStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechBackStateTrigger);
        }

        private void CoBo_JoyButtonForMechBackStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechBackStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechBackStateTrigger = ButtonInfos[CoBo_JoyButtonForMechBackStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechBackStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechVibrationStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechVibrationStateTrigger);
        }

        private void CoBo_JoyButtonForMechVibrationStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechVibrationStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechVibrationStateTrigger = ButtonInfos[CoBo_JoyButtonForMechVibrationStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechVibrationStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechWaterSprayStateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechWaterSprayStateTrigger);
        }

        private void CoBo_JoyButtonForMechWaterSprayStateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechWaterSprayStateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechWaterSprayStateTrigger = ButtonInfos[CoBo_JoyButtonForMechWaterSprayStateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechWaterSprayStateTrigger = null;
        }

        private void CoBo_JoyButtonForMechSweepingLegs1StateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechSweepingLegs1StateTrigger);
        }

        private void CoBo_JoyButtonForMechSweepingLegs1StateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechSweepingLegs1StateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechSweepingLegs1StateTrigger = ButtonInfos[CoBo_JoyButtonForMechSweepingLegs1StateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechSweepingLegs1StateTrigger = null;
        }

        private void CoBo_JoyButtonForMechSweepingLegs2StateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechSweepingLegs2StateTrigger);
        }

        private void CoBo_JoyButtonForMechSweepingLegs2StateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechSweepingLegs2StateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechSweepingLegs2StateTrigger = ButtonInfos[CoBo_JoyButtonForMechSweepingLegs2StateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechSweepingLegs2StateTrigger = null;
        }

        private void CoBo_JoyButtonForMechSpare1StateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechSpare1StateTrigger);
        }

        private void CoBo_JoyButtonForMechSpare1StateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechSpare1StateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechSpare1StateTrigger = ButtonInfos[CoBo_JoyButtonForMechSpare1StateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechSpare1StateTrigger = null;
        }

        private void CoBo_JoyButtonForMechSpare2StateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechSpare2StateTrigger);
        }

        private void CoBo_JoyButtonForMechSpare2StateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechSpare2StateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechSpare2StateTrigger = ButtonInfos[CoBo_JoyButtonForMechSpare2StateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechSpare2StateTrigger = null;
        }

        private void CoBo_JoyButtonForMechSpare3StateTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForMechSpare3StateTrigger);
        }

        private void CoBo_JoyButtonForMechSpare3StateTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForMechSpare3StateTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForMechSpare3StateTrigger = ButtonInfos[CoBo_JoyButtonForMechSpare3StateTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForMechSpare3StateTrigger = null;
        }

        private void CoBo_JoyButtonForEndTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_JoyButtonForEndTrigger);
        }

        private void CoBo_JoyButtonForEndTrigger_DropDownClosed(object sender, EventArgs e)
        {
            if (CoBo_JoyButtonForEndTrigger.SelectedIndex != -1)
                MotionController.JoyButtonForEnd = ButtonInfos[CoBo_JoyButtonForEndTrigger.SelectedIndex];
            else
                MotionController.JoyButtonForEnd = null;
        }

        private void Bu_Run_Click(object sender, EventArgs e)
        {
            JoyStickPollCycle.Stop();

            if (!MotionController.Run)
            {
                Bu_Run.Enabled = false;

                StartGame();

                DaGrVi_DataOutput.Rows.Clear();

                Bu_Run.Text = "Stop";
                CoBo_JoyStickList.Enabled = false;
                GrBo_MotionData.Enabled = false;
                GrBo_Game.Enabled = false;
                GrBo_ConfigLoadAndSave.Enabled = false;
                Bu_PlayBackSavedData.Enabled = false;
                MotionController.SavePath = $"{TeBo_MotionOutputPath.Text}.JMMov";
                MotionController.TimeBetweenTicksMS = (ulong)TrBa_TimeBetweenTicks.Value;
                MotionController.GrabHardware();
                MotionController.Start();
                Bu_Run.Enabled = true;

                JoyStickPollCycle.Start();
            }
            else
            {
                Bu_Run.Enabled = false;
                MotionController.Stop();
                bool LoopFinished = false;
                while (!LoopFinished)
                {
                    lock (MotionController.LockObj)
                        LoopFinished = MotionController.LoopFinished;
                }
                MotionController.ReleaseHardware();
                Bu_Run.Text = "Run";
                CoBo_JoyStickList.Enabled = true;
                GrBo_MotionData.Enabled = true;
                GrBo_Game.Enabled = true;
                GrBo_ConfigLoadAndSave.Enabled = true;

                DaGrVi_DataOutput.Rows.Clear();
                LastFrame = 0;

                try
                {
                    GameRunTime.Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{EnglishText.HelpMessage_GameLaunchErrorHelpMessage}\n{ex}");
                }

                Bu_Run.Enabled = true;
                Bu_PlayBackSavedData.Enabled = true;
                JoyStickPollCycle.Start();
            }
        }

        void CheckForRunConditions()
        {
            CheckForRunConditionsInternal();
            if (MotionController?.JoyStick == null)
                RunErrors = $"{EnglishText.HelpMessage_RunJoyStickNotSelectedMessage}\n";
            if (RunErrors != null)
            {
                RunErrors.Remove(RunErrors.Count() - 1, 1);
                GrBo_RunTime.Enabled = false;
            }
            else
            {
                GrBo_RunTime.Enabled = true;
            }
        }

        void CheckForRunConditionsInternal()
        {
            string MotionOutputPath = TeBo_MotionOutputPath.Text;
            int LastOfPath = MotionOutputPath.LastIndexOf('\\') + 1;
            MotionOutputPath = MotionOutputPath.Remove(LastOfPath, MotionOutputPath.Count() - LastOfPath);
            RunErrors = null;
            if (!Directory.Exists(MotionOutputPath))
                RunErrors = $"{EnglishText.HelpMessage_RunOutputErrorPathMessage}\n";
            if (!File.Exists(TeBo_GamePath.Text))
                RunErrors = $"{EnglishText.HelpMessage_GameNotFoundHelpMessage}\n";
            if (CoBo_Protocol.SelectedIndex == -1)
                RunErrors = $"{EnglishText.HelpMessage_RunProtocolNotSelectedMessage}\n";
            if (!CheckConnectionString())
                RunErrors = $"{EnglishText.HelpMessage_RunProtocolNotSelectedMessage}\n";
            if (RunErrors != null)
            {
                Bu_PlayBackSavedData.Enabled = false;
            }
            else
            {
                if (MotionController?.Run != true)
                    Bu_PlayBackSavedData.Enabled = true;
            }
        }

        bool CheckConnectionString()
        {
            if (TeBo_ProtocolConnectionString.Text != null)
            {
                if (CoBo_Protocol.SelectedIndex != -1 && SerialPort.GetPortNames().Contains(TeBo_ProtocolConnectionString.Text))
                    return true;
            }
            return false;
        }

        internal static Action[] GetCommands(string AddInput, WindowHandleInfo Window)
        {
            string[] InputCommands = AddInput.Split(' ');
            List<Action> Actions = new List<Action>();
            foreach (string Command in InputCommands)
            {
                if (Command.Length < 1 || Command.Trim().Length < 1)
                    continue;

                if (Command.ToLower().StartsWith("wait"))
                {
                    string[] Params = Command.Split('(')[1].Split(')')[0].Split(',');
                    Actions.Add(new Action(() => { Thread.Sleep(int.Parse(Params[0])); }));
                }
                else if (Command.ToLower().StartsWith("leftmouseclickdown"))
                {
                    string[] Params = Command.Split('(')[1].Split(')')[0].Split(',');
                    Point P = new Point(int.Parse(Params[0]), int.Parse(Params[1]));
                    Actions.Add(new Action(() => { Window.SetForegroundWindow(); Window.SendMouseDown(WindowHandleInfo.MouseButton.MK_LBUTTON, P); }));
                }
                else if (Command.ToLower().StartsWith("leftmouseclickup"))
                {
                    string[] Params = Command.Split('(')[1].Split(')')[0].Split(',');
                    Point P = new Point(int.Parse(Params[0]), int.Parse(Params[1]));
                    Actions.Add(new Action(() => { Window.SetForegroundWindow(); Window.SendMouseUp(WindowHandleInfo.MouseButton.MK_LBUTTON, P); }));
                }
                else if (Command.ToLower().StartsWith("keydown"))
                {
                    string[] Params = Command.Split('(')[1].Split(')')[0].Split(',');
                    byte AsciiValue = GetKeyCode(Params[0]);
                    Actions.Add(new Action(() => { Window.SetForegroundWindow(); KeyboardInputInjector.KeyDownRaw((KeyboardInputInjector.ScanCodeShort)AsciiValue); }));
                }
                else if (Command.ToLower().StartsWith("keyup"))
                {
                    string[] Params = Command.Split('(')[1].Split(')')[0].Split(',');
                    byte AsciiValue = GetKeyCode(Params[0]);
                    Actions.Add(new Action(() => { Window.SetForegroundWindow(); KeyboardInputInjector.KeyDownRaw((KeyboardInputInjector.ScanCodeShort)AsciiValue); }));
                }
                else
                    throw new Exception($"unreconized add input command {Command}");
            }
            return Actions.ToArray();
        }

        static byte GetKeyCode(string input)
        {
            //if you need to add a special key check in _KeyNotes for full list of keys off wind api site
            if (input.Length == 1)
                return (byte)input.ToCharArray()[0];
            else if (input == "shift")
                return 0xA0;
            else if (input == "tab")
                return 0x09;
            else if (input == "control")
                return 0x09;
            else if (input == "enter")
                return 0x0D;
            else if (input == "space")
                return 0x20;
            else if (input == "alt")
                return 0x12;
            else throw new Exception("Key not reconized");
        }

        void StartGame()
        {
            MotionController.ChangeProtocol((AvalibleProtocols)CoBo_Protocol.SelectedIndex, TeBo_ProtocolConnectionString.Text);

            if (!File.Exists(TeBo_GamePath.Text))
            {
                MessageBox.Show(EnglishText.HelpMessage_GameNotFoundHelpMessage);
                return;
            }
            try
            {
                GameRunTime = new Process();
                GameRunTime.StartInfo = new ProcessStartInfo()
                {
                    FileName = TeBo_GamePath.Text,
                    WorkingDirectory = Path.GetDirectoryName(TeBo_GamePath.Text),
                    Arguments = TeBo_StartOptionsRunArgs.Text
                };
                GameRunTime.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{EnglishText.HelpMessage_GameLaunchErrorHelpMessage}\n{ex}");
                return;
            }

            if (TeBo_RuntimeProcess.Text != null && TeBo_RuntimeProcess.Text != "")
            {
                Task FindGameTask = Task.Run(() => {
                    GameRunTime = null;
                    while (GameRunTime == null)
                    {
                        GameRunTime = Process.GetProcesses().FirstOrDefault(P => P.MainWindowHandle != IntPtr.Zero && P.ProcessName.ToLower() == TeBo_RuntimeProcess.Text.ToLower());
                    }
                    while (!GameRunTime.Responding) ;
                });
                TimeSpan TimeoutSpan = TimeSpan.FromMilliseconds(1000);
                if (!FindGameTask.Wait(TimeoutSpan))
                    MessageBox.Show($"{EnglishText.HelpMessage_GameLaunchErrorHelpMessage}{1000} MS.");
            }

            WindowHandleInfo Window = new WindowHandleInfo(GameRunTime.MainWindowHandle);

            Task InputTask = new Task(() => {
                if (TeBo_StartOptionsInput.Text != null && TeBo_StartOptionsInput.Text != "")
                {
                    Thread.Sleep(50);
                    Action[] Commands = GetCommands(TeBo_StartOptionsInput.Text, Window);
                    foreach (Action Command in Commands)
                    {
                        Command.Invoke();
                    }
                }
            });

            Window.SetForegroundWindow();

            InputTask.Start();
        }

        private void Bu_TestGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void TeBo_MotionOutputPath_TextChanged(object sender, EventArgs e)
        {
            CheckForRunConditions();
        }

        private void TeBo_GamePath_TextChanged(object sender, EventArgs e)
        {
            CheckForRunConditions();
        }

        private void TeBo_ProtocolConnectionString_TextChanged(object sender, EventArgs e)
        {
            CheckForRunConditions();
        }

        private void CoBo_Protocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckForRunConditions();
        }

        private void Bu_Run_MouseClick(object sender, MouseEventArgs e)
        {
            CheckForRunConditions();
            if (RunErrors != null)
                MessageBox.Show(RunErrors, "Not ready");
        }

        private void Bu_ViewSavedData_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog GamePathDialog = new OpenFileDialog())
            {
                GamePathDialog.Filter = "JMDM Move files (*.JMmov)|*.JMmov";//"JMDM Custom Move files (*.JMMov)|*.JMMov";
                GamePathDialog.InitialDirectory = Path.GetDirectoryName(TeBo_MotionOutputPath.Text);
                if (GamePathDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(GamePathDialog.FileName))
                    {
                        try
                        {
                            Time = 0;
                            PositionAndTimingDataModel Data = PositionAndTimingDataModel.DataLoadFromFile(GamePathDialog.FileName);
                            foreach (MomentaryPositionAndTimingFrameDataModel DataFrame in Data)
                            {
                                Time += DataFrame.Time;
                                DaGrVi_DataOutput.Rows.Add(Time, DataFrame.Time, DataFrame.C1, DataFrame.C2, DataFrame.C3, DataFrame.C4, DataFrame.C5, DataFrame.C6, DataFrame.Snowflakes, DataFrame.Wind, DataFrame.Rain, DataFrame.Smoke, DataFrame.Bubbles, DataFrame.Lightning, DataFrame.Flame, DataFrame.Jet, DataFrame.WaterSpray, DataFrame.Vibration, DataFrame.Back, DataFrame.SweepingLegs1, DataFrame.SweepingLegs2, DataFrame.Spare1, DataFrame.Spare2, DataFrame.Spare3);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{EnglishText.Exception_GenaricOppsException}\n{ex}");
                        }
                    }
                    else
                        MessageBox.Show(EnglishText.Exception_FileDoesentExistException);
                }

            }
        }

        private void TrBa_TimeBetweenTicks_Scroll(object sender, EventArgs e)
        {
            La_TimeBetweenTicksValue.Text = $"Value = {TrBa_TimeBetweenTicks.Value}";
        }

        private void Bu_PlayBackSavedData_Click(object sender, EventArgs e)
        {
            if (Player == null)
            {
                using (OpenFileDialog GamePathDialog = new OpenFileDialog())
                {
                    GamePathDialog.Filter = "JMDM Move files (*.JMmov)|*.JMmov";//"JMDM Custom Move files (*.JMMov)|*.JMMov";
                    GamePathDialog.InitialDirectory = Path.GetDirectoryName(TeBo_MotionOutputPath.Text);
                    if (GamePathDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(GamePathDialog.FileName))
                        {
                            CoBo_JoyStickList.Enabled = false;
                            GrBo_MotionData.Enabled = false;
                            GrBo_Game.Enabled = false;
                            GrBo_ConfigLoadAndSave.Enabled = false;
                            Bu_PlayBackSavedData.Enabled = false;
                            Bu_Run.Enabled = false;

                            Bu_PlayBackSavedData.Text = "Stop Play Back";

                            try
                            {
                                if (TaCo_MachinesSuportedForProtocol.SelectedIndex == 1)

                                    Player = new XYZ3CylMotionPlayer(this, GamePathDialog.FileName, TeBo_GamePath.Text, TeBo_StartOptionsRunArgs.Text, TeBo_RuntimeProcess.Text, TeBo_StartOptionsInput.Text, (AvalibleProtocols)CoBo_Protocol.SelectedIndex, TeBo_ProtocolConnectionString.Text);

                                else if (TaCo_MachinesSuportedForProtocol.SelectedIndex == 2)
                                    Player = new X1CylMotionPlayer(this, GamePathDialog.FileName, TeBo_GamePath.Text, TeBo_StartOptionsRunArgs.Text, TeBo_RuntimeProcess.Text, TeBo_StartOptionsInput.Text, (AvalibleProtocols)CoBo_Protocol.SelectedIndex, TeBo_ProtocolConnectionString.Text);

                                else
                                    Player = new XY2CylMotionPlayer(this, GamePathDialog.FileName, TeBo_GamePath.Text, TeBo_StartOptionsRunArgs.Text, TeBo_RuntimeProcess.Text, TeBo_StartOptionsInput.Text, (AvalibleProtocols)CoBo_Protocol.SelectedIndex, TeBo_ProtocolConnectionString.Text);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"{EnglishText.Exception_GenaricOppsException}\n{ex}");
                            }
                        }
                        else
                            MessageBox.Show(EnglishText.Exception_FileDoesentExistException);
                    }

                }

                Bu_PlayBackSavedData.Enabled = true;
            }
            else
            {
                if (Player != null)
                    Player.Stop();
                while (!Player.LoopFinished && Player.Run) ;
                Player = null;
                Bu_PlayBackSavedData.Text = "Play Back Saved Data";
                CoBo_JoyStickList.Enabled = true;
                GrBo_MotionData.Enabled = true;
                GrBo_Game.Enabled = true;
                GrBo_ConfigLoadAndSave.Enabled = true;
                Bu_Run.Enabled = true;
                Bu_PlayBackSavedData.Enabled = true;
            }
        }

        private void PlayBacksEndFunk()
        {
            Invoke(new MethodInvoker(() => { Bu_PlayBackSavedData_Click(this, new EventArgs()); }));
        }

        private void CaptureEndFunk()
        {
            Invoke(new MethodInvoker(() => {
                Bu_Run_Click(this, new EventArgs());
            }));
        }

        void SelectDeviceInfo(ComboBox TargetBox, ref DeviceObjectInstance TargetDeviceInfo)
        {
            if (TargetBox.SelectedIndex != -1)
                TargetDeviceInfo = ButtonInfos[TargetBox.SelectedIndex];
            else
                TargetDeviceInfo = null;
        }

        private void TaCo_MachinesSuportedForProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TaCo_MachinesSuportedForProtocol.SelectedIndex == 0)
                MotionController = new XYZ3CylMotionController(this);
            if (TaCo_MachinesSuportedForProtocol.SelectedIndex == 1)
                MotionController = new XYZ3CylMotionController(this);

        }

        private void CoBo_X1Cyl_JoyAxisForMechXAxisTilt_DropDown(object sender, EventArgs e)
        {
            AddAxisToComboBox(CoBo_X1Cyl_JoyAxisForMechXAxisTilt);
        }

        private void CoBo_X1Cyl_JoyAxisForMechXAxisTilt_DropDownClosed(object sender, EventArgs e)
        {
            SelectDeviceInfo(CoBo_X1Cyl_JoyAxisForMechXAxisTilt, ref MotionController.JoyButtonForMechBubblesStateTrigger);
        }

        private void La_JoyButtonForMechSytheticNoiseEffect_Click(object sender, EventArgs e)
        {

        }


        private void TaPa_X1Cyl_Click(object sender, EventArgs e)
        {

        }

        private void CoBo_X1Cyl_JoyButtonForMechSytheticNoiseEffect_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_X1Cyl_JoyButtonForMechSytheticNoiseEffect);
        }

        private void CoBo_X1Cyl_JoyButtonForMechSytheticNoiseEffect_DropDownClosed(object sender, EventArgs e)
        {
            SelectDeviceInfo(CoBo_X1Cyl_JoyButtonForMechSytheticNoiseEffect, ref MotionController.JoyButtonForMechSytheticNoiseEffect);
        }

        private void CoBo_X1Cyl_JoyAxisForMechSensitivity_DropDown(object sender, EventArgs e)
        {
            AddAxisToComboBox(CoBo_X1Cyl_JoyAxisForMechSensitivity);
        }

        private void CoBo_X1Cyl_JoyAxisForMechSensitivity_DropDownClosed(object sender, EventArgs e)
        {
            SelectDeviceInfo(CoBo_X1Cyl_JoyAxisForMechSensitivity, ref MotionController.JoyAxisForMechSensitivity);
        }

        private void CoBo_X1Cyl_JoyButtonForEndTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_X1Cyl_JoyButtonForEndTrigger);
        }

        private void CoBo_X1Cyl_JoyButtonForEndTrigger_DropDownClosed(object sender, EventArgs e)
        {
            SelectDeviceInfo(CoBo_X1Cyl_JoyButtonForEndTrigger, ref MotionController.JoyButtonForEnd);
        }

        private void TaPa_XYZ3Cyl_Click(object sender, EventArgs e)
        {

        }

        private void TaPa_XYCyl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CoBo_XY2Cyl_JoyAxisForMechXAxisTilt_DropDown(object sender, EventArgs e)
        {
            AddAxisToComboBox(CoBo_XY2Cyl_JoyAxisForMechXAxisTilt);
        }

        private void CoBo_XY2Cyl_JoyAxisForMechXAxisTilt_DropDownClosed(object sender, EventArgs e)
        {
            SelectDeviceInfo(CoBo_XY2Cyl_JoyAxisForMechXAxisTilt, ref MotionController.JoyButtonForMechBubblesStateTrigger);
        }

        private void CoBo_XY2Cyl_JoyAxisForMechYAxisTilt_DropDown(object sender, EventArgs e)
        {
            AddAxisToComboBox(CoBo_XY2Cyl_JoyAxisForMechYAxisTilt);
        }

        private void CoBo_XY2Cyl_JoyAxisForMechYAxisTilt_DropDownClosed(object sender, EventArgs e)
        {
            SelectDeviceInfo(CoBo_XY2Cyl_JoyAxisForMechYAxisTilt, ref MotionController.JoyButtonForMechBubblesStateTrigger);
        }

        private void CoBo_XY2Cyl_JoyButtonForMechSytheticNoiseEffect_DropDownClosed(object sender, EventArgs e)
        {
            SelectDeviceInfo(CoBo_XY2Cyl_JoyButtonForMechSytheticNoiseEffect, ref MotionController.JoyButtonForMechSytheticNoiseEffect);
        }

        private void CoBo_XY2Cyl_JoyButtonForMechSytheticNoiseEffect_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_XY2Cyl_JoyButtonForMechSytheticNoiseEffect); 
        }

        private void CoBo_XY2Cyl_JoyAxisForMechSensitivity_DropDown(object sender, EventArgs e)
        {
            AddAxisToComboBox(CoBo_XY2Cyl_JoyAxisForMechSensitivity);
        }

        private void CoBo_XY2Cyl_JoyAxisForMechSensitivity_DropDownClosed(object sender, EventArgs e)
        {
            SelectDeviceInfo(CoBo_XY2Cyl_JoyAxisForMechSensitivity, ref MotionController.JoyAxisForMechSensitivity);
        }

        private void CoBo_XY2Cyl_JoyButtonForEndTrigger_DropDown(object sender, EventArgs e)
        {
            AddButtonsToComboBox(CoBo_XY2Cyl_JoyButtonForEndTrigger);
        }

        private void CoBo_XY2Cyl_JoyButtonForEndTrigger_DropDownClosed(object sender, EventArgs e)
        {
            SelectDeviceInfo(CoBo_XY2Cyl_JoyButtonForEndTrigger, ref MotionController.JoyButtonForEnd);
        }

    } 
}

