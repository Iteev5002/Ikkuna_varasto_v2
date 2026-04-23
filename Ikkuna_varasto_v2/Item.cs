namespace Ikkuna_varasto_v2
{
	public class Item : IPrintable
	{
		public string Type { get; set; } = "Tuote";
		public string Model { get; set; } = string.Empty; // Alustetaan tyhjäksi
		public int Amount { get; set; }
		public int ManufactoYear { get; set; }
		public float Price { get; set; }

		public virtual void PrintInfo() { }
	}
}