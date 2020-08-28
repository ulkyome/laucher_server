using System.Drawing;
using System.Windows.Forms;

namespace HeroesOpTool
{
	public partial class InputBox : Form
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
            this.TBoxInput = new TextBox();
            this.BtnOK = new Button();
            this.BtnCancel = new Button();
            this.LabelDesc = new Label();
            this.SuspendLayout();
            // 
            // TBoxInput
            // 
            this.TBoxInput.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.TBoxInput.Location = new Point(7, 37);
            this.TBoxInput.Name = "TBoxInput";
            this.TBoxInput.Size = new Size(282, 20);
            this.TBoxInput.TabIndex = 0;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = AnchorStyles.Bottom;
            this.BtnOK.DialogResult = DialogResult.OK;
            this.BtnOK.Location = new Point(65, 66);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new Size(67, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "Ok";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = AnchorStyles.Bottom;
            this.BtnCancel.DialogResult = DialogResult.Cancel;
            this.BtnCancel.Location = new Point(158, 66);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new Size(67, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            // 
            // LabelDesc
            // 
            this.LabelDesc.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.LabelDesc.Location = new Point(7, 7);
            this.LabelDesc.Name = "LabelDesc";
            this.LabelDesc.Size = new Size(282, 22);
            this.LabelDesc.TabIndex = 2;
            this.LabelDesc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InputBox
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleBaseSize = new Size(5, 13);
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new Size(296, 95);
            this.Controls.Add(this.LabelDesc);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TBoxInput);
            this.Controls.Add(this.BtnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private Button BtnOK;

		private Button BtnCancel;

		private Label LabelDesc;

		private TextBox TBoxInput;

		//private global::System.ComponentModel.Container components = null;
	}
}
