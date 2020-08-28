using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool.RCUser.ServerMonitorSystem.SystemManage
{
	public partial class ProcessPropertyForm : Form
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
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ProcessPropertyForm));
            this.checkBoxAutomaticStart = new CheckBox();
            this.checkBoxUse = new CheckBox();
            this.checkBoxRunOnce = new CheckBox();
            this.textBoxUpdateFileArgs = new TextBox();
            this.textBoxUpdateFileName = new TextBox();
            this.textBoxStandardOutLogLines = new TextBox();
            this.textBoxExecuteFileArgs = new TextBox();
            this.textBoxExecuteFileName = new TextBox();
            this.textBoxWorkingDirectory = new TextBox();
            this.textBoxDescription = new TextBox();
            this.comboBoxName = new ComboBox();
            this.textBoxType = new TextBox();
            this.labelName = new Label();
            this.labelDescription = new Label();
            this.labelWorkingDirectory = new Label();
            this.labelExecuteFile = new Label();
            this.labelUpdateFile = new Label();
            this.labelStandardOutLogLines = new Label();
            this.groupBoxBasicProperty = new GroupBox();
            this.labelType = new Label();
            this.groupBoxFileProperty = new GroupBox();
            this.groupBoxEtcProperty = new GroupBox();
            this.checkBoxPerformance = new CheckBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.toolTipProperty = new ToolTip(this.components);
            this.BtnDetail = new Button();
            this.groupBoxSchedule = new GroupBox();
            this.buttonScheduleAdd = new Button();
            this.buttonScheduleSub = new Button();
            this.listViewSchedule = new ListView();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();
            this.columnHeader3 = new ColumnHeader();
            this.columnHeader4 = new ColumnHeader();
            this.imageList1 = new ImageList(this.components);
            this.groupBoxBasicProperty.SuspendLayout();
            this.groupBoxFileProperty.SuspendLayout();
            this.groupBoxEtcProperty.SuspendLayout();
            this.groupBoxSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxAutomaticStart
            // 
            this.checkBoxAutomaticStart.Location = new Point(7, 59);
            this.checkBoxAutomaticStart.Name = "checkBoxAutomaticStart";
            this.checkBoxAutomaticStart.Size = new Size(340, 23);
            this.checkBoxAutomaticStart.TabIndex = 2;
            this.checkBoxAutomaticStart.Text = "Autostart on boot up of pc";
            this.toolTipProperty.SetToolTip(this.checkBoxAutomaticStart, "Turn on this option if you want the computer to start up immediately when it is turned on again for some reason without waiting for a user command.");
            // 
            // checkBoxUse
            // 
            this.checkBoxUse.Location = new Point(7, 41);
            this.checkBoxUse.Name = "checkBoxUse";
            this.checkBoxUse.Size = new Size(166, 22);
            this.checkBoxUse.TabIndex = 1;
            this.checkBoxUse.Text = "Activate program use";
            this.toolTipProperty.SetToolTip(this.checkBoxUse, "When this option is off, it is not selected by default when selecting a workgroup, and it is not included in \'Continuous Run/Shutdown\'..");
            // 
            // checkBoxRunOnce
            // 
            this.checkBoxRunOnce.Location = new Point(188, 41);
            this.checkBoxRunOnce.Name = "checkBoxRunOnce";
            this.checkBoxRunOnce.Size = new Size(159, 22);
            this.checkBoxRunOnce.TabIndex = 0;
            this.checkBoxRunOnce.Text = "Automatic restart at program termination";
            this.toolTipProperty.SetToolTip(this.checkBoxRunOnce, resources.GetString("checkBoxRunOnce.ToolTip"));
            // 
            // textBoxUpdateFileArgs
            // 
            this.textBoxUpdateFileArgs.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBoxUpdateFileArgs.Location = new Point(213, 94);
            this.textBoxUpdateFileArgs.MaxLength = 256;
            this.textBoxUpdateFileArgs.Name = "textBoxUpdateFileArgs";
            this.textBoxUpdateFileArgs.Size = new Size(208, 20);
            this.textBoxUpdateFileArgs.TabIndex = 4;
            this.toolTipProperty.SetToolTip(this.textBoxUpdateFileArgs, "Is the argument of the update file.");
            // 
            // textBoxUpdateFileName
            // 
            this.textBoxUpdateFileName.Location = new Point(100, 94);
            this.textBoxUpdateFileName.MaxLength = 32;
            this.textBoxUpdateFileName.Name = "textBoxUpdateFileName";
            this.textBoxUpdateFileName.Size = new Size(113, 20);
            this.textBoxUpdateFileName.TabIndex = 3;
            this.toolTipProperty.SetToolTip(this.textBoxUpdateFileName, "This is the file that is executed when an update is required.");
            // 
            // textBoxStandardOutLogLines
            // 
            this.textBoxStandardOutLogLines.Location = new Point(103, 19);
            this.textBoxStandardOutLogLines.MaxLength = 4;
            this.textBoxStandardOutLogLines.Name = "textBoxStandardOutLogLines";
            this.textBoxStandardOutLogLines.Size = new Size(114, 20);
            this.textBoxStandardOutLogLines.TabIndex = 0;
            this.toolTipProperty.SetToolTip(this.textBoxStandardOutLogLines, "The number of log lines of the program to remember. It can have a value from 10 to 1000, and usually remembers 100 lines..");
            // 
            // textBoxExecuteFileArgs
            // 
            this.textBoxExecuteFileArgs.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBoxExecuteFileArgs.Location = new Point(100, 65);
            this.textBoxExecuteFileArgs.MaxLength = 256;
            this.textBoxExecuteFileArgs.Name = "textBoxExecuteFileArgs";
            this.textBoxExecuteFileArgs.Size = new Size(321, 20);
            this.textBoxExecuteFileArgs.TabIndex = 2;
            this.toolTipProperty.SetToolTip(this.textBoxExecuteFileArgs, "Is the argument of the executable file.");
            // 
            // textBoxExecuteFileName
            // 
            this.textBoxExecuteFileName.Location = new Point(100, 43);
            this.textBoxExecuteFileName.MaxLength = 32;
            this.textBoxExecuteFileName.Name = "textBoxExecuteFileName";
            this.textBoxExecuteFileName.Size = new Size(247, 20);
            this.textBoxExecuteFileName.TabIndex = 1;
            this.toolTipProperty.SetToolTip(this.textBoxExecuteFileName, "The name of the executable file.");
            // 
            // textBoxWorkingDirectory
            // 
            this.textBoxWorkingDirectory.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBoxWorkingDirectory.Location = new Point(100, 15);
            this.textBoxWorkingDirectory.MaxLength = 256;
            this.textBoxWorkingDirectory.Name = "textBoxWorkingDirectory";
            this.textBoxWorkingDirectory.Size = new Size(321, 20);
            this.textBoxWorkingDirectory.TabIndex = 0;
            this.toolTipProperty.SetToolTip(this.textBoxWorkingDirectory, "This is the working directory where the executable file is run. Enter relative directory.");
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBoxDescription.Location = new Point(100, 63);
            this.textBoxDescription.MaxLength = 256;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new Size(321, 20);
            this.textBoxDescription.TabIndex = 1;
            this.toolTipProperty.SetToolTip(this.textBoxDescription, "Enter a description of the program. It is a standard used to display on the screen or to divide work groups..");
            // 
            // comboBoxName
            // 
            this.comboBoxName.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.comboBoxName.Location = new Point(100, 15);
            this.comboBoxName.MaxLength = 32;
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new Size(321, 21);
            this.comboBoxName.TabIndex = 0;
            this.toolTipProperty.SetToolTip(this.comboBoxName, "Enter the program\'s representative name. When registering a new program, you can choose from a list of templates.");
            this.comboBoxName.SelectedIndexChanged += new EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // textBoxType
            // 
            this.textBoxType.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBoxType.Location = new Point(100, 39);
            this.textBoxType.MaxLength = 32;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new Size(321, 20);
            this.textBoxType.TabIndex = 0;
            this.toolTipProperty.SetToolTip(this.textBoxType, "Enter the program type. Programs of the same type are treated as the same program even with different names, allowing simultaneous operation instructions..");
            // 
            // labelName
            // 
            this.labelName.Location = new Point(7, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new Size(93, 22);
            this.labelName.TabIndex = 34;
            this.labelName.Text = "Program name";
            this.labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new Point(7, 63);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new Size(93, 22);
            this.labelDescription.TabIndex = 34;
            this.labelDescription.Text = "Program description";
            this.labelDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelWorkingDirectory
            // 
            this.labelWorkingDirectory.Location = new Point(7, 15);
            this.labelWorkingDirectory.Name = "labelWorkingDirectory";
            this.labelWorkingDirectory.Size = new Size(93, 22);
            this.labelWorkingDirectory.TabIndex = 34;
            this.labelWorkingDirectory.Text = "Working directory";
            this.labelWorkingDirectory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelExecuteFile
            // 
            this.labelExecuteFile.Location = new Point(7, 43);
            this.labelExecuteFile.Name = "labelExecuteFile";
            this.labelExecuteFile.Size = new Size(93, 22);
            this.labelExecuteFile.TabIndex = 34;
            this.labelExecuteFile.Text = "Executable file";
            this.labelExecuteFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelUpdateFile
            // 
            this.labelUpdateFile.Location = new Point(7, 94);
            this.labelUpdateFile.Name = "labelUpdateFile";
            this.labelUpdateFile.Size = new Size(93, 22);
            this.labelUpdateFile.TabIndex = 34;
            this.labelUpdateFile.Text = "Update file";
            this.labelUpdateFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelStandardOutLogLines
            // 
            this.labelStandardOutLogLines.Location = new Point(7, 19);
            this.labelStandardOutLogLines.Name = "labelStandardOutLogLines";
            this.labelStandardOutLogLines.Size = new Size(101, 22);
            this.labelStandardOutLogLines.TabIndex = 34;
            this.labelStandardOutLogLines.Text = "Number of log lines to remember";
            this.labelStandardOutLogLines.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxBasicProperty
            // 
            this.groupBoxBasicProperty.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBoxBasicProperty.Controls.Add(this.labelType);
            this.groupBoxBasicProperty.Controls.Add(this.labelDescription);
            this.groupBoxBasicProperty.Controls.Add(this.labelName);
            this.groupBoxBasicProperty.Controls.Add(this.comboBoxName);
            this.groupBoxBasicProperty.Controls.Add(this.textBoxType);
            this.groupBoxBasicProperty.Controls.Add(this.textBoxDescription);
            this.groupBoxBasicProperty.Location = new Point(7, 9);
            this.groupBoxBasicProperty.Name = "groupBoxBasicProperty";
            this.groupBoxBasicProperty.Size = new Size(427, 86);
            this.groupBoxBasicProperty.TabIndex = 0;
            this.groupBoxBasicProperty.TabStop = false;
            this.groupBoxBasicProperty.Text = "Basic attribute";
            this.toolTipProperty.SetToolTip(this.groupBoxBasicProperty, "Set the basic properties of the program.");
            // 
            // labelType
            // 
            this.labelType.Location = new Point(7, 39);
            this.labelType.Name = "labelType";
            this.labelType.Size = new Size(93, 22);
            this.labelType.TabIndex = 35;
            this.labelType.Text = "Program type";
            this.labelType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxFileProperty
            // 
            this.groupBoxFileProperty.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBoxFileProperty.Controls.Add(this.textBoxExecuteFileArgs);
            this.groupBoxFileProperty.Controls.Add(this.textBoxUpdateFileArgs);
            this.groupBoxFileProperty.Controls.Add(this.textBoxWorkingDirectory);
            this.groupBoxFileProperty.Controls.Add(this.textBoxExecuteFileName);
            this.groupBoxFileProperty.Controls.Add(this.labelExecuteFile);
            this.groupBoxFileProperty.Controls.Add(this.labelUpdateFile);
            this.groupBoxFileProperty.Controls.Add(this.textBoxUpdateFileName);
            this.groupBoxFileProperty.Controls.Add(this.labelWorkingDirectory);
            this.groupBoxFileProperty.Location = new Point(7, 100);
            this.groupBoxFileProperty.Name = "groupBoxFileProperty";
            this.groupBoxFileProperty.Size = new Size(427, 119);
            this.groupBoxFileProperty.TabIndex = 1;
            this.groupBoxFileProperty.TabStop = false;
            this.groupBoxFileProperty.Text = "Information about executable files";
            this.toolTipProperty.SetToolTip(this.groupBoxFileProperty, "You can set the files related to the program.");
            // 
            // groupBoxEtcProperty
            // 
            this.groupBoxEtcProperty.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBoxEtcProperty.Controls.Add(this.checkBoxPerformance);
            this.groupBoxEtcProperty.Controls.Add(this.checkBoxRunOnce);
            this.groupBoxEtcProperty.Controls.Add(this.checkBoxAutomaticStart);
            this.groupBoxEtcProperty.Controls.Add(this.checkBoxUse);
            this.groupBoxEtcProperty.Controls.Add(this.textBoxStandardOutLogLines);
            this.groupBoxEtcProperty.Controls.Add(this.labelStandardOutLogLines);
            this.groupBoxEtcProperty.Location = new Point(10, 436);
            this.groupBoxEtcProperty.Name = "groupBoxEtcProperty";
            this.groupBoxEtcProperty.Size = new Size(424, 87);
            this.groupBoxEtcProperty.TabIndex = 4;
            this.groupBoxEtcProperty.TabStop = false;
            this.groupBoxEtcProperty.Text = "Other information";
            this.toolTipProperty.SetToolTip(this.groupBoxEtcProperty, "Set other information.");
            // 
            // checkBoxPerformance
            // 
            this.checkBoxPerformance.AutoSize = true;
            this.checkBoxPerformance.Location = new Point(188, 63);
            this.checkBoxPerformance.Name = "checkBoxPerformance";
            this.checkBoxPerformance.Size = new Size(203, 17);
            this.checkBoxPerformance.TabIndex = 35;
            this.checkBoxPerformance.Text = "Mem/CPU performance monitoring";
            this.checkBoxPerformance.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.buttonOK.DialogResult = DialogResult.OK;
            this.buttonOK.Location = new Point(146, 531);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(87, 22);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Confirm";
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(238, 531);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(87, 22);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            // 
            // BtnDetail
            // 
            this.BtnDetail.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.BtnDetail.Location = new Point(371, 532);
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.Size = new Size(63, 21);
            this.BtnDetail.TabIndex = 7;
            this.BtnDetail.Text = ">>";
            this.BtnDetail.UseVisualStyleBackColor = true;
            this.BtnDetail.Click += new EventHandler(this.BtnDetail_Click);
            // 
            // groupBoxSchedule
            // 
            this.groupBoxSchedule.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBoxSchedule.Controls.Add(this.buttonScheduleAdd);
            this.groupBoxSchedule.Controls.Add(this.buttonScheduleSub);
            this.groupBoxSchedule.Controls.Add(this.listViewSchedule);
            this.groupBoxSchedule.Location = new Point(10, 225);
            this.groupBoxSchedule.Name = "groupBoxSchedule";
            this.groupBoxSchedule.Size = new Size(424, 205);
            this.groupBoxSchedule.TabIndex = 8;
            this.groupBoxSchedule.TabStop = false;
            this.groupBoxSchedule.Text = "Scheduler";
            // 
            // buttonScheduleAdd
            // 
            this.buttonScheduleAdd.Location = new Point(5, 19);
            this.buttonScheduleAdd.Name = "buttonScheduleAdd";
            this.buttonScheduleAdd.Size = new Size(20, 22);
            this.buttonScheduleAdd.TabIndex = 6;
            this.buttonScheduleAdd.Text = "＋";
            this.buttonScheduleAdd.Click += new EventHandler(this.buttonScheduleAdd_Click);
            // 
            // buttonScheduleSub
            // 
            this.buttonScheduleSub.Location = new Point(5, 41);
            this.buttonScheduleSub.Name = "buttonScheduleSub";
            this.buttonScheduleSub.Size = new Size(20, 22);
            this.buttonScheduleSub.TabIndex = 7;
            this.buttonScheduleSub.Text = "－";
            this.buttonScheduleSub.Click += new EventHandler(this.buttonScheduleSub_Click);
            // 
            // listViewSchedule
            // 
            this.listViewSchedule.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.listViewSchedule.Columns.AddRange(new ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSchedule.FullRowSelect = true;
            this.listViewSchedule.GridLines = true;
            this.listViewSchedule.HideSelection = false;
            this.listViewSchedule.Location = new Point(30, 19);
            this.listViewSchedule.MultiSelect = false;
            this.listViewSchedule.Name = "listViewSchedule";
            this.listViewSchedule.Size = new Size(387, 181);
            this.listViewSchedule.StateImageList = this.imageList1;
            this.listViewSchedule.TabIndex = 0;
            this.listViewSchedule.UseCompatibleStateImageBehavior = false;
            this.listViewSchedule.View = View.Details;
            this.listViewSchedule.DoubleClick += new EventHandler(this.listViewSchedule_DoubleClick);
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
            this.imageList1.ColorDepth = ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new Size(16, 16);
            this.imageList1.TransparentColor = Color.Transparent;
            // 
            // ProcessPropertyForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleBaseSize = new Size(5, 13);
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(442, 562);
            this.Controls.Add(this.groupBoxSchedule);
            this.Controls.Add(this.BtnDetail);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxEtcProperty);
            this.Controls.Add(this.groupBoxFileProperty);
            this.Controls.Add(this.groupBoxBasicProperty);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessPropertyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Program details";
            this.LocationChanged += new EventHandler(this.ProcessPropertyForm_LocationChanged);
            this.groupBoxBasicProperty.ResumeLayout(false);
            this.groupBoxBasicProperty.PerformLayout();
            this.groupBoxFileProperty.ResumeLayout(false);
            this.groupBoxFileProperty.PerformLayout();
            this.groupBoxEtcProperty.ResumeLayout(false);
            this.groupBoxEtcProperty.PerformLayout();
            this.groupBoxSchedule.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private GroupBox groupBoxBasicProperty;

		private GroupBox groupBoxFileProperty;

		private GroupBox groupBoxEtcProperty;

		private ComboBox comboBoxName;

		private TextBox textBoxType;

		private TextBox textBoxDescription;

		private TextBox textBoxWorkingDirectory;

		private TextBox textBoxExecuteFileArgs;

		private TextBox textBoxExecuteFileName;

		private TextBox textBoxUpdateFileArgs;

		private TextBox textBoxUpdateFileName;

		private TextBox textBoxStandardOutLogLines;

		private CheckBox checkBoxAutomaticStart;

		private CheckBox checkBoxUse;

		private CheckBox checkBoxRunOnce;

		private Label labelName;

		private Label labelDescription;

		private Label labelWorkingDirectory;

		private Label labelExecuteFile;

		private Label labelUpdateFile;

		private Label labelStandardOutLogLines;

		private Button buttonOK;

		private Button buttonCancel;

		private ToolTip toolTipProperty;

		private Button BtnDetail;

		private GroupBox groupBoxSchedule;

		private ListView listViewSchedule;

		private Button buttonScheduleAdd;

		private Button buttonScheduleSub;

		private ColumnHeader columnHeader1;

		private ColumnHeader columnHeader2;

		private ColumnHeader columnHeader3;

		private ColumnHeader columnHeader4;

		private ImageList imageList1;

		private Label labelType;

		private CheckBox checkBoxPerformance;

		private IContainer components;
	}
}
