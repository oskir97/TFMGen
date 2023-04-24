using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class IncidenciaRepository : BaseRepository, IIncidenciaRepository
    {
        public ResponseModel<IncidenciaDTOA> Crear(IncidenciaDTO dto)
        {
            var result = Post<IncidenciaDTO, IncidenciaDTOA>(API_URIs.incidenciaURI + "/Crear", dto);

            return result;
        }

        public ResponseModel<ActionResult> Eliminar(int p_incidencia_oid)
        {
            var result = Delete<ActionResult>(API_URIs.incidenciaURI + "/Eliminar?p_incidencia_oid=" + p_incidencia_oid);

            return result;
        }

        public ResponseModel<List<IncidenciaDTOA>> Listar(int p_idevento)
        {
            var result = Get<List<IncidenciaDTOA>>(API_URIs.incidenciaURI + "/Listar?p_idevento=" + p_idevento);

            return result;
        }

        public ResponseModel<IncidenciaDTOA> Modificar(int idIncidencia, IncidenciaDTO dto)
        {
            var result = Put<IncidenciaDTO, IncidenciaDTOA>(API_URIs.incidenciaURI + "/Modificar?idIncidencia=" + idIncidencia, dto);

            return result;
        }

        public ResponseModel<IncidenciaDTOA> Obtener(int idIncidencia)
        {
            var result = Get<IncidenciaDTOA>(API_URIs.incidenciaURI + "/" + idIncidencia);

            return result;
        }

        public ResponseModel<List<IncidenciaDTOA>> ObtenerIncidencias(int idEvento)
        {
            var result = Get<List<IncidenciaDTOA>>(API_URIs.incidenciaURI + "/ObtenerIncidencias?idEvento=" + idEvento);

            return result;
        }

        public ResponseModel<List<IncidenciaDTOA>> Listartodas()
        {
            var result = Get<List<IncidenciaDTOA>>(API_URIs.incidenciaURI + "/Listartodos");

            return result;
        }
    }
}
