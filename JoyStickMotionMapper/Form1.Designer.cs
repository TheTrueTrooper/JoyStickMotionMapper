namespace JoyStickMotionMapper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CoBo_JoyStickList = new System.Windows.Forms.ComboBox();
            this.La_SelectJoyStick = new System.Windows.Forms.Label();
            this.La_JoystickDevicesName = new System.Windows.Forms.Label();
            this.La_JoystickDevicesGUID = new System.Windows.Forms.Label();
            this.TeBo_JoystickDevicesName = new System.Windows.Forms.TextBox();
            this.TeBo_JoystickDevicesGUID = new System.Windows.Forms.TextBox();
            this.TeBo_JoystickDeviceInstancesName = new System.Windows.Forms.TextBox();
            this.La_JoystickDeviceInstancesName = new System.Windows.Forms.Label();
            this.TeBo_JoystickDeviceInstancesGUID = new System.Windows.Forms.TextBox();
            this.La_JoystickDeviceInstancesGUID = new System.Windows.Forms.Label();
            this.TeBo_AxisCount = new System.Windows.Forms.TextBox();
            this.La_AxisCount = new System.Windows.Forms.Label();
            this.TeBo_ButtonCount = new System.Windows.Forms.TextBox();
            this.La_ButtonCount = new System.Windows.Forms.Label();
            this.TeBo_POVCount = new System.Windows.Forms.TextBox();
            this.La_POVCount = new System.Windows.Forms.Label();
            this.DaGrVi_Effects = new System.Windows.Forms.DataGridView();
            this.Col_EffectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_EffectGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_EffectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.La_Effects = new System.Windows.Forms.Label();
            this.DaGrVi_Axis = new System.Windows.Forms.DataGridView();
            this.Col_AxisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AxisValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaGrVi_Buttons = new System.Windows.Forms.DataGridView();
            this.Col_ButtonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.La_Axis = new System.Windows.Forms.Label();
            this.La_Buttons = new System.Windows.Forms.Label();
            this.JoyStickPollCycle = new System.Windows.Forms.Timer(this.components);
            this.DaGrVi_POVs = new System.Windows.Forms.DataGridView();
            this.Col_POVs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.La_POVs = new System.Windows.Forms.Label();
            this.GrBo_Joystick = new System.Windows.Forms.GroupBox();
            this.GrBo_Game = new System.Windows.Forms.GroupBox();
            this.But_RuntimeProcessNameHelp = new System.Windows.Forms.Button();
            this.But_StartOptionsRunArgsHelp = new System.Windows.Forms.Button();
            this.Bu_TestGame = new System.Windows.Forms.Button();
            this.But_StartOptionsInputHelp = new System.Windows.Forms.Button();
            this.La_StartOptionsInput = new System.Windows.Forms.Label();
            this.TeBo_StartOptionsInput = new System.Windows.Forms.TextBox();
            this.La_StartOptionsRunArgs = new System.Windows.Forms.Label();
            this.TeBo_StartOptionsRunArgs = new System.Windows.Forms.TextBox();
            this.La_RuntimeProcess = new System.Windows.Forms.Label();
            this.TeBo_RuntimeProcess = new System.Windows.Forms.TextBox();
            this.La_GamePath = new System.Windows.Forms.Label();
            this.TeBo_GamePath = new System.Windows.Forms.TextBox();
            this.Bu_LoadConfigFile = new System.Windows.Forms.Button();
            this.Bu_SaveConfigFile = new System.Windows.Forms.Button();
            this.GrBo_MotionData = new System.Windows.Forms.GroupBox();
            this.La_MachinesSuportedForProtocol = new System.Windows.Forms.Label();
            this.TaCo_MachinesSuportedForProtocol = new System.Windows.Forms.TabControl();
            this.TaPa_XYZ3Cyl = new System.Windows.Forms.TabPage();
            this.La_JoyButtonForMechWaterSprayStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechVibrationStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechVibrationStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechBackStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechBackStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechSweepingLegs1StateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechSweepingLegs2StateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechSpare1StateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechSpare1StateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechSpare2StateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechSpare2StateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechSpare3StateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechSpare3StateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechBubblesStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechBubblesStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechLightningStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechLightningStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechFlameStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechFlameStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechJetStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechJetStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechRainStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechRainStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechSmokeStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechSmokeStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechWindStateTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechWindStateTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForEndTrigger = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForEndTrigger = new System.Windows.Forms.ComboBox();
            this.La_JoyAxisForMechSensitivity = new System.Windows.Forms.Label();
            this.CoBo_JoyAxisForMechSensitivity = new System.Windows.Forms.ComboBox();
            this.La_JoyButtonForMechSytheticNoiseEffect = new System.Windows.Forms.Label();
            this.CoBo_JoyButtonForMechSytheticNoiseEffect = new System.Windows.Forms.ComboBox();
            this.La_JoyAxisForMechYAxisTilt = new System.Windows.Forms.Label();
            this.CoBo_JoyAxisForMechYAxisTilt = new System.Windows.Forms.ComboBox();
            this.La_JoyAxisForMechXAxisTilt = new System.Windows.Forms.Label();
            this.VScBa_3CylXYZ = new System.Windows.Forms.VScrollBar();
            this.CoBo_JoyAxisForMechXAxisTilt = new System.Windows.Forms.ComboBox();
            this.But_ProtocolConnectionStringHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TeBo_ProtocolConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CoBo_Protocol = new System.Windows.Forms.ComboBox();
            this.La_MotionOutputPathEnding = new System.Windows.Forms.Label();
            this.La_MotionOutputPath = new System.Windows.Forms.Label();
            this.TeBo_MotionOutputPath = new System.Windows.Forms.TextBox();
            this.GrBo_RunTime = new System.Windows.Forms.GroupBox();
            this.Bu_Run = new System.Windows.Forms.Button();
            this.DaGrVi_DataOutput = new System.Windows.Forms.DataGridView();
            this.Col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DeltaTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_C5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_C6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Snowflakes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Wind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Rain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Smoke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Bubbles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Lightning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Flame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Jet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_WaterSpray = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Vibration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Back = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SweepingLegs1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SweepingLegs2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Spare1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Spare2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Spare3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.La_FrameOutput = new System.Windows.Forms.Label();
            this.GrBo_FrameData = new System.Windows.Forms.GroupBox();
            this.Bu_PlayBackSavedData = new System.Windows.Forms.Button();
            this.La_TimeBetweenTicksValue = new System.Windows.Forms.Label();
            this.La_TimeBetweenTicks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TrBa_TimeBetweenTicks = new System.Windows.Forms.TrackBar();
            this.Bu_ViewSavedData = new System.Windows.Forms.Button();
            this.GrBo_ConfigLoadAndSave = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_Effects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_Axis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_Buttons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_POVs)).BeginInit();
            this.GrBo_Joystick.SuspendLayout();
            this.GrBo_Game.SuspendLayout();
            this.GrBo_MotionData.SuspendLayout();
            this.TaCo_MachinesSuportedForProtocol.SuspendLayout();
            this.TaPa_XYZ3Cyl.SuspendLayout();
            this.GrBo_RunTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_DataOutput)).BeginInit();
            this.GrBo_FrameData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_TimeBetweenTicks)).BeginInit();
            this.GrBo_ConfigLoadAndSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoBo_JoyStickList
            // 
            this.CoBo_JoyStickList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyStickList.FormattingEnabled = true;
            this.CoBo_JoyStickList.Location = new System.Drawing.Point(40, 92);
            this.CoBo_JoyStickList.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyStickList.Name = "CoBo_JoyStickList";
            this.CoBo_JoyStickList.Size = new System.Drawing.Size(1512, 33);
            this.CoBo_JoyStickList.TabIndex = 0;
            this.CoBo_JoyStickList.DropDown += new System.EventHandler(this.CoBo_JoyStickList_DropDown);
            this.CoBo_JoyStickList.DropDownClosed += new System.EventHandler(this.CoBo_JoyStickList_DropDownClosed);
            // 
            // La_SelectJoyStick
            // 
            this.La_SelectJoyStick.AutoSize = true;
            this.La_SelectJoyStick.Location = new System.Drawing.Point(34, 48);
            this.La_SelectJoyStick.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_SelectJoyStick.Name = "La_SelectJoyStick";
            this.La_SelectJoyStick.Size = new System.Drawing.Size(165, 25);
            this.La_SelectJoyStick.TabIndex = 1;
            this.La_SelectJoyStick.Text = "Select Joy Stick";
            // 
            // La_JoystickDevicesName
            // 
            this.La_JoystickDevicesName.AutoSize = true;
            this.La_JoystickDevicesName.Location = new System.Drawing.Point(40, 156);
            this.La_JoystickDevicesName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoystickDevicesName.Name = "La_JoystickDevicesName";
            this.La_JoystickDevicesName.Size = new System.Drawing.Size(235, 25);
            this.La_JoystickDevicesName.TabIndex = 2;
            this.La_JoystickDevicesName.Text = "Joystick Devices Name";
            // 
            // La_JoystickDevicesGUID
            // 
            this.La_JoystickDevicesGUID.AutoSize = true;
            this.La_JoystickDevicesGUID.Location = new System.Drawing.Point(40, 231);
            this.La_JoystickDevicesGUID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoystickDevicesGUID.Name = "La_JoystickDevicesGUID";
            this.La_JoystickDevicesGUID.Size = new System.Drawing.Size(230, 25);
            this.La_JoystickDevicesGUID.TabIndex = 3;
            this.La_JoystickDevicesGUID.Text = "Joystick Devices GUID";
            // 
            // TeBo_JoystickDevicesName
            // 
            this.TeBo_JoystickDevicesName.Location = new System.Drawing.Point(40, 187);
            this.TeBo_JoystickDevicesName.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_JoystickDevicesName.Name = "TeBo_JoystickDevicesName";
            this.TeBo_JoystickDevicesName.ReadOnly = true;
            this.TeBo_JoystickDevicesName.Size = new System.Drawing.Size(1512, 31);
            this.TeBo_JoystickDevicesName.TabIndex = 4;
            // 
            // TeBo_JoystickDevicesGUID
            // 
            this.TeBo_JoystickDevicesGUID.Location = new System.Drawing.Point(40, 262);
            this.TeBo_JoystickDevicesGUID.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_JoystickDevicesGUID.Name = "TeBo_JoystickDevicesGUID";
            this.TeBo_JoystickDevicesGUID.ReadOnly = true;
            this.TeBo_JoystickDevicesGUID.Size = new System.Drawing.Size(1512, 31);
            this.TeBo_JoystickDevicesGUID.TabIndex = 5;
            // 
            // TeBo_JoystickDeviceInstancesName
            // 
            this.TeBo_JoystickDeviceInstancesName.Location = new System.Drawing.Point(40, 346);
            this.TeBo_JoystickDeviceInstancesName.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_JoystickDeviceInstancesName.Name = "TeBo_JoystickDeviceInstancesName";
            this.TeBo_JoystickDeviceInstancesName.ReadOnly = true;
            this.TeBo_JoystickDeviceInstancesName.Size = new System.Drawing.Size(1512, 31);
            this.TeBo_JoystickDeviceInstancesName.TabIndex = 7;
            // 
            // La_JoystickDeviceInstancesName
            // 
            this.La_JoystickDeviceInstancesName.AutoSize = true;
            this.La_JoystickDeviceInstancesName.Location = new System.Drawing.Point(40, 315);
            this.La_JoystickDeviceInstancesName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoystickDeviceInstancesName.Name = "La_JoystickDeviceInstancesName";
            this.La_JoystickDeviceInstancesName.Size = new System.Drawing.Size(322, 25);
            this.La_JoystickDeviceInstancesName.TabIndex = 6;
            this.La_JoystickDeviceInstancesName.Text = "Joystick Device Instances Name";
            // 
            // TeBo_JoystickDeviceInstancesGUID
            // 
            this.TeBo_JoystickDeviceInstancesGUID.Location = new System.Drawing.Point(40, 429);
            this.TeBo_JoystickDeviceInstancesGUID.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_JoystickDeviceInstancesGUID.Name = "TeBo_JoystickDeviceInstancesGUID";
            this.TeBo_JoystickDeviceInstancesGUID.ReadOnly = true;
            this.TeBo_JoystickDeviceInstancesGUID.Size = new System.Drawing.Size(1512, 31);
            this.TeBo_JoystickDeviceInstancesGUID.TabIndex = 9;
            // 
            // La_JoystickDeviceInstancesGUID
            // 
            this.La_JoystickDeviceInstancesGUID.AutoSize = true;
            this.La_JoystickDeviceInstancesGUID.Location = new System.Drawing.Point(40, 398);
            this.La_JoystickDeviceInstancesGUID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoystickDeviceInstancesGUID.Name = "La_JoystickDeviceInstancesGUID";
            this.La_JoystickDeviceInstancesGUID.Size = new System.Drawing.Size(317, 25);
            this.La_JoystickDeviceInstancesGUID.TabIndex = 8;
            this.La_JoystickDeviceInstancesGUID.Text = "Joystick Device Instances GUID";
            // 
            // TeBo_AxisCount
            // 
            this.TeBo_AxisCount.Location = new System.Drawing.Point(42, 523);
            this.TeBo_AxisCount.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_AxisCount.Name = "TeBo_AxisCount";
            this.TeBo_AxisCount.ReadOnly = true;
            this.TeBo_AxisCount.Size = new System.Drawing.Size(128, 31);
            this.TeBo_AxisCount.TabIndex = 11;
            // 
            // La_AxisCount
            // 
            this.La_AxisCount.AutoSize = true;
            this.La_AxisCount.Location = new System.Drawing.Point(42, 492);
            this.La_AxisCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_AxisCount.Name = "La_AxisCount";
            this.La_AxisCount.Size = new System.Drawing.Size(116, 25);
            this.La_AxisCount.TabIndex = 10;
            this.La_AxisCount.Text = "Axis Count";
            // 
            // TeBo_ButtonCount
            // 
            this.TeBo_ButtonCount.Location = new System.Drawing.Point(186, 523);
            this.TeBo_ButtonCount.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_ButtonCount.Name = "TeBo_ButtonCount";
            this.TeBo_ButtonCount.ReadOnly = true;
            this.TeBo_ButtonCount.Size = new System.Drawing.Size(128, 31);
            this.TeBo_ButtonCount.TabIndex = 13;
            // 
            // La_ButtonCount
            // 
            this.La_ButtonCount.AutoSize = true;
            this.La_ButtonCount.Location = new System.Drawing.Point(180, 492);
            this.La_ButtonCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_ButtonCount.Name = "La_ButtonCount";
            this.La_ButtonCount.Size = new System.Drawing.Size(137, 25);
            this.La_ButtonCount.TabIndex = 12;
            this.La_ButtonCount.Text = "Button Count";
            // 
            // TeBo_POVCount
            // 
            this.TeBo_POVCount.Location = new System.Drawing.Point(330, 523);
            this.TeBo_POVCount.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_POVCount.Name = "TeBo_POVCount";
            this.TeBo_POVCount.ReadOnly = true;
            this.TeBo_POVCount.Size = new System.Drawing.Size(128, 31);
            this.TeBo_POVCount.TabIndex = 15;
            // 
            // La_POVCount
            // 
            this.La_POVCount.AutoSize = true;
            this.La_POVCount.Location = new System.Drawing.Point(324, 492);
            this.La_POVCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_POVCount.Name = "La_POVCount";
            this.La_POVCount.Size = new System.Drawing.Size(119, 25);
            this.La_POVCount.TabIndex = 14;
            this.La_POVCount.Text = "POV Count";
            // 
            // DaGrVi_Effects
            // 
            this.DaGrVi_Effects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaGrVi_Effects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_EffectName,
            this.Col_EffectGUID,
            this.Col_EffectType});
            this.DaGrVi_Effects.Location = new System.Drawing.Point(542, 523);
            this.DaGrVi_Effects.Margin = new System.Windows.Forms.Padding(6);
            this.DaGrVi_Effects.Name = "DaGrVi_Effects";
            this.DaGrVi_Effects.ReadOnly = true;
            this.DaGrVi_Effects.RowHeadersWidth = 82;
            this.DaGrVi_Effects.Size = new System.Drawing.Size(1008, 108);
            this.DaGrVi_Effects.TabIndex = 16;
            // 
            // Col_EffectName
            // 
            this.Col_EffectName.HeaderText = "Effect Name";
            this.Col_EffectName.MinimumWidth = 10;
            this.Col_EffectName.Name = "Col_EffectName";
            this.Col_EffectName.ReadOnly = true;
            this.Col_EffectName.Width = 200;
            // 
            // Col_EffectGUID
            // 
            this.Col_EffectGUID.HeaderText = "Effect GUID";
            this.Col_EffectGUID.MinimumWidth = 10;
            this.Col_EffectGUID.Name = "Col_EffectGUID";
            this.Col_EffectGUID.ReadOnly = true;
            this.Col_EffectGUID.Width = 200;
            // 
            // Col_EffectType
            // 
            this.Col_EffectType.HeaderText = "Effect Type";
            this.Col_EffectType.MinimumWidth = 10;
            this.Col_EffectType.Name = "Col_EffectType";
            this.Col_EffectType.ReadOnly = true;
            this.Col_EffectType.Width = 200;
            // 
            // La_Effects
            // 
            this.La_Effects.AutoSize = true;
            this.La_Effects.Location = new System.Drawing.Point(542, 492);
            this.La_Effects.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_Effects.Name = "La_Effects";
            this.La_Effects.Size = new System.Drawing.Size(78, 25);
            this.La_Effects.TabIndex = 17;
            this.La_Effects.Text = "Effects";
            // 
            // DaGrVi_Axis
            // 
            this.DaGrVi_Axis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaGrVi_Axis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_AxisName,
            this.Col_AxisValue});
            this.DaGrVi_Axis.Location = new System.Drawing.Point(548, 683);
            this.DaGrVi_Axis.Margin = new System.Windows.Forms.Padding(6);
            this.DaGrVi_Axis.Name = "DaGrVi_Axis";
            this.DaGrVi_Axis.ReadOnly = true;
            this.DaGrVi_Axis.RowHeadersWidth = 82;
            this.DaGrVi_Axis.Size = new System.Drawing.Size(496, 235);
            this.DaGrVi_Axis.TabIndex = 18;
            // 
            // Col_AxisName
            // 
            this.Col_AxisName.HeaderText = "Axis Name";
            this.Col_AxisName.MinimumWidth = 10;
            this.Col_AxisName.Name = "Col_AxisName";
            this.Col_AxisName.ReadOnly = true;
            this.Col_AxisName.Width = 200;
            // 
            // Col_AxisValue
            // 
            this.Col_AxisValue.HeaderText = "Value";
            this.Col_AxisValue.MinimumWidth = 10;
            this.Col_AxisValue.Name = "Col_AxisValue";
            this.Col_AxisValue.ReadOnly = true;
            this.Col_AxisValue.Width = 200;
            // 
            // DaGrVi_Buttons
            // 
            this.DaGrVi_Buttons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaGrVi_Buttons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ButtonName,
            this.dataGridViewTextBoxColumn2});
            this.DaGrVi_Buttons.Location = new System.Drawing.Point(42, 598);
            this.DaGrVi_Buttons.Margin = new System.Windows.Forms.Padding(6);
            this.DaGrVi_Buttons.Name = "DaGrVi_Buttons";
            this.DaGrVi_Buttons.ReadOnly = true;
            this.DaGrVi_Buttons.RowHeadersWidth = 82;
            this.DaGrVi_Buttons.Size = new System.Drawing.Size(494, 319);
            this.DaGrVi_Buttons.TabIndex = 19;
            // 
            // Col_ButtonName
            // 
            this.Col_ButtonName.HeaderText = "Button Name";
            this.Col_ButtonName.MinimumWidth = 10;
            this.Col_ButtonName.Name = "Col_ButtonName";
            this.Col_ButtonName.ReadOnly = true;
            this.Col_ButtonName.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // La_Axis
            // 
            this.La_Axis.AutoSize = true;
            this.La_Axis.Location = new System.Drawing.Point(542, 652);
            this.La_Axis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_Axis.Name = "La_Axis";
            this.La_Axis.Size = new System.Drawing.Size(53, 25);
            this.La_Axis.TabIndex = 20;
            this.La_Axis.Text = "Axis";
            // 
            // La_Buttons
            // 
            this.La_Buttons.AutoSize = true;
            this.La_Buttons.Location = new System.Drawing.Point(36, 567);
            this.La_Buttons.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_Buttons.Name = "La_Buttons";
            this.La_Buttons.Size = new System.Drawing.Size(85, 25);
            this.La_Buttons.TabIndex = 21;
            this.La_Buttons.Text = "Buttons";
            // 
            // JoyStickPollCycle
            // 
            this.JoyStickPollCycle.Tick += new System.EventHandler(this.JoyStickPollCycle_Tick);
            // 
            // DaGrVi_POVs
            // 
            this.DaGrVi_POVs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaGrVi_POVs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_POVs,
            this.dataGridViewTextBoxColumn3});
            this.DaGrVi_POVs.Location = new System.Drawing.Point(1054, 683);
            this.DaGrVi_POVs.Margin = new System.Windows.Forms.Padding(6);
            this.DaGrVi_POVs.Name = "DaGrVi_POVs";
            this.DaGrVi_POVs.ReadOnly = true;
            this.DaGrVi_POVs.RowHeadersWidth = 82;
            this.DaGrVi_POVs.Size = new System.Drawing.Size(494, 235);
            this.DaGrVi_POVs.TabIndex = 22;
            // 
            // Col_POVs
            // 
            this.Col_POVs.HeaderText = "POV Name";
            this.Col_POVs.MinimumWidth = 10;
            this.Col_POVs.Name = "Col_POVs";
            this.Col_POVs.ReadOnly = true;
            this.Col_POVs.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Value";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // La_POVs
            // 
            this.La_POVs.AutoSize = true;
            this.La_POVs.Location = new System.Drawing.Point(1048, 652);
            this.La_POVs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_POVs.Name = "La_POVs";
            this.La_POVs.Size = new System.Drawing.Size(67, 25);
            this.La_POVs.TabIndex = 23;
            this.La_POVs.Text = "POVs";
            // 
            // GrBo_Joystick
            // 
            this.GrBo_Joystick.Controls.Add(this.La_SelectJoyStick);
            this.GrBo_Joystick.Controls.Add(this.La_POVs);
            this.GrBo_Joystick.Controls.Add(this.CoBo_JoyStickList);
            this.GrBo_Joystick.Controls.Add(this.DaGrVi_POVs);
            this.GrBo_Joystick.Controls.Add(this.La_JoystickDevicesName);
            this.GrBo_Joystick.Controls.Add(this.La_Buttons);
            this.GrBo_Joystick.Controls.Add(this.La_JoystickDevicesGUID);
            this.GrBo_Joystick.Controls.Add(this.La_Axis);
            this.GrBo_Joystick.Controls.Add(this.TeBo_JoystickDevicesName);
            this.GrBo_Joystick.Controls.Add(this.DaGrVi_Buttons);
            this.GrBo_Joystick.Controls.Add(this.TeBo_JoystickDevicesGUID);
            this.GrBo_Joystick.Controls.Add(this.DaGrVi_Axis);
            this.GrBo_Joystick.Controls.Add(this.La_JoystickDeviceInstancesName);
            this.GrBo_Joystick.Controls.Add(this.La_Effects);
            this.GrBo_Joystick.Controls.Add(this.TeBo_JoystickDeviceInstancesName);
            this.GrBo_Joystick.Controls.Add(this.DaGrVi_Effects);
            this.GrBo_Joystick.Controls.Add(this.La_JoystickDeviceInstancesGUID);
            this.GrBo_Joystick.Controls.Add(this.TeBo_POVCount);
            this.GrBo_Joystick.Controls.Add(this.TeBo_JoystickDeviceInstancesGUID);
            this.GrBo_Joystick.Controls.Add(this.La_POVCount);
            this.GrBo_Joystick.Controls.Add(this.La_AxisCount);
            this.GrBo_Joystick.Controls.Add(this.TeBo_ButtonCount);
            this.GrBo_Joystick.Controls.Add(this.TeBo_AxisCount);
            this.GrBo_Joystick.Controls.Add(this.La_ButtonCount);
            this.GrBo_Joystick.Location = new System.Drawing.Point(24, 23);
            this.GrBo_Joystick.Margin = new System.Windows.Forms.Padding(6);
            this.GrBo_Joystick.Name = "GrBo_Joystick";
            this.GrBo_Joystick.Padding = new System.Windows.Forms.Padding(6);
            this.GrBo_Joystick.Size = new System.Drawing.Size(1582, 944);
            this.GrBo_Joystick.TabIndex = 24;
            this.GrBo_Joystick.TabStop = false;
            this.GrBo_Joystick.Text = "Joystick Settings";
            // 
            // GrBo_Game
            // 
            this.GrBo_Game.Controls.Add(this.But_RuntimeProcessNameHelp);
            this.GrBo_Game.Controls.Add(this.But_StartOptionsRunArgsHelp);
            this.GrBo_Game.Controls.Add(this.Bu_TestGame);
            this.GrBo_Game.Controls.Add(this.But_StartOptionsInputHelp);
            this.GrBo_Game.Controls.Add(this.La_StartOptionsInput);
            this.GrBo_Game.Controls.Add(this.TeBo_StartOptionsInput);
            this.GrBo_Game.Controls.Add(this.La_StartOptionsRunArgs);
            this.GrBo_Game.Controls.Add(this.TeBo_StartOptionsRunArgs);
            this.GrBo_Game.Controls.Add(this.La_RuntimeProcess);
            this.GrBo_Game.Controls.Add(this.TeBo_RuntimeProcess);
            this.GrBo_Game.Controls.Add(this.La_GamePath);
            this.GrBo_Game.Controls.Add(this.TeBo_GamePath);
            this.GrBo_Game.Location = new System.Drawing.Point(1618, 23);
            this.GrBo_Game.Margin = new System.Windows.Forms.Padding(6);
            this.GrBo_Game.Name = "GrBo_Game";
            this.GrBo_Game.Padding = new System.Windows.Forms.Padding(6);
            this.GrBo_Game.Size = new System.Drawing.Size(956, 562);
            this.GrBo_Game.TabIndex = 25;
            this.GrBo_Game.TabStop = false;
            this.GrBo_Game.Text = "Game Info";
            // 
            // But_RuntimeProcessNameHelp
            // 
            this.But_RuntimeProcessNameHelp.Location = new System.Drawing.Point(272, 146);
            this.But_RuntimeProcessNameHelp.Margin = new System.Windows.Forms.Padding(6);
            this.But_RuntimeProcessNameHelp.Name = "But_RuntimeProcessNameHelp";
            this.But_RuntimeProcessNameHelp.Size = new System.Drawing.Size(150, 44);
            this.But_RuntimeProcessNameHelp.TabIndex = 37;
            this.But_RuntimeProcessNameHelp.Text = "Help";
            this.But_RuntimeProcessNameHelp.UseVisualStyleBackColor = true;
            this.But_RuntimeProcessNameHelp.Click += new System.EventHandler(this.But_RuntimeProcessNameHelp_Click);
            // 
            // But_StartOptionsRunArgsHelp
            // 
            this.But_StartOptionsRunArgsHelp.Location = new System.Drawing.Point(266, 256);
            this.But_StartOptionsRunArgsHelp.Margin = new System.Windows.Forms.Padding(6);
            this.But_StartOptionsRunArgsHelp.Name = "But_StartOptionsRunArgsHelp";
            this.But_StartOptionsRunArgsHelp.Size = new System.Drawing.Size(150, 44);
            this.But_StartOptionsRunArgsHelp.TabIndex = 36;
            this.But_StartOptionsRunArgsHelp.Text = "Help";
            this.But_StartOptionsRunArgsHelp.UseVisualStyleBackColor = true;
            this.But_StartOptionsRunArgsHelp.Click += new System.EventHandler(this.But_StartOptionsRunArgsHelp_Click);
            // 
            // Bu_TestGame
            // 
            this.Bu_TestGame.Location = new System.Drawing.Point(30, 492);
            this.Bu_TestGame.Margin = new System.Windows.Forms.Padding(6);
            this.Bu_TestGame.Name = "Bu_TestGame";
            this.Bu_TestGame.Size = new System.Drawing.Size(888, 44);
            this.Bu_TestGame.TabIndex = 35;
            this.Bu_TestGame.Text = "Test Game";
            this.Bu_TestGame.UseVisualStyleBackColor = true;
            this.Bu_TestGame.Click += new System.EventHandler(this.Bu_TestGame_Click);
            // 
            // But_StartOptionsInputHelp
            // 
            this.But_StartOptionsInputHelp.Location = new System.Drawing.Point(226, 367);
            this.But_StartOptionsInputHelp.Margin = new System.Windows.Forms.Padding(6);
            this.But_StartOptionsInputHelp.Name = "But_StartOptionsInputHelp";
            this.But_StartOptionsInputHelp.Size = new System.Drawing.Size(150, 44);
            this.But_StartOptionsInputHelp.TabIndex = 32;
            this.But_StartOptionsInputHelp.Text = "Help";
            this.But_StartOptionsInputHelp.UseVisualStyleBackColor = true;
            this.But_StartOptionsInputHelp.Click += new System.EventHandler(this.But_StartOptionsInputHelp_Click);
            // 
            // La_StartOptionsInput
            // 
            this.La_StartOptionsInput.AutoSize = true;
            this.La_StartOptionsInput.Location = new System.Drawing.Point(24, 377);
            this.La_StartOptionsInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_StartOptionsInput.Name = "La_StartOptionsInput";
            this.La_StartOptionsInput.Size = new System.Drawing.Size(190, 25);
            this.La_StartOptionsInput.TabIndex = 31;
            this.La_StartOptionsInput.Text = "Start Options Input";
            // 
            // TeBo_StartOptionsInput
            // 
            this.TeBo_StartOptionsInput.Location = new System.Drawing.Point(30, 423);
            this.TeBo_StartOptionsInput.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_StartOptionsInput.Name = "TeBo_StartOptionsInput";
            this.TeBo_StartOptionsInput.Size = new System.Drawing.Size(884, 31);
            this.TeBo_StartOptionsInput.TabIndex = 30;
            // 
            // La_StartOptionsRunArgs
            // 
            this.La_StartOptionsRunArgs.AutoSize = true;
            this.La_StartOptionsRunArgs.Location = new System.Drawing.Point(24, 267);
            this.La_StartOptionsRunArgs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_StartOptionsRunArgs.Name = "La_StartOptionsRunArgs";
            this.La_StartOptionsRunArgs.Size = new System.Drawing.Size(232, 25);
            this.La_StartOptionsRunArgs.TabIndex = 29;
            this.La_StartOptionsRunArgs.Text = "Start Options Run Args";
            // 
            // TeBo_StartOptionsRunArgs
            // 
            this.TeBo_StartOptionsRunArgs.Location = new System.Drawing.Point(30, 313);
            this.TeBo_StartOptionsRunArgs.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_StartOptionsRunArgs.Name = "TeBo_StartOptionsRunArgs";
            this.TeBo_StartOptionsRunArgs.Size = new System.Drawing.Size(884, 31);
            this.TeBo_StartOptionsRunArgs.TabIndex = 28;
            // 
            // La_RuntimeProcess
            // 
            this.La_RuntimeProcess.AutoSize = true;
            this.La_RuntimeProcess.Location = new System.Drawing.Point(24, 156);
            this.La_RuntimeProcess.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_RuntimeProcess.Name = "La_RuntimeProcess";
            this.La_RuntimeProcess.Size = new System.Drawing.Size(237, 25);
            this.La_RuntimeProcess.TabIndex = 27;
            this.La_RuntimeProcess.Text = "Runtime Process Name";
            // 
            // TeBo_RuntimeProcess
            // 
            this.TeBo_RuntimeProcess.Location = new System.Drawing.Point(30, 202);
            this.TeBo_RuntimeProcess.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_RuntimeProcess.Name = "TeBo_RuntimeProcess";
            this.TeBo_RuntimeProcess.Size = new System.Drawing.Size(884, 31);
            this.TeBo_RuntimeProcess.TabIndex = 26;
            // 
            // La_GamePath
            // 
            this.La_GamePath.AutoSize = true;
            this.La_GamePath.Location = new System.Drawing.Point(24, 48);
            this.La_GamePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_GamePath.Name = "La_GamePath";
            this.La_GamePath.Size = new System.Drawing.Size(119, 25);
            this.La_GamePath.TabIndex = 25;
            this.La_GamePath.Text = "Game Path";
            // 
            // TeBo_GamePath
            // 
            this.TeBo_GamePath.Location = new System.Drawing.Point(30, 94);
            this.TeBo_GamePath.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_GamePath.Name = "TeBo_GamePath";
            this.TeBo_GamePath.Size = new System.Drawing.Size(884, 31);
            this.TeBo_GamePath.TabIndex = 0;
            this.TeBo_GamePath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TeBo_GamePath_MouseClick);
            this.TeBo_GamePath.TextChanged += new System.EventHandler(this.TeBo_GamePath_TextChanged);
            // 
            // Bu_LoadConfigFile
            // 
            this.Bu_LoadConfigFile.Location = new System.Drawing.Point(30, 92);
            this.Bu_LoadConfigFile.Margin = new System.Windows.Forms.Padding(6);
            this.Bu_LoadConfigFile.Name = "Bu_LoadConfigFile";
            this.Bu_LoadConfigFile.Size = new System.Drawing.Size(888, 44);
            this.Bu_LoadConfigFile.TabIndex = 34;
            this.Bu_LoadConfigFile.Text = "Load Config File";
            this.Bu_LoadConfigFile.UseVisualStyleBackColor = true;
            this.Bu_LoadConfigFile.Click += new System.EventHandler(this.Bu_LoadConfigFile_Click);
            // 
            // Bu_SaveConfigFile
            // 
            this.Bu_SaveConfigFile.Location = new System.Drawing.Point(30, 37);
            this.Bu_SaveConfigFile.Margin = new System.Windows.Forms.Padding(6);
            this.Bu_SaveConfigFile.Name = "Bu_SaveConfigFile";
            this.Bu_SaveConfigFile.Size = new System.Drawing.Size(888, 44);
            this.Bu_SaveConfigFile.TabIndex = 33;
            this.Bu_SaveConfigFile.Text = "Save Config File";
            this.Bu_SaveConfigFile.UseVisualStyleBackColor = true;
            this.Bu_SaveConfigFile.Click += new System.EventHandler(this.Bu_SaveConfigFile_Click);
            // 
            // GrBo_MotionData
            // 
            this.GrBo_MotionData.Controls.Add(this.La_MachinesSuportedForProtocol);
            this.GrBo_MotionData.Controls.Add(this.TaCo_MachinesSuportedForProtocol);
            this.GrBo_MotionData.Controls.Add(this.But_ProtocolConnectionStringHelp);
            this.GrBo_MotionData.Controls.Add(this.label2);
            this.GrBo_MotionData.Controls.Add(this.TeBo_ProtocolConnectionString);
            this.GrBo_MotionData.Controls.Add(this.label1);
            this.GrBo_MotionData.Controls.Add(this.CoBo_Protocol);
            this.GrBo_MotionData.Controls.Add(this.La_MotionOutputPathEnding);
            this.GrBo_MotionData.Controls.Add(this.La_MotionOutputPath);
            this.GrBo_MotionData.Controls.Add(this.TeBo_MotionOutputPath);
            this.GrBo_MotionData.Location = new System.Drawing.Point(2586, 35);
            this.GrBo_MotionData.Margin = new System.Windows.Forms.Padding(6);
            this.GrBo_MotionData.Name = "GrBo_MotionData";
            this.GrBo_MotionData.Padding = new System.Windows.Forms.Padding(6);
            this.GrBo_MotionData.Size = new System.Drawing.Size(852, 933);
            this.GrBo_MotionData.TabIndex = 26;
            this.GrBo_MotionData.TabStop = false;
            this.GrBo_MotionData.Text = "MotionData";
            // 
            // La_MachinesSuportedForProtocol
            // 
            this.La_MachinesSuportedForProtocol.AutoSize = true;
            this.La_MachinesSuportedForProtocol.Location = new System.Drawing.Point(32, 263);
            this.La_MachinesSuportedForProtocol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_MachinesSuportedForProtocol.Name = "La_MachinesSuportedForProtocol";
            this.La_MachinesSuportedForProtocol.Size = new System.Drawing.Size(321, 25);
            this.La_MachinesSuportedForProtocol.TabIndex = 40;
            this.La_MachinesSuportedForProtocol.Text = "Machines Suported For Protocol";
            // 
            // TaCo_MachinesSuportedForProtocol
            // 
            this.TaCo_MachinesSuportedForProtocol.Controls.Add(this.TaPa_XYZ3Cyl);
            this.TaCo_MachinesSuportedForProtocol.Enabled = false;
            this.TaCo_MachinesSuportedForProtocol.Location = new System.Drawing.Point(30, 302);
            this.TaCo_MachinesSuportedForProtocol.Margin = new System.Windows.Forms.Padding(6);
            this.TaCo_MachinesSuportedForProtocol.Name = "TaCo_MachinesSuportedForProtocol";
            this.TaCo_MachinesSuportedForProtocol.SelectedIndex = 0;
            this.TaCo_MachinesSuportedForProtocol.Size = new System.Drawing.Size(784, 604);
            this.TaCo_MachinesSuportedForProtocol.TabIndex = 39;
            // 
            // TaPa_XYZ3Cyl
            // 
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechWaterSprayStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechWaterSprayStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechVibrationStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechVibrationStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechBackStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechBackStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechSweepingLegs1StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechSweepingLegs2StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechSpare1StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechSpare1StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechSpare2StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechSpare2StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechSpare3StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechSpare3StateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechBubblesStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechBubblesStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechLightningStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechLightningStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechFlameStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechFlameStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechJetStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechJetStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechRainStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechRainStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechSmokeStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechSmokeStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechWindStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechWindStateTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForEndTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForEndTrigger);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyAxisForMechSensitivity);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyAxisForMechSensitivity);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyButtonForMechSytheticNoiseEffect);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyButtonForMechSytheticNoiseEffect);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyAxisForMechYAxisTilt);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyAxisForMechYAxisTilt);
            this.TaPa_XYZ3Cyl.Controls.Add(this.La_JoyAxisForMechXAxisTilt);
            this.TaPa_XYZ3Cyl.Controls.Add(this.VScBa_3CylXYZ);
            this.TaPa_XYZ3Cyl.Controls.Add(this.CoBo_JoyAxisForMechXAxisTilt);
            this.TaPa_XYZ3Cyl.Location = new System.Drawing.Point(8, 39);
            this.TaPa_XYZ3Cyl.Margin = new System.Windows.Forms.Padding(6);
            this.TaPa_XYZ3Cyl.Name = "TaPa_XYZ3Cyl";
            this.TaPa_XYZ3Cyl.Padding = new System.Windows.Forms.Padding(6);
            this.TaPa_XYZ3Cyl.Size = new System.Drawing.Size(768, 557);
            this.TaPa_XYZ3Cyl.TabIndex = 0;
            this.TaPa_XYZ3Cyl.Text = "XYZ 3 Cyl ";
            this.TaPa_XYZ3Cyl.UseVisualStyleBackColor = true;
            // 
            // La_JoyButtonForMechWaterSprayStateTrigger
            // 
            this.La_JoyButtonForMechWaterSprayStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechWaterSprayStateTrigger.Location = new System.Drawing.Point(12, 1531);
            this.La_JoyButtonForMechWaterSprayStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechWaterSprayStateTrigger.Name = "La_JoyButtonForMechWaterSprayStateTrigger";
            this.La_JoyButtonForMechWaterSprayStateTrigger.Size = new System.Drawing.Size(466, 25);
            this.La_JoyButtonForMechWaterSprayStateTrigger.TabIndex = 81;
            this.La_JoyButtonForMechWaterSprayStateTrigger.Text = "Joy Button For Mech Water Spray State Trigger";
            // 
            // CoBo_JoyButtonForMechWaterSprayStateTrigger
            // 
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger.Location = new System.Drawing.Point(18, 1575);
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger.Name = "CoBo_JoyButtonForMechWaterSprayStateTrigger";
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger.TabIndex = 80;
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechWaterSprayStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechWaterSprayStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechWaterSprayStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechVibrationStateTrigger
            // 
            this.La_JoyButtonForMechVibrationStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechVibrationStateTrigger.Location = new System.Drawing.Point(12, 1429);
            this.La_JoyButtonForMechVibrationStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechVibrationStateTrigger.Name = "La_JoyButtonForMechVibrationStateTrigger";
            this.La_JoyButtonForMechVibrationStateTrigger.Size = new System.Drawing.Size(432, 25);
            this.La_JoyButtonForMechVibrationStateTrigger.TabIndex = 79;
            this.La_JoyButtonForMechVibrationStateTrigger.Text = "Joy Button For Mech Vibration State Trigger";
            // 
            // CoBo_JoyButtonForMechVibrationStateTrigger
            // 
            this.CoBo_JoyButtonForMechVibrationStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechVibrationStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechVibrationStateTrigger.Location = new System.Drawing.Point(18, 1473);
            this.CoBo_JoyButtonForMechVibrationStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechVibrationStateTrigger.Name = "CoBo_JoyButtonForMechVibrationStateTrigger";
            this.CoBo_JoyButtonForMechVibrationStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechVibrationStateTrigger.TabIndex = 78;
            this.CoBo_JoyButtonForMechVibrationStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechVibrationStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechVibrationStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechVibrationStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechBackStateTrigger
            // 
            this.La_JoyButtonForMechBackStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechBackStateTrigger.Location = new System.Drawing.Point(12, 1323);
            this.La_JoyButtonForMechBackStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechBackStateTrigger.Name = "La_JoyButtonForMechBackStateTrigger";
            this.La_JoyButtonForMechBackStateTrigger.Size = new System.Drawing.Size(395, 25);
            this.La_JoyButtonForMechBackStateTrigger.TabIndex = 77;
            this.La_JoyButtonForMechBackStateTrigger.Text = "Joy Button For Mech Back State Trigger";
            // 
            // CoBo_JoyButtonForMechBackStateTrigger
            // 
            this.CoBo_JoyButtonForMechBackStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechBackStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechBackStateTrigger.Location = new System.Drawing.Point(18, 1367);
            this.CoBo_JoyButtonForMechBackStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechBackStateTrigger.Name = "CoBo_JoyButtonForMechBackStateTrigger";
            this.CoBo_JoyButtonForMechBackStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechBackStateTrigger.TabIndex = 76;
            this.CoBo_JoyButtonForMechBackStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechBackStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechBackStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechBackStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechSweepingLegs1StateTrigger
            // 
            this.La_JoyButtonForMechSweepingLegs1StateTrigger.AutoSize = true;
            this.La_JoyButtonForMechSweepingLegs1StateTrigger.Location = new System.Drawing.Point(12, 1638);
            this.La_JoyButtonForMechSweepingLegs1StateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechSweepingLegs1StateTrigger.Name = "La_JoyButtonForMechSweepingLegs1StateTrigger";
            this.La_JoyButtonForMechSweepingLegs1StateTrigger.Size = new System.Drawing.Size(512, 25);
            this.La_JoyButtonForMechSweepingLegs1StateTrigger.TabIndex = 75;
            this.La_JoyButtonForMechSweepingLegs1StateTrigger.Text = "Joy Button For Mech Sweeping Legs 1 State Trigger";
            // 
            // CoBo_JoyButtonForMechSweepingLegs1StateTrigger
            // 
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger.Location = new System.Drawing.Point(18, 1683);
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger.Name = "CoBo_JoyButtonForMechSweepingLegs1StateTrigger";
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger.TabIndex = 74;
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger_DropDown);
            this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechSweepingLegs1StateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechSweepingLegs2StateTrigger
            // 
            this.La_JoyButtonForMechSweepingLegs2StateTrigger.AutoSize = true;
            this.La_JoyButtonForMechSweepingLegs2StateTrigger.Location = new System.Drawing.Point(12, 1742);
            this.La_JoyButtonForMechSweepingLegs2StateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechSweepingLegs2StateTrigger.Name = "La_JoyButtonForMechSweepingLegs2StateTrigger";
            this.La_JoyButtonForMechSweepingLegs2StateTrigger.Size = new System.Drawing.Size(512, 25);
            this.La_JoyButtonForMechSweepingLegs2StateTrigger.TabIndex = 73;
            this.La_JoyButtonForMechSweepingLegs2StateTrigger.Text = "Joy Button For Mech Sweeping Legs 2 State Trigger";
            // 
            // CoBo_JoyButtonForMechSweepingLegs2StateTrigger
            // 
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger.Location = new System.Drawing.Point(18, 1787);
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger.Name = "CoBo_JoyButtonForMechSweepingLegs2StateTrigger";
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger.TabIndex = 72;
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger_DropDown);
            this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechSweepingLegs2StateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechSpare1StateTrigger
            // 
            this.La_JoyButtonForMechSpare1StateTrigger.AutoSize = true;
            this.La_JoyButtonForMechSpare1StateTrigger.Location = new System.Drawing.Point(12, 1854);
            this.La_JoyButtonForMechSpare1StateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechSpare1StateTrigger.Name = "La_JoyButtonForMechSpare1StateTrigger";
            this.La_JoyButtonForMechSpare1StateTrigger.Size = new System.Drawing.Size(422, 25);
            this.La_JoyButtonForMechSpare1StateTrigger.TabIndex = 71;
            this.La_JoyButtonForMechSpare1StateTrigger.Text = "Joy Button For Mech Spare 1 State Trigger";
            // 
            // CoBo_JoyButtonForMechSpare1StateTrigger
            // 
            this.CoBo_JoyButtonForMechSpare1StateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechSpare1StateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechSpare1StateTrigger.Location = new System.Drawing.Point(18, 1898);
            this.CoBo_JoyButtonForMechSpare1StateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechSpare1StateTrigger.Name = "CoBo_JoyButtonForMechSpare1StateTrigger";
            this.CoBo_JoyButtonForMechSpare1StateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechSpare1StateTrigger.TabIndex = 70;
            this.CoBo_JoyButtonForMechSpare1StateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechSpare1StateTrigger_DropDown);
            this.CoBo_JoyButtonForMechSpare1StateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechSpare1StateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechSpare2StateTrigger
            // 
            this.La_JoyButtonForMechSpare2StateTrigger.AutoSize = true;
            this.La_JoyButtonForMechSpare2StateTrigger.Location = new System.Drawing.Point(12, 1958);
            this.La_JoyButtonForMechSpare2StateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechSpare2StateTrigger.Name = "La_JoyButtonForMechSpare2StateTrigger";
            this.La_JoyButtonForMechSpare2StateTrigger.Size = new System.Drawing.Size(422, 25);
            this.La_JoyButtonForMechSpare2StateTrigger.TabIndex = 69;
            this.La_JoyButtonForMechSpare2StateTrigger.Text = "Joy Button For Mech Spare 2 State Trigger";
            // 
            // CoBo_JoyButtonForMechSpare2StateTrigger
            // 
            this.CoBo_JoyButtonForMechSpare2StateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechSpare2StateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechSpare2StateTrigger.Location = new System.Drawing.Point(18, 2002);
            this.CoBo_JoyButtonForMechSpare2StateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechSpare2StateTrigger.Name = "CoBo_JoyButtonForMechSpare2StateTrigger";
            this.CoBo_JoyButtonForMechSpare2StateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechSpare2StateTrigger.TabIndex = 68;
            this.CoBo_JoyButtonForMechSpare2StateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechSpare2StateTrigger_DropDown);
            this.CoBo_JoyButtonForMechSpare2StateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechSpare2StateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechSpare3StateTrigger
            // 
            this.La_JoyButtonForMechSpare3StateTrigger.AutoSize = true;
            this.La_JoyButtonForMechSpare3StateTrigger.Location = new System.Drawing.Point(12, 2062);
            this.La_JoyButtonForMechSpare3StateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechSpare3StateTrigger.Name = "La_JoyButtonForMechSpare3StateTrigger";
            this.La_JoyButtonForMechSpare3StateTrigger.Size = new System.Drawing.Size(422, 25);
            this.La_JoyButtonForMechSpare3StateTrigger.TabIndex = 67;
            this.La_JoyButtonForMechSpare3StateTrigger.Text = "Joy Button For Mech Spare 3 State Trigger";
            // 
            // CoBo_JoyButtonForMechSpare3StateTrigger
            // 
            this.CoBo_JoyButtonForMechSpare3StateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechSpare3StateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechSpare3StateTrigger.Location = new System.Drawing.Point(18, 2106);
            this.CoBo_JoyButtonForMechSpare3StateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechSpare3StateTrigger.Name = "CoBo_JoyButtonForMechSpare3StateTrigger";
            this.CoBo_JoyButtonForMechSpare3StateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechSpare3StateTrigger.TabIndex = 66;
            this.CoBo_JoyButtonForMechSpare3StateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechSpare3StateTrigger_DropDown);
            this.CoBo_JoyButtonForMechSpare3StateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechSpare3StateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechBubblesStateTrigger
            // 
            this.La_JoyButtonForMechBubblesStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechBubblesStateTrigger.Location = new System.Drawing.Point(12, 1217);
            this.La_JoyButtonForMechBubblesStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechBubblesStateTrigger.Name = "La_JoyButtonForMechBubblesStateTrigger";
            this.La_JoyButtonForMechBubblesStateTrigger.Size = new System.Drawing.Size(425, 25);
            this.La_JoyButtonForMechBubblesStateTrigger.TabIndex = 65;
            this.La_JoyButtonForMechBubblesStateTrigger.Text = "Joy Button For Mech Bubbles State Trigger";
            // 
            // CoBo_JoyButtonForMechBubblesStateTrigger
            // 
            this.CoBo_JoyButtonForMechBubblesStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechBubblesStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechBubblesStateTrigger.Location = new System.Drawing.Point(18, 1262);
            this.CoBo_JoyButtonForMechBubblesStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechBubblesStateTrigger.Name = "CoBo_JoyButtonForMechBubblesStateTrigger";
            this.CoBo_JoyButtonForMechBubblesStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechBubblesStateTrigger.TabIndex = 64;
            this.CoBo_JoyButtonForMechBubblesStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechBubblesStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechBubblesStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechBubblesStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechLightningStateTrigger
            // 
            this.La_JoyButtonForMechLightningStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechLightningStateTrigger.Location = new System.Drawing.Point(12, 1115);
            this.La_JoyButtonForMechLightningStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechLightningStateTrigger.Name = "La_JoyButtonForMechLightningStateTrigger";
            this.La_JoyButtonForMechLightningStateTrigger.Size = new System.Drawing.Size(435, 25);
            this.La_JoyButtonForMechLightningStateTrigger.TabIndex = 63;
            this.La_JoyButtonForMechLightningStateTrigger.Text = "Joy Button For Mech Lightning State Trigger";
            // 
            // CoBo_JoyButtonForMechLightningStateTrigger
            // 
            this.CoBo_JoyButtonForMechLightningStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechLightningStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechLightningStateTrigger.Location = new System.Drawing.Point(18, 1160);
            this.CoBo_JoyButtonForMechLightningStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechLightningStateTrigger.Name = "CoBo_JoyButtonForMechLightningStateTrigger";
            this.CoBo_JoyButtonForMechLightningStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechLightningStateTrigger.TabIndex = 62;
            this.CoBo_JoyButtonForMechLightningStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechLightningStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechLightningStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechLightningStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechFlameStateTrigger
            // 
            this.La_JoyButtonForMechFlameStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechFlameStateTrigger.Location = new System.Drawing.Point(12, 998);
            this.La_JoyButtonForMechFlameStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechFlameStateTrigger.Name = "La_JoyButtonForMechFlameStateTrigger";
            this.La_JoyButtonForMechFlameStateTrigger.Size = new System.Drawing.Size(406, 25);
            this.La_JoyButtonForMechFlameStateTrigger.TabIndex = 61;
            this.La_JoyButtonForMechFlameStateTrigger.Text = "Joy Button For Mech Flame State Trigger";
            // 
            // CoBo_JoyButtonForMechFlameStateTrigger
            // 
            this.CoBo_JoyButtonForMechFlameStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechFlameStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechFlameStateTrigger.Location = new System.Drawing.Point(18, 1042);
            this.CoBo_JoyButtonForMechFlameStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechFlameStateTrigger.Name = "CoBo_JoyButtonForMechFlameStateTrigger";
            this.CoBo_JoyButtonForMechFlameStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechFlameStateTrigger.TabIndex = 60;
            this.CoBo_JoyButtonForMechFlameStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechFlameStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechFlameStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechFlameStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechJetStateTrigger
            // 
            this.La_JoyButtonForMechJetStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechJetStateTrigger.Location = new System.Drawing.Point(12, 896);
            this.La_JoyButtonForMechJetStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechJetStateTrigger.Name = "La_JoyButtonForMechJetStateTrigger";
            this.La_JoyButtonForMechJetStateTrigger.Size = new System.Drawing.Size(376, 25);
            this.La_JoyButtonForMechJetStateTrigger.TabIndex = 59;
            this.La_JoyButtonForMechJetStateTrigger.Text = "Joy Button For Mech Jet State Trigger";
            // 
            // CoBo_JoyButtonForMechJetStateTrigger
            // 
            this.CoBo_JoyButtonForMechJetStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechJetStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechJetStateTrigger.Location = new System.Drawing.Point(18, 940);
            this.CoBo_JoyButtonForMechJetStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechJetStateTrigger.Name = "CoBo_JoyButtonForMechJetStateTrigger";
            this.CoBo_JoyButtonForMechJetStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechJetStateTrigger.TabIndex = 58;
            this.CoBo_JoyButtonForMechJetStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechJetStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechJetStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechJetStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechRainStateTrigger
            // 
            this.La_JoyButtonForMechRainStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechRainStateTrigger.Location = new System.Drawing.Point(12, 788);
            this.La_JoyButtonForMechRainStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechRainStateTrigger.Name = "La_JoyButtonForMechRainStateTrigger";
            this.La_JoyButtonForMechRainStateTrigger.Size = new System.Drawing.Size(391, 25);
            this.La_JoyButtonForMechRainStateTrigger.TabIndex = 57;
            this.La_JoyButtonForMechRainStateTrigger.Text = "Joy Button For Mech Rain State Trigger";
            // 
            // CoBo_JoyButtonForMechRainStateTrigger
            // 
            this.CoBo_JoyButtonForMechRainStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechRainStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechRainStateTrigger.Location = new System.Drawing.Point(18, 833);
            this.CoBo_JoyButtonForMechRainStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechRainStateTrigger.Name = "CoBo_JoyButtonForMechRainStateTrigger";
            this.CoBo_JoyButtonForMechRainStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechRainStateTrigger.TabIndex = 56;
            this.CoBo_JoyButtonForMechRainStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechRainStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechRainStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechRainStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechSmokeStateTrigger
            // 
            this.La_JoyButtonForMechSmokeStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechSmokeStateTrigger.Location = new System.Drawing.Point(12, 687);
            this.La_JoyButtonForMechSmokeStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechSmokeStateTrigger.Name = "La_JoyButtonForMechSmokeStateTrigger";
            this.La_JoyButtonForMechSmokeStateTrigger.Size = new System.Drawing.Size(413, 25);
            this.La_JoyButtonForMechSmokeStateTrigger.TabIndex = 55;
            this.La_JoyButtonForMechSmokeStateTrigger.Text = "Joy Button For Mech Smoke State Trigger";
            // 
            // CoBo_JoyButtonForMechSmokeStateTrigger
            // 
            this.CoBo_JoyButtonForMechSmokeStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechSmokeStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechSmokeStateTrigger.Location = new System.Drawing.Point(18, 731);
            this.CoBo_JoyButtonForMechSmokeStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechSmokeStateTrigger.Name = "CoBo_JoyButtonForMechSmokeStateTrigger";
            this.CoBo_JoyButtonForMechSmokeStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechSmokeStateTrigger.TabIndex = 54;
            this.CoBo_JoyButtonForMechSmokeStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechSmokeStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechSmokeStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechSmokeStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForMechWindStateTrigger
            // 
            this.La_JoyButtonForMechWindStateTrigger.AutoSize = true;
            this.La_JoyButtonForMechWindStateTrigger.Location = new System.Drawing.Point(12, 569);
            this.La_JoyButtonForMechWindStateTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechWindStateTrigger.Name = "La_JoyButtonForMechWindStateTrigger";
            this.La_JoyButtonForMechWindStateTrigger.Size = new System.Drawing.Size(396, 25);
            this.La_JoyButtonForMechWindStateTrigger.TabIndex = 53;
            this.La_JoyButtonForMechWindStateTrigger.Text = "Joy Button For Mech Wind State Trigger";
            // 
            // CoBo_JoyButtonForMechWindStateTrigger
            // 
            this.CoBo_JoyButtonForMechWindStateTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechWindStateTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechWindStateTrigger.Location = new System.Drawing.Point(18, 613);
            this.CoBo_JoyButtonForMechWindStateTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechWindStateTrigger.Name = "CoBo_JoyButtonForMechWindStateTrigger";
            this.CoBo_JoyButtonForMechWindStateTrigger.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechWindStateTrigger.TabIndex = 52;
            this.CoBo_JoyButtonForMechWindStateTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechWindStateTrigger_DropDown);
            this.CoBo_JoyButtonForMechWindStateTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechWindStateTrigger_DropDownClosed);
            // 
            // La_JoyButtonForEndTrigger
            // 
            this.La_JoyButtonForEndTrigger.AutoSize = true;
            this.La_JoyButtonForEndTrigger.Location = new System.Drawing.Point(12, 467);
            this.La_JoyButtonForEndTrigger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForEndTrigger.Name = "La_JoyButtonForEndTrigger";
            this.La_JoyButtonForEndTrigger.Size = new System.Drawing.Size(270, 25);
            this.La_JoyButtonForEndTrigger.TabIndex = 51;
            this.La_JoyButtonForEndTrigger.Text = "Joy Button For End Trigger";
            // 
            // CoBo_JoyButtonForEndTrigger
            // 
            this.CoBo_JoyButtonForEndTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForEndTrigger.FormattingEnabled = true;
            this.CoBo_JoyButtonForEndTrigger.Location = new System.Drawing.Point(18, 512);
            this.CoBo_JoyButtonForEndTrigger.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForEndTrigger.Name = "CoBo_JoyButtonForEndTrigger";
            this.CoBo_JoyButtonForEndTrigger.Size = new System.Drawing.Size(700, 33);
            this.CoBo_JoyButtonForEndTrigger.TabIndex = 50;
            this.CoBo_JoyButtonForEndTrigger.DropDown += new System.EventHandler(this.CoBo_JoyButtonForEndTrigger_DropDown);
            this.CoBo_JoyButtonForEndTrigger.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForEndTrigger_DropDownClosed);
            // 
            // La_JoyAxisForMechSensitivity
            // 
            this.La_JoyAxisForMechSensitivity.AutoSize = true;
            this.La_JoyAxisForMechSensitivity.Location = new System.Drawing.Point(6, 360);
            this.La_JoyAxisForMechSensitivity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyAxisForMechSensitivity.Name = "La_JoyAxisForMechSensitivity";
            this.La_JoyAxisForMechSensitivity.Size = new System.Drawing.Size(294, 25);
            this.La_JoyAxisForMechSensitivity.TabIndex = 48;
            this.La_JoyAxisForMechSensitivity.Text = "Joy Axis For Mech Sensitivity";
            // 
            // CoBo_JoyAxisForMechSensitivity
            // 
            this.CoBo_JoyAxisForMechSensitivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyAxisForMechSensitivity.FormattingEnabled = true;
            this.CoBo_JoyAxisForMechSensitivity.Location = new System.Drawing.Point(12, 404);
            this.CoBo_JoyAxisForMechSensitivity.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyAxisForMechSensitivity.Name = "CoBo_JoyAxisForMechSensitivity";
            this.CoBo_JoyAxisForMechSensitivity.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyAxisForMechSensitivity.TabIndex = 47;
            this.CoBo_JoyAxisForMechSensitivity.DropDown += new System.EventHandler(this.CoBo_JoyAxisForMechSensitivity_DropDown);
            this.CoBo_JoyAxisForMechSensitivity.DropDownClosed += new System.EventHandler(this.CoBo_JoyAxisForMechSensitivity_DropDownClosed);
            // 
            // La_JoyButtonForMechSytheticNoiseEffect
            // 
            this.La_JoyButtonForMechSytheticNoiseEffect.AutoSize = true;
            this.La_JoyButtonForMechSytheticNoiseEffect.Location = new System.Drawing.Point(6, 250);
            this.La_JoyButtonForMechSytheticNoiseEffect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyButtonForMechSytheticNoiseEffect.Name = "La_JoyButtonForMechSytheticNoiseEffect";
            this.La_JoyButtonForMechSytheticNoiseEffect.Size = new System.Drawing.Size(416, 25);
            this.La_JoyButtonForMechSytheticNoiseEffect.TabIndex = 46;
            this.La_JoyButtonForMechSytheticNoiseEffect.Text = "Joy Button For Mech Sythetic Noise Effect";
            // 
            // CoBo_JoyButtonForMechSytheticNoiseEffect
            // 
            this.CoBo_JoyButtonForMechSytheticNoiseEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyButtonForMechSytheticNoiseEffect.FormattingEnabled = true;
            this.CoBo_JoyButtonForMechSytheticNoiseEffect.Location = new System.Drawing.Point(12, 294);
            this.CoBo_JoyButtonForMechSytheticNoiseEffect.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyButtonForMechSytheticNoiseEffect.Name = "CoBo_JoyButtonForMechSytheticNoiseEffect";
            this.CoBo_JoyButtonForMechSytheticNoiseEffect.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyButtonForMechSytheticNoiseEffect.TabIndex = 45;
            this.CoBo_JoyButtonForMechSytheticNoiseEffect.DropDown += new System.EventHandler(this.CoBo_JoyButtonForMechSytheticNoiseEffect_DropDown);
            this.CoBo_JoyButtonForMechSytheticNoiseEffect.DropDownClosed += new System.EventHandler(this.CoBo_JoyButtonForMechSytheticNoiseEffect_DropDownClosed);
            // 
            // La_JoyAxisForMechYAxisTilt
            // 
            this.La_JoyAxisForMechYAxisTilt.AutoSize = true;
            this.La_JoyAxisForMechYAxisTilt.Location = new System.Drawing.Point(6, 137);
            this.La_JoyAxisForMechYAxisTilt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyAxisForMechYAxisTilt.Name = "La_JoyAxisForMechYAxisTilt";
            this.La_JoyAxisForMechYAxisTilt.Size = new System.Drawing.Size(293, 25);
            this.La_JoyAxisForMechYAxisTilt.TabIndex = 44;
            this.La_JoyAxisForMechYAxisTilt.Text = "Joy Axis For Mech Y Axis Tilt";
            // 
            // CoBo_JoyAxisForMechYAxisTilt
            // 
            this.CoBo_JoyAxisForMechYAxisTilt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyAxisForMechYAxisTilt.FormattingEnabled = true;
            this.CoBo_JoyAxisForMechYAxisTilt.Location = new System.Drawing.Point(12, 181);
            this.CoBo_JoyAxisForMechYAxisTilt.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyAxisForMechYAxisTilt.Name = "CoBo_JoyAxisForMechYAxisTilt";
            this.CoBo_JoyAxisForMechYAxisTilt.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyAxisForMechYAxisTilt.TabIndex = 43;
            this.CoBo_JoyAxisForMechYAxisTilt.DropDown += new System.EventHandler(this.CoBo_JoyAxisForMechYAxisTilt_DropDown);
            this.CoBo_JoyAxisForMechYAxisTilt.DropDownClosed += new System.EventHandler(this.CoBo_JoyAxisForMechYAxisTilt_DropDownClosed);
            // 
            // La_JoyAxisForMechXAxisTilt
            // 
            this.La_JoyAxisForMechXAxisTilt.AutoSize = true;
            this.La_JoyAxisForMechXAxisTilt.Location = new System.Drawing.Point(6, 21);
            this.La_JoyAxisForMechXAxisTilt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_JoyAxisForMechXAxisTilt.Name = "La_JoyAxisForMechXAxisTilt";
            this.La_JoyAxisForMechXAxisTilt.Size = new System.Drawing.Size(292, 25);
            this.La_JoyAxisForMechXAxisTilt.TabIndex = 42;
            this.La_JoyAxisForMechXAxisTilt.Text = "Joy Axis For Mech X Axis Tilt";
            // 
            // VScBa_3CylXYZ
            // 
            this.VScBa_3CylXYZ.Location = new System.Drawing.Point(728, 12);
            this.VScBa_3CylXYZ.Maximum = 860;
            this.VScBa_3CylXYZ.Name = "VScBa_3CylXYZ";
            this.VScBa_3CylXYZ.Size = new System.Drawing.Size(17, 537);
            this.VScBa_3CylXYZ.TabIndex = 0;
            this.VScBa_3CylXYZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScBa_3CylXYZ_Scroll);
            // 
            // CoBo_JoyAxisForMechXAxisTilt
            // 
            this.CoBo_JoyAxisForMechXAxisTilt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_JoyAxisForMechXAxisTilt.FormattingEnabled = true;
            this.CoBo_JoyAxisForMechXAxisTilt.Location = new System.Drawing.Point(12, 65);
            this.CoBo_JoyAxisForMechXAxisTilt.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_JoyAxisForMechXAxisTilt.Name = "CoBo_JoyAxisForMechXAxisTilt";
            this.CoBo_JoyAxisForMechXAxisTilt.Size = new System.Drawing.Size(706, 33);
            this.CoBo_JoyAxisForMechXAxisTilt.TabIndex = 41;
            this.CoBo_JoyAxisForMechXAxisTilt.DropDown += new System.EventHandler(this.CoBo_JoyAxisForMechXAxisTilt_DropDown);
            this.CoBo_JoyAxisForMechXAxisTilt.DropDownClosed += new System.EventHandler(this.CoBo_JoyAxisForMechXAxisTilt_DropDownClosed);
            // 
            // But_ProtocolConnectionStringHelp
            // 
            this.But_ProtocolConnectionStringHelp.Location = new System.Drawing.Point(476, 150);
            this.But_ProtocolConnectionStringHelp.Margin = new System.Windows.Forms.Padding(6);
            this.But_ProtocolConnectionStringHelp.Name = "But_ProtocolConnectionStringHelp";
            this.But_ProtocolConnectionStringHelp.Size = new System.Drawing.Size(150, 44);
            this.But_ProtocolConnectionStringHelp.TabIndex = 36;
            this.But_ProtocolConnectionStringHelp.Text = "Help";
            this.But_ProtocolConnectionStringHelp.UseVisualStyleBackColor = true;
            this.But_ProtocolConnectionStringHelp.Click += new System.EventHandler(this.But_ProtocolConnectionStringHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Protocol Connection String";
            // 
            // TeBo_ProtocolConnectionString
            // 
            this.TeBo_ProtocolConnectionString.Location = new System.Drawing.Point(204, 206);
            this.TeBo_ProtocolConnectionString.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_ProtocolConnectionString.Name = "TeBo_ProtocolConnectionString";
            this.TeBo_ProtocolConnectionString.Size = new System.Drawing.Size(560, 31);
            this.TeBo_ProtocolConnectionString.TabIndex = 37;
            this.TeBo_ProtocolConnectionString.TextChanged += new System.EventHandler(this.TeBo_ProtocolConnectionString_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Protocol";
            // 
            // CoBo_Protocol
            // 
            this.CoBo_Protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBo_Protocol.FormattingEnabled = true;
            this.CoBo_Protocol.Location = new System.Drawing.Point(30, 204);
            this.CoBo_Protocol.Margin = new System.Windows.Forms.Padding(6);
            this.CoBo_Protocol.Name = "CoBo_Protocol";
            this.CoBo_Protocol.Size = new System.Drawing.Size(150, 33);
            this.CoBo_Protocol.TabIndex = 24;
            this.CoBo_Protocol.SelectedIndexChanged += new System.EventHandler(this.CoBo_Protocol_SelectedIndexChanged);
            // 
            // La_MotionOutputPathEnding
            // 
            this.La_MotionOutputPathEnding.AutoSize = true;
            this.La_MotionOutputPathEnding.Location = new System.Drawing.Point(678, 113);
            this.La_MotionOutputPathEnding.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_MotionOutputPathEnding.Name = "La_MotionOutputPathEnding";
            this.La_MotionOutputPathEnding.Size = new System.Drawing.Size(88, 25);
            this.La_MotionOutputPathEnding.TabIndex = 35;
            this.La_MotionOutputPathEnding.Text = ".JMMov";
            // 
            // La_MotionOutputPath
            // 
            this.La_MotionOutputPath.AutoSize = true;
            this.La_MotionOutputPath.Location = new System.Drawing.Point(24, 54);
            this.La_MotionOutputPath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_MotionOutputPath.Name = "La_MotionOutputPath";
            this.La_MotionOutputPath.Size = new System.Drawing.Size(197, 25);
            this.La_MotionOutputPath.TabIndex = 34;
            this.La_MotionOutputPath.Text = "Motion Output Path";
            // 
            // TeBo_MotionOutputPath
            // 
            this.TeBo_MotionOutputPath.Location = new System.Drawing.Point(30, 100);
            this.TeBo_MotionOutputPath.Margin = new System.Windows.Forms.Padding(6);
            this.TeBo_MotionOutputPath.Name = "TeBo_MotionOutputPath";
            this.TeBo_MotionOutputPath.Size = new System.Drawing.Size(632, 31);
            this.TeBo_MotionOutputPath.TabIndex = 33;
            this.TeBo_MotionOutputPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TeBo_MotionOutputPath_MouseClick);
            this.TeBo_MotionOutputPath.TextChanged += new System.EventHandler(this.TeBo_MotionOutputPath_TextChanged);
            // 
            // GrBo_RunTime
            // 
            this.GrBo_RunTime.Controls.Add(this.Bu_Run);
            this.GrBo_RunTime.Location = new System.Drawing.Point(1618, 775);
            this.GrBo_RunTime.Margin = new System.Windows.Forms.Padding(6);
            this.GrBo_RunTime.Name = "GrBo_RunTime";
            this.GrBo_RunTime.Padding = new System.Windows.Forms.Padding(6);
            this.GrBo_RunTime.Size = new System.Drawing.Size(956, 192);
            this.GrBo_RunTime.TabIndex = 27;
            this.GrBo_RunTime.TabStop = false;
            this.GrBo_RunTime.Text = "Run Time";
            // 
            // Bu_Run
            // 
            this.Bu_Run.Location = new System.Drawing.Point(30, 37);
            this.Bu_Run.Margin = new System.Windows.Forms.Padding(6);
            this.Bu_Run.Name = "Bu_Run";
            this.Bu_Run.Size = new System.Drawing.Size(888, 129);
            this.Bu_Run.TabIndex = 35;
            this.Bu_Run.Text = "Run";
            this.Bu_Run.UseVisualStyleBackColor = true;
            this.Bu_Run.Click += new System.EventHandler(this.Bu_Run_Click);
            this.Bu_Run.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Bu_Run_MouseClick);
            // 
            // DaGrVi_DataOutput
            // 
            this.DaGrVi_DataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaGrVi_DataOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Time,
            this.Col_DeltaTime,
            this.Col_C1,
            this.Col_C2,
            this.Col_C3,
            this.Col_C4,
            this.Col_C5,
            this.Col_C6,
            this.Col_Snowflakes,
            this.Col_Wind,
            this.Col_Rain,
            this.Col_Smoke,
            this.Col_Bubbles,
            this.Col_Lightning,
            this.Col_Flame,
            this.Col_Jet,
            this.Col_WaterSpray,
            this.Col_Vibration,
            this.Col_Back,
            this.Col_SweepingLegs1,
            this.Col_SweepingLegs2,
            this.Col_Spare1,
            this.Col_Spare2,
            this.Col_Spare3});
            this.DaGrVi_DataOutput.Location = new System.Drawing.Point(40, 183);
            this.DaGrVi_DataOutput.Margin = new System.Windows.Forms.Padding(6);
            this.DaGrVi_DataOutput.Name = "DaGrVi_DataOutput";
            this.DaGrVi_DataOutput.ReadOnly = true;
            this.DaGrVi_DataOutput.RowHeadersWidth = 82;
            this.DaGrVi_DataOutput.Size = new System.Drawing.Size(3336, 562);
            this.DaGrVi_DataOutput.TabIndex = 24;
            // 
            // Col_Time
            // 
            this.Col_Time.HeaderText = "Time";
            this.Col_Time.MinimumWidth = 10;
            this.Col_Time.Name = "Col_Time";
            this.Col_Time.ReadOnly = true;
            this.Col_Time.Width = 200;
            // 
            // Col_DeltaTime
            // 
            this.Col_DeltaTime.HeaderText = "Delta Time";
            this.Col_DeltaTime.MinimumWidth = 10;
            this.Col_DeltaTime.Name = "Col_DeltaTime";
            this.Col_DeltaTime.ReadOnly = true;
            this.Col_DeltaTime.Width = 200;
            // 
            // Col_C1
            // 
            this.Col_C1.HeaderText = "C1";
            this.Col_C1.MinimumWidth = 10;
            this.Col_C1.Name = "Col_C1";
            this.Col_C1.ReadOnly = true;
            this.Col_C1.Width = 200;
            // 
            // Col_C2
            // 
            this.Col_C2.HeaderText = "C2";
            this.Col_C2.MinimumWidth = 10;
            this.Col_C2.Name = "Col_C2";
            this.Col_C2.ReadOnly = true;
            this.Col_C2.Width = 200;
            // 
            // Col_C3
            // 
            this.Col_C3.HeaderText = "C3";
            this.Col_C3.MinimumWidth = 10;
            this.Col_C3.Name = "Col_C3";
            this.Col_C3.ReadOnly = true;
            this.Col_C3.Width = 200;
            // 
            // Col_C4
            // 
            this.Col_C4.HeaderText = "C4";
            this.Col_C4.MinimumWidth = 10;
            this.Col_C4.Name = "Col_C4";
            this.Col_C4.ReadOnly = true;
            this.Col_C4.Width = 200;
            // 
            // Col_C5
            // 
            this.Col_C5.HeaderText = "C5";
            this.Col_C5.MinimumWidth = 10;
            this.Col_C5.Name = "Col_C5";
            this.Col_C5.ReadOnly = true;
            this.Col_C5.Width = 200;
            // 
            // Col_C6
            // 
            this.Col_C6.HeaderText = "C6";
            this.Col_C6.MinimumWidth = 10;
            this.Col_C6.Name = "Col_C6";
            this.Col_C6.ReadOnly = true;
            this.Col_C6.Width = 200;
            // 
            // Col_Snowflakes
            // 
            this.Col_Snowflakes.HeaderText = "Snowflakes";
            this.Col_Snowflakes.MinimumWidth = 10;
            this.Col_Snowflakes.Name = "Col_Snowflakes";
            this.Col_Snowflakes.ReadOnly = true;
            this.Col_Snowflakes.Width = 200;
            // 
            // Col_Wind
            // 
            this.Col_Wind.HeaderText = "Wind";
            this.Col_Wind.MinimumWidth = 10;
            this.Col_Wind.Name = "Col_Wind";
            this.Col_Wind.ReadOnly = true;
            this.Col_Wind.Width = 200;
            // 
            // Col_Rain
            // 
            this.Col_Rain.HeaderText = "Rain";
            this.Col_Rain.MinimumWidth = 10;
            this.Col_Rain.Name = "Col_Rain";
            this.Col_Rain.ReadOnly = true;
            this.Col_Rain.Width = 200;
            // 
            // Col_Smoke
            // 
            this.Col_Smoke.HeaderText = "Smoke";
            this.Col_Smoke.MinimumWidth = 10;
            this.Col_Smoke.Name = "Col_Smoke";
            this.Col_Smoke.ReadOnly = true;
            this.Col_Smoke.Width = 200;
            // 
            // Col_Bubbles
            // 
            this.Col_Bubbles.HeaderText = "Bubbles";
            this.Col_Bubbles.MinimumWidth = 10;
            this.Col_Bubbles.Name = "Col_Bubbles";
            this.Col_Bubbles.ReadOnly = true;
            this.Col_Bubbles.Width = 200;
            // 
            // Col_Lightning
            // 
            this.Col_Lightning.HeaderText = "Lightning";
            this.Col_Lightning.MinimumWidth = 10;
            this.Col_Lightning.Name = "Col_Lightning";
            this.Col_Lightning.ReadOnly = true;
            this.Col_Lightning.Width = 200;
            // 
            // Col_Flame
            // 
            this.Col_Flame.HeaderText = "Flame";
            this.Col_Flame.MinimumWidth = 10;
            this.Col_Flame.Name = "Col_Flame";
            this.Col_Flame.ReadOnly = true;
            this.Col_Flame.Width = 200;
            // 
            // Col_Jet
            // 
            this.Col_Jet.HeaderText = "Jet";
            this.Col_Jet.MinimumWidth = 10;
            this.Col_Jet.Name = "Col_Jet";
            this.Col_Jet.ReadOnly = true;
            this.Col_Jet.Width = 200;
            // 
            // Col_WaterSpray
            // 
            this.Col_WaterSpray.HeaderText = "Water Spray";
            this.Col_WaterSpray.MinimumWidth = 10;
            this.Col_WaterSpray.Name = "Col_WaterSpray";
            this.Col_WaterSpray.ReadOnly = true;
            this.Col_WaterSpray.Width = 200;
            // 
            // Col_Vibration
            // 
            this.Col_Vibration.HeaderText = "Vibration";
            this.Col_Vibration.MinimumWidth = 10;
            this.Col_Vibration.Name = "Col_Vibration";
            this.Col_Vibration.ReadOnly = true;
            this.Col_Vibration.Width = 200;
            // 
            // Col_Back
            // 
            this.Col_Back.HeaderText = "Back";
            this.Col_Back.MinimumWidth = 10;
            this.Col_Back.Name = "Col_Back";
            this.Col_Back.ReadOnly = true;
            this.Col_Back.Width = 200;
            // 
            // Col_SweepingLegs1
            // 
            this.Col_SweepingLegs1.HeaderText = "Sweeping Legs 1";
            this.Col_SweepingLegs1.MinimumWidth = 10;
            this.Col_SweepingLegs1.Name = "Col_SweepingLegs1";
            this.Col_SweepingLegs1.ReadOnly = true;
            this.Col_SweepingLegs1.Width = 200;
            // 
            // Col_SweepingLegs2
            // 
            this.Col_SweepingLegs2.HeaderText = "Sweeping Legs 2";
            this.Col_SweepingLegs2.MinimumWidth = 10;
            this.Col_SweepingLegs2.Name = "Col_SweepingLegs2";
            this.Col_SweepingLegs2.ReadOnly = true;
            this.Col_SweepingLegs2.Width = 200;
            // 
            // Col_Spare1
            // 
            this.Col_Spare1.HeaderText = "Spare 1";
            this.Col_Spare1.MinimumWidth = 10;
            this.Col_Spare1.Name = "Col_Spare1";
            this.Col_Spare1.ReadOnly = true;
            this.Col_Spare1.Width = 200;
            // 
            // Col_Spare2
            // 
            this.Col_Spare2.HeaderText = "Spare 2";
            this.Col_Spare2.MinimumWidth = 10;
            this.Col_Spare2.Name = "Col_Spare2";
            this.Col_Spare2.ReadOnly = true;
            this.Col_Spare2.Width = 200;
            // 
            // Col_Spare3
            // 
            this.Col_Spare3.HeaderText = "Spare 3";
            this.Col_Spare3.MinimumWidth = 10;
            this.Col_Spare3.Name = "Col_Spare3";
            this.Col_Spare3.ReadOnly = true;
            this.Col_Spare3.Width = 200;
            // 
            // La_FrameOutput
            // 
            this.La_FrameOutput.AutoSize = true;
            this.La_FrameOutput.Location = new System.Drawing.Point(34, 146);
            this.La_FrameOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_FrameOutput.Name = "La_FrameOutput";
            this.La_FrameOutput.Size = new System.Drawing.Size(185, 25);
            this.La_FrameOutput.TabIndex = 36;
            this.La_FrameOutput.Text = "Frame Output Log";
            // 
            // GrBo_FrameData
            // 
            this.GrBo_FrameData.Controls.Add(this.Bu_PlayBackSavedData);
            this.GrBo_FrameData.Controls.Add(this.La_TimeBetweenTicksValue);
            this.GrBo_FrameData.Controls.Add(this.La_TimeBetweenTicks);
            this.GrBo_FrameData.Controls.Add(this.label3);
            this.GrBo_FrameData.Controls.Add(this.TrBa_TimeBetweenTicks);
            this.GrBo_FrameData.Controls.Add(this.Bu_ViewSavedData);
            this.GrBo_FrameData.Controls.Add(this.La_FrameOutput);
            this.GrBo_FrameData.Controls.Add(this.DaGrVi_DataOutput);
            this.GrBo_FrameData.Location = new System.Drawing.Point(24, 979);
            this.GrBo_FrameData.Margin = new System.Windows.Forms.Padding(6);
            this.GrBo_FrameData.Name = "GrBo_FrameData";
            this.GrBo_FrameData.Padding = new System.Windows.Forms.Padding(6);
            this.GrBo_FrameData.Size = new System.Drawing.Size(3414, 777);
            this.GrBo_FrameData.TabIndex = 0;
            this.GrBo_FrameData.TabStop = false;
            this.GrBo_FrameData.Text = "Fame Data";
            // 
            // Bu_PlayBackSavedData
            // 
            this.Bu_PlayBackSavedData.Location = new System.Drawing.Point(48, 92);
            this.Bu_PlayBackSavedData.Margin = new System.Windows.Forms.Padding(6);
            this.Bu_PlayBackSavedData.Name = "Bu_PlayBackSavedData";
            this.Bu_PlayBackSavedData.Size = new System.Drawing.Size(254, 44);
            this.Bu_PlayBackSavedData.TabIndex = 41;
            this.Bu_PlayBackSavedData.Text = "Play Back Saved Data";
            this.Bu_PlayBackSavedData.UseVisualStyleBackColor = true;
            this.Bu_PlayBackSavedData.Click += new System.EventHandler(this.Bu_PlayBackSavedData_Click);
            // 
            // La_TimeBetweenTicksValue
            // 
            this.La_TimeBetweenTicksValue.AutoSize = true;
            this.La_TimeBetweenTicksValue.Location = new System.Drawing.Point(606, 37);
            this.La_TimeBetweenTicksValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_TimeBetweenTicksValue.Name = "La_TimeBetweenTicksValue";
            this.La_TimeBetweenTicksValue.Size = new System.Drawing.Size(127, 25);
            this.La_TimeBetweenTicksValue.TabIndex = 40;
            this.La_TimeBetweenTicksValue.Text = "Value = 250";
            // 
            // La_TimeBetweenTicks
            // 
            this.La_TimeBetweenTicks.AutoSize = true;
            this.La_TimeBetweenTicks.Location = new System.Drawing.Point(336, 37);
            this.La_TimeBetweenTicks.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.La_TimeBetweenTicks.Name = "La_TimeBetweenTicks";
            this.La_TimeBetweenTicks.Size = new System.Drawing.Size(257, 25);
            this.La_TimeBetweenTicks.TabIndex = 39;
            this.La_TimeBetweenTicks.Text = "Time Between Ticks (MS)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 38;
            // 
            // TrBa_TimeBetweenTicks
            // 
            this.TrBa_TimeBetweenTicks.Location = new System.Drawing.Point(330, 85);
            this.TrBa_TimeBetweenTicks.Margin = new System.Windows.Forms.Padding(6);
            this.TrBa_TimeBetweenTicks.Maximum = 10000;
            this.TrBa_TimeBetweenTicks.Name = "TrBa_TimeBetweenTicks";
            this.TrBa_TimeBetweenTicks.Size = new System.Drawing.Size(3046, 90);
            this.TrBa_TimeBetweenTicks.TabIndex = 37;
            this.TrBa_TimeBetweenTicks.Value = 250;
            this.TrBa_TimeBetweenTicks.Scroll += new System.EventHandler(this.TrBa_TimeBetweenTicks_Scroll);
            // 
            // Bu_ViewSavedData
            // 
            this.Bu_ViewSavedData.Location = new System.Drawing.Point(48, 37);
            this.Bu_ViewSavedData.Margin = new System.Windows.Forms.Padding(6);
            this.Bu_ViewSavedData.Name = "Bu_ViewSavedData";
            this.Bu_ViewSavedData.Size = new System.Drawing.Size(254, 44);
            this.Bu_ViewSavedData.TabIndex = 36;
            this.Bu_ViewSavedData.Text = "View Saved Data";
            this.Bu_ViewSavedData.UseVisualStyleBackColor = true;
            this.Bu_ViewSavedData.Click += new System.EventHandler(this.Bu_ViewSavedData_Click);
            // 
            // GrBo_ConfigLoadAndSave
            // 
            this.GrBo_ConfigLoadAndSave.Controls.Add(this.Bu_SaveConfigFile);
            this.GrBo_ConfigLoadAndSave.Controls.Add(this.Bu_LoadConfigFile);
            this.GrBo_ConfigLoadAndSave.Location = new System.Drawing.Point(1618, 596);
            this.GrBo_ConfigLoadAndSave.Margin = new System.Windows.Forms.Padding(6);
            this.GrBo_ConfigLoadAndSave.Name = "GrBo_ConfigLoadAndSave";
            this.GrBo_ConfigLoadAndSave.Padding = new System.Windows.Forms.Padding(6);
            this.GrBo_ConfigLoadAndSave.Size = new System.Drawing.Size(956, 167);
            this.GrBo_ConfigLoadAndSave.TabIndex = 24;
            this.GrBo_ConfigLoadAndSave.TabStop = false;
            this.GrBo_ConfigLoadAndSave.Text = "Config Load And Save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2740, 1779);
            this.Controls.Add(this.GrBo_MotionData);
            this.Controls.Add(this.GrBo_ConfigLoadAndSave);
            this.Controls.Add(this.GrBo_FrameData);
            this.Controls.Add(this.GrBo_RunTime);
            this.Controls.Add(this.GrBo_Game);
            this.Controls.Add(this.GrBo_Joystick);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_Effects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_Axis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_Buttons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_POVs)).EndInit();
            this.GrBo_Joystick.ResumeLayout(false);
            this.GrBo_Joystick.PerformLayout();
            this.GrBo_Game.ResumeLayout(false);
            this.GrBo_Game.PerformLayout();
            this.GrBo_MotionData.ResumeLayout(false);
            this.GrBo_MotionData.PerformLayout();
            this.TaCo_MachinesSuportedForProtocol.ResumeLayout(false);
            this.TaPa_XYZ3Cyl.ResumeLayout(false);
            this.TaPa_XYZ3Cyl.PerformLayout();
            this.GrBo_RunTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaGrVi_DataOutput)).EndInit();
            this.GrBo_FrameData.ResumeLayout(false);
            this.GrBo_FrameData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_TimeBetweenTicks)).EndInit();
            this.GrBo_ConfigLoadAndSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CoBo_JoyStickList;
        private System.Windows.Forms.Label La_SelectJoyStick;
        private System.Windows.Forms.Label La_JoystickDevicesName;
        private System.Windows.Forms.Label La_JoystickDevicesGUID;
        private System.Windows.Forms.TextBox TeBo_JoystickDevicesName;
        private System.Windows.Forms.TextBox TeBo_JoystickDevicesGUID;
        private System.Windows.Forms.TextBox TeBo_JoystickDeviceInstancesName;
        private System.Windows.Forms.Label La_JoystickDeviceInstancesName;
        private System.Windows.Forms.TextBox TeBo_JoystickDeviceInstancesGUID;
        private System.Windows.Forms.Label La_JoystickDeviceInstancesGUID;
        private System.Windows.Forms.TextBox TeBo_AxisCount;
        private System.Windows.Forms.Label La_AxisCount;
        private System.Windows.Forms.TextBox TeBo_ButtonCount;
        private System.Windows.Forms.Label La_ButtonCount;
        private System.Windows.Forms.TextBox TeBo_POVCount;
        private System.Windows.Forms.Label La_POVCount;
        private System.Windows.Forms.DataGridView DaGrVi_Effects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_EffectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_EffectGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_EffectType;
        private System.Windows.Forms.Label La_Effects;
        private System.Windows.Forms.DataGridView DaGrVi_Axis;
        private System.Windows.Forms.DataGridView DaGrVi_Buttons;
        private System.Windows.Forms.Label La_Axis;
        private System.Windows.Forms.Label La_Buttons;
        private System.Windows.Forms.Timer JoyStickPollCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AxisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AxisValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ButtonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView DaGrVi_POVs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_POVs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label La_POVs;
        private System.Windows.Forms.GroupBox GrBo_Joystick;
        private System.Windows.Forms.GroupBox GrBo_Game;
        private System.Windows.Forms.Label La_RuntimeProcess;
        private System.Windows.Forms.TextBox TeBo_RuntimeProcess;
        private System.Windows.Forms.Label La_GamePath;
        private System.Windows.Forms.TextBox TeBo_GamePath;
        private System.Windows.Forms.Label La_StartOptionsRunArgs;
        private System.Windows.Forms.TextBox TeBo_StartOptionsRunArgs;
        private System.Windows.Forms.Label La_StartOptionsInput;
        private System.Windows.Forms.TextBox TeBo_StartOptionsInput;
        private System.Windows.Forms.Button But_StartOptionsInputHelp;
        private System.Windows.Forms.GroupBox GrBo_MotionData;
        private System.Windows.Forms.Label La_MotionOutputPathEnding;
        private System.Windows.Forms.Label La_MotionOutputPath;
        private System.Windows.Forms.TextBox TeBo_MotionOutputPath;
        private System.Windows.Forms.Button Bu_TestGame;
        private System.Windows.Forms.Button Bu_LoadConfigFile;
        private System.Windows.Forms.Button Bu_SaveConfigFile;
        private System.Windows.Forms.GroupBox GrBo_RunTime;
        private System.Windows.Forms.Button Bu_Run;
        private System.Windows.Forms.DataGridView DaGrVi_DataOutput;
        private System.Windows.Forms.Label La_FrameOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DeltaTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_C4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_C5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_C6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Snowflakes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Wind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Rain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Smoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Bubbles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Lightning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Flame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Jet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_WaterSpray;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Vibration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SweepingLegs1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SweepingLegs2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Spare1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Spare2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Spare3;
        private System.Windows.Forms.GroupBox GrBo_FrameData;
        private System.Windows.Forms.VScrollBar VScBa_3CylXYZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TeBo_ProtocolConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CoBo_Protocol;
        private System.Windows.Forms.Button But_StartOptionsRunArgsHelp;
        private System.Windows.Forms.Button But_ProtocolConnectionStringHelp;
        private System.Windows.Forms.Button But_RuntimeProcessNameHelp;
        private System.Windows.Forms.GroupBox GrBo_ConfigLoadAndSave;
        private System.Windows.Forms.Label La_MachinesSuportedForProtocol;
        private System.Windows.Forms.TabControl TaCo_MachinesSuportedForProtocol;
        private System.Windows.Forms.TabPage TaPa_XYZ3Cyl;
        private System.Windows.Forms.Label La_JoyAxisForMechSensitivity;
        private System.Windows.Forms.ComboBox CoBo_JoyAxisForMechSensitivity;
        private System.Windows.Forms.Label La_JoyButtonForMechSytheticNoiseEffect;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechSytheticNoiseEffect;
        private System.Windows.Forms.Label La_JoyAxisForMechYAxisTilt;
        private System.Windows.Forms.ComboBox CoBo_JoyAxisForMechYAxisTilt;
        private System.Windows.Forms.Label La_JoyAxisForMechXAxisTilt;
        private System.Windows.Forms.ComboBox CoBo_JoyAxisForMechXAxisTilt;
        private System.Windows.Forms.Label La_JoyButtonForEndTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForEndTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechWaterSprayStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechWaterSprayStateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechVibrationStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechVibrationStateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechBackStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechBackStateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechSweepingLegs1StateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechSweepingLegs1StateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechSweepingLegs2StateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechSweepingLegs2StateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechSpare1StateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechSpare1StateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechSpare2StateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechSpare2StateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechSpare3StateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechSpare3StateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechBubblesStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechBubblesStateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechLightningStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechLightningStateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechFlameStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechFlameStateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechJetStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechJetStateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechRainStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechRainStateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechSmokeStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechSmokeStateTrigger;
        private System.Windows.Forms.Label La_JoyButtonForMechWindStateTrigger;
        private System.Windows.Forms.ComboBox CoBo_JoyButtonForMechWindStateTrigger;
        private System.Windows.Forms.Button Bu_ViewSavedData;
        private System.Windows.Forms.TrackBar TrBa_TimeBetweenTicks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label La_TimeBetweenTicksValue;
        private System.Windows.Forms.Label La_TimeBetweenTicks;
        private System.Windows.Forms.Button Bu_PlayBackSavedData;
    }
}

