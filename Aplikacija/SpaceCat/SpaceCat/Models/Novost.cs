using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaceCat
{
	public class Novost {
        #region Konstruktori
        public Novost() { }
		public Novost(string naslov, string text, DateTime vrijemeObjave, List<string> slike, List<Komentar> komentari)
		{
			Naslov = naslov;
			Text = text;
			Slike = slike;
			VrijemeObjave = vrijemeObjave;
			Komentari = komentari;
		}
        #endregion
        #region Properties
		[Key]
		[Required]
        public int ID { get; set; }
		[Required]
		public string Naslov { get; set; }
		[Required]
		public string Text { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime VrijemeObjave { get; }
		[NotMapped]
		public List<string> Slike { get; set; }
		[NotMapped]
		public List<Komentar> Komentari { get; set; }
        #endregion
    }
}
