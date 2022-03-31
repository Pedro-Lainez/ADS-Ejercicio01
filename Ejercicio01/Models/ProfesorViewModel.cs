using Ejercicio01.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio01.Models
{
    public class ProfesorViewModel
    {
        [Display(Name = "ID")]
        public int IDProfesor { get; set; }
        [Required(ErrorMessage = Constantes.CAMPO_REQUERIDO)]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 70 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Nombre")]
        public string NombreProfesor { get; set; }
        [Display(Name = "Apellido")]
        public string ApellidoProfesor { get; set; }
        [Display(Name = "Correo")]
        public string CorreoProfesor { get; set; }
    }
}
