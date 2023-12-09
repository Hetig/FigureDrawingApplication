namespace FigureDrawingApplication
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			selectComboBox = new ComboBox();
			widthComboBox = new ComboBox();
			widthLabel = new Label();
			heightLabel = new Label();
			heightComboBox = new ComboBox();
			colorLabel = new Label();
			colorComboBox = new ComboBox();
			SuspendLayout();
			// 
			// selectComboBox
			// 
			selectComboBox.FormattingEnabled = true;
			selectComboBox.Location = new Point(667, 12);
			selectComboBox.Name = "selectComboBox";
			selectComboBox.Size = new Size(121, 23);
			selectComboBox.TabIndex = 0;
			// 
			// widthComboBox
			// 
			widthComboBox.FormattingEnabled = true;
			widthComboBox.Location = new Point(667, 79);
			widthComboBox.Name = "widthComboBox";
			widthComboBox.Size = new Size(121, 23);
			widthComboBox.TabIndex = 1;
			// 
			// widthLabel
			// 
			widthLabel.AutoSize = true;
			widthLabel.Location = new Point(667, 61);
			widthLabel.Name = "widthLabel";
			widthLabel.Size = new Size(39, 15);
			widthLabel.TabIndex = 2;
			widthLabel.Text = "Width";
			// 
			// heightLabel
			// 
			heightLabel.AutoSize = true;
			heightLabel.Location = new Point(667, 133);
			heightLabel.Name = "heightLabel";
			heightLabel.Size = new Size(43, 15);
			heightLabel.TabIndex = 4;
			heightLabel.Text = "Height";
			// 
			// heightComboBox
			// 
			heightComboBox.FormattingEnabled = true;
			heightComboBox.Location = new Point(667, 151);
			heightComboBox.Name = "heightComboBox";
			heightComboBox.Size = new Size(121, 23);
			heightComboBox.TabIndex = 3;
			// 
			// colorLabel
			// 
			colorLabel.AutoSize = true;
			colorLabel.Location = new Point(667, 205);
			colorLabel.Name = "colorLabel";
			colorLabel.Size = new Size(36, 15);
			colorLabel.TabIndex = 6;
			colorLabel.Text = "Color";
			// 
			// colorComboBox
			// 
			colorComboBox.FormattingEnabled = true;
			colorComboBox.Location = new Point(667, 223);
			colorComboBox.Name = "colorComboBox";
			colorComboBox.Size = new Size(121, 23);
			colorComboBox.TabIndex = 5;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(colorLabel);
			Controls.Add(colorComboBox);
			Controls.Add(heightLabel);
			Controls.Add(heightComboBox);
			Controls.Add(widthLabel);
			Controls.Add(widthComboBox);
			Controls.Add(selectComboBox);
			Name = "MainForm";
			Text = "MainForm";
			MouseDown += MainForm_MouseDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox selectComboBox;
		private ComboBox widthComboBox;
		private Label widthLabel;
		private Label heightLabel;
		private ComboBox heightComboBox;
		private Label colorLabel;
		private ComboBox colorComboBox;
	}
}