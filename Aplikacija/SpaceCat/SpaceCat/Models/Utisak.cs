using System;

namespace SpaceCat
{
	public class Utisak()
	{
		public Utisak(string text, Ocjena ocjena, Macka macka)
		{
		Utisak.text = text;
		Utisak.ocjena = ocjena;
		Utisak.macka = macka;
		}
		public int ID { get;}
		public Macka macka { get; }
		public string text { get; }
	    public Ocjena ocjena { get; }
	}
}
