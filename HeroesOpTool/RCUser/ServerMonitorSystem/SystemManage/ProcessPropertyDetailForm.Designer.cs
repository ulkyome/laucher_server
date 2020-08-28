using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool.RCUser.ServerMonitorSystem.SystemManage
{

	public partial class ProcessPropertyDetailForm : Form
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
			this.groupBoxStandardInProperty = new GroupBox();
			this.listViewCustomCommand = new ListView();
			this.columnHeader1 = new ColumnHeader();
			this.defComm = new ColumnHeader();
			this.labelBootedString = new Label();
			this.textBoxBootedString = new TextBox();
			this.label1 = new Label();
			this.buttonCustomCommandDown = new Button();
			this.buttonCustomCommandAdd = new Button();
			this.buttonCustomCommandSub = new Button();
			this.buttonCustomCommandUp = new Button();
			this.groupBoxStandardOutProperty = new GroupBox();
			this.buttonPerformanceDescSub = new Button();
			this.listViewPerformanceDescription = new ListView();
			this.columnHeader3 = new ColumnHeader();
			this.columnHeader4 = new ColumnHeader();
			this.textBoxShutdownString = new TextBox();
			this.labelPerformanceString = new Label();
			this.textBoxPerformanceString = new TextBox();
			this.labelShutdownString = new Label();
			this.labelPerformanceDescription = new Label();
			this.buttonPerformanceDescAdd = new Button();
			this.buttonPerformanceDescDown = new Button();
			this.buttonPerformanceDescUp = new Button();
			this.toolTipProperty = new ToolTip(this.components);
			this.groupBoxProperty = new GroupBox();
			this.buttonPropertyDel = new Button();
			this.buttonPropertyAdd = new Button();
			this.listViewProperty = new ListView();
			this.groupBoxChild = new GroupBox();
			this.textBoxChildProcessLogStr = new TextBox();
			this.labelChildProcessLogStr = new Label();
			this.textBoxMaxChildProcessCount = new Utility.NumericTextBox();
			this.labelMaxChildProcessCount = new Label();
			this.checkBoxTraceChildProcess = new CheckBox();
			ColumnHeader columnHeader5 = new ColumnHeader();
			ColumnHeader columnHeader6 = new ColumnHeader();
			this.groupBoxStandardInProperty.SuspendLayout();
			this.groupBoxStandardOutProperty.SuspendLayout();
			this.groupBoxProperty.SuspendLayout();
			this.groupBoxChild.SuspendLayout();
			base.SuspendLayout();
			columnHeader5.Text = "Key";
			columnHeader5.Width = 151;
			columnHeader6.Text = "Value";
			columnHeader6.Width = 216;
			this.groupBoxStandardInProperty.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBoxStandardInProperty.Controls.Add(this.listViewCustomCommand);
			this.groupBoxStandardInProperty.Controls.Add(this.labelBootedString);
			this.groupBoxStandardInProperty.Controls.Add(this.textBoxBootedString);
			this.groupBoxStandardInProperty.Controls.Add(this.label1);
			this.groupBoxStandardInProperty.Controls.Add(this.buttonCustomCommandDown);
			this.groupBoxStandardInProperty.Controls.Add(this.buttonCustomCommandAdd);
			this.groupBoxStandardInProperty.Controls.Add(this.buttonCustomCommandSub);
			this.groupBoxStandardInProperty.Controls.Add(this.buttonCustomCommandUp);
			this.groupBoxStandardInProperty.Location = new Point(6, 12);
			this.groupBoxStandardInProperty.Name = "groupBoxStandardInProperty";
			this.groupBoxStandardInProperty.Size = new Size(424, 196);
			this.groupBoxStandardInProperty.TabIndex = 4;
			this.groupBoxStandardInProperty.TabStop = false;
			this.groupBoxStandardInProperty.Text = "Standard input related settings";
			this.listViewCustomCommand.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.listViewCustomCommand.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader1,
				this.defComm
			});
			this.listViewCustomCommand.FullRowSelect = true;
			this.listViewCustomCommand.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.listViewCustomCommand.HideSelection = false;
			this.listViewCustomCommand.Location = new Point(40, 64);
			this.listViewCustomCommand.MultiSelect = false;
			this.listViewCustomCommand.Name = "listViewCustomCommand";
			this.listViewCustomCommand.ShowGroups = false;
			this.listViewCustomCommand.Size = new Size(376, 126);
			this.listViewCustomCommand.TabIndex = 1;
			this.listViewCustomCommand.UseCompatibleStateImageBehavior = false;
			this.listViewCustomCommand.View = View.Details;
			this.listViewCustomCommand.DoubleClick += this.ListViewCustomCommand_DoubleClick;
			this.columnHeader1.Text = "Command name";
			this.columnHeader1.Width = 120;
			this.defComm.Text = "Defined command";
			this.defComm.Width = 246;
			this.labelBootedString.Location = new Point(8, 16);
			this.labelBootedString.Name = "labelBootedString";
			this.labelBootedString.Size = new Size(112, 24);
			this.labelBootedString.TabIndex = 34;
			this.labelBootedString.Text = "Boot completion output statement";
			this.labelBootedString.TextAlign = ContentAlignment.MiddleLeft;
			this.textBoxBootedString.Location = new Point(120, 16);
			this.textBoxBootedString.MaxLength = 32;
			this.textBoxBootedString.Name = "textBoxBootedString";
			this.textBoxBootedString.Size = new Size(136, 21);
			this.textBoxBootedString.TabIndex = 0;
			this.label1.Location = new Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new Size(112, 24);
			this.label1.TabIndex = 34;
			this.label1.Text = "User-defined input statement";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.buttonCustomCommandDown.Location = new Point(10, 136);
			this.buttonCustomCommandDown.Name = "buttonCustomCommandDown";
			this.buttonCustomCommandDown.Size = new Size(24, 24);
			this.buttonCustomCommandDown.TabIndex = 3;
			this.buttonCustomCommandDown.Text = "↓";
			this.buttonCustomCommandDown.Click += this.buttonCustomCommandDown_Click;
			this.buttonCustomCommandAdd.Location = new Point(10, 64);
			this.buttonCustomCommandAdd.Name = "buttonCustomCommandAdd";
			this.buttonCustomCommandAdd.Size = new Size(24, 24);
			this.buttonCustomCommandAdd.TabIndex = 4;
			this.buttonCustomCommandAdd.Text = "＋";
			this.buttonCustomCommandAdd.Click += this.buttonCustomCommandAdd_Click;
			this.buttonCustomCommandSub.Location = new Point(10, 88);
			this.buttonCustomCommandSub.Name = "buttonCustomCommandSub";
			this.buttonCustomCommandSub.Size = new Size(24, 24);
			this.buttonCustomCommandSub.TabIndex = 5;
			this.buttonCustomCommandSub.Text = "－";
			this.buttonCustomCommandSub.Click += this.buttonCustomCommandSub_Click;
			this.buttonCustomCommandUp.Location = new Point(10, 112);
			this.buttonCustomCommandUp.Name = "buttonCustomCommandUp";
			this.buttonCustomCommandUp.Size = new Size(24, 24);
			this.buttonCustomCommandUp.TabIndex = 2;
			this.buttonCustomCommandUp.Text = "↑";
			this.buttonCustomCommandUp.Click += this.buttonCustomCommandUp_Click;
			this.groupBoxStandardOutProperty.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBoxStandardOutProperty.Controls.Add(this.buttonPerformanceDescSub);
			this.groupBoxStandardOutProperty.Controls.Add(this.listViewPerformanceDescription);
			this.groupBoxStandardOutProperty.Controls.Add(this.textBoxShutdownString);
			this.groupBoxStandardOutProperty.Controls.Add(this.labelPerformanceString);
			this.groupBoxStandardOutProperty.Controls.Add(this.textBoxPerformanceString);
			this.groupBoxStandardOutProperty.Controls.Add(this.labelShutdownString);
			this.groupBoxStandardOutProperty.Controls.Add(this.labelPerformanceDescription);
			this.groupBoxStandardOutProperty.Controls.Add(this.buttonPerformanceDescAdd);
			this.groupBoxStandardOutProperty.Controls.Add(this.buttonPerformanceDescDown);
			this.groupBoxStandardOutProperty.Controls.Add(this.buttonPerformanceDescUp);
			this.groupBoxStandardOutProperty.Location = new Point(6, 214);
			this.groupBoxStandardOutProperty.Name = "groupBoxStandardOutProperty";
			this.groupBoxStandardOutProperty.Size = new Size(424, 220);
			this.groupBoxStandardOutProperty.TabIndex = 5;
			this.groupBoxStandardOutProperty.TabStop = false;
			this.groupBoxStandardOutProperty.Text = "Settings related to standard output";
			this.buttonPerformanceDescSub.Location = new Point(10, 112);
			this.buttonPerformanceDescSub.Name = "buttonPerformanceDescSub";
			this.buttonPerformanceDescSub.Size = new Size(24, 24);
			this.buttonPerformanceDescSub.TabIndex = 7;
			this.buttonPerformanceDescSub.Text = "－";
			this.buttonPerformanceDescSub.Click += this.buttonPerformanceDescSub_Click;
			this.listViewPerformanceDescription.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.listViewPerformanceDescription.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader3,
				this.columnHeader4
			});
			this.listViewPerformanceDescription.FullRowSelect = true;
			this.listViewPerformanceDescription.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.listViewPerformanceDescription.HideSelection = false;
			this.listViewPerformanceDescription.Location = new Point(40, 88);
			this.listViewPerformanceDescription.MultiSelect = false;
			this.listViewPerformanceDescription.Name = "listViewPerformanceDescription";
			this.listViewPerformanceDescription.Size = new Size(376, 126);
			this.listViewPerformanceDescription.TabIndex = 3;
			this.listViewPerformanceDescription.UseCompatibleStateImageBehavior = false;
			this.listViewPerformanceDescription.View = View.Details;
			this.listViewPerformanceDescription.DoubleClick += this.ListViewPerformanceDescription_DoubleClick;
			this.columnHeader3.Text = "Performance name";
			this.columnHeader3.Width = 120;
			this.columnHeader4.Text = "Detail explanation";
			this.columnHeader4.Width = 245;
			this.textBoxShutdownString.Location = new Point(120, 16);
			this.textBoxShutdownString.MaxLength = 32;
			this.textBoxShutdownString.Name = "textBoxShutdownString";
			this.textBoxShutdownString.Size = new Size(136, 21);
			this.textBoxShutdownString.TabIndex = 1;
			this.labelPerformanceString.Location = new Point(8, 40);
			this.labelPerformanceString.Name = "labelPerformanceString";
			this.labelPerformanceString.Size = new Size(112, 24);
			this.labelPerformanceString.TabIndex = 34;
			this.labelPerformanceString.Text = "Performance output prefix";
			this.labelPerformanceString.TextAlign = ContentAlignment.MiddleLeft;
			this.textBoxPerformanceString.Location = new Point(120, 40);
			this.textBoxPerformanceString.MaxLength = 32;
			this.textBoxPerformanceString.Name = "textBoxPerformanceString";
			this.textBoxPerformanceString.Size = new Size(136, 21);
			this.textBoxPerformanceString.TabIndex = 2;
			this.labelShutdownString.Location = new Point(8, 16);
			this.labelShutdownString.Name = "labelShutdownString";
			this.labelShutdownString.Size = new Size(112, 24);
			this.labelShutdownString.TabIndex = 34;
			this.labelShutdownString.Text = "End request input statement";
			this.labelShutdownString.TextAlign = ContentAlignment.MiddleLeft;
			this.labelPerformanceDescription.Location = new Point(8, 64);
			this.labelPerformanceDescription.Name = "labelPerformanceDescription";
			this.labelPerformanceDescription.Size = new Size(112, 24);
			this.labelPerformanceDescription.TabIndex = 34;
			this.labelPerformanceDescription.Text = "Performance output statement setting";
			this.labelPerformanceDescription.TextAlign = ContentAlignment.MiddleLeft;
			this.buttonPerformanceDescAdd.Location = new Point(10, 88);
			this.buttonPerformanceDescAdd.Name = "buttonPerformanceDescAdd";
			this.buttonPerformanceDescAdd.Size = new Size(24, 24);
			this.buttonPerformanceDescAdd.TabIndex = 6;
			this.buttonPerformanceDescAdd.Text = "＋";
			this.buttonPerformanceDescAdd.Click += this.buttonPerformanceDescAdd_Click;
			this.buttonPerformanceDescDown.Location = new Point(10, 160);
			this.buttonPerformanceDescDown.Name = "buttonPerformanceDescDown";
			this.buttonPerformanceDescDown.Size = new Size(24, 24);
			this.buttonPerformanceDescDown.TabIndex = 5;
			this.buttonPerformanceDescDown.Text = "↓";
			this.buttonPerformanceDescDown.Click += this.buttonPerformanceDescDown_Click;
			this.buttonPerformanceDescUp.Location = new Point(10, 136);
			this.buttonPerformanceDescUp.Name = "buttonPerformanceDescUp";
			this.buttonPerformanceDescUp.Size = new Size(24, 24);
			this.buttonPerformanceDescUp.TabIndex = 4;
			this.buttonPerformanceDescUp.Text = "↑";
			this.buttonPerformanceDescUp.Click += this.buttonPerformanceDescUp_Click;
			this.groupBoxProperty.Controls.Add(this.buttonPropertyDel);
			this.groupBoxProperty.Controls.Add(this.buttonPropertyAdd);
			this.groupBoxProperty.Controls.Add(this.listViewProperty);
			this.groupBoxProperty.Location = new Point(6, 550);
			this.groupBoxProperty.Name = "groupBoxProperty";
			this.groupBoxProperty.Size = new Size(424, 136);
			this.groupBoxProperty.TabIndex = 6;
			this.groupBoxProperty.TabStop = false;
			this.groupBoxProperty.Text = "Process attribute";
			this.buttonPropertyDel.Location = new Point(10, 44);
			this.buttonPropertyDel.Name = "buttonPropertyDel";
			this.buttonPropertyDel.Size = new Size(24, 24);
			this.buttonPropertyDel.TabIndex = 36;
			this.buttonPropertyDel.Text = "－";
			this.buttonPropertyDel.Click += this.buttonPropertyDel_Click;
			this.buttonPropertyAdd.Location = new Point(10, 20);
			this.buttonPropertyAdd.Name = "buttonPropertyAdd";
			this.buttonPropertyAdd.Size = new Size(24, 24);
			this.buttonPropertyAdd.TabIndex = 35;
			this.buttonPropertyAdd.Text = "＋";
			this.buttonPropertyAdd.Click += this.buttonPropertyAdd_Click;
			this.listViewProperty.Columns.AddRange(new ColumnHeader[]
			{
				columnHeader5,
				columnHeader6
			});
			this.listViewProperty.FullRowSelect = true;
			this.listViewProperty.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.listViewProperty.Location = new Point(40, 21);
			this.listViewProperty.Name = "listViewProperty";
			this.listViewProperty.ShowGroups = false;
			this.listViewProperty.Size = new Size(376, 109);
			this.listViewProperty.TabIndex = 0;
			this.listViewProperty.UseCompatibleStateImageBehavior = false;
			this.listViewProperty.View = View.Details;
			this.listViewProperty.DoubleClick += this.listViewProperty_DoubleClick;
			this.groupBoxChild.Controls.Add(this.textBoxChildProcessLogStr);
			this.groupBoxChild.Controls.Add(this.labelChildProcessLogStr);
			this.groupBoxChild.Controls.Add(this.textBoxMaxChildProcessCount);
			this.groupBoxChild.Controls.Add(this.labelMaxChildProcessCount);
			this.groupBoxChild.Controls.Add(this.checkBoxTraceChildProcess);
			this.groupBoxChild.Location = new Point(6, 441);
			this.groupBoxChild.Name = "groupBoxChild";
			this.groupBoxChild.Size = new Size(424, 103);
			this.groupBoxChild.TabIndex = 8;
			this.groupBoxChild.TabStop = false;
			this.groupBoxChild.Text = "Child process";
			this.textBoxChildProcessLogStr.Location = new Point(120, 42);
			this.textBoxChildProcessLogStr.MaxLength = 32;
			this.textBoxChildProcessLogStr.Name = "textBoxChildProcessLogStr";
			this.textBoxChildProcessLogStr.Size = new Size(296, 21);
			this.textBoxChildProcessLogStr.TabIndex = 37;
			this.textBoxChildProcessLogStr.Text = "Log [{pid}] {log}";
			this.labelChildProcessLogStr.AutoSize = true;
			this.labelChildProcessLogStr.Location = new Point(8, 45);
			this.labelChildProcessLogStr.Name = "labelChildProcessLogStr";
			this.labelChildProcessLogStr.Size = new Size(57, 12);
			this.labelChildProcessLogStr.TabIndex = 36;
			this.labelChildProcessLogStr.Text = "Log format";
			this.textBoxMaxChildProcessCount.Location = new Point(120, 69);
			this.textBoxMaxChildProcessCount.MaxLength = 32;
			this.textBoxMaxChildProcessCount.Name = "textBoxMaxChildProcessCount";
			this.textBoxMaxChildProcessCount.Size = new Size(136, 21);
			this.textBoxMaxChildProcessCount.TabIndex = 35;
			this.labelMaxChildProcessCount.AutoSize = true;
			this.labelMaxChildProcessCount.Location = new Point(8, 72);
			this.labelMaxChildProcessCount.Name = "labelMaxChildProcessCount";
			this.labelMaxChildProcessCount.Size = new Size(101, 12);
			this.labelMaxChildProcessCount.TabIndex = 1;
			this.labelMaxChildProcessCount.Text = "Maximum number of trace children";
			this.checkBoxTraceChildProcess.AutoSize = true;
			this.checkBoxTraceChildProcess.Location = new Point(10, 20);
			this.checkBoxTraceChildProcess.Name = "checkBoxTraceChildProcess";
			this.checkBoxTraceChildProcess.Size = new Size(156, 16);
			this.checkBoxTraceChildProcess.TabIndex = 0;
			this.checkBoxTraceChildProcess.Text = "Child process log trace";
			this.checkBoxTraceChildProcess.UseVisualStyleBackColor = true;
			base.AutoScaleMode = AutoScaleMode.None;
			this.AutoSize = true;
			base.ClientSize = new Size(442, 698);
			base.ControlBox = false;
			base.Controls.Add(this.groupBoxChild);
			base.Controls.Add(this.groupBoxProperty);
			base.Controls.Add(this.groupBoxStandardInProperty);
			base.Controls.Add(this.groupBoxStandardOutProperty);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ProcessPropertyDetailForm";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "ProcessPropertyDetailForm";
			this.groupBoxStandardInProperty.ResumeLayout(false);
			this.groupBoxStandardInProperty.PerformLayout();
			this.groupBoxStandardOutProperty.ResumeLayout(false);
			this.groupBoxStandardOutProperty.PerformLayout();
			this.groupBoxProperty.ResumeLayout(false);
			this.groupBoxChild.ResumeLayout(false);
			this.groupBoxChild.PerformLayout();
			base.ResumeLayout(false);
		}

		private bool _editable = true;

		private IContainer components;

		private GroupBox groupBoxStandardInProperty;

		private ListView listViewCustomCommand;

		private ColumnHeader columnHeader1;

		private Label labelBootedString;

		private TextBox textBoxBootedString;

		private Label label1;

		private Button buttonCustomCommandDown;

		private Button buttonCustomCommandAdd;

		private Button buttonCustomCommandSub;

		private Button buttonCustomCommandUp;

		private GroupBox groupBoxStandardOutProperty;

		private Button buttonPerformanceDescSub;

		private ListView listViewPerformanceDescription;

		private ColumnHeader columnHeader3;

		private ColumnHeader columnHeader4;

		private TextBox textBoxShutdownString;

		private Label labelPerformanceString;

		private TextBox textBoxPerformanceString;

		private Label labelShutdownString;

		private Label labelPerformanceDescription;

		private Button buttonPerformanceDescAdd;

		private Button buttonPerformanceDescDown;

		private Button buttonPerformanceDescUp;

		private ToolTip toolTipProperty;

		private ListView listViewProperty;

		private ColumnHeader defComm;

		private GroupBox groupBoxProperty;

		private Button buttonPropertyDel;

		private Button buttonPropertyAdd;

		private GroupBox groupBoxChild;

		private TextBox textBoxChildProcessLogStr;

		private Label labelChildProcessLogStr;

		private Utility.NumericTextBox textBoxMaxChildProcessCount;
		//private TextBox textBoxMaxChildProcessCount;

		private Label labelMaxChildProcessCount;

		private CheckBox checkBoxTraceChildProcess;
	}
}
