using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastrodeProvas.Dominio.Entidades;
using CadastrodeProvas.Dominio.Repositorio;

namespace CadastrodeProvas.Web.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        public ActionResult Index()
        {
            return View();
        }
        private IRepositorio<Professor> _repositorioProfessor;
        public ProfessorController()
        {
            _repositorioProfessor = new ProfessorRepositorio(new ProfessorContexto());
        }
        public ViewResul Cadastro()
        {
            return View(_repositorioProfessor.GetTodos());
        }
    }
}