using System.ComponentModel.DataAnnotations;

namespace WebAppOperacionesTDS.Models
{
    public class Instructor
    {
        [Key]
        public int IdInstructor { get; set; }
        [Display(Name ="Nombres")]
        [Required(ErrorMessage ="Debe de ingresar los nombres del instructor")]
        [MaxLength(60,ErrorMessage ="El campo no debe de tener mas de 60 caracteres")]
        public string Nombres { get; set; }
        [Display(Name ="Apellidos")]
        [Required(ErrorMessage ="Debe de ingresar los apellidos del instructor")]
        [MaxLength(60,ErrorMessage ="El campo no debe de tener mas de 60 caracteres")]
        public string Apellidos { get; set; }
        [Display(Name ="DNI")]
        [Required(ErrorMessage ="Debe de ingresar el DNI del instructor")]
        public int DNI { get; set; }
        [Display(Name ="Edad")]
        [Required(ErrorMessage ="Debe de ingresar la edad del instructor")]
        public int EDAD { get; set; }
        [Display(Name ="Especialidad")]
        [Required(ErrorMessage ="Debe de ingresar la especialidad del instructor")]
        [MaxLength(35,ErrorMessage ="El campo no debe de tener mas de 35 caracteres")]
        public string Especialidad { get; set; }

        [Display(Name ="Estado")]
        [Required(ErrorMessage ="Debe de ingresar el estado del instructor")]
        [MaxLength(8,ErrorMessage ="El campo no debe de tener mas de 8 caracteres")]
        public string Estado { get; set; }

    }
}
