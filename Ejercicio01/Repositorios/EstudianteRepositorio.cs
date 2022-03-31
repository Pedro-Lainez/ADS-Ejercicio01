using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio01.Repositorios
{
    public class EstudianteRepositorio : IEstudianteRepositorio
    {
        private readonly List<EstudianteViewModel> LstEstudiantes;

        public EstudianteRepositorio()
        {
            LstEstudiantes = new List<EstudianteViewModel>
            {
                new EstudianteViewModel{ IDEstudiante = 1, NombresEstudiante = "Juan", ApellidosEstudiante = "Perez", CodigoEstudiante = "PG16I04002", CorreoEstudiante = "Juan@usonsonate.edu.sv"}
            };
        }

        public int AgregarEstudiante(EstudianteViewModel estudianteViewModel)
        {
            try
            {
                if (LstEstudiantes.Count > 0)
                {
                    estudianteViewModel.IDEstudiante = LstEstudiantes.Last().IDEstudiante + 1;
                }
                else
                {
                    estudianteViewModel.IDEstudiante = 1;
                }
                LstEstudiantes.Add(estudianteViewModel);
                return estudianteViewModel.IDEstudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarEstudiante(int IDEstudiante, EstudianteViewModel estudianteViewModel)
        {
            try
            {
                LstEstudiantes[LstEstudiantes.FindIndex(x => x.IDEstudiante == IDEstudiante)] = estudianteViewModel;
                return estudianteViewModel.IDEstudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarEstudiante(int IDEstudiante)
        {
            try
            {
                LstEstudiantes.RemoveAt(LstEstudiantes.FindIndex(x => x.IDEstudiante == IDEstudiante));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public EstudianteViewModel ObtenerEstudiantePorID(int IDEstudiante)
        {
            var item = LstEstudiantes.Find(x => x.IDEstudiante == IDEstudiante);
            return item;
        }

        public List<EstudianteViewModel> ObtenerEstudiantes()
        {
            try
            {
                return LstEstudiantes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
