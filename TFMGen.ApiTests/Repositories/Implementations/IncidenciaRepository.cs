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
    internal class IncidenciaRepository : BaseRepository, IIncidenciaRepository
    {
        public ActionResult<IncidenciaDTOA> Crear(IncidenciaDTO dto)
        {
            var result = Post<IncidenciaDTO, ActionResult<IncidenciaDTOA>>(API_URIs.incidenciaURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_incidencia_oid)
        {
            var result = Delete<ActionResult>(API_URIs.incidenciaURI + "/Eliminar/" + p_incidencia_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<IncidenciaDTOA>> Listar(int p_idevento)
        {
            var result = Get<List<IncidenciaDTOA>>(API_URIs.incidenciaURI + "/Listar?p_idevento=" + p_idevento);
            return result.data != null ? result.data : null;
        }

        public ActionResult<IncidenciaDTOA> Modificar(int idIncidencia, IncidenciaDTO dto)
        {
            var result = Put<IncidenciaDTO, ActionResult<IncidenciaDTOA>>(API_URIs.incidenciaURI + "/Modificar?idIncidencia=" + idIncidencia, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<IncidenciaDTOA> Obtener(int idIncidencia)
        {
            var result = Get<IncidenciaDTOA>(API_URIs.incidenciaURI + "/" + idIncidencia);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<IncidenciaDTOA>> ObtenerIncidencias(int idEvento)
        {
            var result = Get<List<IncidenciaDTOA>>(API_URIs.incidenciaURI + "/ObtenerIncidencias?idEvento=" + idEvento);
            return result.data != null ? result.data : null;
        }
    }
}
