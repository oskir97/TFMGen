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
        public void ReservarPista()
        {
            List<int> myList = new List<int>();

            DeporteEN deporteEN = this.db.deportecen.Listar(0, -1).First(d => d.Nombre.Contains("Baloncesto"));
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            InstalacionEN instalacionEN = db.instalacioncen.Listar(entidadEN.Identidad).First();
            var horario = db.horariocen.Listar(1);
            var usuarios = db.usuariocen.Listar(0, 1);
            var usuario = usuarios.First();
            PistaEstadoEN estadoPistaEN = this.db.pistaestadocen.Listar(0, 1).First();
            myList.Add(deporteEN.Iddeporte);
            int id_pista_creada = this.db.pistacen.Crear("Pistas", 5, entidadEN.Identidad, estadoPistaEN.Idestado, myList, "Castello", true, instalacionEN.Idinstalacion,30,30.00, 30.00);

            int Reserva = this.db.reservacen.Crear(usuario.Nombre, usuario.Apellidos, usuario.Email, usuario.Telefono, false, id_pista_creada, 5, 524293, DateTime.Now, TipoReservaEnum.reserva, usuario.Idusuario, deporteEN.Iddeporte, -1, null, -1, null, null);
            Assert.AreNotEqual(null, this.db.reservacen.Obtener(Reserva));
        }
        [TestMethod]
        public void ReservarPistaNosesion()
        {
            List<int> myList = new List<int>();

            DeporteEN deporteEN = this.db.deportecen.Listar(0, -1).First(d => d.Nombre.Contains("Baloncesto"));
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            PistaEstadoEN estadoPistaEN = this.db.pistaestadocen.Listar(0, 1).First();
            InstalacionEN instalacionEN = db.instalacioncen.Listar(entidadEN.Identidad).First();
            myList.Add(deporteEN.Iddeporte);
            int id_pista_creada = this.db.pistacen.Crear("Pistas", 5, entidadEN.Identidad, estadoPistaEN.Idestado, myList, "Castello", true, instalacionEN.Idinstalacion, 30, 30.00, 30.00);
            var user = this.db.usuariocen.Crear("", "", "", "", DateTime.Now, DateTime.Now, "", "", this.db.rolcen.Listar(1, 0).Where(x => x.Nombre == "Usuario").Select(x => x.Idrol).First(), "", "", "", "", entidadEN.Identidad);
            int Reserva = this.db.reservacen.Crear("", "", "", "", false, id_pista_creada, 5, 524293, DateTime.Now, TipoReservaEnum.reserva, user, deporteEN.Iddeporte, -1, null, -1, null, null);
            Assert.AreNotEqual(null, this.db.reservacen.Obtener(Reserva));

        }
        [TestMethod]
        public void ReservarPistaOcupada()
        {
            List<int> myList = new List<int>();

            DeporteEN deporteEN = this.db.deportecen.Listar(0, -1).First(d => d.Nombre.Contains("Baloncesto"));
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            var horario = db.horariocen.Listar(1);
            var usuarios = db.usuariocen.Listar(0, 1);
            var usuario = usuarios.First();
            PistaEstadoEN estadoPistaEN = this.db.pistaestadocen.Listar(0, 1).First();
            InstalacionEN instalacionEN = db.instalacioncen.Listar(entidadEN.Identidad).First();
            myList.Add(deporteEN.Iddeporte);
            int id_pista_creada = this.db.pistacen.Crear("Pistas", 5, entidadEN.Identidad, estadoPistaEN.Idestado, myList, "Castello", true, instalacionEN.Idinstalacion, 30, 30.00, 30.00);

            DateTime fecha = DateTime.Now;
            int Reserva = this.db.reservacen.Crear(usuario.Nombre, usuario.Apellidos, usuario.Email, usuario.Telefono, false, id_pista_creada, 5, 524293, fecha, TipoReservaEnum.reserva, usuario.Idusuario, deporteEN.Iddeporte, -1, null, -1, null, null);
            Assert.AreNotEqual(null, this.db.reservacen.Obtener(Reserva));
            bool existeReserva = this.db.pistacp.ExisteReserva(id_pista_creada, fecha, usuario.Idusuario);
            Assert.AreEqual(false, existeReserva);
        }
        [TestMethod]
        public void RealizarPago()
        {
            int efectivo = db.pagotipocen.Crear("Efectivo");
            EntidadEN entidadEN = this.db.entidadcen.Listar(0, 1).First();
            var id_reserva = db.reservacen.Listartodos(0,1).First();
            int idpago = db.pagocen.Crear(3.00, 3.63, 0.63, efectivo, Convert.ToDateTime("12/02/2023 08:00:00"), id_reserva.Idreserva, "inventado");
            Assert.AreNotEqual(null, idpago);
        }
    }
}