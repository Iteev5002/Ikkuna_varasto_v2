namespace Ikkuna_varasto_v2
{
	public class Auto : Item
	{
		public int Kilometrit { get; set; }

		public Auto()
		{
			Type = "Auto";
		}
	}
}