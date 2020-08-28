using System;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool.RCUser.ServerMonitorSystem.SystemManage
{
	public partial class CustomCommandForm : Form
	{
		//protected override void Dispose(bool disposing)
		//{
		//	if (disposing && this.components != null)
		//	{
		//		this.components.Dispose();
		//	}
		//	base.Dispose(disposing);
		//}

		private void InitializeComponent()
		{
			this.groupBoxName = new GroupBox();
			this.textBoxName = new TextBox();
			this.textBoxCommand = new TextBox();
			this.groupBoxCommand = new GroupBox();
			this.groupBoxArg = new GroupBox();
			this.buttoArgDel = new Button();
			this.buttonArgAdd = new Button();
			this.comboBoxType = new ComboBox();
			this.labelArgType = new Label();
			this.labelArgName = new Label();
			this.textBoxArgName = new TextBox();
			this.groupBoxArgList = new GroupBox();
			this.textBoxDesc = new TextBox();
			this.listViewArg = new ListView();
			this.labelDesc = new Label();
			this.textBoxRawCommand = new TextBox();
			this.buttonOK = new Button();
			this.buttonCancel = new Button();
			ColumnHeader columnHeader = new ColumnHeader();
			ColumnHeader columnHeader2 = new ColumnHeader();
			this.groupBoxName.SuspendLayout();
			this.groupBoxCommand.SuspendLayout();
			this.groupBoxArg.SuspendLayout();
			this.groupBoxArgList.SuspendLayout();
			base.SuspendLayout();
			columnHeader.Width = 97;
			columnHeader2.Width = 67;
			this.groupBoxName.Controls.Add(this.textBoxName);
			this.groupBoxName.Location = new Point(12, 12);
			this.groupBoxName.Name = "groupBoxName";
			this.groupBoxName.Size = new Size(174, 45);
			this.groupBoxName.TabIndex = 1;
			this.groupBoxName.TabStop = false;
			this.groupBoxName.Text = "Command name";
			this.textBoxName.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBoxName.Location = new Point(6, 18);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new Size(162, 21);
			this.textBoxName.TabIndex = 0;
			this.textBoxName.TextChanged += new EventHandler(this.textBoxName_TextChanged);
			this.textBoxCommand.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBoxCommand.Location = new Point(6, 18);
			this.textBoxCommand.Name = "textBoxCommand";
			this.textBoxCommand.Size = new Size(162, 21);
			this.textBoxCommand.TabIndex = 0;
			this.textBoxCommand.TextChanged += new EventHandler(this.textBoxCommand_TextChanged);
			this.groupBoxCommand.Controls.Add(this.textBoxCommand);
			this.groupBoxCommand.Location = new Point(12, 63);
			this.groupBoxCommand.Name = "groupBoxCommand";
			this.groupBoxCommand.Size = new Size(174, 45);
			this.groupBoxCommand.TabIndex = 2;
			this.groupBoxCommand.TabStop = false;
			this.groupBoxCommand.Text = "Command";
			this.groupBoxArg.Controls.Add(this.buttoArgDel);
			this.groupBoxArg.Controls.Add(this.buttonArgAdd);
			this.groupBoxArg.Controls.Add(this.comboBoxType);
			this.groupBoxArg.Controls.Add(this.labelArgType);
			this.groupBoxArg.Controls.Add(this.labelArgName);
			this.groupBoxArg.Controls.Add(this.textBoxArgName);
			this.groupBoxArg.Location = new Point(12, 114);
			this.groupBoxArg.Name = "groupBoxArg";
			this.groupBoxArg.Size = new Size(174, 104);
			this.groupBoxArg.TabIndex = 3;
			this.groupBoxArg.TabStop = false;
			this.groupBoxArg.Text = "factor";
			this.buttoArgDel.Location = new Point(144, 72);
			this.buttoArgDel.Name = "buttoArgDel";
			this.buttoArgDel.Size = new Size(24, 24);
			this.buttoArgDel.TabIndex = 5;
			this.buttoArgDel.Text = "－";
			this.buttoArgDel.Click += new EventHandler(this.buttoArgDel_Click);
			this.buttonArgAdd.Location = new Point(114, 72);
			this.buttonArgAdd.Name = "buttonArgAdd";
			this.buttonArgAdd.Size = new Size(24, 24);
			this.buttonArgAdd.TabIndex = 4;
			this.buttonArgAdd.Text = "＋";
			this.buttonArgAdd.Click += new EventHandler(this.buttonArgAdd_Click);
			this.comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new Point(41, 46);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new Size(127, 20);
			this.comboBoxType.TabIndex = 3;
			this.comboBoxType.SelectedIndexChanged += new EventHandler(this.comboBoxType_SelectedIndexChanged);
			this.labelArgType.AutoSize = true;
			this.labelArgType.Location = new Point(6, 48);
			this.labelArgType.Name = "labelArgType";
			this.labelArgType.Size = new Size(29, 12);
			this.labelArgType.TabIndex = 2;
			this.labelArgType.Text = "type";
			this.labelArgName.AutoSize = true;
			this.labelArgName.Location = new Point(6, 21);
			this.labelArgName.Name = "labelArgName";
			this.labelArgName.Size = new Size(29, 12);
			this.labelArgName.TabIndex = 0;
			this.labelArgName.Text = "name";
			this.textBoxArgName.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBoxArgName.Location = new Point(41, 18);
			this.textBoxArgName.Name = "textBoxArgName";
			this.textBoxArgName.Size = new Size(127, 21);
			this.textBoxArgName.TabIndex = 1;
			this.textBoxArgName.TextChanged += new EventHandler(this.textBoxArgName_TextChanged);
			this.groupBoxArgList.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBoxArgList.Controls.Add(this.textBoxDesc);
			this.groupBoxArgList.Controls.Add(this.listViewArg);
			this.groupBoxArgList.Controls.Add(this.labelDesc);
			this.groupBoxArgList.Location = new Point(193, 13);
			this.groupBoxArgList.Name = "groupBoxArgList";
			this.groupBoxArgList.Size = new Size(187, 205);
			this.groupBoxArgList.TabIndex = 4;
			this.groupBoxArgList.TabStop = false;
			this.groupBoxArgList.Text = "Argument list";
			this.textBoxDesc.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.textBoxDesc.Location = new Point(7, 176);
			this.textBoxDesc.Name = "textBoxDesc";
			this.textBoxDesc.Size = new Size(174, 21);
			this.textBoxDesc.TabIndex = 2;
			this.textBoxDesc.TextChanged += new EventHandler(this.textBoxDesc_TextChanged);
			this.listViewArg.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.listViewArg.Columns.AddRange(new ColumnHeader[]
			{
				columnHeader,
				columnHeader2
			});
			this.listViewArg.FullRowSelect = true;
			this.listViewArg.GridLines = true;
			this.listViewArg.HeaderStyle = ColumnHeaderStyle.None;
			this.listViewArg.HideSelection = false;
			this.listViewArg.Location = new Point(7, 17);
			this.listViewArg.Name = "listViewArg";
			this.listViewArg.ShowGroups = false;
			this.listViewArg.Size = new Size(174, 138);
			this.listViewArg.TabIndex = 0;
			this.listViewArg.UseCompatibleStateImageBehavior = false;
			this.listViewArg.View = View.Details;
			this.listViewArg.SelectedIndexChanged += new EventHandler(this.listViewArg_SelectedIndexChanged);
			this.labelDesc.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.labelDesc.AutoSize = true;
			this.labelDesc.Location = new Point(6, 161);
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Size = new Size(29, 12);
			this.labelDesc.TabIndex = 1;
			this.labelDesc.Text = "Explanation";
			this.textBoxRawCommand.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.textBoxRawCommand.Location = new Point(12, 224);
			this.textBoxRawCommand.Name = "textBoxRawCommand";
			this.textBoxRawCommand.Size = new Size(368, 21);
			this.textBoxRawCommand.TabIndex = 0;
			this.textBoxRawCommand.TextChanged += new EventHandler(this.textBoxRawCommand_TextChanged);
			this.buttonOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.buttonOK.DialogResult = DialogResult.OK;
			this.buttonOK.Location = new Point(166, 252);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new Size(104, 24);
			this.buttonOK.TabIndex = 5;
			this.buttonOK.Text = "Confirm";
			this.buttonCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.buttonCancel.DialogResult = DialogResult.Cancel;
			this.buttonCancel.Location = new Point(276, 252);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new Size(104, 24);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new SizeF(7f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new Size(392, 288);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.textBoxRawCommand);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.groupBoxArgList);
			base.Controls.Add(this.groupBoxArg);
			base.Controls.Add(this.groupBoxCommand);
			base.Controls.Add(this.groupBoxName);
			this.Name = "CustomCommandForm";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Custom instruction";
			base.FormClosing += new FormClosingEventHandler(this.CustomCommandForm_FormClosing);
			this.groupBoxName.ResumeLayout(false);
			this.groupBoxName.PerformLayout();
			this.groupBoxCommand.ResumeLayout(false);
			this.groupBoxCommand.PerformLayout();
			this.groupBoxArg.ResumeLayout(false);
			this.groupBoxArg.PerformLayout();
			this.groupBoxArgList.ResumeLayout(false);
			this.groupBoxArgList.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		//private ComponentModel.IContainer components;

		private GroupBox groupBoxName;

		private TextBox textBoxName;

		private TextBox textBoxCommand;

		private GroupBox groupBoxCommand;

		private GroupBox groupBoxArg;

		private TextBox textBoxArgName;

		private GroupBox groupBoxArgList;

		private TextBox textBoxRawCommand;

		private Button buttonOK;

		private Button buttonCancel;

		private ComboBox comboBoxType;

		private Label labelDesc;

		private Label labelArgType;

		private Label labelArgName;

		private Button buttoArgDel;

		private Button buttonArgAdd;

		private TextBox textBoxDesc;

		private ListView listViewArg;
	}
}
