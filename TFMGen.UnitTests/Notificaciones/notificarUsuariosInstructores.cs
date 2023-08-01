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

            //Se notifica de la nueva pista
            int notificacion_id = this.db.notificacioncen.CrearNotifEvento("Falta de entrenamiento", 
                "Has faltado, me has decepcionado",true, ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.envio, this.db.eventocen.Listartodos(0, 1).FirstOrDefault().Idevento);

            UsuarioEN usuario = this.db.usuariocen.Listar(0, 1).FirstOrDefault();
            UsuarioEN usuarioInstructor = this.db.usuariocen.Listar(0, 1).FirstOrDefault();
            EntidadEN entidadEN = this.db.entidadcen.Listar(0, 1).FirstOrDefault();

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuario, usuarioInstructor, entidadEN);

            Assert.AreEqual(true, notificacionEN != null, "Noificacion enviada con exito");
        }

        [TestMethod]
        public void NotificarUsuarioBuenEntrenamiento()
        {

            //Se notifica de la nueva pista
            int notificacion_id = this.db.notificacioncen.CrearNotifEvento("Muy buen entrenamiento",
                "Estoy orgulloso de ti, te has superado", true, 
                ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.envio, this.db.eventocen.Listartodos(0,1).FirstOrDefault().Idevento);

            UsuarioEN usuario = this.db.usuariocen.Listar(0,1).FirstOrDefault();
            UsuarioEN usuarioInstructor = this.db.usuariocen.Listar(0, 1).FirstOrDefault();
            EntidadEN entidadEN = this.db.entidadcen.Listar(0, 1).FirstOrDefault();

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuario, usuarioInstructor, entidadEN);

            Assert.AreNotEqual(false, notificacionEN != null, "Noificacion enviada con exito");

        }

        [TestMethod]
        public void NotificarUsuarioFaltaInstructor()
        {

            //Se notifica de la nueva pista
            int notificacion_id = this.db.notificacioncen.CrearNotifEvento("No podre asistir",
                "Lamento decirte que no no podre asistir", true,
                ApplicationCore.Enumerated.TFM.TipoNotificacionEnum.envio, this.db.eventocen.Listartodos(0, 1).FirstOrDefault().Idevento);

            UsuarioEN usuario = this.db.usuariocen.Listar(0, 1).FirstOrDefault();
            UsuarioEN usuarioInstructor = this.db.usuariocen.Listar(0, 1).FirstOrDefault();
            EntidadEN entidadEN = this.db.entidadcen.Listar(0, 1).FirstOrDefault();

            NotificacionEN notificacionEN = this.db.notificacioncen.Obtener(notificacion_id);
            this.db.notificacioncen.EnviarAUsuario(notificacionEN, usuario, usuarioInstructor, entidadEN);

            Assert.AreNotEqual(false, notificacionEN != null, "Noificacion enviada con exito");

        }
    }
}