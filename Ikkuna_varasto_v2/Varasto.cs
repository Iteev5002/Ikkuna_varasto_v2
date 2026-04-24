using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ikkuna_varasto_v2
{
	public class Varasto
	{
		// Käytetään JsonDerivedType-määreitä, jotta JSON tunnistaa eron Itemin ja Auton välillä
		public List<Item> _items { get; set; } = new List<Item>();
		private string tiedosto = "varasto.json";

		public Varasto()
		{
			LoadItems();
		}

		public void AddItem(Item item)
		{
			_items.Add(item);
		}

		public void SaveItems()
		{
			// Asetukset, joilla perintä toimii JSON-muodossa
			var options = new JsonSerializerOptions { WriteIndented = true };
			string json = JsonSerializer.Serialize(_items, options);
			File.WriteAllText(tiedosto, json);
		}

		public void LoadItems()
		{
			if (File.Exists(tiedosto))
			{
				try
				{
					string json = File.ReadAllText(tiedosto);

					_items = JsonSerializer.Deserialize<List<Item>>(json) ?? new List<Item>();
				}
				catch { _items = new List<Item>(); }
			}
		}
	}
}