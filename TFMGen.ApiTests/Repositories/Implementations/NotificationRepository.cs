using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;
using TFM_REST.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class NotificationRepository : BaseRepository, INotificationRepository
    {
        public ActionResult<NotificacionDTOA> CrearNotifEvento(NotificacionDTO dto)
        {
            var result = Post<NotificacionDTO, ActionResult<NotificacionDTOA>>(API_URIs.notificacionURI + "/CrearNotifEvento", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<NotificacionDTOA> CrearNotifReserva(NotificacionDTO dto)
        {
            var result = Post<NotificacionDTO, ActionResult<NotificacionDTOA>>(API_URIs.notificacionURI + "/CrearNotifReserva", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<NotificacionDTOA> Editar(int idNotificacion, NotificacionDTO dto)
        {
            var result = Put<NotificacionDTO, ActionResult<NotificacionDTOA>>(API_URIs.notificacionURI + "/Editar?idNotificacion=" + idNotificacion, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_notificacion_oid)
        {
            var result = Delete<ActionResult>(API_URIs.notificacionURI + "/Eliminar/" + p_notificacion_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult EnviarAEntidad(int p_notificacion, int p_entidad, int p_emisor)
        {
            var result = Post<string, ActionResult>(API_URIs.notificacionURI + "/EnviarAEntidad?p_notificacion=" + p_notificacion + "&p_entidad=" + p_entidad + "&p_emisor=" + p_emisor, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult EnviarAUsuario(int p_notificacion, int p_receptor, int p_emisorusuario, int p_emisorentidad)
        {
            var result = Post<string, ActionResult>(API_URIs.notificacionURI + "/EnviarAEntidad?p_notificacion=" + p_notificacion + "&p_receptor=" + p_receptor + "&p_emisorusuario=" + p_emisorusuario + "&p_emisorentidad=" + p_emisorentidad, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<NotificacionDTOA>> Listar(int p_idusuario)
        {
            var result = Get<List<NotificacionDTOA>>(API_URIs.notificacionURI + "/Listar?p_idusuario=" + p_idusuario);
            return result.data != null ? result.data : null;
        }

        public ActionResult<NotificacionDTOA> Obtener(int idNotificacion)
        {
            var result = Get<NotificacionDTOA>(API_URIs.notificacionURI + "/" + idNotificacion);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<NotificacionDTOA>> ObtenerNotificacionesEntidad(int idEntidad)
        {
            var result = Get<List<NotificacionDTOA>>(API_URIs.notificacionURI + "/ObtenerNotificacionesEntidad?idEntidad=" + idEntidad);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<NotificacionDTOA>> ObtenerNotificacionesEnviadas(int idUsuarioRegistrado)
        {
            var result = Get<List<NotificacionDTOA>>(API_URIs.notificacionURI + "/ObtenerNotificacionesEnviadas?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<NotificacionDTOA>> ObtenerNotificacionesRecibidas(int idUsuarioRegistrado)
        {
            var result = Get<List<NotificacionDTOA>>(API_URIs.notificacionURI + "/ObtenerNotificacionesRecibidas?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<NotificacionDTOA>> ObtenerNotificacionesReserva(int idReserva)
        {
            var result = Get<List<NotificacionDTOA>>(API_URIs.notificacionURI + "/ObtenerNotificacionesReserva?idReserva=" + idReserva);
            return result.data != null ? result.data : null;
        }
    }
}
