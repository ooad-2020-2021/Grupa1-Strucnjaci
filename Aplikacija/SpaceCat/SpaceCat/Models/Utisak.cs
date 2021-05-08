using System;
using System.ComponentModel.DataAnnotations;

namespace SpaceCat
{
	public class Utisak
	{
        #region Konstruktori
        public Utisak() { }
        public Utisak(string text, Ocjena ocjena, Macka macka)
		{
			Text = text;
			Ocjena = ocjena;
			Macka = macka;
		}
        #endregion
        #region Properties
		[Key]
		[Required]
        public int ID { get; set; }
		[Required]
		public Macka Macka { get; }
		[Required]
		public string Text { get; }
		[Required]
		public Ocjena Ocjena { get; }
        #endregion
    }
}
