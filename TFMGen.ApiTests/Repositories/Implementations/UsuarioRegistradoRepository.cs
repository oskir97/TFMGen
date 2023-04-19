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
    public class UsuarioRegistradoRepository : BaseRepository, IUsuarioRegistradoRepository
    {
        public ActionResult Cambiarrol(int p_rol_oid)
        {
            var result = Put<string, ActionResult>(API_URIs.usuarioRegistradoURI + "/Cambiarrol?p_rol_oid=" + p_rol_oid, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult<UsuarioRegistradoDTOA> Crear(UsuarioDTO dto)
        {
            var result = Post<UsuarioDTO, ActionResult>(API_URIs.usuarioRegistradoURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Darsealta(DateTime? p_alta)
        {
            var result = Post<string, ActionResult>(API_URIs.usuarioRegistradoURI + "/Darsealta?p_alta=" + p_alta, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult Darsebaja(DateTime? p_baja)
        {
            var result = Post<string, ActionResult>(API_URIs.usuarioRegistradoURI + "/Darsebaja?p_baja=" + p_baja, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult<UsuarioRegistradoDTOA> Editar(int idUsuario, UsuarioDTO dto)
        {
            var result = Put<UsuarioDTO, ActionResult<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/Editar?idUsuario=" + idUsuario, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_oid)
        {
            var result = Delete<ActionResult>(API_URIs.usuarioRegistradoURI + "/Eliminar/" + p_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<UsuarioRegistradoDTOA>> Listar()
        {
            var result = Get<List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/Listar");
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<UsuarioRegistradoDTOA>> Listaralumnosevento(int p_idevento)
        {
            var result = Get<List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/Listaralumnosevento?p_idevento=" + p_idevento);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<UsuarioRegistradoDTOA>> Listartecnicosevento(int p_idevento)
        {
            var result = Get<List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/Listartecnicosevento?p_idevento=" + p_idevento);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<UsuarioRegistradoDTOA>> Listarusuariospartido(int p_idreserva)
        {
            var result = Get<List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/Listarusuariospartido?p_idreserva=" + p_idreserva);
            return result.data != null ? result.data : null;
        }

        public ActionResult<UsuarioRegistradoDTOA> Obtener(int p_oid)
        {
            var result = Get<UsuarioRegistradoDTOA>(API_URIs.usuarioRegistradoURI + "/" + p_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<UsuarioRegistradoDTOA>> ObtenerAlumnos(int idEvento)
        {
            var result = Get<List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/ObtenerAlumnos?idEvento=" + idEvento);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<UsuarioRegistradoDTOA>> ObtenerUsuarios(int idEntidad)
        {
            var result = Get<List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/ObtenerUsuarios?idEntidad=" + idEntidad);
            return result.data != null ? result.data : null;
        }
    }
}
