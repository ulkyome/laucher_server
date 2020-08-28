using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool
{
	public partial class ExeInfoForm : Form
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
			this.listView = new ListView();
			this.columnHeaderFile = new ColumnHeader();
			this.columnHeaderDate = new ColumnHeader();
			base.SuspendLayout();
			this.listView.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeaderFile,
				this.columnHeaderDate
			});
			this.listView.Dock = DockStyle.Fill;
			this.listView.FullRowSelect = true;
			this.listView.HideSelection = false;
			this.listView.Location = new Point(0, 0);
			this.listView.Name = "listView";
			this.listView.Size = new Size(279, 399);
			this.listView.Sorting = SortOrder.Ascending;
			this.listView.TabIndex = 2;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = View.Details;
			this.listView.ColumnClick += new ColumnClickEventHandler(this.listView_ColumnClick);
			this.columnHeaderFile.Text = "file";
			this.columnHeaderFile.Width = 123;
			this.columnHeaderDate.Text = "date";
			this.columnHeaderDate.Width = 142;
			base.AutoScaleDimensions = new SizeF(7f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(279, 399);
			base.Controls.Add(this.listView);
			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.Name = "ExeInfoForm";
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "File information";
			base.ResumeLayout(false);
		}

		//private global::System.ComponentModel.IContainer components;

		private ListView listView;

		private ColumnHeader columnHeaderFile;

		private ColumnHeader columnHeaderDate;
	}
}
