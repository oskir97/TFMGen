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
    public class Reservas
    {
        Context db;
        public Reservas()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void ReservarPista()
        {
            List<int> myList = new List<int>();

            DeporteEN deporteEN = this.db.deportecen.Listar(0, -1).First(d => d.Nombre.Contains("Baloncesto"));
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            var horario = db.horariocen.Listar(1);
            var usuarios = db.usuariocen.Listar(0, 1);
            var usuario = usuarios.First();
            PistaEstadoEN estadoPistaEN = this.db.pistaestadocen.Listar(0, 1).First();
            myList.Add(deporteEN.Iddeporte);
            int id_pista_creada = this.db.pistacen.Crear("Pistas", 5, entidadEN.Identidad, estadoPistaEN.Idestado, myList, "Castello", true);

            int Reserva = this.db.reservacen.Crear(usuario.Nombre, usuario.Apellidos, usuario.Email, usuario.Telefono, usuario.Idusuario, false, id_pista_creada, 5, 524293, DateTime.Now, TipoReservaEnum.reserva);
            Assert.AreNotEqual(null, this.db.reservacen.Obtener(Reserva));
        }
        [TestMethod]
        public void ReservarPistaNosesion()
        {
            List<int> myList = new List<int>();

            DeporteEN deporteEN = this.db.deportecen.Listar(0, -1).First(d => d.Nombre.Contains("Baloncesto"));
            EntidadEN entidadEN = db.entidadcen.Listar(0, 1).First();
            PistaEstadoEN estadoPistaEN = this.db.pistaestadocen.Listar(0, 1).First();
            myList.Add(deporteEN.Iddeporte);
            int id_pista_creada = this.db.pistacen.Crear("Pistas", 5, entidadEN.Identidad, estadoPistaEN.Idestado, myList, "Castello", true);
            var user = this.db.usuariocen.Crear("", "", "", "", DateTime.Now, DateTime.Now, "", "", this.db.rolcen.Listar(1, 0).Where(x => x.Nombre == "Usuario").Select(x => x.Idrol).First(), "", "", "", "");
            int Reserva = this.db.reservacen.Crear("", "", "", "", user, false, id_pista_creada, 5, 524293, DateTime.Now, TipoReservaEnum.reserva);
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
            myList.Add(deporteEN.Iddeporte);
            var ocupada = db.pistaestadocen.Crear("Ocupada");

            int id_pista_creada = this.db.pistacen.Crear("Pistas", 5, entidadEN.Identidad, ocupada, myList, "Castello", true);

            int Reserva = this.db.reservacen.Crear(usuario.Nombre, usuario.Apellidos, usuario.Email, usuario.Telefono, usuario.Idusuario, false, id_pista_creada, 5, 524293, DateTime.Now, TipoReservaEnum.reserva);
            Assert.AreNotEqual(null, this.db.reservacen.Obtener(Reserva));
        }
        [TestMethod]
        public void RealizarPago()
        {
            int efectivo = db.pagotipocen.Crear("Efectivo");
            EntidadEN entidadEN = this.db.entidadcen.Listar(0, 1).First();
            var id_reserva = db.reservacen.Listar(entidadEN.Identidad).First();
            int idpago = db.pagocen.Crear(3.00, 3.63, 0.63, efectivo, Convert.ToDateTime("12/02/2023 08:00:00"), id_reserva.Idreserva);
            Assert.AreNotEqual(null, idpago);
        }
    }
}