namespace HeroesOpTool.RCUser.ServerMonitorSystem.SystemManage
{
	public partial class RemoteControlSystemManager : global::System.Windows.Forms.Form
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRCCControl = new System.Windows.Forms.TabPage();
            this.tabPageWorkGroupControl = new System.Windows.Forms.TabPage();
            this.tabPageServerGroupControl = new System.Windows.Forms.TabPage();
            this.tabPageProcessTemplate = new System.Windows.Forms.TabPage();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageRCCControl);
            this.tabControl.Controls.Add(this.tabPageWorkGroupControl);
            this.tabControl.Controls.Add(this.tabPageServerGroupControl);
            this.tabControl.Controls.Add(this.tabPageProcessTemplate);
            this.tabControl.Location = new System.Drawing.Point(7, 7);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(618, 411);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageRCCControl
            // 
            this.tabPageRCCControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageRCCControl.Name = "tabPageRCCControl";
            this.tabPageRCCControl.Size = new System.Drawing.Size(610, 385);
            this.tabPageRCCControl.TabIndex = 0;
            this.tabPageRCCControl.Text = "Remote control computer management";
            this.tabPageRCCControl.UseVisualStyleBackColor = true;
            // 
            // tabPageWorkGroupControl
            // 
            this.tabPageWorkGroupControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkGroupControl.Name = "tabPageWorkGroupControl";
            this.tabPageWorkGroupControl.Size = new System.Drawing.Size(610, 385);
            this.tabPageWorkGroupControl.TabIndex = 1;
            this.tabPageWorkGroupControl.Text = "Workgroup management";
            this.tabPageWorkGroupControl.UseVisualStyleBackColor = true;
            // 
            // tabPageServerGroupControl
            // 
            this.tabPageServerGroupControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageServerGroupControl.Name = "tabPageServerGroupControl";
            this.tabPageServerGroupControl.Size = new System.Drawing.Size(610, 385);
            this.tabPageServerGroupControl.TabIndex = 3;
            this.tabPageServerGroupControl.Text = "Server Group Management";
            this.tabPageServerGroupControl.UseVisualStyleBackColor = true;
            // 
            // tabPageProcessTemplate
            // 
            this.tabPageProcessTemplate.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcessTemplate.Name = "tabPageProcessTemplate";
            this.tabPageProcessTemplate.Size = new System.Drawing.Size(610, 385);
            this.tabPageProcessTemplate.TabIndex = 2;
            this.tabPageProcessTemplate.Text = "Program template management";
            this.tabPageProcessTemplate.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(452, 426);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 21);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "Confirm";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(545, 426);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 21);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "cancel";
            // 
            // RemoteControlSystemManager
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.MinimizeBox = false;
            this.Name = "RemoteControlSystemManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remote control system manager";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.RemoteControlSystemManager_Closing);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private global::System.Windows.Forms.TabControl tabControl;

		private global::System.Windows.Forms.TabPage tabPageWorkGroupControl;

		private global::System.Windows.Forms.TabPage tabPageProcessTemplate;

		private global::System.Windows.Forms.TabPage tabPageRCCControl;

		private global::System.Windows.Forms.Button buttonOK;

		private global::System.Windows.Forms.Button buttonCancel;

		private global::HeroesOpTool.RCUser.ServerMonitorSystem.SystemManage.RCClientControl rcClientControl;

		private global::HeroesOpTool.RCUser.ServerMonitorSystem.SystemManage.WorkGroupControl workGroupControl;

		private global::HeroesOpTool.RCUser.ServerMonitorSystem.SystemManage.ServerGroupControl serverGroupControl;

		private global::HeroesOpTool.RCUser.ServerMonitorSystem.SystemManage.ProcessTemplateControl processTemplateControl;

		private global::System.Windows.Forms.TabPage tabPageServerGroupControl;

		//private global::System.ComponentModel.Container components;
	}
}
