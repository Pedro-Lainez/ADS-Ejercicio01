using Ejercicio01.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio01.Models
{
    public class MateriaViewModel
    {
        [Display(Name = "ID")]
        public int IDMateria { get; set; }
        [Required(ErrorMessage = Constantes.CAMPO_REQUERIDO)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Materia")]
        public string NombreMateria { get; set; }
    }
}
