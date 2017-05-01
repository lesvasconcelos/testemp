using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testemeuspedidos;
using testemeuspedidos.Controllers;
using testemeuspedidos.Models;

namespace testemeuspedidos.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void DeveRetornarViewNaoNulaParaActionIndex()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void DeveRetornarViewNaoNulaParaActionNovoCadastroComModelValida()
        {
            var controller = new HomeController();

            var result = controller.NovoCadastro(new HomeViewModel
            {
                Nome = "abc",
                Email = "teste@teste.com",
            }) as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
