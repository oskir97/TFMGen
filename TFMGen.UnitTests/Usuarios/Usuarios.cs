using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Util;
using System;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.CP.TFM;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.Enumerated.TFM;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.Infraestructure.EN.TFM;

namespace TFMGen.UnitTests.Reservas
{
    [TestClass]
    public class Usuarios
    {
        Context db;
        public Usuarios()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void CrearUsuario()
        {
            var rolUsuario = db.rolcen.Crear("Usuario");
            var idusuario = db.usuariocen.Crear("Prueba", "prueba@gmail.com", "Calle", "112", Convert.ToDateTime("15/07/1999"), DateTime.Today, "Usuario", "123456", rolUsuario, "03420", "Castalla", "Alicante", null, -1);

            UsuarioEN usuarioCreado = db.usuariocen.Obtenerusuario(idusuario);

            Assert.AreEqual("Prueba",usuarioCreado.Nombre);
            Assert.AreEqual("prueba@gmail.com", usuarioCreado.Email);
            Assert.AreEqual("112", usuarioCreado.Telefono);
            Assert.AreEqual(DateTime.Today, usuarioCreado.Alta);
            Assert.AreEqual("Usuario", usuarioCreado.Apellidos);
            Assert.AreEqual(rolUsuario, usuarioCreado.Rol.Idrol);
        }

        [TestMethod]
        public void Login()
        {
            var resultado = db.usuariocen.Login("omm35@gcloud.ua.es", "123456");

            Assert.IsNotNull(resultado);
            Assert.AreNotEqual(resultado, "");
        }


    }
}