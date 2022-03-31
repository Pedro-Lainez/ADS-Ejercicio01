using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio01.Repositorios
{
    public interface IProfesorRepositorio
    {
        List<ProfesorViewModel> ObtenerProfesores();

        int AgregarProfesor(ProfesorViewModel profesorViewModel);

        int ActualizarProfesor(int IDProfesor, ProfesorViewModel profesorViewModel);

        bool EliminarProfesor(int IDProfesor);

        ProfesorViewModel ObtenerProfesorPorID(int IDProfesor);
    }
}
