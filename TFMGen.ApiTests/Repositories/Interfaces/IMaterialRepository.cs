using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;
using TFM_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IMaterialRepository
    {
        public ActionResult<MaterialDTOA> Obtener(int idMaterial);
        public ActionResult<System.Collections.Generic.List<MaterialDTOA>> Listar(int p_idinstalacion);
        public ActionResult<MaterialDTOA> Crear(MaterialDTO dto);
        public ActionResult<MaterialDTOA> Editar(int idMaterial, MaterialDTO dto);
        public ActionResult Eliminar(int p_material_oid);

    }
}
