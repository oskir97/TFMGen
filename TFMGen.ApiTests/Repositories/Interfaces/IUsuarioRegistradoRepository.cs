using Microsoft.AspNetCore.Mvc;
using TFM_REST.DTO;
using TFM_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IUsuarioRegistradoRepository
    {
        public ActionResult<List<UsuarioRegistradoDTOA>> Listar();
        public ActionResult<List<UsuarioRegistradoDTOA>> ObtenerAlumnos(int idEvento);
        public ActionResult<List<UsuarioRegistradoDTOA>> ObtenerUsuarios(int idEntidad);
        public ActionResult<UsuarioRegistradoDTOA> Obtener(int p_oid);
        public ActionResult<System.Collections.Generic.List<UsuarioRegistradoDTOA>> Listaralumnosevento(int p_idevento);
        public ActionResult<System.Collections.Generic.List<UsuarioRegistradoDTOA>> Listartecnicosevento(int p_idevento);
        public ActionResult<System.Collections.Generic.List<UsuarioRegistradoDTOA>> Listarusuariospartido(int p_idreserva);
        public ActionResult<UsuarioRegistradoDTOA> Crear(UsuarioDTO dto);
        public ActionResult<UsuarioRegistradoDTOA> Editar(int idUsuario, UsuarioDTO dto);
        public ActionResult Eliminar(int p_oid);
        public ActionResult Cambiarrol(int p_rol_oid);
        public ActionResult Darsebaja(Nullable<DateTime> p_baja);
        public ActionResult Darsealta(Nullable<DateTime> p_alta);

    }
}
