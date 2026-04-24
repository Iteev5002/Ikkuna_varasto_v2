using System;
using System.Windows.Forms;

namespace Ikkuna_varasto_v2
{
	public partial class Form1 : Form
	{
		private Varasto varasto;

		public Form1()
		{
			InitializeComponent();
			varasto = new Varasto();

			// Asetetaan aloitussivuksi lisäysnäkymä
			LoadControl(new Add(varasto));

			button1.Text = "Lisää tuote";
			button2.Text = "Näytä varasto";

			button1.Click += (s, e) => LoadControl(new Add(varasto));
			button2.Click += (s, e) => LoadControl(new ShowItems(varasto));
		}

		private void LoadControl(UserControl control)
		{
			panel1.Controls.Clear();
			control.Dock = DockStyle.Fill;
			panel1.Controls.Add(control);
		}
	}
}