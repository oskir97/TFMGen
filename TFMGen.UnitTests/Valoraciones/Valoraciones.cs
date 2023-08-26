using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.Enumerated.TFM;

namespace TFMGen.UnitTests.Valoraciones
{
    [TestClass]
    public class Valoraciones
    {
        Context db;
        public Valoraciones()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void ValorarInstalacion()
        {
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            InstalacionEN instalacionEN = db.instalacioncen.Listar(entidadEN.Identidad).First();
            var usuarios = db.usuariocen.Listar(0, 1);
            var usuario = usuarios.First();

            int valoracionOID = this.db.valoracioncen.Crear(5, "Prueba", usuario.Idusuario, DateTime.Today);
            this.db.valoracioncen.Valorarinstalacion(valoracionOID, instalacionEN.Idinstalacion);
            ValoracionEN valoracion = this.db.valoracioncen.Obtener(valoracionOID);

            Assert.AreEqual(instalacionEN.Idinstalacion, valoracion.Instalacion.Idinstalacion);
            Assert.AreEqual(5, valoracion.Estrellas);
            Assert.AreEqual("Prueba", valoracion.Comentario);
        }

        [TestMethod]
        public void ValorarPista()
        {
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            PistaEN pistaEN = db.pistacen.Listar().First();
            var usuarios = db.usuariocen.Listar(0, 1);
            var usuario = usuarios.First();

            int valoracionOID = this.db.valoracioncen.Crear(2, "Prueba Pista", usuario.Idusuario, DateTime.Today);
            this.db.valoracioncen.Valorarpista(valoracionOID, pistaEN.Idpista);
            ValoracionEN valoracion = this.db.valoracioncen.Obtener(valoracionOID);

            Assert.AreEqual(pistaEN.Idpista, valoracion.Pista.Idpista);
            Assert.AreEqual(2, valoracion.Estrellas);
            Assert.AreEqual("Prueba Pista", valoracion.Comentario);
        }
    }
}
