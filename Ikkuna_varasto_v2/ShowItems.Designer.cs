using System.Drawing;
using System.Windows.Forms;

namespace Ikkuna_varasto_v2
{
	partial class ShowItems
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
			dataGridView1 = new DataGridView();
			poistaNappi = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(15, 15);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(580, 280);
			dataGridView1.TabIndex = 0;
			// 
			// poistaNappi
			// 
			poistaNappi.Location = new Point(480, 310);
			poistaNappi.Name = "poistaNappi";
			poistaNappi.Size = new Size(115, 35);
			poistaNappi.TabIndex = 1;
			poistaNappi.Text = "Poista valittu";
			poistaNappi.UseVisualStyleBackColor = true;
			poistaNappi.Click += poistaNappi_Click;
			// 
			// ShowItems
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(poistaNappi);
			Controls.Add(dataGridView1);
			Name = "ShowItems";
			Size = new Size(622, 378);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private Button poistaNappi;
	}
}