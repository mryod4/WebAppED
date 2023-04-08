using System.ComponentModel.DataAnnotations;

namespace WebAppOperacionesTDS.Models
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="Debe de ingresar el nombre del servicio")]
        [MaxLength(120,ErrorMessage ="El campo no debe de tener mas de 120 caracteres")]
        public string NombreServicio { get; set; }  

        public virtual ICollection<Operacion> Operacion { get; set;}
    }
}
