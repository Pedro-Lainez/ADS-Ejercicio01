using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio01.Repositorios
{
    public interface IMateriaRepositorio
    {
        List<MateriaViewModel> ObtenerMaterias();

        int AgregarMateria(MateriaViewModel materiaViewModel);

        int ActualizarMateria(int IDMateria, MateriaViewModel materiaViewModel);

        bool EliminarMateria(int IDMateria);

        MateriaViewModel ObtenerMateriaPorID(int IDMateria);
    }
}
