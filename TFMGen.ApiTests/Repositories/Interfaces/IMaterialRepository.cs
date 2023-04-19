using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMTFMGen.ApiTests.Models_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IMaterialRepository
    {
        public ResponseModel<MaterialDTOA> Crear(MaterialDTO dto);

        public ResponseModel<MaterialDTOA> Editar(int idMaterial, MaterialDTO dto);

        public ResponseModel<ActionResult> Eliminar(int p_material_oid);

        public ResponseModel<List<MaterialDTOA>> Listar(int p_idinstalacion);

        public ResponseModel<MaterialDTOA> Obtener(int idMaterial);

        public ResponseModel<List<MaterialDTOA>> Listartodos();

    }
}
