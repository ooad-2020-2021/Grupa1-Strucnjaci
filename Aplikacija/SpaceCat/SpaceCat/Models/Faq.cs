using System;
using System.ComponentModel.DataAnnotations;

namespace SpaceCat
{
	public class Faq
	{
		public object mackeKojeSuUcestvovale;

		#region Konstruktori
		public Faq() { }
        public Faq(string pitanje, string odgovor)
		{
		Pitanje = pitanje;
		Odgovor = odgovor;
		}
        #endregion

        #region Properties
		[Key]
		[Required]
        public int ID { get; set; }
		[Required]
		public string Pitanje { get; set; }
		[Required]
		public string Odgovor { get; set; }

		

		#endregion
    }
}
