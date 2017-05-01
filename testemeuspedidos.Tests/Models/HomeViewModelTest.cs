using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testemeuspedidos;
using testemeuspedidos.Models;
namespace testemeuspedidos.Tests.Models
{
    [TestClass]
    public class HomeViewModelTest
    {
        public HomeViewModel model { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            model = new HomeViewModel
            {
                Nome = "asd",
                Email = "teste@teste.com",
            };
        }

        public void SetConhecimentos(int? html, int? css, int? javascript, int? django, int? python, int? desenvolvimentoIOS, int? desenvolvimentoAndroid)
        {
            model.HTML = html;
            model.CSS = css;
            model.Javascript = javascript;
            model.Django = django;
            model.Python = python;
            model.DesenvolvimentoIOS = desenvolvimentoIOS;
            model.DesenvolvimentoAndroid = desenvolvimentoAndroid;
        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd777()
        {
            SetConhecimentos(7, 7, 7, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd778()
        {
            SetConhecimentos(7, 7, 8, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd779()
        {
            SetConhecimentos(7, 7, 9, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd7710()
        {
            SetConhecimentos(7, 7, 10, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd787()
        {
            SetConhecimentos(7, 8, 7, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd797()
        {
            SetConhecimentos(7, 9, 7, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd7107()
        {
            SetConhecimentos(7, 10, 7, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd877()
        {
            SetConhecimentos(8, 7, 7, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd977()
        {
            SetConhecimentos(9, 7, 7, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosFrontEnd1077()
        {
            SetConhecimentos(10, 7, 7, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarFalsoParaConhecimentosFrontEnd1076()
        {
            SetConhecimentos(10, 7, 6, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void DeveRetornarFalsoParaConhecimentosFrontEnd1068()
        {
            SetConhecimentos(10, 6, 8, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void DeveRetornarFalsoParaConhecimentosFrontEnd589()
        {
            SetConhecimentos(5, 8, 9, null, null, null, null);

            var result = model.TemPontuacaoMinima(model.HTML, model.CSS, model.Javascript);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosBackEnd77()
        {
            SetConhecimentos(null, null, null, 7, 7, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosBackEnd78()
        {
            SetConhecimentos(null, null, null, 7, 8, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosBackEnd79()
        {
            SetConhecimentos(null, null, null, 7, 9, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosBackEnd710()
        {
            SetConhecimentos(null, null, null, 7, 10, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosBackEnd87()
        {
            SetConhecimentos(null, null, null, 8, 7, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosBackEnd97()
        {
            SetConhecimentos(null, null, null, 9, 7, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosBackEnd107()
        {
            SetConhecimentos(null, null, null, 10, 7, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarFalsoParaConhecimentosBackEnd57()
        {
            SetConhecimentos(null, null, null, 5, 7, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void DeveRetornarFalsoParaConhecimentosBackEnd93()
        {
            SetConhecimentos(null, null, null, 9, 3, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeveRetornarFalsoParaConhecimentosBackEnd10Null()
        {
            SetConhecimentos(null, null, null, 10, null, null, null);

            var result = model.TemPontuacaoMinima(model.Django, model.Python);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosMobile77()
        {
            SetConhecimentos(null, null, null, null, null, 7, 7);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosMobile78()
        {
            SetConhecimentos(null, null, null, null, null, 7, 8);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosMobile79()
        {
            SetConhecimentos(null, null, null, null, null, 7, 9);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosMobile710()
        {
            SetConhecimentos(null, null, null, null, null, 7, 10);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosMobile87()
        {
            SetConhecimentos(null, null, null, null, null, 8, 7);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosMobile97()
        {
            SetConhecimentos(null, null, null, null, null, 9, 7);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarVerdadeParaConhecimentosMobile107()
        {
            SetConhecimentos(null, null, null, null, null, 10, 7);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeveRetornarFalsoParaConhecimentosMobile57()
        {
            SetConhecimentos(null, null, null, null, null, 5, 7);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void DeveRetornarFalsoParaConhecimentosMobile93()
        {
            SetConhecimentos(null, null, null, null, null, 9, 3);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeveRetornarFalsoParaConhecimentosMobile10Null()
        {
            SetConhecimentos(null, null, null, null, null, 10, null);

            var result = model.TemPontuacaoMinima(model.DesenvolvimentoAndroid, model.DesenvolvimentoIOS);

            Assert.IsFalse(result);

        }
    }
}
