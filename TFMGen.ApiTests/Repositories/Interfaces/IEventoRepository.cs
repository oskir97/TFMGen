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
    public interface IEventoRepository
    {
        public ActionResult<List<EventoDTOA>> ObtenerEventosImpartidos(int idUsuarioRegistrado);
        public ActionResult<List<EventoDTOA>> ObtenerEventosInscrito(int idUsuarioRegistrado);
        public ActionResult<EventoDTOA> Obtener(int idEvento);
        public ActionResult<System.Collections.Generic.List<EventoDTOA>> Listar(int p_idusuario);
        public ActionResult<System.Collections.Generic.List<EventoDTOA>> Listarentidad(int p_identidad);
        public ActionResult<System.Collections.Generic.List<EventoDTOA>> Obtenereventospista(int p_idpista, Nullable<DateTime> p_fecha, int p_iddiasemana);
        public ActionResult<EventoDTOA> Crear( EventoDTO dto);
        public ActionResult Eliminar(int p_evento_oid);
        public ActionResult<EventoDTOA> Editar(int idEvento, EventoDTO dto);
        public ActionResult Asignarusuario(int p_evento_oid, IList<int> p_usuarios_oids);

    }
}
