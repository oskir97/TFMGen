using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Implementations;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApplicationCore.Enumerated.TFM;
using TFMTFMGen.ApiTests.Models_REST.DTOA;

namespace TFMGen.ApiTests.Tests.Notificacion
{
    [TestClass]
    public class Notificacion
    {
        private IValoracionRepository repositoryValoracion;
        private IUsuarioRegistradoRepository repositoryusuarioRegistrado;
        private IUsuarioRegistradoRepository repositoryUsuario;
        private IEventoRepository repositoryEvento;
        private IDiaSemanaRepository repositoryDiasSemana;
        private IEntidadRepository repositoryEntidad;
        private IHorarioRepository repositoryHorario;
        private IPistaRepository repositoryPista;
        private IRolRepository repositoryRol;
        private IReservaRepository repositoryReservas;
        private IInstalacionRepository repositoryInstalaciones;
        private IAsistenciaRepository repositoryAsistencia;
        private INotificationRepository repositoryNotification;
        
        private IMaterialRepository repositoryMaterial;
        private List<UsuarioRegistradoDTOA> usuariosRegistrados;
        private List<AsitenciaDTOA> asistencias;
        private List<InstalacionDTOA> instalaciones;
        private List<EventoDTOA> eventos;
        private List<UsuarioRegistradoDTOA> usuarios;
        private List<ValoracionDTOA> valoraciones;
        private List<HorarioDTOA> horarios;
        private List<DiaSemanaDTOA> diasSemana;
        private List<EntidadDTOA> entidades;
        private List<PistaDTOA> pistas;
        private List<RolDTOA> roles;
        private List<ReservaDTOA> reservas;
        private List<NotificacionDTOA> notificaciones;
        private List<MaterialDTOA> materiales;

        public Notificacion()
        {
            repositoryNotification=new NotificationRepository();
            repositoryusuarioRegistrado = new UsuarioRegistradoRepository();
            repositoryAsistencia=new AsistenciaRepository();
            repositoryMaterial=new MaterialRepository();
            repositoryInstalaciones=new InstalacionRepository();
            repositoryValoracion = new ValoracionRepository();
            repositoryUsuario = new UsuarioRegistradoRepository();
            repositoryEvento = new EventoRepository();
            repositoryHorario = new HorarioRepository();
            repositoryDiasSemana = new DiaSemanaRepository();
            repositoryEntidad = new EntidadRepository();
            repositoryPista = new PistaRepository();
            repositoryRol = new RolRepository();
            repositoryReservas = new ReservaRepository();

            
            usuarios = repositoryUsuario.Listar().data;
            usuariosRegistrados=repositoryusuarioRegistrado.Listar().data;
            valoraciones = repositoryValoracion.Listartodas().data;
            diasSemana = repositoryDiasSemana.Listar().data;
            entidades = repositoryEntidad.Listar().data;
            horarios = repositoryHorario.Listartodos().data;
            pistas = repositoryPista.Listartodas().data;
            roles = repositoryRol.Listar().data;
            eventos = repositoryEvento.Listartodos().data;
            reservas = repositoryReservas.Listartodos().data;
            asistencias = repositoryAsistencia.Listartodos().data;
            instalaciones = repositoryInstalaciones.Listartodos().data;
            materiales = repositoryMaterial.Listartodos().data;
            notificaciones = repositoryNotification.Listartodas().data;
        }
        [TestMethod]
        public void ListarTodas()
        {
            var result = repositoryNotification.Listartodas();
            Assert.AreEqual(false, result.error);
        }

        [TestMethod]
        public void ObtenerNotificacionesEnviadas()
        {
            var result = repositoryNotification.ObtenerNotificacionesEnviadas(usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ObtenerNotificacionesRecibidas()
        {
            var result = repositoryNotification.ObtenerNotificacionesEnviadas(usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ObtenerNotificacionesEntidad()
        {
            var result = repositoryNotification.ObtenerNotificacionesEntidad(entidades.Select(u => u.Identidad).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void ObtenerNotificacionesReserva()
        {
            var result = repositoryNotification.ObtenerNotificacionesReserva(reservas.Select(u => u.Idreserva).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Listar()
        {
            var result = repositoryNotification.Listar(usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void CrearNotificacionEvento ()
        {
            var result = repositoryNotification.CrearNotifEvento(new Models.DTO.NotificacionDTO
            {
                Asunto = "Asunto de pruebas evento",
                Descripcion = "Deacripción de pruebas",
                Receptor_oid=usuarios.Select(u=>u.Idusuario).FirstOrDefault(),
                Leida=true,
                Emisor_oid= usuarios.Select(u => u.Idusuario).LastOrDefault(),
                Entidad_oid= entidades.Select(u => u.Identidad).FirstOrDefault(),
                Evento_oid = eventos.Select(u => u.Idevento).FirstOrDefault(),
                Tipo=TipoNotificacionEnum.alerta,
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void CrearNotificacionReserva()
        {
            var result = repositoryNotification.CrearNotifReserva(new Models.DTO.NotificacionDTO
            {
                Asunto = "Asunto de pruebas evento",
                Descripcion = "Deacripción de pruebas",
                Receptor_oid = usuarios.Select(u => u.Idusuario).FirstOrDefault(),
                Leida = true,
                Emisor_oid = usuarios.Select(u => u.Idusuario).LastOrDefault(),
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
                Reserva_oid = reservas.Select(u => u.Idreserva).FirstOrDefault(),
                Tipo = TipoNotificacionEnum.alerta,
            });
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Eliminar()
        {
            
            var result = repositoryNotification.Eliminar(notificaciones.Select(u => u.Idnotificacion).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void Editar()
        {
            var result = repositoryNotification.Editar(notificaciones.Select(u => u.Idnotificacion).FirstOrDefault(),new Models.DTO.NotificacionDTO
            {
                Idnotificacion = notificaciones.Select(u => u.Idnotificacion).FirstOrDefault(),
                Asunto = "Asunto de pruebas editado",
                Descripcion = "Deacripción de pruebas editada",
                Receptor_oid = usuarios.Select(u => u.Idusuario).FirstOrDefault(),
                Leida = true,
                Emisor_oid = usuarios.Select(u => u.Idusuario).LastOrDefault(),
                Entidad_oid = entidades.Select(u => u.Identidad).FirstOrDefault(),
                Reserva_oid = reservas.Select(u => u.Idreserva).FirstOrDefault(),
                Evento_oid = eventos.Select(u => u.Idevento).FirstOrDefault(),
                Tipo = TipoNotificacionEnum.alerta,
            });
            Assert.AreEqual("Asunto de pruebas editado", result.data.Asunto);
        }
        [TestMethod]
        public void EnviarAEntidad()
        {
            var result = repositoryNotification.EnviarAEntidad(notificaciones.Select(u => u.Idnotificacion).FirstOrDefault(),
                entidades.Select(u => u.Identidad).FirstOrDefault(), usuarios.Select(u => u.Idusuario).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }
        [TestMethod]
        public void EnviarAUsuario()
        {
            var result = repositoryNotification.EnviarAUsuario(notificaciones.Select(u => u.Idnotificacion).FirstOrDefault(),
                usuarios.Select(u => u.Idusuario).LastOrDefault(), usuarios.Select(u => u.Idusuario).FirstOrDefault(), entidades.Select(u => u.Identidad).FirstOrDefault());
            Assert.AreEqual(false, result.error);
        }

    }
}