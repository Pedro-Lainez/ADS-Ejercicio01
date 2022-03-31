using Ejercicio01.Models;
using Ejercicio01.Repositorios;
using Ejercicio01.Utilidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio01.Controllers
{
    public class ControlEstudiante : Controller
    {
        private readonly IEstudianteRepositorio estudianteRepositorio;
        
        public ControlEstudiante(IEstudianteRepositorio estudianteRepositorio)
        {
            this.estudianteRepositorio = estudianteRepositorio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = estudianteRepositorio.ObtenerEstudiantes();
                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? IDEstudiante, Operaciones operaciones)
        {
            try
            {
                var estudiante = new EstudianteViewModel();
                if (IDEstudiante.HasValue)
                {
                    estudiante = estudianteRepositorio.ObtenerEstudiantePorID(IDEstudiante.Value);
                }

                //Indica el tipo de operación que se está realizando.
                ViewData["Operaciones"] = operaciones;
                return View(estudiante);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(EstudianteViewModel estudianteViewModel)
        {
            try
            {
                if (estudianteViewModel.IDEstudiante == 0)//En caso de insertar
                {
                    estudianteRepositorio.AgregarEstudiante(estudianteViewModel);
                }
                else//En caso de actualizar
                {
                    estudianteRepositorio.ActualizarEstudiante(estudianteViewModel.IDEstudiante, estudianteViewModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Delete(int IDEstudiante)
        {
            try
            {
                estudianteRepositorio.EliminarEstudiante(IDEstudiante);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
