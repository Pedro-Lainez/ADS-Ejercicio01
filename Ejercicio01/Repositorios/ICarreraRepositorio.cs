using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio01.Repositorios
{
    public interface ICarreraRepositorio
    {
        List<CarreraViewModel> ObtenerCarreras();

        int AgregarCarrera(CarreraViewModel carreraViewModel);

        int ActualizarCarrera(int IDCarrera, CarreraViewModel carreraViewModel);

        bool EliminarCarrera(int IDCarrera);

        CarreraViewModel ObtenerCarreraPorID(int IDCarrera);
    }
}
