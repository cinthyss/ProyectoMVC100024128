using System.ComponentModel.DataAnnotations;

namespace inventariosmvc.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del servicio es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Range(0, 10000, ErrorMessage = "Ingrese un precio válido")]
        public decimal Precio { get; set; }

        public int DuracionMinutos { get; set; }
        
        public string ImagenUrl { get; set; } = string.Empty;
    }
}
