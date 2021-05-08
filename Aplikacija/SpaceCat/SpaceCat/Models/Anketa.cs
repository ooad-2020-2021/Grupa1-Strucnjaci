using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
	public class Anketa
	{
		public Anketa(string text, Dictionary<string,double> opcijeIGlasovi)
		{
		Text = text;
		OpcijeIGlasovi = opcijeIGlasovi;
		}
		public int ID { get; }
		public string Text { get; set; }
		public Dictionary<string, double> OpcijeIGlasovi { get; set; }
		public List<string> getOpcije() {
			return OpcijeIGlasovi.Keys.ToList();
		}
	
		public void dodajOpciju(string opcija) { 
			OpcijeIGlasovi.Add(opcija, 0);
		}
		public void dodajGlas(string opcija) { 
			OpcijeIGlasovi[opcija]= OpcijeIGlasovi[opcija]+1; //treba provjeriti
		}
	}
}
