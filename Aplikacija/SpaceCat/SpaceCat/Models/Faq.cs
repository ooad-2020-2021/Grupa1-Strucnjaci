using System;

namespace SpaceCat
{
	public class Faq()
	{
		public Faq(string pitanje, string odgovor)
		{
		Pitanje = pitanje;
		Odgovor = odgovor;
		}
		public int ID { get; }
		public string Pitanje { get; set; }
		public string Odgovor { get; set; }
		
	}
}
