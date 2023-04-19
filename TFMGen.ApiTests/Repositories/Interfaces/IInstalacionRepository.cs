using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IInstalacionRepository
    {
        public ResponseModel<ActionResult> Asignarimagen(int p_oid, string p_imagen);

        public ResponseModel<ActionResult> Asignarpista(int p_instalacion_oid, IList<int> p_pistas_oids);

        public ResponseModel<InstalacionDTOA> Crear(InstalacionDTO dto);

        public ResponseModel<InstalacionDTOA> Editar(int idInstalacion, InstalacionDTO dto);

        public ResponseModel<ActionResult> Eliminar(int p_instalacion_oid);

        public ResponseModel<List<InstalacionDTOA>> Listar(int p_identidad);

        public ResponseModel<InstalacionDTOA> Obtener(int idInstalacion);

        public ResponseModel<List<InstalacionDTOA>> Listartodos();
    }
}
