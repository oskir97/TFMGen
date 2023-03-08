using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFMGen.UnitTests.Notificaciones
{
    [TestClass]
    public class notificarUsuariosInstalaciones
    {
        Context db;

        public notificarUsuariosInstalaciones()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void NotificarPistasNoDisponible()
        {
            EntidadEN entidadEN = this.db.entidadcen.Listar(0, 1).First();
            EventoEN eventoEN = this.db.eventocen.Listarentidad(entidadEN.Identidad).First();

            int notificacion_id = this.db.notificacioncen.CrearNotifEvento("Pista no disponible", "Pista no disponible",
                false, ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.envio, eventoEN.Idevento);

            var usuarios = this.db.usuariocen.Listar(0, 2);


            UsuarioEN usuarioReceptor = usuarios[0];
            UsuarioEN usuarioEmisor = usuarios[1];

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuarioReceptor, usuarioEmisor, entidadEN);

            Assert.AreEqual(true, notificacionEN != null, "Noificacion enviada con exito");
        }

        [TestMethod]
        public void NotificarUsuariosPistaNueva()
        {
            EntidadEN entidadEN = this.db.entidadcen.Listar(0, 1).First();
            PistaEstadoEN estadoPistaEN = this.db.pistaestadocen.Listar(0, 1).First();
            PistaEN pistaEN = this.db.pistacen.Listar().First();
            DeporteEN deporteEN = this.db.deportecen.Listar(0, -1).First(d => d.Nombre.Contains("Baloncesto"));
            ReservaEN reservaEn = this.db.reservacen.Listar(entidadEN.Identidad).First();

            IList<int> deportes = new List<int>();
            deportes.Add(deporteEN.Iddeporte);

            //Se crea una nueva pista
            int id_pista_creada = this.db.pistacen.Crear("Pistas baseball", 5, entidadEN.Identidad, estadoPistaEN.Idestado, deportes, "Castello", true);

            //Se notifica de la nueva pista
            int notificacion_id = this.db.notificacioncen.CrearNotifReserva("Pista nueva", "Pista nueva abierta",
                true, ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.alerta, reservaEn.Idreserva);

            var usuarios = this.db.usuariocen.Listar(0, 2);

            UsuarioEN usuarioReceptor = usuarios[0];
            UsuarioEN usuarioEmisor = usuarios[1];

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuarioReceptor, usuarioEmisor, entidadEN);

            Assert.AreEqual(true, notificacionEN != null, "Noificacion enviada con exito");
        }

        [TestMethod]
        public void NotificarUsuariosCambioDeHora()
        {
            EntidadEN entidadEN = this.db.entidadcen.Listar(0, 1).First();
            PistaEstadoEN estadoPistaEN = this.db.pistaestadocen.Listar(0, 1).First();
            PistaEN pistaEN = this.db.pistacen.Listar().First();
            ReservaEN reservaEn = this.db.reservacen.Listar(entidadEN.Identidad).First();
            DeporteEN deporteEN = this.db.deportecen.Listar(0, -1).First(d => d.Nombre.Contains("Baloncesto"));

            IList<int> deportes = new List<int>();
            deportes.Add(deporteEN.Iddeporte);

            //Se notifica de la nueva pista
            int notificacion_id = this.db.notificacioncen.CrearNotifReserva("Cambio de horario", "Cambio horario pista",
                true, ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.alerta, reservaEn.Idreserva);

            var usuarios = this.db.usuariocen.Listar(0, 2);

            UsuarioEN usuarioReceptor = usuarios[0];
            UsuarioEN usuarioEmisor = usuarios[1];

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuarioReceptor, usuarioEmisor, entidadEN);

            Assert.AreEqual(true, notificacionEN != null, "Noificacion enviada con exito");
        }
    }
}