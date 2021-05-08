using System;
using System.ComponentModel.DataAnnotations;

namespace SpaceCat
{
	public class Komentar
	{
		#region Konstruktori
		public Komentar() { }
        public Komentar(string text, Novost novost, Macka macka, DateTime vrijemeObjave)
		{
			Text = text;
			Novost = novost;
			Macka = macka;
			VrijemeObjave = vrijemeObjave;
		}
		#endregion

		#region Properties

		[Key]
		[Required]
        public int ID { get; set; }
		[Required]
		public Novost Novost { get; set; }
		[Required]
		public Macka Macka { get; set; }
		[Required]
		public string Text { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime VrijemeObjave { get; set; }
        #endregion
    }
}
