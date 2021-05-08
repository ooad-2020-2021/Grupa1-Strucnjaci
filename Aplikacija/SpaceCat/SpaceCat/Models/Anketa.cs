using System;
using System.Collections.Generic;

namespace SpaceCat
{
	public class Anketa()
	{
		public Anketa(string text, Dictionary<string,double> opcijeIGlasovi)
		{
		Text = text;
		OpcijeIGlasovi = opcijeIGlasovi;
		}
		public int ID { get; }
		public string Text { get; set; }
		public Dictionary<string, double> OpcijeIGlasovi { get; set; }
		//getGlasovi
		//setGlasovi
		//dodajOpciju
		//dodajGlas
	}
}
