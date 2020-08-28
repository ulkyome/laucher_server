using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool.RCUser.GeneralManage
{
	public partial class AuthUserManage : Form
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
			this.TBoxID = new TextBox();
			this.TBoxPassword = new TextBox();
			this.TBoxRePassword = new TextBox();
			this.CBoxAuthLevel = new ComboBox();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.BtnOK = new Button();
			this.BtnCancel = new Button();
			base.SuspendLayout();
			this.TBoxID.Location = new Point(88, 8);
			this.TBoxID.MaxLength = 16;
			this.TBoxID.Name = "TBoxID";
			this.TBoxID.Size = new Size(192, 21);
			this.TBoxID.TabIndex = 0;
			this.TBoxID.Text = "";
			this.TBoxPassword.Location = new Point(88, 40);
			this.TBoxPassword.MaxLength = 16;
			this.TBoxPassword.Name = "TBoxPassword";
			this.TBoxPassword.PasswordChar = '*';
			this.TBoxPassword.Size = new Size(192, 21);
			this.TBoxPassword.TabIndex = 1;
			this.TBoxPassword.Text = "";
			this.TBoxRePassword.Location = new Point(88, 72);
			this.TBoxRePassword.MaxLength = 16;
			this.TBoxRePassword.Name = "TBoxRePassword";
			this.TBoxRePassword.PasswordChar = '*';
			this.TBoxRePassword.Size = new Size(192, 21);
			this.TBoxRePassword.TabIndex = 2;
			this.TBoxRePassword.Text = "";
			this.CBoxAuthLevel.DropDownStyle = ComboBoxStyle.DropDownList;
			this.CBoxAuthLevel.Location = new Point(88, 104);
			this.CBoxAuthLevel.Name = "CBoxAuthLevel";
			this.CBoxAuthLevel.Size = new Size(192, 20);
			this.CBoxAuthLevel.TabIndex = 3;
			this.label1.Location = new Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new Size(72, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "userID";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.label2.Location = new Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new Size(72, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "User password";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.label3.Location = new Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new Size(72, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password reconfirmation";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			this.label4.Location = new Point(8, 104);
			this.label4.Name = "label4";
			this.label4.Size = new Size(72, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "authority";
			this.label4.TextAlign = ContentAlignment.MiddleCenter;
			this.BtnOK.DialogResult = DialogResult.OK;
			this.BtnOK.Location = new Point(40, 136);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new Size(80, 24);
			this.BtnOK.TabIndex = 5;
			this.BtnOK.Text = "Confirm";
			this.BtnCancel.DialogResult = DialogResult.Cancel;
			this.BtnCancel.Location = new Point(168, 136);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new Size(80, 24);
			this.BtnCancel.TabIndex = 5;
			this.BtnCancel.Text = "cancel";
			base.AcceptButton = this.BtnOK;
			this.AutoScaleBaseSize = new Size(6, 14);
			base.CancelButton = this.BtnCancel;
			base.ClientSize = new Size(290, 167);
			base.Controls.AddRange(new Control[]
			{
				this.BtnOK,
				this.label1,
				this.CBoxAuthLevel,
				this.TBoxRePassword,
				this.TBoxPassword,
				this.TBoxID,
				this.label2,
				this.label3,
				this.label4,
				this.BtnCancel
			});
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AuthUserManage";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Add a new user.";
			base.ResumeLayout(false);
		}

		internal TextBox TBoxID;

		internal TextBox TBoxPassword;

		internal TextBox TBoxRePassword;

		internal ComboBox CBoxAuthLevel;

		private Label label1;

		private Label label2;

		private Label label3;

		private Label label4;

		private Button BtnOK;

		private Button BtnCancel;

		//private global::System.ComponentModel.Container components;
	}
}
