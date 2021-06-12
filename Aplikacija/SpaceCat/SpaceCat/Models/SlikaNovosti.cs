using System.ComponentModel.DataAnnotations;

namespace SpaceCat
{
    public class SlikaNovosti
    {
        [Key]
        public string ID {get; set; }
        public string stringSlike { get; set; }
        public string idNovosti { get; set; }
    }
}