using System;
using System.Linq;
using System.Windows.Forms;

namespace Ikkuna_varasto_v2
{
	public partial class ShowItems : UserControl
	{
		private Varasto varasto;

		public ShowItems(Varasto varasto1)
		{
			InitializeComponent();
			varasto = varasto1;
			PaivitaLista();
		}

		private void PaivitaLista()
		{
			dataGridView1.DataSource = null;
			// Käytetään ToList(), jotta näkymä on staattinen kopio
			dataGridView1.DataSource = varasto._items.ToList();

			// Jos haluat näyttää Kilometrit-sarakkeen vain jos listassa on autoja,
			// DataGridView luo ne automaattisesti jos ne ovat Item-luokassa, 
			// mutta perityt kentät (Kilometrit) eivät välttämättä näy ilman kustomointia.
		}

		private void poistaNappi_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow?.DataBoundItem is Item poistettava)
			{
				DialogResult dr = MessageBox.Show($"Poistetaanko {poistettava.Model}?", "Vahvistus", MessageBoxButtons.YesNo);
				if (dr == DialogResult.Yes)
				{
					varasto._items.Remove(poistettava);
					varasto.SaveItems();
					PaivitaLista();
				}
			}
			else
			{
				MessageBox.Show("Valitse ensin poistettava rivi.");
			}
		}

	}
}