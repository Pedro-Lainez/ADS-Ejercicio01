using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio01.Repositorios
{
    public class CarreraRepositorio : ICarreraRepositorio
    {
        private readonly List<CarreraViewModel> LstCarreras;
        public CarreraRepositorio()
        {
            LstCarreras = new List<CarreraViewModel>
            {
                new CarreraViewModel{ IDCarrera = 1, CodigoCarrera = "I04", NombreCarrera = "Ingeniería En Sistemas Computacionales"}
            };
        }

        public int AgregarCarrera(CarreraViewModel carreraViewModel)
        {
            try
            {
                if (LstCarreras.Count > 0)
                {
                    carreraViewModel.IDCarrera = LstCarreras.Last().IDCarrera + 1;
                }
                else
                {
                    carreraViewModel.IDCarrera = 1;
                }
                LstCarreras.Add(carreraViewModel);
                return carreraViewModel.IDCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarCarrera(int IDCarrera, CarreraViewModel carreraViewModel)
        {
            try
            {
                LstCarreras[LstCarreras.FindIndex(x => x.IDCarrera == IDCarrera)] = carreraViewModel;
                return carreraViewModel.IDCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarCarrera(int IDCarrera)
        {
            try
            {
                LstCarreras.RemoveAt(LstCarreras.FindIndex(x => x.IDCarrera == IDCarrera));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CarreraViewModel ObtenerCarreraPorID(int IDCarrera)
        {
            var item = LstCarreras.Find(x => x.IDCarrera == IDCarrera);
            return item;
        }

        public List<CarreraViewModel> ObtenerCarreras()
        {
            try
            {
                return LstCarreras;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
