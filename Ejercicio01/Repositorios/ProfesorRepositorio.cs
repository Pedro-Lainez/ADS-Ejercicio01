using Ejercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio01.Repositorios
{
    public class ProfesorRepositorio : IProfesorRepositorio
    {
        private readonly List<ProfesorViewModel> LstProfesores;

        public ProfesorRepositorio()
        {
            LstProfesores = new List<ProfesorViewModel>
            {
                new ProfesorViewModel{ IDProfesor = 1, NombreProfesor = "Iván", ApellidoProfesor = "Alvarado", CorreoProfesor = "Ivan@usonsonate.edu.sv"}
            };
        }

        public int AgregarProfesor(ProfesorViewModel profesorViewModel)
        {
            try
            {
                if (LstProfesores.Count > 0)
                {
                    profesorViewModel.IDProfesor = LstProfesores.Last().IDProfesor + 1;
                }
                else
                {
                    profesorViewModel.IDProfesor = 1;
                }
                LstProfesores.Add(profesorViewModel);
                return profesorViewModel.IDProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarProfesor(int IDProfesor, ProfesorViewModel profesorViewModel)
        {
            try
            {
                LstProfesores[LstProfesores.FindIndex(x => x.IDProfesor == IDProfesor)] = profesorViewModel;
                return profesorViewModel.IDProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarProfesor(int IDProfesor)
        {
            try
            {
                LstProfesores.RemoveAt(LstProfesores.FindIndex(x => x.IDProfesor == IDProfesor));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ProfesorViewModel ObtenerProfesorPorID(int IDProfesor)
        {
            var item = LstProfesores.Find(x => x.IDProfesor == IDProfesor);
            return item;
        }

        public List<ProfesorViewModel> ObtenerProfesores()
        {
            try
            {
                return LstProfesores;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
