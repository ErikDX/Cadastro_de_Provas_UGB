using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastrodeProvas.Dominio.Entidades;
using CadastrodeProvas.Dominio.Repositorio;

namespace CadastrodeProvas.Web.Controllers
{
    public class DiciplinaController : Controller
    {
        // GET: Diciplina
        public ActionResult Index()
        {
            return View();
        }
        private IRepositorio<Diciplina> _repositorioDiciplina;
        public DiciplinaController()
        {
            _repositorioDiciplina = new DiciplinaRepositorio(new DiciplinaContexto());
        }
        public ViewResul Cadastro()
        {
            return View(_repositorioDiciplina.GetTodos());
        }
    }
}