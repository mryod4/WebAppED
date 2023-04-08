using System.ComponentModel.DataAnnotations;

namespace WebAppOperacionesTDS.Models
{
    public class Sedes
    {
        public int IdSedes { get; set; }

        [Display(Name = "Nonbre")]
        [Required(ErrorMessage = "Debe de ingresar el nombre de la sede")]
        [MaxLength(65, ErrorMessage = "El campo no debe de tener mas de 65 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Debe de ingresar la direccion de la sede")]
        [MaxLength(100, ErrorMessage = "El campo no debe de tener mas de 100 caracteres")]
        public string Direccion { get; set; }

        [Display(Name = "Responsable")]
        [Required(ErrorMessage = "Debe de ingresar el nombre del responsable")]
        [MaxLength(85, ErrorMessage = "El campo no debe de tener mas de 85 caracteres")]
        public string Responsable { get; set; }
    }
}
