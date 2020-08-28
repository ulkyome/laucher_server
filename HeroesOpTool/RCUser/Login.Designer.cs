using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool.RCUser
{
	public partial class Login : Form
	{
	//	protected override void Dispose(bool disposing)
	//	{
	//		if (disposing && this.components != null)
	//		{
	//			this.components.Dispose();
	//		}
	//		base.Dispose(disposing);
	//	}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RCUser.Login));
			this.TBoxID = new TextBox();
			this.label1 = new Label();
			this.label2 = new Label();
			this.TBoxPasswd = new TextBox();
			this.BtnLogin = new Button();
			this.BtnExit = new Button();
			this.LbVersion = new Label();
			base.SuspendLayout();
			this.TBoxID.BackColor = Color.White;
			this.TBoxID.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.TBoxID.Location = new Point(128, 104);
			this.TBoxID.MaxLength = 16;
			this.TBoxID.Name = "TBoxID";
			this.TBoxID.Size = new Size(112, 22);
			this.TBoxID.TabIndex = 0;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(56, 104);
			this.label1.Name = "label1";
			this.label1.Size = new Size(64, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(56, 136);
			this.label2.Name = "label2";
			this.label2.Size = new Size(64, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.TBoxPasswd.BackColor = Color.White;
			this.TBoxPasswd.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.TBoxPasswd.Location = new Point(128, 136);
			this.TBoxPasswd.MaxLength = 16;
			this.TBoxPasswd.Name = "TBoxPasswd";
			this.TBoxPasswd.PasswordChar = '*';
			this.TBoxPasswd.Size = new Size(112, 22);
			this.TBoxPasswd.TabIndex = 0;
			this.BtnLogin.BackColor = Color.Transparent;
			this.BtnLogin.FlatStyle = FlatStyle.Popup;
			this.BtnLogin.Location = new Point(184, 168);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new Size(48, 24);
			this.BtnLogin.TabIndex = 2;
			this.BtnLogin.Text = "Login";
			this.BtnLogin.UseVisualStyleBackColor = false;
			this.BtnLogin.Click += new EventHandler(this.BtnLogin_Click);
			this.BtnExit.BackColor = Color.Transparent;
			this.BtnExit.DialogResult = DialogResult.Cancel;
			this.BtnExit.FlatStyle = FlatStyle.Popup;
			this.BtnExit.Location = new Point(240, 168);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new Size(48, 24);
			this.BtnExit.TabIndex = 2;
			this.BtnExit.Text = "Exit";
			this.BtnExit.UseVisualStyleBackColor = false;
			this.LbVersion.AutoSize = true;
			this.LbVersion.BackColor = Color.Transparent;
			this.LbVersion.Location = new Point(12, 173);
			this.LbVersion.Name = "LbVersion";
			this.LbVersion.Size = new Size(32, 14);
			this.LbVersion.TabIndex = 3;
			this.LbVersion.Text = "Build";
			this.LbVersion.TextAlign = ContentAlignment.MiddleLeft;
			base.AcceptButton = this.BtnLogin;
			this.AutoScaleBaseSize = new Size(6, 15);
			this.BackgroundImage = BackgroundImage;
			base.CancelButton = this.BtnExit;
			base.ClientSize = new Size(300, 200);
			base.Controls.Add(this.LbVersion);
			base.Controls.Add(this.BtnLogin);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.TBoxID);
			base.Controls.Add(this.TBoxPasswd);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.BtnExit);
			this.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = Icon;
			base.MaximizeBox = false;
			base.Name = "Login";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "HeroesOpTool Login";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		//private global::System.ComponentModel.IContainer components;

		private TextBox TBoxID;

		private Label label1;

		private Label label2;

		private TextBox TBoxPasswd;

		private Button BtnLogin;

		private Button BtnExit;

		private Label LbVersion;
	}
}
