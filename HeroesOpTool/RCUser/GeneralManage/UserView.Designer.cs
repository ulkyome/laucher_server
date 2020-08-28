using System;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool.RCUser.GeneralManage
{
	public partial class UserView : Form
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
            this.LViewUsers = new ListView();
            this.UserId = new ColumnHeader();
            this.UserAuthority = new ColumnHeader();
            this.BtnAddUser = new Button();
            this.BtnRemoveUser = new Button();
            this.panel1 = new Panel();
            this.BtnChangeUser = new Button();
            this.BtnOK = new Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LViewUsers
            // 
            this.LViewUsers.AllowColumnReorder = true;
            this.LViewUsers.AutoArrange = false;
            this.LViewUsers.Columns.AddRange(new ColumnHeader[] {
            this.UserId,
            this.UserAuthority});
            this.LViewUsers.Dock = DockStyle.Fill;
            this.LViewUsers.FullRowSelect = true;
            this.LViewUsers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.LViewUsers.HideSelection = false;
            this.LViewUsers.Location = new Point(0, 0);
            this.LViewUsers.MultiSelect = false;
            this.LViewUsers.Name = "LViewUsers";
            this.LViewUsers.Size = new Size(258, 165);
            this.LViewUsers.TabIndex = 0;
            this.LViewUsers.UseCompatibleStateImageBehavior = false;
            this.LViewUsers.View = View.Details;
            this.LViewUsers.SelectedIndexChanged += new EventHandler(this.LViewUsers_SelectedIndexChanged);
            this.LViewUsers.DoubleClick += new EventHandler(this.LViewUsers_DoubleClick);
            // 
            // UserId
            // 
            this.UserId.Text = "user ID";
            this.UserId.Width = 120;
            // 
            // UserAuthority
            // 
            this.UserAuthority.Text = "User rights";
            this.UserAuthority.Width = 120;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Anchor = AnchorStyles.None;
            this.BtnAddUser.Location = new Point(35, 7);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new Size(87, 23);
            this.BtnAddUser.TabIndex = 1;
            this.BtnAddUser.Text = "Add user";
            this.BtnAddUser.Click += new EventHandler(this.BtnAddUser_Click);
            // 
            // BtnRemoveUser
            // 
            this.BtnRemoveUser.Anchor = AnchorStyles.None;
            this.BtnRemoveUser.Location = new Point(135, 7);
            this.BtnRemoveUser.Name = "BtnRemoveUser";
            this.BtnRemoveUser.Size = new Size(87, 23);
            this.BtnRemoveUser.TabIndex = 2;
            this.BtnRemoveUser.Text = "Delete user";
            this.BtnRemoveUser.Click += new EventHandler(this.BtnRemoveUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAddUser);
            this.panel1.Controls.Add(this.BtnRemoveUser);
            this.panel1.Controls.Add(this.BtnChangeUser);
            this.panel1.Controls.Add(this.BtnOK);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(258, 66);
            this.panel1.TabIndex = 4;
            // 
            // BtnChangeUser
            // 
            this.BtnChangeUser.Anchor = AnchorStyles.None;
            this.BtnChangeUser.Location = new Point(35, 37);
            this.BtnChangeUser.Name = "BtnChangeUser";
            this.BtnChangeUser.Size = new Size(87, 22);
            this.BtnChangeUser.TabIndex = 3;
            this.BtnChangeUser.Text = "User change";
            this.BtnChangeUser.Click += new EventHandler(this.BtnChangeUser_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = AnchorStyles.None;
            this.BtnOK.DialogResult = DialogResult.Cancel;
            this.BtnOK.Location = new Point(135, 37);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new Size(87, 22);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "Confirm";
            this.BtnOK.Click += new EventHandler(this.BtnOK_Click);
            // 
            // UserView
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleBaseSize = new Size(5, 13);
            this.CancelButton = this.BtnOK;
            this.ClientSize = new Size(258, 231);
            this.Controls.Add(this.LViewUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserView";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "User view";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private Panel panel1;

		private ListView LViewUsers;

		private Button BtnAddUser;

		private Button BtnRemoveUser;

		private ColumnHeader UserId;

		private ColumnHeader UserAuthority;

		private Button BtnChangeUser;

		private Button BtnOK;

		//private global::System.ComponentModel.Container components;
	}
}
