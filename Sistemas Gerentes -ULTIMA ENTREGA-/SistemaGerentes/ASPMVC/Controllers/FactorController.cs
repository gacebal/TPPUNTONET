using ASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositorios.Repositorio;
using dominio.Models;

namespace ASPMVC.Controllers
{
    public class FactorController : Controller
    {
        //
        // GET: /Factor/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(FactorModel model)
        {
            RepositorioFactor repositorioFactor = new RepositorioFactor();

            Factor factor = new Factor();
            factor.Nombre = model.Nombre;
            factor.Descripcion = model.Descripcion;
            factor.Ponderacion = model.Ponderacion;

            Categoria categoria1 = new Categoria();
            categoria1.Nombre = model.Categoria1;
            categoria1.Valor = 0;

            Categoria categoria2 = new Categoria();
            categoria2.Nombre = model.Categoria2;
            categoria2.Valor = 1;

            Categoria categoria3 = new Categoria();
            categoria3.Nombre = model.Categoria3;
            categoria3.Valor = 2;

            factor.Categorias.Add(categoria1);
            factor.Categorias.Add(categoria2);
            factor.Categorias.Add(categoria3);

            repositorioFactor.Crear(factor);

            return View();
        }

        public ActionResult Eliminar()
        {
            return View();
        }

        public ActionResult Actualizar()
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View();
        }

    }
}
