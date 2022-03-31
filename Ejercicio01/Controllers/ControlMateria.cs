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
    public class ControlMateria : Controller
    {
        private readonly IMateriaRepositorio materiaRepositorio;

        public ControlMateria(IMateriaRepositorio materiaRepositorio)
        {
            this.materiaRepositorio = materiaRepositorio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = materiaRepositorio.ObtenerMaterias();
                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? IDMateria, Operaciones operaciones)
        {
            try
            {
                var materia = new MateriaViewModel();
                if (IDMateria.HasValue)
                {
                    materia = materiaRepositorio.ObtenerMateriaPorID(IDMateria.Value);
                }

                //Indica el tipo de operación que se está realizando.
                ViewData["Operaciones"] = operaciones;
                return View(materia);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(MateriaViewModel materiaViewModel)
        {
            try
            {
                if (materiaViewModel.IDMateria == 0)//En caso de insertar
                {
                    materiaRepositorio.AgregarMateria(materiaViewModel);
                }
                else//En caso de actualizar
                {
                    materiaRepositorio.ActualizarMateria(materiaViewModel.IDMateria, materiaViewModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Delete(int IDMateria)
        {
            try
            {
                materiaRepositorio.EliminarMateria(IDMateria);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
