using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace HeroesOpTool
{
	public partial class ServerMonitorForm : Form
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
			ResourceManager resourceManager = new ResourceManager(typeof(ServerMonitorForm));
			this.mainMenu1 = new MainMenu();
			this.menuItem1 = new MenuItem();
			this.menuItemControl = new MenuItem();
			this.mainMenu1.MenuItems.AddRange(new MenuItem[]
			{
				this.menuItem1
			});
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new MenuItem[]
			{
				this.menuItemControl
			});
			this.menuItem1.Text = "Server monitoring menu";
			this.menuItemControl.Index = 0;
			this.menuItemControl.Shortcut = Shortcut.F10;
			this.menuItemControl.Text = "Preferences";
			this.menuItemControl.Click += new EventHandler(this.menuItemControl_Click);
			this.AutoScaleBaseSize = new Size(6, 14);
			base.ClientSize = new Size(792, 573);
			
			base.Icon = Properties.Resources.this_Icon;
			base.Menu = this.mainMenu1;
			base.Name = "ServerMonitorForm";
			this.Text = "Server monitoring window";
		}

		private MainMenu mainMenu1;

		private MenuItem menuItem1;

		private MenuItem menuItemControl;

		//private global::System.ComponentModel.Container components;
	}
}
