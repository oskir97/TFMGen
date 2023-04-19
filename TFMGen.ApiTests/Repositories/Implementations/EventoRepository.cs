using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{

    public class EventoRepository : BaseRepository, IEventoRepository
    {
        public ResponseModel<ActionResult> Asignarusuario(int p_evento_oid, IList<int> p_usuarios_oids)
        {
            var result = Put<IList<int>, ActionResult>(API_URIs.eventoURI + "/Asignarusuario?p_evento_oid=" + p_evento_oid, p_usuarios_oids);

            return result;
        }

        public ResponseModel<EventoDTOA> Crear(EventoDTO dto)
        {
            var result = Post<EventoDTO, EventoDTOA>(API_URIs.eventoURI + "/Crear", dto);

            return result;
        }

        public ResponseModel<EventoDTOA> Editar(int idEvento, EventoDTO dto)
        {
            var result = Put<EventoDTO, EventoDTOA>(API_URIs.eventoURI + "/Editar?idEvento=" + idEvento, dto);

            return result;
        }

        public ResponseModel<ActionResult> Eliminar(int p_evento_oid)
        {
            var result = Delete<ActionResult>(API_URIs.eventoURI + "/Eliminar?p_evento_oid=" + p_evento_oid);

            return result;
        }

        public ResponseModel<List<EventoDTOA>> Listar(int p_idusuario)
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/Listar?p_idusuario=" + p_idusuario);

            return result;
        }

        public ResponseModel<List<EventoDTOA>> Listarentidad(int p_identidad)
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/Listarentidad?p_identidad=" + p_identidad);

            return result;
        }

        public ResponseModel<EventoDTOA> Obtener(int idEvento)
        {
            var result = Get<EventoDTOA>(API_URIs.eventoURI + "/" + idEvento);

            return result;
        }

        public ResponseModel<List<EventoDTOA>> ObtenerEventosImpartidos(int idUsuarioRegistrado)
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/ObtenerEventosImpartidos?idUsuarioRegistrado=" + idUsuarioRegistrado);

            return result;
        }

        public ResponseModel<List<EventoDTOA>> ObtenerEventosInscrito(int idUsuarioRegistrado)
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/ObtenerEventosInscrito?idUsuarioRegistrado=" + idUsuarioRegistrado);

            return result;
        }

        public ResponseModel<List<EventoDTOA>> Obtenereventospista(int p_idpista, DateTime? p_fecha, int p_iddiasemana)
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/Obtenereventospista?p_idpista="+ p_idpista + "&p_fecha="+ string.Format("{0}/{1}/{2}", p_fecha.Value.Month, p_fecha.Value.Day, p_fecha.Value.Year).Replace("/", "%2F") +"&p_iddiasemana="+ p_iddiasemana);

            return result;
        }

        public ResponseModel<List<EventoDTOA>> Listartodos()
        {
            var result = Get<List<EventoDTOA>>(API_URIs.eventoURI + "/Listartodos");

            return result;
        }
    }
}
