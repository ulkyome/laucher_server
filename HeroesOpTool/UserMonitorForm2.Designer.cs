namespace HeroesOpTool
{
	public partial class UserMonitorForm2 : global::System.Windows.Forms.Form
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
            this.TSComboStyle = new System.Windows.Forms.ToolStripComboBox();
            this.TSButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSComboStyle
            // 
            this.TSComboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSComboStyle.Name = "TSComboStyle";
            this.TSComboStyle.Size = new System.Drawing.Size(101, 25);
            this.TSComboStyle.SelectedIndexChanged += new System.EventHandler(this.TSComboStyle_SelectedIndexChanged);
            // 
            // TSButtonCopy
            // 
            this.TSButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSButtonCopy.Image = global::HeroesOpTool.Properties.Resources.TSButtonCopy_Image;
            this.TSButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSButtonCopy.Name = "TSButtonCopy";
            this.TSButtonCopy.Size = new System.Drawing.Size(23, 22);
            this.TSButtonCopy.Click += new System.EventHandler(this.TSButtonCopy_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(0, 26);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(792, 547);
            this.panel.TabIndex = 4;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSComboStyle,
            this.TSButtonCopy});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(792, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip";
            // 
            // UserMonitorForm2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel);
            this.Name = "UserMonitorForm2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMonitorForm2_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		//private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Panel panel;

		private global::System.Windows.Forms.ToolStripComboBox TSComboStyle;

		private global::System.Windows.Forms.ToolStripButton TSButtonCopy;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}
