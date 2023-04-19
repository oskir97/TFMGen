using Microsoft.AspNetCore.Mvc;
using TFM_REST.DTO;
using TFM_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IAsistenciaRepository
    {
        public ActionResult<List<AsitenciaDTOA>> ObtenerAsistencias(int idUsuarioRegistrado);
        public ActionResult<List<AsitenciaDTOA>> ObtenerAsistenciasEvento(int idEvento);
        public ActionResult<AsitenciaDTOA> Obtener(int idAsitencia);
        public ActionResult<List<AsitenciaDTOA>> Listar();
        public ActionResult<AsitenciaDTOA> Crear(AsitenciaDTO dto);
        public ActionResult<AsitenciaDTOA> Editar(int idAsitencia, AsitenciaDTO dto);
        public ActionResult Eliminar(int p_asitencia_oid);
    }
}
