using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface INotificationRepository
    {
        public ResponseModel<NotificacionDTOA> CrearNotifEvento(NotificacionDTO dto);

        public ResponseModel<NotificacionDTOA> CrearNotifReserva(NotificacionDTO dto);

        public ResponseModel<NotificacionDTOA> Editar(int idNotificacion, NotificacionDTO dto);

        public ResponseModel<ActionResult> Eliminar(int p_notificacion_oid);

        public ResponseModel<ActionResult> EnviarAEntidad(int p_notificacion, int p_entidad, int p_emisor);

        public ResponseModel<ActionResult> EnviarAUsuario(int p_notificacion, int p_receptor, int p_emisorusuario, int p_emisorentidad);

        public ResponseModel<List<NotificacionDTOA>> Listar(int p_idusuario);

        public ResponseModel<NotificacionDTOA> Obtener(int idNotificacion);

        public ResponseModel<List<NotificacionDTOA>> ObtenerNotificacionesEntidad(int idEntidad);

        public ResponseModel<List<NotificacionDTOA>> ObtenerNotificacionesEnviadas(int idUsuarioRegistrado);

        public ResponseModel<List<NotificacionDTOA>> ObtenerNotificacionesRecibidas(int idUsuarioRegistrado);

        public ResponseModel<List<NotificacionDTOA>> ObtenerNotificacionesReserva(int idReserva);

        public ResponseModel<List<NotificacionDTOA>> Listartodas();
    }
}
