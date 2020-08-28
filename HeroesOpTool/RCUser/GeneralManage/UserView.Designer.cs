namespace HeroesOpTool.RCUser.GeneralManage
{
	public partial class UserView : global::System.Windows.Forms.Form
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
            this.LViewUsers = new System.Windows.Forms.ListView();
            this.UserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserAuthority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.BtnRemoveUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnChangeUser = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LViewUsers
            // 
            this.LViewUsers.AllowColumnReorder = true;
            this.LViewUsers.AutoArrange = false;
            this.LViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserId,
            this.UserAuthority});
            this.LViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LViewUsers.FullRowSelect = true;
            this.LViewUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LViewUsers.HideSelection = false;
            this.LViewUsers.Location = new System.Drawing.Point(0, 0);
            this.LViewUsers.MultiSelect = false;
            this.LViewUsers.Name = "LViewUsers";
            this.LViewUsers.Size = new System.Drawing.Size(258, 165);
            this.LViewUsers.TabIndex = 0;
            this.LViewUsers.UseCompatibleStateImageBehavior = false;
            this.LViewUsers.View = System.Windows.Forms.View.Details;
            this.LViewUsers.SelectedIndexChanged += new System.EventHandler(this.LViewUsers_SelectedIndexChanged);
            this.LViewUsers.DoubleClick += new System.EventHandler(this.LViewUsers_DoubleClick);
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
            this.BtnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddUser.Location = new System.Drawing.Point(35, 7);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(87, 23);
            this.BtnAddUser.TabIndex = 1;
            this.BtnAddUser.Text = "Add user";
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnRemoveUser
            // 
            this.BtnRemoveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRemoveUser.Location = new System.Drawing.Point(135, 7);
            this.BtnRemoveUser.Name = "BtnRemoveUser";
            this.BtnRemoveUser.Size = new System.Drawing.Size(87, 23);
            this.BtnRemoveUser.TabIndex = 2;
            this.BtnRemoveUser.Text = "Delete user";
            this.BtnRemoveUser.Click += new System.EventHandler(this.BtnRemoveUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAddUser);
            this.panel1.Controls.Add(this.BtnRemoveUser);
            this.panel1.Controls.Add(this.BtnChangeUser);
            this.panel1.Controls.Add(this.BtnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 66);
            this.panel1.TabIndex = 4;
            // 
            // BtnChangeUser
            // 
            this.BtnChangeUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnChangeUser.Location = new System.Drawing.Point(35, 37);
            this.BtnChangeUser.Name = "BtnChangeUser";
            this.BtnChangeUser.Size = new System.Drawing.Size(87, 22);
            this.BtnChangeUser.TabIndex = 3;
            this.BtnChangeUser.Text = "User change";
            this.BtnChangeUser.Click += new System.EventHandler(this.BtnChangeUser_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnOK.Location = new System.Drawing.Point(135, 37);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(87, 22);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "Confirm";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // UserView
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.BtnOK;
            this.ClientSize = new System.Drawing.Size(258, 231);
            this.Controls.Add(this.LViewUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User view";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private global::System.Windows.Forms.Panel panel1;

		private global::System.Windows.Forms.ListView LViewUsers;

		private global::System.Windows.Forms.Button BtnAddUser;

		private global::System.Windows.Forms.Button BtnRemoveUser;

		private global::System.Windows.Forms.ColumnHeader UserId;

		private global::System.Windows.Forms.ColumnHeader UserAuthority;

		private global::System.Windows.Forms.Button BtnChangeUser;

		private global::System.Windows.Forms.Button BtnOK;

		//private global::System.ComponentModel.Container components;
	}
}
