using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IIncidenciaRepository
    {
        public ResponseModel<IncidenciaDTOA> Crear(IncidenciaDTO dto);

        public ResponseModel<ActionResult> Eliminar(int p_incidencia_oid);

        public ResponseModel<List<IncidenciaDTOA>> Listar(int p_idevento);

        public ResponseModel<IncidenciaDTOA> Modificar(int idIncidencia, IncidenciaDTO dto);

        public ResponseModel<IncidenciaDTOA> Obtener(int idIncidencia);

        public ResponseModel<List<IncidenciaDTOA>> ObtenerIncidencias(int idEvento);

        public ResponseModel<List<IncidenciaDTOA>> Listartodas();

    }
}
