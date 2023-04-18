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
    public class AsistenciaRepository : BaseRepository, IAsistenciaRepository
    {
        public ActionResult<AsitenciaDTOA> Crear(AsitenciaDTO dto)
        {
            var result = Post<AsitenciaDTO, ActionResult<AsitenciaDTOA>>(API_URIs.asistenciaURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<AsitenciaDTOA> Editar(int idAsitencia, AsitenciaDTO dto)
        {
            var result = Put<AsitenciaDTO, ActionResult<AsitenciaDTOA>>(API_URIs.asistenciaURI+"/Editar?idAsitencia=" + idAsitencia, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_asitencia_oid)
        {
            var result = Delete<ActionResult>(API_URIs.asistenciaURI + "/Eliminar/" + p_asitencia_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<AsitenciaDTOA>> Listar()
        {
            var result = Get<List<AsitenciaDTOA>>(API_URIs.asistenciaURI + "/Listar");
            return result.data != null ? result.data : null;
        }

        public ActionResult<AsitenciaDTOA> Obtener(int idAsitencia)
        {
            var result = Get<AsitenciaDTOA>(API_URIs.asistenciaURI + "/" + idAsitencia);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<AsitenciaDTOA>> ObtenerAsistencias(int idUsuarioRegistrado)
        {
            var result = Get<List<AsitenciaDTOA>>(API_URIs.valoracionURI + "/ObtenerAsistencias?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<AsitenciaDTOA>> ObtenerAsistenciasEvento(int idEvento)
        {
            var result = Get<List<AsitenciaDTOA>>(API_URIs.valoracionURI + "/ObtenerAsistenciasEvento?idEvento=" + idEvento);
            return result.data != null ? result.data : null;
        }
    }
}
