using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IEntidadRepository
    {
        public ResponseModel<ActionResult> Asignarimagen(int p_oid, string p_imagen);

        public ResponseModel<ActionResult> Configurar(int p_oid, string p_config);

        public ResponseModel<ActionResult> Darsebaja(int p_oid, DateTime? p_baja);

        public ResponseModel<EntidadDTOA> Editar(int idEntidad, EntidadDTO dto);

        public ResponseModel<List<EntidadDTOA>> Listar();

        public ResponseModel<EntidadDTOA> Obtener(int idEntidad);
    }
}
