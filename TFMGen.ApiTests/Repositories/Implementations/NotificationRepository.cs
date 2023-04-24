using Microsoft.AspNetCore.Mvc;
using System;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class NotificationRepository : BaseRepository, INotificationRepository
    {
        public ResponseModel<NotificacionDTOA> CrearNotifEvento(NotificacionDTO dto)
        {
            var result = Post<NotificacionDTO, NotificacionDTOA>(API_URIs.notificacionURI + "/CrearNotifEvento", dto);

            return result;
        }

        public ResponseModel<NotificacionDTOA> CrearNotifReserva(NotificacionDTO dto)
        {
            var result = Post<NotificacionDTO, NotificacionDTOA>(API_URIs.notificacionURI + "/CrearNotifReserva", dto);

            return result;
        }

        public ResponseModel<NotificacionDTOA> Editar(int idNotificacion, NotificacionDTO dto)
        {
            var result = Put<NotificacionDTO, NotificacionDTOA>(API_URIs.notificacionURI + "/Editar?idNotificacion=" + idNotificacion, dto);

            return result;
        }

        public ResponseModel<ActionResult> Eliminar(int p_notificacion_oid)
        {
            var result = Delete<ActionResult>(API_URIs.notificacionURI + "/Eliminar?p_notificacion_oid=" + p_notificacion_oid);
            return result;
        }

        public ResponseModel<ActionResult> EnviarAEntidad(int p_notificacion, int p_entidad, int p_emisor)
        {
            var result = Post<string, ActionResult>(API_URIs.notificacionURI + "/EnviarAEntidad?p_notificacion=" + p_notificacion + "&p_entidad=" + p_entidad + "&p_emisor=" + p_emisor, "");
            return result;
        }

        public ResponseModel<ActionResult> EnviarAUsuario(int p_notificacion, int p_receptor, int p_emisorusuario, int p_emisorentidad)
        {
            var result = Post<string, ActionResult>(API_URIs.notificacionURI + "/EnviarAEntidad?p_notificacion=" + p_notificacion + "&p_receptor=" + p_receptor + "&p_emisorusuario=" + p_emisorusuario + "&p_emisorentidad=" + p_emisorentidad, "");
            return result;
        }

        public ResponseModel<List<NotificacionDTOA>> Listar(int p_idusuario)
        {
            var result = Get <List<NotificacionDTOA>>(API_URIs.notificacionURI + "/Listar?p_idusuario=" + p_idusuario);

            return result;
        }

        public ResponseModel<NotificacionDTOA> Obtener(int idNotificacion)
        {
            var result = Get <NotificacionDTOA>(API_URIs.notificacionURI + "/" + idNotificacion);
            return result;
        }

        public ResponseModel<List<NotificacionDTOA>> ObtenerNotificacionesEntidad(int idEntidad)
        {
            var result = Get <List<NotificacionDTOA>>(API_URIs.notificacionURI + "/ObtenerNotificacionesEntidad?idEntidad=" + idEntidad);
            return result;
        }

        public ResponseModel<List<NotificacionDTOA>> ObtenerNotificacionesEnviadas(int idUsuarioRegistrado)
        {
            var result = Get <List<NotificacionDTOA>>(API_URIs.notificacionURI + "/ObtenerNotificacionesEnviadas?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result;
        }

        public ResponseModel<List<NotificacionDTOA>> ObtenerNotificacionesRecibidas(int idUsuarioRegistrado)
        {
            var result = Get <List<NotificacionDTOA>>(API_URIs.notificacionURI + "/ObtenerNotificacionesRecibidas?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result;
        }

        public ResponseModel<List<NotificacionDTOA>> ObtenerNotificacionesReserva(int idReserva)
        {
            var result = Get <List<NotificacionDTOA>>(API_URIs.notificacionURI + "/ObtenerNotificacionesReserva?idReserva=" + idReserva);
            return result;
        }

        public ResponseModel<List<NotificacionDTOA>> Listartodas()
        {
            var result = Get <List<NotificacionDTOA>>(API_URIs.notificacionURI + "/Listartodos");
            return result;
        }
    }
}
