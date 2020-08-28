using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool
{
	public partial class LogViewForm : Form
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LogViewForm));
			this.panel2 = new Panel();
			this.buttonInput = new Button();
			this.TBoxInput = new TextBox();
			this.TBoxLog = new LogTextBox();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel2.Controls.Add(this.buttonInput);
			this.panel2.Controls.Add(this.TBoxInput);
			this.panel2.Dock = DockStyle.Bottom;
			this.panel2.Location = new Point(0, 446);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(716, 26);
			this.panel2.TabIndex = 6;
			this.buttonInput.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.buttonInput.Enabled = false;
			this.buttonInput.Location = new Point(641, 1);
			this.buttonInput.Name = "buttonInput";
			this.buttonInput.Size = new Size(75, 23);
			this.buttonInput.TabIndex = 3;
			this.buttonInput.Text = "input";
			this.buttonInput.UseVisualStyleBackColor = true;
			this.TBoxInput.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.TBoxInput.Enabled = false;
			this.TBoxInput.Location = new Point(0, 1);
			this.TBoxInput.Name = "TBoxInput";
			this.TBoxInput.Size = new Size(638, 21);
			this.TBoxInput.TabIndex = 2;
			this.TBoxLog.DisabledBackColor = SystemColors.Control;
			this.TBoxLog.DisabledForeColor = SystemColors.ControlText;
			this.TBoxLog.DisabledText = null;
			this.TBoxLog.Dock = DockStyle.Fill;
			this.TBoxLog.EnabledBackColor = Color.Black;
			this.TBoxLog.EnabledForeColor = Color.White;
			this.TBoxLog.Location = new Point(0, 0);
			this.TBoxLog.Name = "TBoxLog";
			this.TBoxLog.Size = new Size(716, 446);
			this.TBoxLog.TabIndex = 7;
			
			base.AutoScaleDimensions = new SizeF(7f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(716, 472);
			base.Controls.Add(this.TBoxLog);
			base.Controls.Add(this.panel2);
			base.Icon = Icon;
			base.Name = "LogViewForm";
			this.Text = "View log";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		//private global::System.ComponentModel.IContainer components;

		private Panel panel2;

		private Button buttonInput;

		private TextBox TBoxInput;

		private LogTextBox TBoxLog;
	}
}
