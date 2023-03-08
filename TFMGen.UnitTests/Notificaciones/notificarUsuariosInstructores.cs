using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.UnitTests.Notificaciones
{
    [TestClass]
    public class notificarUsuariosInstructores
    {

        Context db;
        public notificarUsuariosInstructores()
        {
            this.db = new Context();
        }

        [TestMethod]
        public void NotificarUsuarioFaltaEntrenamiento()
        {
            IList<int> deportes = new List<int>();
            deportes.Add(262145);

            //Se notifica de la nueva pista
            int notificacion_id = this.db.notificacioncen.CrearNotifEvento("Falta de entrenamiento", 
                "Has faltado, me has decepcionado",true, ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.envio, 720896);

            UsuarioEN usuario = this.db.usuariocen.Obtener(131072);
            UsuarioEN usuarioInstructor = this.db.usuariocen.Obtener(131075);
            EntidadEN entidadEN = this.db.entidadcen.Obtener(196608);

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuario, usuarioInstructor, entidadEN);

            Assert.AreEqual(true, notificacionEN != null, "Noificacion enviada con exito");
        }

        [TestMethod]
        public void NotificarUsuarioBuenEntrenamiento()
        {
            IList<int> deportes = new List<int>();
            deportes.Add(262145);

            //Se notifica de la nueva pista
            int notificacion_id = this.db.notificacioncen.CrearNotifEvento("Muy buen entrenamiento",
                "Estoy orgulloso de ti, te has superado", true, 
                ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.envio, 720896);

            UsuarioEN usuario = this.db.usuariocen.Obtener(131072);
            UsuarioEN usuarioInstructor = this.db.usuariocen.Obtener(131075);
            EntidadEN entidadEN = this.db.entidadcen.Obtener(196608);

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuario, usuarioInstructor, entidadEN);

            Assert.AreNotEqual(false, notificacionEN != null, "Noificacion enviada con exito");

        }

        [TestMethod]
        public void NotificarUsuarioFaltaInstructor()
        {
            IList<int> deportes = new List<int>();
            deportes.Add(262145);

            //Se notifica de la nueva pista
            int notificacion_id = this.db.notificacioncen.CrearNotifEvento("No podre asistir",
                "Lamento decirte que no no podre asistir", true,
                ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.envio, 720896);

            UsuarioEN usuario = this.db.usuariocen.Obtener(131072);
            UsuarioEN usuarioInstructor = this.db.usuariocen.Obtener(131075);
            EntidadEN entidadEN = this.db.entidadcen.Obtener(196608);

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuario, usuarioInstructor, entidadEN);

            Assert.AreNotEqual(false, notificacionEN != null, "Noificacion enviada con exito");

        }
    }
}