using System;
using System.Windows.Forms;

namespace Ikkuna_varasto_v2
{
	public partial class Add : UserControl
	{
		private Varasto varasto;

		public Add(Varasto varasto1)
		{
			InitializeComponent();
			varasto = varasto1;
			// Estetään kilometrien syöttö ennen kuin "Auto" on valittu
			tuote_kilometrit.Enabled = false;
			tuoteValinta.SelectedIndexChanged += TuoteValinta_SelectedIndexChanged;
		}

		// Muuta eventin allekirjoitusta ja tarkistusta:
		private void TuoteValinta_SelectedIndexChanged(object? sender, EventArgs e)
		{
			string? valinta = tuoteValinta.SelectedItem?.ToString();
			tuote_kilometrit.Enabled = (valinta == "Auto");
		}

		private void tallenna_Click(object sender, EventArgs e)
		{
			if (tuoteValinta.SelectedItem == null)
			{
				MessageBox.Show("Valitse tyyppi: Auto tai Tuote");
				return;
			}


			if (!int.TryParse(tuote_maara.Text, out int maara) ||
				!int.TryParse(vuosi.Text, out int valmistus) ||
				!float.TryParse(tuote_hinta.Text, out float hinta))
			{
				MessageBox.Show("Tarkista numeroarvot (Määrä, Vuosi, Hinta)!");
				return;
			}

			string tyyppi = tuoteValinta.SelectedItem.ToString();
			Item uusiTuote;

			if (tyyppi == "Auto")
			{
				int.TryParse(tuote_kilometrit.Text, out int kilometrit);
				uusiTuote = new Auto
				{
					Model = tuote_malli.Text,
					Amount = maara,
					ManufactoYear = valmistus,
					Price = hinta,
					Kilometrit = kilometrit
				};
			}
			else
			{
				uusiTuote = new Item
				{
					Model = tuote_malli.Text,
					Amount = maara,
					ManufactoYear = valmistus,
					Price = hinta
				};
			}

			varasto.AddItem(uusiTuote);
			varasto.SaveItems();
			MessageBox.Show("Tallennettu onnistuneesti!");
			tyhjaa();
		}

		private void tyhjaa()
		{
			tuote_malli.Clear();
			tuote_maara.Clear();
			vuosi.Clear();
			tuote_hinta.Clear();
			tuote_kilometrit.Clear();
			tuoteValinta.SelectedIndex = -1;
		}
	}
}