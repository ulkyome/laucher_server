using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool
{
	public partial class MainForm : Form
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
			this.toolStripStatusAlarm = new ToolStripStatusLabel();
			this.MainMenuOpTool = new MainMenu(this.components);
			this.menuItem1 = new MenuItem();
			this.MenuItemAboutMe = new MenuItem();
			this.menuItem3 = new MenuItem();
			this.MenuItemClose = new MenuItem();
			this.menuItem5 = new MenuItem();
			this.MenuItemUser = new MenuItem();
			this.menuItem4 = new MenuItem();
			this.MenuItemHelp = new MenuItem();
			this.imageListToolIcon = new ImageList(this.components);
			this.toolStrip = new ToolStrip();
			this.TSBUser = new ToolStripButton();
			this.TSBServer = new ToolStripButton();
			StatusStrip statusStrip = new StatusStrip();
			ToolStripStatusLabel toolStripStatusLabel = new ToolStripStatusLabel();
			statusStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			statusStrip.Items.AddRange(new ToolStripItem[]
			{
				toolStripStatusLabel,
				this.toolStripStatusAlarm
			});
			statusStrip.Location = new Point(0, 678);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(1016, 22);
			statusStrip.TabIndex = 2;
			statusStrip.Text = "statusStrip1";
			toolStripStatusLabel.Name = "toolStripStatusLabel1";
			toolStripStatusLabel.Size = new Size(985, 17);
			toolStripStatusLabel.Spring = true;
			this.toolStripStatusAlarm.BorderStyle = Border3DStyle.SunkenInner;
			this.toolStripStatusAlarm.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripStatusAlarm.Image = Properties.Resources.alarmon;
			this.toolStripStatusAlarm.ImageTransparentColor = Color.White;
			this.toolStripStatusAlarm.Name = "toolStripStatusAlarm";
			this.toolStripStatusAlarm.Size = new Size(16, 17);
			this.toolStripStatusAlarm.Text = "alarm";
			this.toolStripStatusAlarm.ToolTipText = "Turn the alarm on or off.";
			this.toolStripStatusAlarm.Click += new EventHandler(this.toolStripStatusAlarm_Click);
			this.MainMenuOpTool.MenuItems.AddRange(new MenuItem[]
			{
				this.menuItem1,
				this.menuItem5,
				this.menuItem4
			});
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new MenuItem[]
			{
				this.MenuItemAboutMe,
				this.menuItem3,
				this.MenuItemClose
			});
			this.menuItem1.Text = "File (F)";
			this.MenuItemAboutMe.Index = 0;
			this.MenuItemAboutMe.Text = "My info (A)";
			this.MenuItemAboutMe.Click += new EventHandler(this.MenuItemAboutMe_Click);
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			this.MenuItemClose.Index = 2;
			this.MenuItemClose.Text = "Exit(X)";
			this.MenuItemClose.Click += new EventHandler(this.MenuItemClose_Click);
			this.menuItem5.Index = 1;
			this.menuItem5.MenuItems.AddRange(new MenuItem[]
			{
				this.MenuItemUser
			});
			this.menuItem5.Text = "Management(M)";
			this.MenuItemUser.Index = 0;
			this.MenuItemUser.Text = "Operation tool user management(U)";
			this.MenuItemUser.Click += new EventHandler(this.MenuItemUser_Click);
			this.menuItem4.Index = 2;
			this.menuItem4.MenuItems.AddRange(new MenuItem[]
			{
				this.MenuItemHelp
			});
			this.menuItem4.Text = "Help(H)";
			this.MenuItemHelp.Index = 0;
			this.MenuItemHelp.Shortcut = Shortcut.F1;
			this.MenuItemHelp.Text = "Help(H)";
			this.MenuItemHelp.Click += new EventHandler(this.MenuItemHelp_Click);
			
			this.imageListToolIcon.ImageStream = imageListToolIcon.ImageStream;
			this.imageListToolIcon.TransparentColor = Color.White;
			//this.imageListToolIcon.Images.SetKeyName(0, "RCSControl.bmp");
			//this.imageListToolIcon.Images.SetKeyName(1, "UserMonitor.bmp");
			this.toolStrip.BackColor = SystemColors.Control;
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[]
			{
				this.TSBServer,
				this.TSBUser
			});
			this.toolStrip.Location = new Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size(1016, 25);
			this.toolStrip.TabIndex = 4;
			this.toolStrip.Text = "toolStrip1";
			this.TSBUser.AutoSize = false;
			this.TSBUser.BackColor = SystemColors.Control;
			this.TSBUser.Image = Properties.Resources.TSBUser_Image;
			this.TSBUser.ImageTransparentColor = Color.White;
			this.TSBUser.Name = "TSBUser";
			this.TSBUser.Size = new Size(83, 22);
			this.TSBUser.Text = "User situation";
			this.TSBUser.Click += new EventHandler(this.TSBUser_Click);
			this.TSBServer.AutoSize = false;
			this.TSBServer.BackColor = SystemColors.Control;
			this.TSBServer.Image = Properties.Resources.TSBServer_Image;
			this.TSBServer.ImageTransparentColor = Color.White;
			this.TSBServer.Name = "TSBServer";
			this.TSBServer.Size = new Size(83, 22);
			this.TSBServer.Text = "Server status";
			this.TSBServer.Click += new EventHandler(this.TSBServer_Click);
			this.AutoScaleBaseSize = new Size(6, 14);
			base.ClientSize = new Size(1016, 700);
			base.Controls.Add(this.toolStrip);
			base.Controls.Add(statusStrip);
			base.Icon = Properties.Resources.this_Icon;
			base.IsMdiContainer = true;
			base.Menu = this.MainMenuOpTool;
			base.Name = "MainForm";
			this.Text = "Hero War Operation Tool";
			base.MdiChildActivate += new EventHandler(this.MainForm_MdiChildActivate);
			base.Closing += new CancelEventHandler(this.MainForm_Closing);
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private IContainer components;

		private MainMenu MainMenuOpTool;

		private MenuItem menuItem1;

		private MenuItem MenuItemAboutMe;

		private MenuItem menuItem3;

		private MenuItem MenuItemClose;

		private MenuItem menuItem5;

		private MenuItem MenuItemUser;

		private MenuItem menuItem4;

		private MenuItem MenuItemHelp;

		private ImageList imageListToolIcon;

		private ToolStripStatusLabel toolStripStatusAlarm;

		private ToolStrip toolStrip;

		private ToolStripButton TSBUser;

		private ToolStripButton TSBServer;
	}
}
