using Microsoft.AspNetCore.Mvc;
using TFM_REST.DTO;
using TFM_REST.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{

    public class EventoRepository : BaseRepository, IEventoRepository
    {
        public ActionResult Asignarusuario(int p_evento_oid, IList<int> p_usuarios_oids)
        {
            var result = Post<IList<int>, ActionResult>(API_URIs.eventoURI + "/Asignarusuario?p_evento_oid=" + p_evento_oid, p_usuarios_oids);
            return result.data != null ? result.data : null;
        }

        public ActionResult<EventoDTOA> Crear(EventoDTO dto)
        {
            var result = Post<EventoDTO, ActionResult<EventoDTOA>>(API_URIs.eventoURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<EventoDTOA> Editar(int idEvento, EventoDTO dto)
        {
            var result = Put<EventoDTO, ActionResult<EventoDTOA>>(API_URIs.eventoURI + "/Editar?idEvento=" + idEvento, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_evento_oid)
        {
            var result = Delete<ActionResult>(API_URIs.eventoURI + "/Eliminar/" + p_evento_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<EventoDTOA>> Listar(int p_idusuario)
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/Listar?p_idusuario=" + p_idusuario);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<EventoDTOA>> Listarentidad(int p_identidad)
        {
            var result = Post<string, List<EventoDTOA>>(API_URIs.eventoURI + "/Listarentidad?p_identidad=" + p_identidad, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult<EventoDTOA> Obtener(int idEvento)
        {
            var result = Get<EventoDTOA>(API_URIs.eventoURI + "/" + idEvento);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<EventoDTOA>> ObtenerEventosImpartidos(int idUsuarioRegistrado)
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/ObtenerEventosImpartidos?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<EventoDTOA>> ObtenerEventosInscrito(int idUsuarioRegistrado)
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/ObtenerEventosInscrito?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<EventoDTOA>> Obtenereventospista(int p_idpista, DateTime? p_fecha, int p_iddiasemana)
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/Obtenereventospista?p_idpista=" + p_idpista + "&p_fecha=" + p_fecha + "&p_iddiasemana=" + p_iddiasemana);
            return result.data != null ? result.data : null;
        }
    }
}
