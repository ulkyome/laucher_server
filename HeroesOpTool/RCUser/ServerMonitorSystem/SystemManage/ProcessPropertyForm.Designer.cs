namespace HeroesOpTool.RCUser.ServerMonitorSystem.SystemManage
{
	public partial class ProcessPropertyForm : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessPropertyForm));
            this.checkBoxAutomaticStart = new System.Windows.Forms.CheckBox();
            this.checkBoxUse = new System.Windows.Forms.CheckBox();
            this.checkBoxRunOnce = new System.Windows.Forms.CheckBox();
            this.textBoxUpdateFileArgs = new System.Windows.Forms.TextBox();
            this.textBoxUpdateFileName = new System.Windows.Forms.TextBox();
            this.textBoxStandardOutLogLines = new System.Windows.Forms.TextBox();
            this.textBoxExecuteFileArgs = new System.Windows.Forms.TextBox();
            this.textBoxExecuteFileName = new System.Windows.Forms.TextBox();
            this.textBoxWorkingDirectory = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelWorkingDirectory = new System.Windows.Forms.Label();
            this.labelExecuteFile = new System.Windows.Forms.Label();
            this.labelUpdateFile = new System.Windows.Forms.Label();
            this.labelStandardOutLogLines = new System.Windows.Forms.Label();
            this.groupBoxBasicProperty = new System.Windows.Forms.GroupBox();
            this.labelType = new System.Windows.Forms.Label();
            this.groupBoxFileProperty = new System.Windows.Forms.GroupBox();
            this.groupBoxEtcProperty = new System.Windows.Forms.GroupBox();
            this.checkBoxPerformance = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.toolTipProperty = new System.Windows.Forms.ToolTip(this.components);
            this.BtnDetail = new System.Windows.Forms.Button();
            this.groupBoxSchedule = new System.Windows.Forms.GroupBox();
            this.buttonScheduleAdd = new System.Windows.Forms.Button();
            this.buttonScheduleSub = new System.Windows.Forms.Button();
            this.listViewSchedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxBasicProperty.SuspendLayout();
            this.groupBoxFileProperty.SuspendLayout();
            this.groupBoxEtcProperty.SuspendLayout();
            this.groupBoxSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxAutomaticStart
            // 
            this.checkBoxAutomaticStart.Location = new System.Drawing.Point(7, 59);
            this.checkBoxAutomaticStart.Name = "checkBoxAutomaticStart";
            this.checkBoxAutomaticStart.Size = new System.Drawing.Size(340, 23);
            this.checkBoxAutomaticStart.TabIndex = 2;
            this.checkBoxAutomaticStart.Text = "Autostart on boot up of pc";
            this.toolTipProperty.SetToolTip(this.checkBoxAutomaticStart, "Turn on this option if you want the computer to start up immediately when it is t" +
        "urned on again for some reason without waiting for a user command.");
            // 
            // checkBoxUse
            // 
            this.checkBoxUse.Location = new System.Drawing.Point(7, 41);
            this.checkBoxUse.Name = "checkBoxUse";
            this.checkBoxUse.Size = new System.Drawing.Size(166, 22);
            this.checkBoxUse.TabIndex = 1;
            this.checkBoxUse.Text = "Activate program use";
            this.toolTipProperty.SetToolTip(this.checkBoxUse, "When this option is off, it is not selected by default when selecting a workgroup" +
        ", and it is not included in \'Continuous Run/Shutdown\'..");
            // 
            // checkBoxRunOnce
            // 
            this.checkBoxRunOnce.Location = new System.Drawing.Point(188, 41);
            this.checkBoxRunOnce.Name = "checkBoxRunOnce";
            this.checkBoxRunOnce.Size = new System.Drawing.Size(159, 22);
            this.checkBoxRunOnce.TabIndex = 0;
            this.checkBoxRunOnce.Text = "Automatic restart at program termination";
            this.toolTipProperty.SetToolTip(this.checkBoxRunOnce, resources.GetString("checkBoxRunOnce.ToolTip"));
            // 
            // textBoxUpdateFileArgs
            // 
            this.textBoxUpdateFileArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUpdateFileArgs.Location = new System.Drawing.Point(213, 94);
            this.textBoxUpdateFileArgs.MaxLength = 256;
            this.textBoxUpdateFileArgs.Name = "textBoxUpdateFileArgs";
            this.textBoxUpdateFileArgs.Size = new System.Drawing.Size(208, 20);
            this.textBoxUpdateFileArgs.TabIndex = 4;
            this.toolTipProperty.SetToolTip(this.textBoxUpdateFileArgs, "Is the argument of the update file.");
            // 
            // textBoxUpdateFileName
            // 
            this.textBoxUpdateFileName.Location = new System.Drawing.Point(100, 94);
            this.textBoxUpdateFileName.MaxLength = 32;
            this.textBoxUpdateFileName.Name = "textBoxUpdateFileName";
            this.textBoxUpdateFileName.Size = new System.Drawing.Size(113, 20);
            this.textBoxUpdateFileName.TabIndex = 3;
            this.toolTipProperty.SetToolTip(this.textBoxUpdateFileName, "This is the file that is executed when an update is required.");
            // 
            // textBoxStandardOutLogLines
            // 
            this.textBoxStandardOutLogLines.Location = new System.Drawing.Point(103, 19);
            this.textBoxStandardOutLogLines.MaxLength = 4;
            this.textBoxStandardOutLogLines.Name = "textBoxStandardOutLogLines";
            this.textBoxStandardOutLogLines.Size = new System.Drawing.Size(114, 20);
            this.textBoxStandardOutLogLines.TabIndex = 0;
            this.toolTipProperty.SetToolTip(this.textBoxStandardOutLogLines, "The number of log lines of the program to remember. It can have a value from 10 to 1000, and usually remembers 100 lines..");
            // 
            // textBoxExecuteFileArgs
            // 
            this.textBoxExecuteFileArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExecuteFileArgs.Location = new System.Drawing.Point(100, 65);
            this.textBoxExecuteFileArgs.MaxLength = 256;
            this.textBoxExecuteFileArgs.Name = "textBoxExecuteFileArgs";
            this.textBoxExecuteFileArgs.Size = new System.Drawing.Size(321, 20);
            this.textBoxExecuteFileArgs.TabIndex = 2;
            this.toolTipProperty.SetToolTip(this.textBoxExecuteFileArgs, "Is the argument of the executable file.");
            this.textBoxExecuteFileArgs.TextChanged += new System.EventHandler(this.textBoxExecuteFileArgs_TextChanged);
            // 
            // textBoxExecuteFileName
            // 
            this.textBoxExecuteFileName.Location = new System.Drawing.Point(100, 43);
            this.textBoxExecuteFileName.MaxLength = 32;
            this.textBoxExecuteFileName.Name = "textBoxExecuteFileName";
            this.textBoxExecuteFileName.Size = new System.Drawing.Size(247, 20);
            this.textBoxExecuteFileName.TabIndex = 1;
            this.toolTipProperty.SetToolTip(this.textBoxExecuteFileName, "The name of the executable file.");
            // 
            // textBoxWorkingDirectory
            // 
            this.textBoxWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkingDirectory.Location = new System.Drawing.Point(100, 15);
            this.textBoxWorkingDirectory.MaxLength = 256;
            this.textBoxWorkingDirectory.Name = "textBoxWorkingDirectory";
            this.textBoxWorkingDirectory.Size = new System.Drawing.Size(321, 20);
            this.textBoxWorkingDirectory.TabIndex = 0;
            this.toolTipProperty.SetToolTip(this.textBoxWorkingDirectory, "This is the working directory where the executable file is run. Enter relative di" +
        "rectory.");
            this.textBoxWorkingDirectory.TextChanged += new System.EventHandler(this.textBoxWorkingDirectory_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(100, 63);
            this.textBoxDescription.MaxLength = 256;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(321, 20);
            this.textBoxDescription.TabIndex = 1;
            this.toolTipProperty.SetToolTip(this.textBoxDescription, "Enter a description of the program. It is a standard used to display on the scree" +
        "n or to divide work groups..");
            // 
            // comboBoxName
            // 
            this.comboBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxName.Location = new System.Drawing.Point(100, 15);
            this.comboBoxName.MaxLength = 32;
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(321, 21);
            this.comboBoxName.TabIndex = 0;
            this.toolTipProperty.SetToolTip(this.comboBoxName, "Enter the program\'s representative name. When registering a new program, you can " +
        "choose from a list of templates.");
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // textBoxType
            // 
            this.textBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxType.Location = new System.Drawing.Point(100, 39);
            this.textBoxType.MaxLength = 32;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(321, 20);
            this.textBoxType.TabIndex = 0;
            this.toolTipProperty.SetToolTip(this.textBoxType, "Enter the program type. Programs of the same type are treated as the same program" +
        " even with different names, allowing simultaneous operation instructions..");
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(7, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 22);
            this.labelName.TabIndex = 34;
            this.labelName.Text = "Program name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(7, 63);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(93, 22);
            this.labelDescription.TabIndex = 34;
            this.labelDescription.Text = "Program description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkingDirectory
            // 
            this.labelWorkingDirectory.Location = new System.Drawing.Point(7, 15);
            this.labelWorkingDirectory.Name = "labelWorkingDirectory";
            this.labelWorkingDirectory.Size = new System.Drawing.Size(93, 22);
            this.labelWorkingDirectory.TabIndex = 34;
            this.labelWorkingDirectory.Text = "Working directory";
            this.labelWorkingDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExecuteFile
            // 
            this.labelExecuteFile.Location = new System.Drawing.Point(7, 43);
            this.labelExecuteFile.Name = "labelExecuteFile";
            this.labelExecuteFile.Size = new System.Drawing.Size(93, 22);
            this.labelExecuteFile.TabIndex = 34;
            this.labelExecuteFile.Text = "Executable file";
            this.labelExecuteFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUpdateFile
            // 
            this.labelUpdateFile.Location = new System.Drawing.Point(7, 94);
            this.labelUpdateFile.Name = "labelUpdateFile";
            this.labelUpdateFile.Size = new System.Drawing.Size(93, 22);
            this.labelUpdateFile.TabIndex = 34;
            this.labelUpdateFile.Text = "Update file";
            this.labelUpdateFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStandardOutLogLines
            // 
            this.labelStandardOutLogLines.Location = new System.Drawing.Point(7, 19);
            this.labelStandardOutLogLines.Name = "labelStandardOutLogLines";
            this.labelStandardOutLogLines.Size = new System.Drawing.Size(101, 22);
            this.labelStandardOutLogLines.TabIndex = 34;
            this.labelStandardOutLogLines.Text = "Number of log lines to remember";
            this.labelStandardOutLogLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxBasicProperty
            // 
            this.groupBoxBasicProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBasicProperty.Controls.Add(this.labelType);
            this.groupBoxBasicProperty.Controls.Add(this.labelDescription);
            this.groupBoxBasicProperty.Controls.Add(this.labelName);
            this.groupBoxBasicProperty.Controls.Add(this.comboBoxName);
            this.groupBoxBasicProperty.Controls.Add(this.textBoxType);
            this.groupBoxBasicProperty.Controls.Add(this.textBoxDescription);
            this.groupBoxBasicProperty.Location = new System.Drawing.Point(7, 9);
            this.groupBoxBasicProperty.Name = "groupBoxBasicProperty";
            this.groupBoxBasicProperty.Size = new System.Drawing.Size(427, 86);
            this.groupBoxBasicProperty.TabIndex = 0;
            this.groupBoxBasicProperty.TabStop = false;
            this.groupBoxBasicProperty.Text = "Basic attribute";
            this.toolTipProperty.SetToolTip(this.groupBoxBasicProperty, "Set the basic properties of the program.");
            // 
            // labelType
            // 
            this.labelType.Location = new System.Drawing.Point(7, 39);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(93, 22);
            this.labelType.TabIndex = 35;
            this.labelType.Text = "Program type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxFileProperty
            // 
            this.groupBoxFileProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFileProperty.Controls.Add(this.textBoxExecuteFileArgs);
            this.groupBoxFileProperty.Controls.Add(this.textBoxUpdateFileArgs);
            this.groupBoxFileProperty.Controls.Add(this.textBoxWorkingDirectory);
            this.groupBoxFileProperty.Controls.Add(this.textBoxExecuteFileName);
            this.groupBoxFileProperty.Controls.Add(this.labelExecuteFile);
            this.groupBoxFileProperty.Controls.Add(this.labelUpdateFile);
            this.groupBoxFileProperty.Controls.Add(this.textBoxUpdateFileName);
            this.groupBoxFileProperty.Controls.Add(this.labelWorkingDirectory);
            this.groupBoxFileProperty.Location = new System.Drawing.Point(7, 100);
            this.groupBoxFileProperty.Name = "groupBoxFileProperty";
            this.groupBoxFileProperty.Size = new System.Drawing.Size(427, 119);
            this.groupBoxFileProperty.TabIndex = 1;
            this.groupBoxFileProperty.TabStop = false;
            this.groupBoxFileProperty.Text = "Information about executable files";
            this.toolTipProperty.SetToolTip(this.groupBoxFileProperty, "You can set the files related to the program.");
            // 
            // groupBoxEtcProperty
            // 
            this.groupBoxEtcProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEtcProperty.Controls.Add(this.checkBoxPerformance);
            this.groupBoxEtcProperty.Controls.Add(this.checkBoxRunOnce);
            this.groupBoxEtcProperty.Controls.Add(this.checkBoxAutomaticStart);
            this.groupBoxEtcProperty.Controls.Add(this.checkBoxUse);
            this.groupBoxEtcProperty.Controls.Add(this.textBoxStandardOutLogLines);
            this.groupBoxEtcProperty.Controls.Add(this.labelStandardOutLogLines);
            this.groupBoxEtcProperty.Location = new System.Drawing.Point(10, 436);
            this.groupBoxEtcProperty.Name = "groupBoxEtcProperty";
            this.groupBoxEtcProperty.Size = new System.Drawing.Size(424, 87);
            this.groupBoxEtcProperty.TabIndex = 4;
            this.groupBoxEtcProperty.TabStop = false;
            this.groupBoxEtcProperty.Text = "Other information";
            this.toolTipProperty.SetToolTip(this.groupBoxEtcProperty, "Set other information.");
            // 
            // checkBoxPerformance
            // 
            this.checkBoxPerformance.AutoSize = true;
            this.checkBoxPerformance.Location = new System.Drawing.Point(188, 63);
            this.checkBoxPerformance.Name = "checkBoxPerformance";
            this.checkBoxPerformance.Size = new System.Drawing.Size(203, 17);
            this.checkBoxPerformance.TabIndex = 35;
            this.checkBoxPerformance.Text = "Memory/CPU performance monitoring";
            this.checkBoxPerformance.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(146, 531);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 22);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Confirm";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(238, 531);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 22);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            // 
            // BtnDetail
            // 
            this.BtnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDetail.Location = new System.Drawing.Point(371, 532);
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.Size = new System.Drawing.Size(63, 21);
            this.BtnDetail.TabIndex = 7;
            this.BtnDetail.Text = ">>";
            this.BtnDetail.UseVisualStyleBackColor = true;
            this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // groupBoxSchedule
            // 
            this.groupBoxSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSchedule.Controls.Add(this.buttonScheduleAdd);
            this.groupBoxSchedule.Controls.Add(this.buttonScheduleSub);
            this.groupBoxSchedule.Controls.Add(this.listViewSchedule);
            this.groupBoxSchedule.Location = new System.Drawing.Point(10, 225);
            this.groupBoxSchedule.Name = "groupBoxSchedule";
            this.groupBoxSchedule.Size = new System.Drawing.Size(424, 205);
            this.groupBoxSchedule.TabIndex = 8;
            this.groupBoxSchedule.TabStop = false;
            this.groupBoxSchedule.Text = "Scheduler";
            // 
            // buttonScheduleAdd
            // 
            this.buttonScheduleAdd.Location = new System.Drawing.Point(5, 19);
            this.buttonScheduleAdd.Name = "buttonScheduleAdd";
            this.buttonScheduleAdd.Size = new System.Drawing.Size(20, 22);
            this.buttonScheduleAdd.TabIndex = 6;
            this.buttonScheduleAdd.Text = "＋";
            this.buttonScheduleAdd.Click += new System.EventHandler(this.buttonScheduleAdd_Click);
            // 
            // buttonScheduleSub
            // 
            this.buttonScheduleSub.Location = new System.Drawing.Point(5, 41);
            this.buttonScheduleSub.Name = "buttonScheduleSub";
            this.buttonScheduleSub.Size = new System.Drawing.Size(20, 22);
            this.buttonScheduleSub.TabIndex = 7;
            this.buttonScheduleSub.Text = "－";
            this.buttonScheduleSub.Click += new System.EventHandler(this.buttonScheduleSub_Click);
            // 
            // listViewSchedule
            // 
            this.listViewSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSchedule.FullRowSelect = true;
            this.listViewSchedule.GridLines = true;
            this.listViewSchedule.HideSelection = false;
            this.listViewSchedule.Location = new System.Drawing.Point(30, 19);
            this.listViewSchedule.MultiSelect = false;
            this.listViewSchedule.Name = "listViewSchedule";
            this.listViewSchedule.Size = new System.Drawing.Size(387, 181);
            this.listViewSchedule.StateImageList = this.imageList1;
            this.listViewSchedule.TabIndex = 0;
            this.listViewSchedule.UseCompatibleStateImageBehavior = false;
            this.listViewSchedule.View = System.Windows.Forms.View.Details;
            this.listViewSchedule.DoubleClick += new System.EventHandler(this.listViewSchedule_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 22;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Action plan";
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Command";
            this.columnHeader4.Width = 229;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ProcessPropertyForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(442, 562);
            this.Controls.Add(this.groupBoxSchedule);
            this.Controls.Add(this.BtnDetail);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxEtcProperty);
            this.Controls.Add(this.groupBoxFileProperty);
            this.Controls.Add(this.groupBoxBasicProperty);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessPropertyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Program details";
            this.LocationChanged += new System.EventHandler(this.ProcessPropertyForm_LocationChanged);
            this.groupBoxBasicProperty.ResumeLayout(false);
            this.groupBoxBasicProperty.PerformLayout();
            this.groupBoxFileProperty.ResumeLayout(false);
            this.groupBoxFileProperty.PerformLayout();
            this.groupBoxEtcProperty.ResumeLayout(false);
            this.groupBoxEtcProperty.PerformLayout();
            this.groupBoxSchedule.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private global::System.Windows.Forms.GroupBox groupBoxBasicProperty;

		private global::System.Windows.Forms.GroupBox groupBoxFileProperty;

		private global::System.Windows.Forms.GroupBox groupBoxEtcProperty;

		private global::System.Windows.Forms.ComboBox comboBoxName;

		private global::System.Windows.Forms.TextBox textBoxType;

		private global::System.Windows.Forms.TextBox textBoxDescription;

		private global::System.Windows.Forms.TextBox textBoxWorkingDirectory;

		private global::System.Windows.Forms.TextBox textBoxExecuteFileArgs;

		private global::System.Windows.Forms.TextBox textBoxExecuteFileName;

		private global::System.Windows.Forms.TextBox textBoxUpdateFileArgs;

		private global::System.Windows.Forms.TextBox textBoxUpdateFileName;

		private global::System.Windows.Forms.TextBox textBoxStandardOutLogLines;

		private global::System.Windows.Forms.CheckBox checkBoxAutomaticStart;

		private global::System.Windows.Forms.CheckBox checkBoxUse;

		private global::System.Windows.Forms.CheckBox checkBoxRunOnce;

		private global::System.Windows.Forms.Label labelName;

		private global::System.Windows.Forms.Label labelDescription;

		private global::System.Windows.Forms.Label labelWorkingDirectory;

		private global::System.Windows.Forms.Label labelExecuteFile;

		private global::System.Windows.Forms.Label labelUpdateFile;

		private global::System.Windows.Forms.Label labelStandardOutLogLines;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::System.Windows.Forms.ToolTip toolTipProperty;

		private global::System.Windows.Forms.Button BtnDetail;

		private global::System.Windows.Forms.GroupBox groupBoxSchedule;

		private global::System.Windows.Forms.ListView listViewSchedule;

		private global::System.Windows.Forms.Button buttonScheduleAdd;

		private global::System.Windows.Forms.Button buttonScheduleSub;

		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		private global::System.Windows.Forms.ImageList imageList1;

		private global::System.Windows.Forms.Label labelType;

		private global::System.Windows.Forms.CheckBox checkBoxPerformance;

		private global::System.ComponentModel.IContainer components;
	}
}
