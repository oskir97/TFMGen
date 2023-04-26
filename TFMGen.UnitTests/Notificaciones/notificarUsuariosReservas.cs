using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.UnitTests.Notificaciones
{
    [TestClass]
    public class notificarUsuariosReservas
    {
        Context db;

        public notificarUsuariosReservas() 
        {
            this.db = new Context();
        }

        [TestMethod]
        public void NotificarReservaRealizadaConExito()
        {
            var usuario = this.db.usuariocen.Listar(0, 1).First();
            var usuario2 = this.db.usuariocen.Listar(0, -1).Last();
            var entidad = this.db.entidadcen.Listar(0, 1).First();
            var evento = this.db.eventocen.Listartodos(0, 1).First();
            var pista = this.db.pistacen.Listartodas(0, 1).First();
            var horario = this.db.horariocen.Listartodos(0, 1).First();
            PistaEN pistaEN = this.db.pistacen.Listartodas(0, 1).First();

            int id_reserva = this.db.reservacen.Crear("Usuario2", "Usuario2", "usuario@pruebas.es", "645325495"
                , false, pista.Idpista,2, horario.Idhorario, DateTime.Now, ApplicationCore.Enumerated.TFM.TipoReservaEnum.reserva, usuario.Idusuario);

            int notificacion_id = this.db.notificacioncen.CrearNotifEvento("Reserva exitosa", "Reserva realizada con exito",
                false, ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.alerta, evento.Idevento);

            UsuarioEN usuarioReceptor = usuario2;
            UsuarioEN usuarioEmisor = usuario;
            EntidadEN entidadEN = entidad;

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuarioReceptor, usuarioEmisor, entidadEN);

            Assert.AreEqual(true, this.db.notificacioncen.Obtener(notificacion_id) != null);
            Assert.AreEqual(true, notificacionEN != null, "Reserva creada con exitos");
        }
    }
}