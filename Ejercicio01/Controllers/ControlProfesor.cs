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
    public class ControlProfesor : Controller
    {
        private readonly IProfesorRepositorio profesorRepositorio;

        public ControlProfesor(IProfesorRepositorio profesorRepositorio)
        {
            this.profesorRepositorio = profesorRepositorio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = profesorRepositorio.ObtenerProfesores();
                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? IDProfesor, Operaciones operaciones)
        {
            try
            {
                var profesor = new ProfesorViewModel();
                if (IDProfesor.HasValue)
                {
                    profesor = profesorRepositorio.ObtenerProfesorPorID(IDProfesor.Value);
                }

                //Indica el tipo de operación que se está realizando.
                ViewData["Operaciones"] = operaciones;
                return View(profesor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(ProfesorViewModel profesorViewModel)
        {
            try
            {
                if (profesorViewModel.IDProfesor == 0)//En caso de insertar
                {
                    profesorRepositorio.AgregarProfesor(profesorViewModel);
                }
                else//En caso de actualizar
                {
                    profesorRepositorio.ActualizarProfesor(profesorViewModel.IDProfesor, profesorViewModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Delete(int IDProfesor)
        {
            try
            {
                profesorRepositorio.EliminarProfesor(IDProfesor);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
