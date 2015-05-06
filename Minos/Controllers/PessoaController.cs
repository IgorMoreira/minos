using Minos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minos.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/
        public ActionResult Index()
        {
			Context ctx = new Context();
			List<Pessoa> pessoas = ctx.Pessoas.ToList();

            return View(pessoas);
        }

        //
        // GET: /Pessoa/Details/5
        public ActionResult Details(int id)
        {
			Context ctx = new Context();

			var pessoa = ctx.Pessoas.First(x => x.Id == id);

            return View(pessoa);
        }

        //
        // GET: /Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pessoa/Create
        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
            try
            {
                // TODO: Add insert logic here
				Context ctx = new Context();

				ctx.Pessoas.Add(pessoa);

				ctx.SaveChanges();
				
                return RedirectToAction("Index");
            }
            catch
            {
                return View(pessoa);
            }
        }

        //
        // GET: /Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
			Context ctx = new Context();
			Pessoa pessoa = new Pessoa();

			pessoa = ctx.Pessoas.Where(x => x.Id == id).FirstOrDefault();

            return View(pessoa);
        }

        //
        // POST: /Pessoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pessoa pessoa)
        {
			Context ctx = new Context();

            try
            {
                // TODO: Add update logic here
				var pessoaNoBanco = ctx.Pessoas.Where(x => x.Id == id).FirstOrDefault();
				
				pessoaNoBanco.Nome = pessoa.Nome;
				pessoaNoBanco.DataDeNascimento = pessoa.DataDeNascimento;
				pessoaNoBanco.CPF = pessoa.CPF;
				pessoaNoBanco.Naturalidade = pessoa.Naturalidade;
				pessoaNoBanco.Altura = pessoa.Altura;
				pessoaNoBanco.Peso = pessoa.Peso;
				pessoaNoBanco.Etnia = pessoa.Etnia;
				pessoaNoBanco.NivelDeEscolaridade = pessoa.NivelDeEscolaridade;
				pessoaNoBanco.Sexo = pessoa.Sexo;

				ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
			Context ctx = new Context();
			
			var pessoaDeletada = ctx.Pessoas.Where(x => x.Id == id).FirstOrDefault();

			return View(pessoaDeletada);
        }

        //
        // POST: /Pessoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Pessoa pessoa)
        {
            try
            {
                // TODO: Add delete logic here
				Context ctx = new Context();
				
				var pessoaDeletada = ctx.Pessoas.Where(x => x.Id == id).FirstOrDefault();
				ctx.Pessoas.Remove(pessoaDeletada);
				ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
