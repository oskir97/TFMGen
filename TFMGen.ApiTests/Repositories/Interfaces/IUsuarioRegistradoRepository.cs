using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IUsuarioRegistradoRepository
    {
        public ResponseModel<ActionResult> Cambiarrol(int p_rol_oid);

        public ResponseModel<UsuarioRegistradoDTOA> Crear(UsuarioDTO dto);

        public ResponseModel<ActionResult> Darsealta(DateTime? p_alta);

        public ResponseModel<ActionResult> Darsebaja(DateTime? p_baja);

        public ResponseModel<UsuarioRegistradoDTOA> Editar(int idUsuario, UsuarioDTO dto);

        public ResponseModel<ActionResult> Eliminar(int p_oid);

        public ResponseModel<List<UsuarioRegistradoDTOA>> Listar();

        public ResponseModel<List<UsuarioRegistradoDTOA>> Listaralumnosevento(int p_idevento);

        public ResponseModel<List<UsuarioRegistradoDTOA>> Listartecnicosevento(int p_idevento);

        public ResponseModel<List<UsuarioRegistradoDTOA>> Listarusuariospartido(int p_idreserva);

        public ResponseModel<UsuarioRegistradoDTOA> Obtener(int p_oid);

        public ResponseModel<List<UsuarioRegistradoDTOA>> ObtenerAlumnos(int idEvento);

        public ResponseModel<List<UsuarioRegistradoDTOA>> ObtenerUsuarios(int idEntidad);

    }
}
