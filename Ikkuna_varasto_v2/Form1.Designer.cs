namespace Ikkuna_varasto_v2
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;


		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			panel1 = new Panel();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(59, 20);
			label1.Text = "Varasto";
			// 
			// button1
			// 
			button1.Location = new Point(107, 4);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 3;
			// 
			// button2
			// 
			button2.Location = new Point(207, 4);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 4;
			// 
			// panel1
			// 
			panel1.Location = new Point(12, 39);
			panel1.Name = "panel1";
			panel1.Size = new Size(776, 399);
			panel1.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Varasto App";
			ResumeLayout(false);
			PerformLayout();
		}

		private Label label1;
		private Button button1;
		private Button button2;
		private Panel panel1;
	}
}