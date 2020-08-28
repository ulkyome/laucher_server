using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool.UserMonitorSystem
{
	public partial class UserAlarmForm : Form
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UserMonitorSystem.UserAlarmForm));
			this.ListLog = new ListView();
			this.clmnTime = new ColumnHeader();
			this.clmnDesc = new ColumnHeader();
			this.BtnOK = new Button();
			this.ChkSupress = new CheckBox();
			this.ComboMinute = new ComboBox();
			this.LabelDesc = new Label();
			this.EmergencyView = new ListView();
			this.Department = new ColumnHeader();
			this.Id = new ColumnHeader();
			this.CallName = new ColumnHeader();
			this.PhoneNumber = new ColumnHeader();
			this.Mail = new ColumnHeader();
			this.Rank = new ColumnHeader();
			this.EmergencyCallLabel = new Label();
			base.SuspendLayout();
			this.ListLog.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ListLog.Columns.AddRange(new ColumnHeader[]
			{
				this.clmnTime,
				this.clmnDesc
			});
			this.ListLog.Location = new Point(33, 37);
			this.ListLog.Name = "ListLog";
			this.ListLog.Size = new Size(612, 282);
			this.ListLog.TabIndex = 0;
			this.ListLog.UseCompatibleStateImageBehavior = false;
			this.ListLog.View = View.Details;
			this.clmnTime.Width = 103;
			this.clmnDesc.Width = 505;
			this.BtnOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.BtnOK.Location = new Point(602, 598);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new Size(75, 23);
			this.BtnOK.TabIndex = 1;
			this.BtnOK.Text = "button1";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new global::System.EventHandler(this.BtnOK_Click);
			this.ChkSupress.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.ChkSupress.AutoSize = true;
			this.ChkSupress.Location = new Point(12, 605);
			this.ChkSupress.Name = "ChkSupress";
			this.ChkSupress.Size = new Size(15, 14);
			this.ChkSupress.TabIndex = 2;
			this.ChkSupress.UseVisualStyleBackColor = true;
			this.ComboMinute.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.ComboMinute.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ComboMinute.FormattingEnabled = true;
			this.ComboMinute.Location = new Point(33, 600);
			this.ComboMinute.Name = "ComboMinute";
			this.ComboMinute.Size = new Size(55, 20);
			this.ComboMinute.TabIndex = 3;
			this.LabelDesc.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.LabelDesc.AutoSize = true;
			this.LabelDesc.Location = new Point(94, 603);
			this.LabelDesc.Name = "LabelDesc";
			this.LabelDesc.Size = new Size(53, 12);
			this.LabelDesc.TabIndex = 4;
			this.LabelDesc.Text = "Turn off the alarm";
			this.EmergencyView.Columns.AddRange(new ColumnHeader[]
			{
				this.Department,
				this.Id,
				this.CallName,
				this.PhoneNumber,
				this.Mail,
				this.Rank
			});
			this.EmergencyView.Location = new Point(33, 397);
			this.EmergencyView.Name = "EmergencyView";
			this.EmergencyView.Size = new Size(612, 197);
			this.EmergencyView.TabIndex = 5;
			this.EmergencyView.UseCompatibleStateImageBehavior = false;
			this.EmergencyView.View = View.Details;
			this.Department.Width = 91;
			this.Id.Width = 74;
			this.CallName.Width = 71;
			this.PhoneNumber.Width = 137;
			this.Mail.Width = 148;
			this.Rank.Width = 85;
			this.EmergencyCallLabel.AutoSize = true;
			this.EmergencyCallLabel.Font = new Font("Roll", 18f, FontStyle.Regular, GraphicsUnit.Point, 129);
			this.EmergencyCallLabel.Location = new Point(36, 361);
			this.EmergencyCallLabel.Name = "EmergencyCallLabel";
			this.EmergencyCallLabel.Size = new Size(130, 24);
			this.EmergencyCallLabel.TabIndex = 6;
			this.EmergencyCallLabel.Text = "Emergency contact network";
			base.AcceptButton = this.BtnOK;
			base.AutoScaleDimensions = new SizeF(7f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.DarkRed;
			base.ClientSize = new Size(689, 630);
			base.Controls.Add(this.EmergencyCallLabel);
			base.Controls.Add(this.EmergencyView);
			base.Controls.Add(this.LabelDesc);
			base.Controls.Add(this.ComboMinute);
			base.Controls.Add(this.ChkSupress);
			base.Controls.Add(this.BtnOK);
			base.Controls.Add(this.ListLog);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			
			base.Icon = Icon;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UserAlarmForm";
			base.SizeGripStyle = SizeGripStyle.Show;
			this.Text = "Warning window";
			base.TopMost = true;
			base.FormClosing += new FormClosingEventHandler(this.UserAlarmForm_FormClosing);
			base.VisibleChanged += new EventHandler(this.UserAlarmForm_VisibleChanged);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		//private global::System.ComponentModel.IContainer components;

		private ListView ListLog;

		private Button BtnOK;

		private CheckBox ChkSupress;

		private ComboBox ComboMinute;

		private Label LabelDesc;

		private ColumnHeader clmnTime;

		private ColumnHeader clmnDesc;

		private ListView EmergencyView;

		private ColumnHeader Department;

		private ColumnHeader Id;

		private ColumnHeader CallName;

		private ColumnHeader PhoneNumber;

		private ColumnHeader Mail;

		private ColumnHeader Rank;

		private Label EmergencyCallLabel;
	}
}
