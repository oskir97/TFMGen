using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;
using TFMGen.ApiTests.Tests.UsuarioRegistrado;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class AsistenciaRepository : BaseRepository, IAsistenciaRepository
    {
        public ResponseModel<AsitenciaDTOA> Crear(AsitenciaDTO dto)
        {
            var result = Post<AsitenciaDTO, AsitenciaDTOA>(API_URIs.asistenciaURI + "/Crear", dto);

            return result;
        }

        public ResponseModel<AsitenciaDTOA> Editar(int idAsitencia, AsitenciaDTO dto)
        {
            var result = Put<AsitenciaDTO, AsitenciaDTOA>(API_URIs.asistenciaURI+"/Editar?idAsitencia=" + idAsitencia, dto);

            return result;
        }


        public ResponseModel<ActionResult> Eliminar(int p_asitencia_oid)
        {
            var result = Delete<ActionResult>(API_URIs.asistenciaURI + "/Eliminar?p_asitencia_oid=" + p_asitencia_oid);

            return result;
        }

        public ResponseModel<List<AsitenciaDTOA>> Listar(int idusuario)
        {
            var result = Get<List<AsitenciaDTOA>>(API_URIs.asistenciaURI + "/Listar?idusuario=" + idusuario);

            return result;
        }

        public ResponseModel<List<AsitenciaDTOA>> Listartodos()
        {
            var result = Get<List<AsitenciaDTOA>>(API_URIs.asistenciaURI + "/Listartodos");

            return result;

        }

        public ResponseModel<AsitenciaDTOA> Obtener(int idAsitencia)
        {
            var result = Get<AsitenciaDTOA>(API_URIs.asistenciaURI + "/" + idAsitencia);

            return result;
        }

        public ResponseModel<List<AsitenciaDTOA>> ObtenerAsistencias(int idUsuarioRegistrado)
        {
            //var result = Get<List<AsitenciaDTOA>>(API_URIs.valoracionURI + "/ObtenerAsistencias?idUsuarioRegistrado=" + idUsuarioRegistrado);
            var result = Get<List<AsitenciaDTOA>>(API_URIs.asistenciaURI + "/ObtenerAsistencias?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result;
        }

        public ResponseModel<List<AsitenciaDTOA>> ObtenerAsistenciasEvento(int idEvento)
        {
            var result = Get<List<AsitenciaDTOA>>(API_URIs.asistenciaURI + "/ObtenerAsistenciasEvento?idEvento=" + idEvento);
            //var result = Get<List<AsitenciaDTOA>>(API_URIs.valoracionURI + "/ObtenerAsistenciasEvento?idEvento=" + idEvento);
            return result;
        }
    }
}
