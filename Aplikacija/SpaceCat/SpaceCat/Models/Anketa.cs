using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
	public class Anketa
	{
		#region Konstruktor
		public Anketa() { }
		public Anketa(string text, Dictionary<string,double> opcijeIGlasovi)
		{
			Text = text;
			OpcijeIGlasovi = opcijeIGlasovi;
		}

        #endregion

        #region Properties

        [Key]
		[Required]
		public int ID { get; set; }
		[Required]
		public string Text { get; set; }
		[Required]
		[NotMapped]
		public Dictionary<string, double> OpcijeIGlasovi { get; set; }

        #endregion

        #region Metode

        public List<string> GetOpcije() {
			return OpcijeIGlasovi.Keys.ToList();
		}
	
		public void DodajOpciju(string opcija) { 
			OpcijeIGlasovi.Add(opcija, 0);
		}
		public void DodajGlas(string opcija) { 
			OpcijeIGlasovi[opcija]= OpcijeIGlasovi[opcija]+1; //treba provjeriti
		}

        #endregion
    }
}
