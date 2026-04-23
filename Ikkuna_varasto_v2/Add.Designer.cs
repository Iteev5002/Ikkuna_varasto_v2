namespace Ikkuna_varasto_v2
{
    partial class Add
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tuoteValinta = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            tuote_malli = new TextBox();
            vuosi = new TextBox();
            label3 = new Label();
            tuote_hinta = new TextBox();
            label4 = new Label();
            tuote_maara = new TextBox();
            label5 = new Label();
            tallenna = new Button();
            tuote_kilometrit = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // tuoteValinta
            // 
            tuoteValinta.FormattingEnabled = true;
            tuoteValinta.Items.AddRange(new object[] { "Auto", "Tuote" });
            tuoteValinta.Location = new Point(20, 51);
            tuoteValinta.Name = "tuoteValinta";
            tuoteValinta.Size = new Size(156, 28);
            tuoteValinta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Mikä lisätään";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Malli";
            // 
            // tuote_malli
            // 
            tuote_malli.Location = new Point(20, 114);
            tuote_malli.Margin = new Padding(2);
            tuote_malli.Name = "tuote_malli";
            tuote_malli.Size = new Size(121, 27);
            tuote_malli.TabIndex = 3;
            // 
            // vuosi
            // 
            vuosi.Location = new Point(18, 173);
            vuosi.Margin = new Padding(2);
            vuosi.Name = "vuosi";
            vuosi.Size = new Size(121, 27);
            vuosi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 150);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 4;
            label3.Text = "Valmistus vuosi";
            // 
            // tuote_hinta
            // 
            tuote_hinta.Location = new Point(163, 173);
            tuote_hinta.Margin = new Padding(2);
            tuote_hinta.Name = "tuote_hinta";
            tuote_hinta.Size = new Size(121, 27);
            tuote_hinta.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 150);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Hinta";
            // 
            // tuote_maara
            // 
            tuote_maara.Location = new Point(166, 114);
            tuote_maara.Margin = new Padding(2);
            tuote_maara.Name = "tuote_maara";
            tuote_maara.Size = new Size(121, 27);
            tuote_maara.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 91);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 8;
            label5.Text = "Määrä";
            // 
            // tallenna
            // 
            tallenna.Location = new Point(514, 329);
            tallenna.Margin = new Padding(2);
            tallenna.Name = "tallenna";
            tallenna.Size = new Size(90, 27);
            tallenna.TabIndex = 10;
            tallenna.Text = "Tallenna";
            tallenna.UseVisualStyleBackColor = true;
            tallenna.Click += tallenna_Click;
            // 
            // tuote_kilometrit
            // 
            tuote_kilometrit.Location = new Point(18, 230);
            tuote_kilometrit.Margin = new Padding(2);
            tuote_kilometrit.Name = "tuote_kilometrit";
            tuote_kilometrit.Size = new Size(121, 27);
            tuote_kilometrit.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 208);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 11;
            label6.Text = "Kilometrit";
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tuote_kilometrit);
            Controls.Add(label6);
            Controls.Add(tallenna);
            Controls.Add(tuote_maara);
            Controls.Add(label5);
            Controls.Add(tuote_hinta);
            Controls.Add(label4);
            Controls.Add(vuosi);
            Controls.Add(label3);
            Controls.Add(tuote_malli);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tuoteValinta);
            Name = "Add";
            Size = new Size(622, 378);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox tuoteValinta;
        private Label label1;
        private Label label2;
        private TextBox tuote_malli;
        private TextBox vuosi;
        private Label label3;
        private TextBox tuote_hinta;
        private Label label4;
        private TextBox tuote_maara;
        private Label label5;
        private Button tallenna;
        private TextBox tuote_kilometrit;
        private Label label6;
    }
}
