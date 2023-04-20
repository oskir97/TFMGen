using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class UsuarioRegistradoRepository : BaseRepository, IUsuarioRegistradoRepository
    {
        public ResponseModel<ActionResult> Cambiarrol(int p_rol_oid, int idusuario)
        {
            var result = Put<string, ActionResult>(API_URIs.usuarioRegistradoURI + "/Cambiarrol?p_rol_oid=" + p_rol_oid + "&idusuario=" + idusuario, "");

            return result;
        }

        public ResponseModel<UsuarioRegistradoDTOA> Crear(UsuarioDTO dto)
        {
            var result = Post<UsuarioDTO, UsuarioRegistradoDTOA>(API_URIs.usuarioRegistradoURI + "/Crear", dto);

            return result;
        }

        public ResponseModel<ActionResult> Darsealta(DateTime? p_alta, int idusuario)
        {
            var result = Post<string, ActionResult>(API_URIs.usuarioRegistradoURI + "/Darsealta?p_alta=" + string.Format("{0}/{1}/{2}", p_alta.Value.Month, p_alta.Value.Day, p_alta.Value.Year).Replace("/", "%2F") + "&idusuario=" + idusuario, "");

            return result;
        }

        public ResponseModel<ActionResult> Darsebaja(DateTime? p_baja, int idusuario)
        {
            var result = Post<string, ActionResult>(API_URIs.usuarioRegistradoURI + "/Darsebaja?p_baja=" + string.Format("{0}/{1}/{2}", p_baja.Value.Month, p_baja.Value.Day, p_baja.Value.Year).Replace("/", "%2F") + "&idusuario=" + idusuario, "");

            return result;
        }

        public ResponseModel<UsuarioRegistradoDTOA> Editar(int idUsuario, UsuarioDTO dto)
        {
            var result = Put<UsuarioDTO, UsuarioRegistradoDTOA>(API_URIs.usuarioRegistradoURI + "/Editar?idUsuario=" + idUsuario, dto);

            return result;
        }

        public ResponseModel<ActionResult> Eliminar(int p_oid)
        {
            var result = Delete<ActionResult>(API_URIs.usuarioRegistradoURI + "/Eliminar?p_oid=" + p_oid);

            return result;
        }

        public ResponseModel<List<UsuarioRegistradoDTOA>> Listar()
        {
            var result = Get < List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/Listar");

            return result;
        }

        public ResponseModel<List<UsuarioRegistradoDTOA>> Listaralumnosevento(int p_idevento)
        {
            var result = Get <List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/Listaralumnosevento?p_idevento=" + p_idevento);

            return result;
        }

        public ResponseModel<List<UsuarioRegistradoDTOA>> Listartecnicosevento(int p_idevento)
        {
            var result = Get <List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/Listartecnicosevento?p_idevento=" + p_idevento);

            return result;
        }

        public ResponseModel<List<UsuarioRegistradoDTOA>> Listarusuariospartido(int p_idreserva)
        {
            var result = Get <List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/Listarusuariospartido?p_idreserva=" + p_idreserva);

            return result;
        }

        public ResponseModel<UsuarioRegistradoDTOA> Obtener()
        {
            var result = Get <UsuarioRegistradoDTOA>(API_URIs.usuarioRegistradoURI);

            return result;
        }

        public ResponseModel<List<UsuarioRegistradoDTOA>> ObtenerAlumnos(int idEvento)
        {
            var result = Get <List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/ObtenerAlumnos?idEvento=" + idEvento);

            return result;
        }

        public ResponseModel<List<UsuarioRegistradoDTOA>> ObtenerUsuarios(int idEntidad)
        {
            var result = Get <List<UsuarioRegistradoDTOA>>(API_URIs.usuarioRegistradoURI + "/ObtenerUsuarios?idEntidad=" + idEntidad);

            return result;
        }

        public ResponseModel<UsuarioRegistradoDTOA> Obtenerusuario(int idusuario)
        {
            var result = Get<UsuarioRegistradoDTOA>(API_URIs.usuarioRegistradoURI + "/Obtenerusuario?idusuario=" + idusuario);

            return result;
        }
    }
}
