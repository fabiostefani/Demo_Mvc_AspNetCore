using System;
using fabiostefani.io.UI.Site.Data;
using fabiostefani.io.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace fabiostefani.io.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;
        public TesteCrudController(MeuDbContext dbContext)
        {
            _contexto = dbContext;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Fabio",
                DataNascimento = DateTime.Now,
                Email = "fabiostefani@gmail.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();
            return View();
        }
    }
}