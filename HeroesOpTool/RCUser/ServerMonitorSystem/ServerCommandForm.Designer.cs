using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RemoteControlSystem;
using RemoteControlSystem.ServerMessage;

namespace HeroesOpTool.RCUser.ServerMonitorSystem
{
	public partial class ServerCommandForm : CommandForm
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
			//this.components = new global::System.ComponentModel.Container();
			this.groupBoxCommand = new GroupBox();
			this.listBoxCommand = new ListBox();
			this.groupBoxServer = new GroupBox();
			this.checkedListBoxServer = new CheckedListBox();
			this.groupBoxArgList = new GroupBox();
			this.panelArgList = new Panel();
			this.panelMid = new Panel();
			this.panelBottom = new Panel();
			this.dateTimePicker = new DateTimePicker();
			this.checkSchedule = new CheckBox();
			this.buttonCancel = new Button();
			this.buttonOK = new Button();
			this.panelTop = new Panel();
			this.textBox1 = new TextBox();
			this.panelSchdule = new Panel();
			SplitContainer splitContainer = new SplitContainer();
			SplitContainer splitContainer2 = new SplitContainer();
			splitContainer.Panel1.SuspendLayout();
			splitContainer.Panel2.SuspendLayout();
			splitContainer.SuspendLayout();
			this.groupBoxCommand.SuspendLayout();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			this.groupBoxServer.SuspendLayout();
			this.groupBoxArgList.SuspendLayout();
			this.panelMid.SuspendLayout();
			this.panelBottom.SuspendLayout();
			this.panelTop.SuspendLayout();
			base.SuspendLayout();
			splitContainer.Dock = DockStyle.Fill;
			splitContainer.Location = new Point(0, 0);
			splitContainer.Name = "splitContainerLeftRight";
			splitContainer.Panel1.Controls.Add(this.groupBoxCommand);
			splitContainer.Panel2.Controls.Add(splitContainer2);
			splitContainer.Size = new Size(530, 291);
			splitContainer.SplitterDistance = 186;
			splitContainer.TabIndex = 1;
			this.groupBoxCommand.Controls.Add(this.listBoxCommand);
			this.groupBoxCommand.Dock = DockStyle.Fill;
			this.groupBoxCommand.Location = new Point(0, 0);
			this.groupBoxCommand.Name = "groupBoxCommand";
			this.groupBoxCommand.Size = new Size(186, 291);
			this.groupBoxCommand.TabIndex = 5;
			this.groupBoxCommand.TabStop = false;
			this.groupBoxCommand.Text = "Available commands";
			this.listBoxCommand.Dock = DockStyle.Fill;
			this.listBoxCommand.FormattingEnabled = true;
			this.listBoxCommand.ItemHeight = 12;
			this.listBoxCommand.Location = new Point(3, 17);
			this.listBoxCommand.Name = "listBoxCommand";
			this.listBoxCommand.Size = new Size(180, 268);
			this.listBoxCommand.TabIndex = 0;
			this.listBoxCommand.SelectedIndexChanged += new EventHandler(this.listBoxCommand_SelectedIndexChanged);
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainerRightTopBottom";
			splitContainer2.Orientation = Orientation.Horizontal;
			splitContainer2.Panel1.Controls.Add(this.groupBoxServer);
			splitContainer2.Panel2.Controls.Add(this.groupBoxArgList);
			splitContainer2.Size = new Size(340, 291);
			splitContainer2.SplitterDistance = 66;
			splitContainer2.TabIndex = 0;
			this.groupBoxServer.Controls.Add(this.checkedListBoxServer);
			this.groupBoxServer.Dock = DockStyle.Fill;
			this.groupBoxServer.Location = new Point(0, 0);
			this.groupBoxServer.Name = "groupBoxServer";
			this.groupBoxServer.Size = new Size(340, 66);
			this.groupBoxServer.TabIndex = 4;
			this.groupBoxServer.TabStop = false;
			this.groupBoxServer.Text = "Server group";
			this.checkedListBoxServer.CheckOnClick = true;
			this.checkedListBoxServer.Dock = DockStyle.Fill;
			this.checkedListBoxServer.FormattingEnabled = true;
			this.checkedListBoxServer.Location = new Point(3, 17);
			this.checkedListBoxServer.Name = "checkedListBoxServer";
			this.checkedListBoxServer.Size = new Size(334, 36);
			this.checkedListBoxServer.TabIndex = 0;
			this.groupBoxArgList.Controls.Add(this.panelArgList);
			this.groupBoxArgList.Dock = DockStyle.Fill;
			this.groupBoxArgList.Location = new Point(0, 0);
			this.groupBoxArgList.Name = "groupBoxArgList";
			this.groupBoxArgList.Size = new Size(340, 221);
			this.groupBoxArgList.TabIndex = 6;
			this.groupBoxArgList.TabStop = false;
			this.groupBoxArgList.Text = "Execution factor";
			this.panelArgList.Dock = DockStyle.Fill;
			this.panelArgList.Location = new Point(3, 17);
			this.panelArgList.Name = "panelArgList";
			this.panelArgList.Size = new Size(334, 201);
			this.panelArgList.TabIndex = 0;
			this.panelMid.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelMid.BackColor = Color.Transparent;
			this.panelMid.Controls.Add(splitContainer);
			this.panelMid.Location = new Point(6, 35);
			this.panelMid.Name = "panelMid";
			this.panelMid.Size = new Size(530, 291);
			this.panelMid.TabIndex = 0;
			this.panelBottom.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelBottom.BackColor = SystemColors.Control;
			this.panelBottom.Controls.Add(this.dateTimePicker);
			this.panelBottom.Controls.Add(this.checkSchedule);
			this.panelBottom.Controls.Add(this.buttonCancel);
			this.panelBottom.Controls.Add(this.buttonOK);
			this.panelBottom.Location = new Point(0, 332);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new Size(542, 49);
			this.panelBottom.TabIndex = 1;
			this.dateTimePicker.CustomFormat = "yyyy-MM-dd dddd HH:mm";
			this.dateTimePicker.Enabled = false;
			this.dateTimePicker.Format = DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new Point(57, 13);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new Size(171, 21);
			this.dateTimePicker.TabIndex = 9;
			this.checkSchedule.AutoSize = true;
			this.checkSchedule.Location = new Point(9, 15);
			this.checkSchedule.Name = "checkSchedule";
			this.checkSchedule.Size = new Size(48, 16);
			this.checkSchedule.TabIndex = 8;
			this.checkSchedule.Text = "reservation";
			this.checkSchedule.UseVisualStyleBackColor = true;
			this.checkSchedule.CheckedChanged += new EventHandler(this.checkSchedule_CheckedChanged);
			this.buttonCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.buttonCancel.DialogResult = DialogResult.Cancel;
			this.buttonCancel.Location = new Point(434, 8);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new Size(96, 29);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "cancel";
			this.buttonOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.buttonOK.FlatAppearance.BorderSize = 0;
			this.buttonOK.Location = new Point(332, 8);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new Size(96, 29);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.Text = "Execution";
			this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
			this.panelTop.BackColor = SystemColors.Control;
			this.panelTop.Controls.Add(this.textBox1);
			this.panelTop.Dock = DockStyle.Top;
			this.panelTop.Location = new Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new Size(542, 29);
			this.panelTop.TabIndex = 2;
			this.textBox1.BorderStyle = BorderStyle.None;
			this.textBox1.Cursor = Cursors.Default;
			this.textBox1.Location = new Point(9, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new Size(411, 25);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "The commands here apply to the entire server family..\r\nThe command is set in a process with the CommandBridge attribute.";
			this.panelSchdule.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panelSchdule.AutoSize = true;
			this.panelSchdule.BackColor = SystemColors.Window;
			this.panelSchdule.Location = new Point(0, 380);
			this.panelSchdule.Name = "panelSchdule";
			this.panelSchdule.Size = new Size(542, 10);
			this.panelSchdule.TabIndex = 3;
			base.AutoScaleDimensions = new SizeF(7f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Window;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new Size(542, 388);
			base.Controls.Add(this.panelSchdule);
			base.Controls.Add(this.panelTop);
			base.Controls.Add(this.panelBottom);
			base.Controls.Add(this.panelMid);
			base.Name = "ServerCommandForm";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Choose a server command.";
			splitContainer.Panel1.ResumeLayout(false);
			splitContainer.Panel2.ResumeLayout(false);
			splitContainer.ResumeLayout(false);
			this.groupBoxCommand.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			splitContainer2.ResumeLayout(false);
			this.groupBoxServer.ResumeLayout(false);
			this.groupBoxArgList.ResumeLayout(false);
			this.panelMid.ResumeLayout(false);
			this.panelBottom.ResumeLayout(false);
			this.panelBottom.PerformLayout();
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		//private global::System.ComponentModel.IContainer components;

		private GroupBox groupBoxCommand;

		private ListBox listBoxCommand;

		private GroupBox groupBoxServer;

		private CheckedListBox checkedListBoxServer;

		private GroupBox groupBoxArgList;

		private Button buttonCancel;

		private Button buttonOK;

		private Panel panelArgList;

		private Panel panelTop;

		private TextBox textBox1;

		private Panel panelSchdule;

		private Panel panelMid;

		private Panel panelBottom;

		private CheckBox checkSchedule;

		private DateTimePicker dateTimePicker;
	}
}
