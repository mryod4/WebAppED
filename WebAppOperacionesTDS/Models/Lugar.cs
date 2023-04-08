using System.ComponentModel.DataAnnotations;

namespace WebAppOperacionesTDS.Models
{
    public class Lugar
    {
        [Key]
        public int IdLugar { get; set; }

        [Display(Name ="Nombre")]
        [Required(ErrorMessage ="Debe de ingresar el nombre del lugar donde se realiza la operacion")]
        [MaxLength(60,ErrorMessage ="El campo no debe de tner mas de 60 caracteres")]
        public string NombreLugar { get; set; }
        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Debe de ingresar el nombre de la direccion del lugar de las operaciones")]
        [MaxLength(80, ErrorMessage = "El campo no debe de tner mas de 80 caracteres")]
        public string Direccion { get; set; }

        [Display(Name = "Responsable")]
        [Required(ErrorMessage = "Debe de ingresar el nombre del responsable")]
        [MaxLength(60, ErrorMessage = "El campo no debe de tener mas de 60 caracteres")]
        public string Responsable { get; set; }

        public virtual ICollection<Operacion> Operacion { get; set;}
    }
}
