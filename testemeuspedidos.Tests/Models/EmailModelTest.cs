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
    public class EmailModelTest
    {
        [TestMethod]
        public void DeveRetornarMensagemBackEndParaPerfilBackEnd()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.BackEnd);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Back-End ");

            Assert.AreEqual(esperado, result.Body);
        }

        [TestMethod]
        public void DeveRetornarMensagemFrontEndParaPerfilFrontEnd()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.FrontEnd);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Front-End ");

            Assert.AreEqual(esperado, result.Body);
        }

        [TestMethod]
        public void DeveRetornarMensagemMobileParaPerfilMobile()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.Mobile);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Mobile ");

            Assert.AreEqual(esperado, result.Body);
        }

        [TestMethod]
        public void DeveRetornarMensagemGenricaParaPerfilGenerico()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.Generico);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, string.Empty);

            Assert.AreEqual(esperado, result.Body);
        }

        [TestMethod]
        public void NaoDeveRetornarMensagemBackEndParaPerfilFrontEnd()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.FrontEnd);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Back-End ");

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void NaoDeveRetornarMensagemBackEndParaPerfilMobile()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.Mobile);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Back-End ");

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void DeveRetornarMensagemBackEndParaPerfilGenerico()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.Generico);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Back-End ");

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void NaoDeveRetornarMensagemFrontEndParaPerfilBackEnd()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.BackEnd);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Front-End ");

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void NaoDeveRetornarMensagemFrontEndParaPerfilMobile()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.Mobile);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Front-End ");

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void DeveRetornarMensagemFrontEndParaPerfilGenerico()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.Generico);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Front-End ");

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void NaoDeveRetornarMensagemMobileParaPerfilFrontEnd()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.FrontEnd);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Mobile ");

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void NaoDeveRetornarMensagemMobileParaPerfilBackEnd()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.BackEnd);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Mobile ");

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void DeveRetornarMensagemMobileParaPerfilGenerico()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.Generico);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, "Mobile ");

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void NaoDeveRetornarMensagemGenericaParaPerfilFrontEnd()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.FrontEnd);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, string.Empty);

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void NaoDeveRetornarMensagemGenericoParaPerfilMobile()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.Mobile);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, string.Empty);

            Assert.AreNotEqual(esperado, result.Body);
        }

        [TestMethod]
        public void DeveRetornarMensagemGenericoParaPerfilBackEnd()
        {
            var result = EmailModel.MailMessageFromEmailPerfil(EmailPerfil.BackEnd);
            var esperado = string.Format(EmailModel.CORPO_GENERICO, string.Empty);

            Assert.AreNotEqual(esperado, result.Body);
        }
    }
}
