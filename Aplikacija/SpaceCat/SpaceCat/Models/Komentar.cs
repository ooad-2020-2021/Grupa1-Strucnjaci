using System;

namespace SpaceCat
{
	public class Komentar()
	{
		public Komentar(string text, Novost novost, Macka macka, DateTime vrijemeObjave)
		{
			Text = text;
			Novost = novost;
			Macka = macka;
			VrijemeObjave = vrijemeObjave;
		}
		public int ID { get; }
		public Novost Novost { get; set; }
		public Macka Macka { get; set; }
		public string Text { get; set; }
		public DateTime VrijemeObjave { get; set; }
	}
}
