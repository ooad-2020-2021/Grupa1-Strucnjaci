using System;
using System.Collections.Generic;

namespace SpaceCat
{
	public class Novost {
		public Novost(string naslov, string text, DateTime vrijemeObjave, List<string> slike, List<Komentar> komentari)
		{
			Naslov = naslov;
			Text = text;
			Slike = slike;
			VrijemeObjave = vrijemeObjave;
			Komentari = komentari;
		}
		public int ID { get; }
		public string Naslov { get; set; }
		public string Text { get; set; }
		public DateTime VrijemeObjave { get; }
		public List<string> Slike { get; set; }
		public List<Komentar> Komentari { get; set; }
	}
}
