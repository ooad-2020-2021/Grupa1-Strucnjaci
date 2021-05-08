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
		public getGlasovi() {
			return OpcijeIGlasovi.Keys.ToList();
		}
	
		public dodajOpciju(string opcija) { 
			OpcijeIGlasovi.Add(opcija, 0);
		}
		public dodajGlas(string opcija) { 
			OpcijeIGlasovi[opcija].Value++;
		}
	}
}
