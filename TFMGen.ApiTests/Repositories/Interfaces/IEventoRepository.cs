using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IEventoRepository
    {
        public ResponseModel<ActionResult> Asignarusuario(int p_evento_oid, IList<int> p_usuarios_oids);

        public ResponseModel<EventoDTOA> Crear(EventoDTO dto);

        public ResponseModel<EventoDTOA> Editar(int idEvento, EventoDTO dto);

        public ResponseModel<ActionResult> Eliminar(int p_evento_oid);

        public ResponseModel<List<EventoDTOA>> Listar(int p_idusuario);

        public ResponseModel<List<EventoDTOA>> Listarentidad(int p_identidad);

        public ResponseModel<EventoDTOA> Obtener(int idEvento);

        public ResponseModel<List<EventoDTOA>> ObtenerEventosImpartidos(int idUsuarioRegistrado);

        public ResponseModel<List<EventoDTOA>> ObtenerEventosInscrito(int idUsuarioRegistrado);

        public ResponseModel<List<EventoDTOA>> Obtenereventospista(int p_idpista, DateTime? p_fecha, int p_iddiasemana);

        public ResponseModel<List<EventoDTOA>> Listartodos();

    }
}
