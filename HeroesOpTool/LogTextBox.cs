using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HeroesOpTool
{
	public class LogTextBox : UserControl
	{
		private struct TagSchem
		{
			public string BeginTag;

			public string EndTag;

			public Color ForeColor;

			public Color BackColor;
		}

		public Func<string, int> ParseDate;

		private readonly string TagBeginFormat = "[{0}]";

		private readonly string TagEndFormat = "[/{0}]";

		private string inColor = string.Empty;

		private bool enabled = true;

		private Color enabledBackColor;

		private Color enabledForeColor;

		private Color CurrentForeColor = Color.Empty;

		private Color CurrentBackColor = Color.Empty;

		private List<TagSchem> tags;

		private IContainer components;

		private RichTextBox TextBox;

		public new bool Enabled
		{
			get
			{
				return enabled;
			}
			set
			{
				if (enabled == value)
				{
					return;
				}
				enabled = value;
				if (!enabled)
				{
					TextBox.BackColor = DisabledBackColor;
					TextBox.ForeColor = DisabledForeColor;
					if (!string.IsNullOrEmpty(DisabledText))
					{
						TextBox.Text = DisabledText;
						TextBox.Select(0, DisabledText.Length);
						TextBox.SelectionColor = DisabledForeColor;
						TextBox.SelectionBackColor = DisabledBackColor;
					}
				}
				else
				{
					TextBox.Clear();
					TextBox.BackColor = EnabledBackColor;
					TextBox.ForeColor = EnabledForeColor;
				}
			}
		}

		public string DisabledText
		{
			get;
			set;
		}

		public Color DisabledBackColor
		{
			get;
			set;
		}

		public Color DisabledForeColor
		{
			get;
			set;
		}

		public Color EnabledBackColor
		{
			get
			{
				return enabledBackColor;
			}
			set
			{
				enabledBackColor = value;
				if (Enabled)
				{
					TextBox.BackColor = enabledBackColor;
				}
			}
		}

		public Color EnabledForeColor
		{
			get
			{
				return enabledForeColor;
			}
			set
			{
				enabledForeColor = value;
				if (Enabled)
				{
					TextBox.ForeColor = enabledForeColor;
				}
			}
		}

		[DllImport("user32.dll")]
		public static extern bool LockWindowUpdate(IntPtr hWnd);

		public LogTextBox()
		{
			InitializeComponent();
			DisabledBackColor = Color.FromKnownColor(KnownColor.Control);
			DisabledForeColor = Color.FromKnownColor(KnownColor.ControlText);
			EnabledBackColor = Color.Black;
			EnabledForeColor = Color.White;
			ParseDate = DefaultDateParser;
			tags = new List<TagSchem>();
			AddTag("FATAL", Color.White, Color.Red);
			AddTag("ERROR", Color.Red);
			AddTag("WARN", Color.Yellow);
			AddTag("INFO", Color.Green);
		}

		private int DefaultDateParser(string text)
		{
			return 17;
		}

		public void AddTag(string tagName, Color foreColor)
		{
			AddTag(tagName, foreColor, Color.Empty);
		}

		public void AddTag(string tagName, Color foreColor, Color backColor)
		{
			tags.Add(new TagSchem
			{
				BeginTag = string.Format(TagBeginFormat, tagName),
				EndTag = string.Format(TagEndFormat, tagName),
				ForeColor = foreColor,
				BackColor = backColor
			});
		}

		public void Clear()
		{
			TextBox.Clear();
		}

		public void AddPrefix(string text, Color foreColor, Color backColor)
		{
			TextBox.AppendText(text);
			TextBox.SelectionStart = Math.Max(TextBox.Text.Length - text.Length, 0);
			TextBox.SelectionLength = text.Length;
			TextBox.SelectionColor = foreColor;
			TextBox.SelectionBackColor = backColor;
		}

		public void AddLog(string[] message)
		{
			try
			{
				LockWindowUpdate(TextBox.Handle);
				foreach (string s in message)
				{
					AddLog(s);
				}
			}
			finally
			{
				LockWindowUpdate(IntPtr.Zero);
			}
		}

		public void AddLog(string message)
		{
			int dateLength = ParseDate(message);
			string real = message.Substring(dateLength);
			string date = message.Substring(0, dateLength);
			bool bBackToOriginalColor = false;
			bool bIsMatch = false;
			if (inColor.Length == 0 && real.StartsWith("["))
			{
				foreach (TagSchem s in tags)
				{
					if (real.StartsWith(s.BeginTag))
					{
						CurrentForeColor = s.ForeColor;
						CurrentBackColor = s.BackColor;
						real = real.Substring(s.BeginTag.Length);
						bIsMatch = true;
						inColor = s.EndTag;
						break;
					}
				}
			}
			if (inColor.Length > 0 && real.EndsWith(inColor))
			{
				bBackToOriginalColor = true;
				real = real.Substring(0, real.Length - inColor.Length);
				bIsMatch = true;
				inColor = string.Empty;
			}
			if (bIsMatch)
			{
				message = message.Substring(0, dateLength) + real;
			}
			if (TextBox.Text.Length > 0)
			{
				TextBox.Select(TextBox.Text.Length, 0);
			}
			TextBox.SelectionColor = Color.Gray;
			TextBox.SelectionBackColor = EnabledBackColor;
			TextBox.AppendText(date);
			TextBox.SelectionColor = ((CurrentForeColor == Color.Empty) ? TextBox.ForeColor : CurrentForeColor);
			TextBox.SelectionBackColor = ((CurrentBackColor == Color.Empty) ? TextBox.BackColor : CurrentBackColor);
			TextBox.AppendText(real + Environment.NewLine);
			if (bBackToOriginalColor)
			{
				CurrentForeColor = Color.Empty;
				CurrentBackColor = Color.Empty;
			}
		}

		public void ScrollToEnd()
		{
			if (TextBox.Text.Length > 0)
			{
				TextBox.Select(TextBox.Text.Length - 1, 0);
				TextBox.ScrollToCaret();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			TextBox = new System.Windows.Forms.RichTextBox();
			SuspendLayout();
			TextBox.BackColor = System.Drawing.Color.Black;
			TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			TextBox.ForeColor = System.Drawing.Color.White;
			TextBox.Location = new System.Drawing.Point(0, 0);
			TextBox.Name = "TextBox";
			TextBox.ReadOnly = true;
			TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			TextBox.Size = new System.Drawing.Size(150, 150);
			TextBox.TabIndex = 0;
			TextBox.Text = "";
			base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(TextBox);
			base.Name = "LogTextBox";
			ResumeLayout(false);
		}
	}
}
