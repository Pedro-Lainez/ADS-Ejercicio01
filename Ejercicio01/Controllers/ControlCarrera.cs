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
    public class ControlCarrera : Controller
    {
        private readonly ICarreraRepositorio carreraRepositorio;

        public ControlCarrera(ICarreraRepositorio carreraRepositorio)
        {
            this.carreraRepositorio = carreraRepositorio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = carreraRepositorio.ObtenerCarreras();
                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? IDCarrera, Operaciones operaciones)
        {
            try
            {
                var carrera = new CarreraViewModel();
                if (IDCarrera.HasValue)
                {
                    carrera = carreraRepositorio.ObtenerCarreraPorID(IDCarrera.Value);
                }

                //Indica el tipo de operación que se está realizando.
                ViewData["Operaciones"] = operaciones;
                return View(carrera);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(CarreraViewModel carreraViewModel)
        {
            try
            {
                if (carreraViewModel.IDCarrera == 0)//En caso de insertar
                {
                    carreraRepositorio.AgregarCarrera(carreraViewModel);
                }
                else//En caso de actualizar
                {
                    carreraRepositorio.ActualizarCarrera(carreraViewModel.IDCarrera, carreraViewModel);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Delete(int IDCarrera)
        {
            try
            {
                carreraRepositorio.EliminarCarrera(IDCarrera);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
