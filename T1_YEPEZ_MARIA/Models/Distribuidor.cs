using System.ComponentModel.DataAnnotations;

namespace T1_YEPEZ_MARIA.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }
        [Required(ErrorMessage = "La razón social es obligatoria")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string Telefono {  get; set; }
        [Required(ErrorMessage = "El año de operación es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año de operación debe ser entre 1900 y 3000")]
        public int AnioInicioOperacion { get; set; }
        [Required(ErrorMessage = "El contacto es obligatorio")]
        public string Contacto { get; set; }

    }
}
