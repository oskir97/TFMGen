using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;
using TFMTFMGen.ApiTests.Models_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class MaterialRepository : BaseRepository, IMaterialRepository
    {
        public ResponseModel<MaterialDTOA> Crear(MaterialDTO dto)
        {
            var result = Post<MaterialDTO, MaterialDTOA>(API_URIs.materialURI + "/Crear", dto);
            return result;
        }

        public ResponseModel<MaterialDTOA> Editar(int idMaterial, MaterialDTO dto)
        {
            var result = Put<MaterialDTO, MaterialDTOA>(API_URIs.materialURI + "/Editar?idMaterial=" + idMaterial, dto);
            return result;
        }

        public ResponseModel<ActionResult> Eliminar(int p_material_oid)
        {
            var result = Delete<ActionResult>(API_URIs.materialURI + "/Eliminar?p_material_oid=" + p_material_oid);
            return result;
        }

        public ResponseModel<List<MaterialDTOA>> Listar(int p_idinstalacion)
        {
            var result = Get <List<MaterialDTOA>>(API_URIs.materialURI + "/Listar?p_idinstalacion=" + p_idinstalacion);
            return result;
        }

        public ResponseModel<MaterialDTOA> Obtener(int idMaterial)
        {
            var result = Get <MaterialDTOA>(API_URIs.materialURI + "/" + idMaterial);
            return result;
        }

        public ResponseModel<List<MaterialDTOA>> Listartodos()
        {
            var result = Get <List<MaterialDTOA>>(API_URIs.materialURI + "/Listartodos");
            return result;
        }
    }
}
