using System.ComponentModel.DataAnnotations;

namespace SeriesPersonajesApp.Models
{
    public class Personaje
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        public string Apodo { get; set; }
        public string Raza { get; set; }
        public string FotoUrl { get; set; }
        public int Edad { get; set; }
        public string PoderCaracteristico { get; set; }

        public int SerieId { get; set; }
        public Serie Serie { get; set; }
    }
}