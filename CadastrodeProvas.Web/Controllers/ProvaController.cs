using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastrodeProvas.Dominio.Entidades;
using CadastrodeProvas.Dominio.Repositorio;

namespace CadastrodeProvas.Web.Controllers
{
    public class ProvaController : Controller
    {
        // GET: Prova
        public ActionResult Index()
        {
            return View();
        }
        private IRepositorio<Prova> _repositorioProva;
        public ProvaController()
        {
            _repositorioProva = new ProvaRepositorio(new ProvaContexto());
        }
        public ActionResult Cadastro()
        {
            return View(_repositorioProva.GetTodos());
        }
    }
}