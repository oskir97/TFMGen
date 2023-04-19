using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class InstalacionRepository : BaseRepository, IInstalacionRepository
    {
        public ResponseModel<ActionResult> Asignarimagen(int p_oid, string p_imagen)
        {
            var result = Post<string, ActionResult>(API_URIs.instalacionURI + "/Asignarimagen?p_oid=" + p_oid + "&p_imagen=" + p_imagen, "");

            return result;
        }

        public ResponseModel<ActionResult> Asignarpista(int p_instalacion_oid, IList<int> p_pistas_oids)
        {
            var result = Post<IList<int>, ActionResult>(API_URIs.instalacionURI + "/Asignarpista?p_evento_oid=" + p_instalacion_oid, p_pistas_oids);

            return result;
        }

        public ResponseModel<InstalacionDTOA> Crear(InstalacionDTO dto)
        {
            var result = Post<InstalacionDTO, InstalacionDTOA>(API_URIs.instalacionURI + "/Crear", dto);

            return result;
        }

        public ResponseModel<InstalacionDTOA> Editar(int idInstalacion, InstalacionDTO dto)
        {
            var result = Put<InstalacionDTO, InstalacionDTOA>(API_URIs.instalacionURI + "/Editar?idInstalacion=" + idInstalacion, dto);

            return result;
        }

        public ResponseModel<ActionResult> Eliminar(int p_instalacion_oid)
        {
            var result = Delete<ActionResult>(API_URIs.instalacionURI + "/Eliminar?p_instalacion_oid=" + p_instalacion_oid);

            return result;
        }

        public ResponseModel<List<InstalacionDTOA>> Listar(int p_identidad)
        {
            var result = Get<List<InstalacionDTOA>>(API_URIs.instalacionURI + "/Listar?p_identidad=" + p_identidad);

            return result;
        }

        public ResponseModel<InstalacionDTOA> Obtener(int idInstalacion)
        {
            var result = Get<InstalacionDTOA>(API_URIs.instalacionURI + "/" + idInstalacion);

            return result;
        }

        public ResponseModel<List<InstalacionDTOA>> Listartodos()
        {
            var result = Get<List<InstalacionDTOA>>(API_URIs.instalacionURI + "/Listartodos");

            return result;
        }
    }
}
