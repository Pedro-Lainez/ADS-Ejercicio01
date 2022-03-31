using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio01.Repositorios
{
    public class MateriaRepositorio : IMateriaRepositorio
    {
        private readonly List<MateriaViewModel> LstMaterias;

        public MateriaRepositorio()
        {
            LstMaterias = new List<MateriaViewModel>
            {
                new MateriaViewModel{ IDMateria = 1, NombreMateria = "Matemática I"}
            };
        }

        public int AgregarMateria(MateriaViewModel materiaViewModel)
        {
            try
            {
                if (LstMaterias.Count > 0)
                {
                    materiaViewModel.IDMateria = LstMaterias.Last().IDMateria + 1;
                }
                else
                {
                    materiaViewModel.IDMateria = 1;
                }
                LstMaterias.Add(materiaViewModel);
                return materiaViewModel.IDMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarMateria(int IDMateria, MateriaViewModel materiaViewModel)
        {
            try
            {
                LstMaterias[LstMaterias.FindIndex(x => x.IDMateria == IDMateria)] = materiaViewModel;
                return materiaViewModel.IDMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarMateria(int IDMateria)
        {
            try
            {
                LstMaterias.RemoveAt(LstMaterias.FindIndex(x => x.IDMateria == IDMateria));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public MateriaViewModel ObtenerMateriaPorID(int IDMateria)
        {
            var item = LstMaterias.Find(x => x.IDMateria == IDMateria);
            return item;
        }

        public List<MateriaViewModel> ObtenerMaterias()
        {
            try
            {
                return LstMaterias;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
