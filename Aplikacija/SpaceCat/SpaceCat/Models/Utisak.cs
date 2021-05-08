using System;

namespace SpaceCat
{
	public class Utisak()
	{
		public Utisak(string text, Ocjena ocjena, Macka macka)
		{
			Text = text;
			Ocjena = ocjena;
			Macka = macka;
		}
		public int ID { get;}
		public Macka Macka { get; }
		public string Text { get; }
	    public Ocjena Ocjena { get; }
	}
}
