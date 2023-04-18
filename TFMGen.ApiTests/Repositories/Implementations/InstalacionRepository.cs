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
    public class InstalacionRepository : BaseRepository, IInstalacionRepository
    {
        public ActionResult Asignarimagen(int p_oid, string p_imagen)
        {
            var result = Post<string, ActionResult>(API_URIs.instalacionURI + "/Asignarimagen?p_oid=" + p_oid + "&p_imagen=" + p_imagen, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult Asignarpista(int p_instalacion_oid, IList<int> p_pistas_oids)
        {
            var result = Post<IList<int>, ActionResult>(API_URIs.instalacionURI + "/Asignarpista?p_evento_oid=" + p_instalacion_oid, p_pistas_oids);
            return result.data != null ? result.data : null;
        }

        public ActionResult<InstalacionDTOA> Crear(InstalacionDTO dto)
        {
            var result = Post<InstalacionDTO, ActionResult<InstalacionDTOA>>(API_URIs.instalacionURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<InstalacionDTOA> Editar(int idInstalacion, InstalacionDTO dto)
        {
            var result = Put<InstalacionDTO, ActionResult<InstalacionDTOA>>(API_URIs.instalacionURI + "/Editar?idInstalacion=" + idInstalacion, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_instalacion_oid)
        {
            var result = Delete<ActionResult>(API_URIs.instalacionURI + "/Eliminar/" + p_instalacion_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<InstalacionDTOA>> Listar(int p_identidad)
        {
            var result = Get<List<InstalacionDTOA>>(API_URIs.instalacionURI + "/Listar?p_identidad=" + p_identidad);
            return result.data != null ? result.data : null;
        }

        public ActionResult<InstalacionDTOA> Obtener(int idInstalacion)
        {
            var result = Get<InstalacionDTOA>(API_URIs.instalacionURI + "/" + idInstalacion);
            return result.data != null ? result.data : null;
        }
    }
}
