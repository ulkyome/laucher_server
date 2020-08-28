using AxSHDocVw;
using System.ComponentModel;
using System.Windows.Forms;

namespace HeroesOpTool
{
	public partial class HelpViewer : Form
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
            this.components = new System.ComponentModel.Container();
            this.TViewHelpIndex = new TreeView();
            this.TreeIcons = new ImageList(this.components);
            this.splitter1 = new Splitter();
            this.SuspendLayout();
            // 
            // TViewHelpIndex
            // 
            this.TViewHelpIndex.Dock = DockStyle.Left;
            this.TViewHelpIndex.HideSelection = false;
            this.TViewHelpIndex.ImageIndex = 0;
            this.TViewHelpIndex.ImageList = this.TreeIcons;
            this.TViewHelpIndex.Indent = 19;
            this.TViewHelpIndex.Location = new System.Drawing.Point(0, 0);
            this.TViewHelpIndex.Name = "TViewHelpIndex";
            this.TViewHelpIndex.PathSeparator = ".";
            this.TViewHelpIndex.SelectedImageIndex = 0;
            this.TViewHelpIndex.Size = new System.Drawing.Size(153, 573);
            this.TViewHelpIndex.TabIndex = 0;
            this.TViewHelpIndex.AfterSelect += new TreeViewEventHandler(this.TViewHelpIndex_AfterSelect);
            // 
            // TreeIcons
            // 
            this.TreeIcons.ColorDepth = ColorDepth.Depth8Bit;
            this.TreeIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.TreeIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(153, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 573);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // HelpViewer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.TViewHelpIndex);
            this.Name = "HelpViewer";
            this.Text = "Help";
            this.ResumeLayout(false);

		}

		private TreeView TViewHelpIndex;

		private Splitter splitter1;

		private ImageList TreeIcons;

		private AxWebBrowser HtmlHelpContent;

		private IContainer components;
	}
}
