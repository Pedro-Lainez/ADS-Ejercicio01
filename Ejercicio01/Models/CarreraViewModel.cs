using Ejercicio01.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio01.Models
{
    public class CarreraViewModel
    {
        [Display(Name = "ID")]
        public int IDCarrera { get; set; }
        [Required(ErrorMessage = Constantes.CAMPO_REQUERIDO)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Código")]
        public string CodigoCarrera { get; set; }
        [Display(Name = "Nombre")]
        public string NombreCarrera { get; set; }
    }
}
