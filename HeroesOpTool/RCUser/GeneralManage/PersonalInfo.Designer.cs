using System;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool.RCUser.GeneralManage
{
	public partial class PersonalInfo : Form
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
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.TBoxOldPassword = new TextBox();
			this.TBoxNewPassword = new TextBox();
			this.TBoxRePassword = new TextBox();
			this.BtnOK = new Button();
			this.BtnCancel = new Button();
			this.LabelID = new Label();
			this.LabelAuth = new Label();
			base.SuspendLayout();
			this.label1.Location = new Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new Size(88, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Your ID";
			this.label1.TextAlign = ContentAlignment.MiddleLeft;
			this.label2.Location = new Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new Size(88, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Your authority";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			this.label3.Location = new Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new Size(64, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Current password";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
			this.label4.Location = new Point(16, 80);
			this.label4.Name = "label4";
			this.label4.Size = new Size(64, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "New password";
			this.label4.TextAlign = ContentAlignment.MiddleRight;
			this.label5.Location = new Point(16, 112);
			this.label5.Name = "label5";
			this.label5.Size = new Size(64, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "Confirm password";
			this.label5.TextAlign = ContentAlignment.MiddleRight;
			this.TBoxOldPassword.Location = new Point(88, 48);
			this.TBoxOldPassword.MaxLength = 16;
			this.TBoxOldPassword.Name = "TBoxOldPassword";
			this.TBoxOldPassword.PasswordChar = '*';
			this.TBoxOldPassword.Size = new Size(184, 21);
			this.TBoxOldPassword.TabIndex = 1;
			this.TBoxOldPassword.Text = "";
			this.TBoxOldPassword.TextChanged += new EventHandler(this.TBoxOldPassword_TextChanged);
			this.TBoxNewPassword.Enabled = false;
			this.TBoxNewPassword.Location = new Point(88, 80);
			this.TBoxNewPassword.MaxLength = 16;
			this.TBoxNewPassword.Name = "TBoxNewPassword";
			this.TBoxNewPassword.PasswordChar = '*';
			this.TBoxNewPassword.Size = new Size(184, 21);
			this.TBoxNewPassword.TabIndex = 2;
			this.TBoxNewPassword.Text = "";
			this.TBoxRePassword.Enabled = false;
			this.TBoxRePassword.Location = new Point(88, 112);
			this.TBoxRePassword.MaxLength = 16;
			this.TBoxRePassword.Name = "TBoxRePassword";
			this.TBoxRePassword.PasswordChar = '*';
			this.TBoxRePassword.Size = new Size(184, 21);
			this.TBoxRePassword.TabIndex = 3;
			this.TBoxRePassword.Text = "";
			this.BtnOK.DialogResult = DialogResult.OK;
			this.BtnOK.Location = new Point(40, 152);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new Size(88, 24);
			this.BtnOK.TabIndex = 4;
			this.BtnOK.Text = "Confirm";
			this.BtnCancel.DialogResult = DialogResult.Cancel;
			this.BtnCancel.Location = new Point(160, 152);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new Size(88, 24);
			this.BtnCancel.TabIndex = 4;
			this.BtnCancel.Text = "cancel";
			this.LabelID.Location = new Point(120, 8);
			this.LabelID.Name = "LabelID";
			this.LabelID.Size = new Size(152, 16);
			this.LabelID.TabIndex = 5;
			this.LabelID.TextAlign = ContentAlignment.MiddleCenter;
			this.LabelAuth.Location = new Point(120, 24);
			this.LabelAuth.Name = "LabelAuth";
			this.LabelAuth.Size = new Size(152, 16);
			this.LabelAuth.TabIndex = 5;
			this.LabelAuth.TextAlign = ContentAlignment.MiddleCenter;
			base.AcceptButton = this.BtnOK;
			this.AutoScaleBaseSize = new Size(6, 14);
			base.CancelButton = this.BtnCancel;
			base.ClientSize = new Size(292, 183);
			base.Controls.AddRange(new Control[]
			{
				this.LabelID,
				this.BtnOK,
				this.TBoxRePassword,
				this.TBoxNewPassword,
				this.TBoxOldPassword,
				this.label1,
				this.label2,
				this.label3,
				this.label4,
				this.label5,
				this.BtnCancel,
				this.LabelAuth
			});
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PersonalInfo";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "My information";
			base.ResumeLayout(false);
		}

		private Label label3;

		private Label label4;

		private Label label5;

		internal TextBox TBoxOldPassword;

		internal TextBox TBoxNewPassword;

		internal TextBox TBoxRePassword;

		private Button BtnOK;

		private Button BtnCancel;

		private Label label1;

		private Label label2;

		private Label LabelID;

		private Label LabelAuth;

		//private global::System.ComponentModel.Container components;
	}
}
