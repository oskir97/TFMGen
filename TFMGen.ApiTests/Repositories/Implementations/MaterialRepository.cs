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
    public class MaterialRepository : BaseRepository, IMaterialRepository
    {
        public ActionResult<MaterialDTOA> Crear(MaterialDTO dto)
        {
            var result = Post<MaterialDTO, ActionResult<MaterialDTOA>>(API_URIs.materialURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<MaterialDTOA> Editar(int idMaterial, MaterialDTO dto)
        {
            var result = Put<MaterialDTO, ActionResult<MaterialDTOA>>(API_URIs.materialURI + "/Editar?idMaterial=" + idMaterial, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_material_oid)
        {
            var result = Delete<ActionResult>(API_URIs.materialURI + "/Eliminar/" + p_material_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<MaterialDTOA>> Listar(int p_idinstalacion)
        {
            var result = Get<List<MaterialDTOA>>(API_URIs.materialURI + "/Listar?p_idinstalacion=" + p_idinstalacion);
            return result.data != null ? result.data : null;
        }

        public ActionResult<MaterialDTOA> Obtener(int idMaterial)
        {
            var result = Get<MaterialDTOA>(API_URIs.materialURI + "/" + idMaterial);
            return result.data != null ? result.data : null;
        }
    }
}
