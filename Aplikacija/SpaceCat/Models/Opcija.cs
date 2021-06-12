using System.ComponentModel.DataAnnotations;

namespace SpaceCat
{
    public class Opcija
    {
        [Key]
        [Required]
        public string IdOpcije { set; get; }
        public string TextOpcije { set; get; }
        public float GlasoviOpcije { set; get; }
        public string IdAnkete { set; get; }
    }
}