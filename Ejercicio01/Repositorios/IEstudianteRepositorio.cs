using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio01.Repositorios
{
    public interface IEstudianteRepositorio
    {
        List<EstudianteViewModel> ObtenerEstudiantes();

        int AgregarEstudiante(EstudianteViewModel estudianteViewModel);

        int ActualizarEstudiante(int IDEstudiante, EstudianteViewModel estudianteViewModel);

        bool EliminarEstudiante(int IDEstudiante);

        EstudianteViewModel ObtenerEstudiantePorID(int IDEstudiante);
    }
}
