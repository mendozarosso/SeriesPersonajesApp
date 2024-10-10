using System.ComponentModel.DataAnnotations;

namespace SeriesPersonajesApp.Models
{
    public class Serie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        public string Pais { get; set; }
        public string Idioma { get; set; }
        public string FotoUrl { get; set; }
        public string Resumen { get; set; }

        public List<Personaje> Personajes { get; set; }
    }
}