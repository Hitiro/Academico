using Academico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academico.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            var banco = new Banco();
            var alunos = banco.Aluno.ToArray(); // Select * From Aluno
            return View(alunos);
        }

        public ActionResult Editar(int id)
        {
            var banco = new Banco();

            var aluno = banco.Aluno.First(a => a.ID == id);

            return View(aluno);
        }


        public ActionResult NovoAluno()
        {
            return View();
        }
        public ActionResult SalvarNovo(Aluno novo)
        {
            var banco = new Banco();
            banco.Aluno.Add(novo);
            banco.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}