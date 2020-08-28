using System;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool
{
	public partial class UserMonitorForm2 : Form
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
            this.TSComboStyle = new ToolStripComboBox();
            this.TSButtonCopy = new ToolStripButton();
            this.panel = new Panel();
            this.toolStrip = new ToolStrip();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSComboStyle
            // 
            this.TSComboStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            this.TSComboStyle.Name = "TSComboStyle";
            this.TSComboStyle.Size = new Size(101, 25);
            this.TSComboStyle.SelectedIndexChanged += new EventHandler(this.TSComboStyle_SelectedIndexChanged);
            // 
            // TSButtonCopy
            // 
            this.TSButtonCopy.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.TSButtonCopy.Image = Properties.Resources.TSButtonCopy_Image;
            this.TSButtonCopy.ImageTransparentColor = Color.Magenta;
            this.TSButtonCopy.Name = "TSButtonCopy";
            this.TSButtonCopy.Size = new Size(23, 22);
            this.TSButtonCopy.Click += new EventHandler(this.TSButtonCopy_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BackColor = SystemColors.AppWorkspace;
            this.panel.BorderStyle = BorderStyle.Fixed3D;
            this.panel.Location = new Point(0, 26);
            this.panel.Name = "panel";
            this.panel.Size = new Size(792, 547);
            this.panel.TabIndex = 4;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new ToolStripItem[] {
            this.TSComboStyle,
            this.TSButtonCopy});
            this.toolStrip.Location = new Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new Size(792, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip";
            // 
            // UserMonitorForm2
            // 
            this.AutoScaleBaseSize = new Size(5, 13);
            this.BackColor = SystemColors.Control;
            this.ClientSize = new Size(792, 573);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel);
            this.Name = "UserMonitorForm2";
            this.FormClosing += new FormClosingEventHandler(this.UserMonitorForm2_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		//private global::System.ComponentModel.IContainer components;

		private Panel panel;

		private ToolStripComboBox TSComboStyle;

		private ToolStripButton TSButtonCopy;
        private ToolStrip toolStrip;
    }
}
