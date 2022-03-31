using Ejercicio01.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio01.Models
{
    public class EstudianteViewModel
    {
        [Display(Name = "ID")]
        public int IDEstudiante { get; set; }
        [Required(ErrorMessage = Constantes.CAMPO_REQUERIDO)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Nombre")]
        public string NombresEstudiante { get; set; }
        [Display(Name = "Apellido")]
        public string ApellidosEstudiante { get; set; }
        [Display(Name = "Código")]
        public string CodigoEstudiante { get; set; }
        [Display(Name = "Correo")]
        public string CorreoEstudiante { get; set; }
    }
}
