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
            PistaEN pistaEN = this.db.pistacen.Obtener(425991);

            int id_reserva = this.db.reservacen.Crear("Usuario2", "Usuario2", "usuario@pruebas.es", "645325495"
                , false, 425991, 2, 524293, DateTime.Now, ApplicationCore.Enumerated.TFM.TipoReservaEnum.reserva, 131073);

            int notificacion_id = this.db.notificacioncen.CrearNotifEvento("Reserva exitosa", "Reserva realizada con exito",
                false, ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.alerta, 720896);

            UsuarioEN usuarioReceptor = this.db.usuariocen.Obtener(131072);
            UsuarioEN usuarioEmisor = this.db.usuariocen.Obtener(131074);
            EntidadEN entidadEN = this.db.entidadcen.Obtener(196608);

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuarioReceptor, usuarioEmisor, entidadEN);

            Assert.AreEqual(true, this.db.notificacioncen.Obtener(notificacion_id) != null);
            Assert.AreEqual(true, notificacionEN != null, "Reserva creada con exitos");
        }
    }
}