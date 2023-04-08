using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppOperacionesTDS.Models
{
    public class Operacion
    {
        [Key]
        public int IdOperacion { get; set; }

        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]

        public virtual Cliente Cliente { get; set; }

        public int IdLugar { get; set; }

        [ForeignKey("IdLugar")]
        public virtual Lugar Lugar { get;set; }

        public int IdServicio { get; set; }
        [ForeignKey("IdServicio")]
        public virtual Servicio Servicio { get; set; }

        [Display(Name ="Precio")]
        [Required(ErrorMessage ="Debe de ingresar el precio de operacion")]
        public float Precio { get; set; }

        [Display(Name ="Registro")]
        [Required]
        public DateTime FechaRegistro { get; set; }

        [Display(Name ="Modificacion")]
        public DateTime? FechaModificacion { get; set; }
    }
}
