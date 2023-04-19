using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;
using TFM_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface INotificationRepository
    {
        public ActionResult<List<NotificacionDTOA>> ObtenerNotificacionesEnviadas(int idUsuarioRegistrado);
        public ActionResult<List<NotificacionDTOA>> ObtenerNotificacionesRecibidas(int idUsuarioRegistrado);
        public ActionResult<List<NotificacionDTOA>> ObtenerNotificacionesEntidad(int idEntidad);
        public ActionResult<List<NotificacionDTOA>> ObtenerNotificacionesReserva(int idReserva);
        public ActionResult<NotificacionDTOA> Obtener(int idNotificacion);
        public ActionResult<System.Collections.Generic.List<NotificacionDTOA>> Listar(int p_idusuario);
        public ActionResult<NotificacionDTOA> CrearNotifEvento(NotificacionDTO dto);
        public ActionResult<NotificacionDTOA> CrearNotifReserva(NotificacionDTO dto);
        public ActionResult Eliminar(int p_notificacion_oid);
        public ActionResult<NotificacionDTOA> Editar(int idNotificacion, NotificacionDTO dto);
        public ActionResult EnviarAEntidad(int p_notificacion, int p_entidad, int p_emisor);
        public ActionResult EnviarAUsuario(int p_notificacion, int p_receptor, int p_emisorusuario, int p_emisorentidad);
    }
}
