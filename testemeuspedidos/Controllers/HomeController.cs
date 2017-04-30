using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testemeuspedidos.Models;

namespace testemeuspedidos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovoCadastro(HomeViewModel cadastro)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", cadastro);
            }

            cadastro.ProcessarCandidatura();

            return View();
        }
    }
}