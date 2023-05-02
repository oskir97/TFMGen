
using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IAsistenciaRepository
    {
        public ResponseModel<AsitenciaDTOA> Crear(AsitenciaDTO dto);

        public ResponseModel<AsitenciaDTOA> Editar(int idAsitencia, AsitenciaDTO dto);
        public ResponseModel<ActionResult> Eliminar(int p_asitencia_oid);

        public ResponseModel<List<AsitenciaDTOA>> Listar(int idusuario);

        public ResponseModel<List<AsitenciaDTOA>> Listartodos();

        public ResponseModel<AsitenciaDTOA> Obtener(int idAsitencia);

        public ResponseModel<List<AsitenciaDTOA>> ObtenerAsistencias(int idUsuarioRegistrado);

        public ResponseModel<List<AsitenciaDTOA>> ObtenerAsistenciasEvento(int idEvento);
    }
}
