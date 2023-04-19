using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IHorarioRepository
    {
        public ResponseModel<HorarioDTOA> Crear(HorarioDTO dto);

        public ResponseModel<HorarioDTOA> Editar(int idHorario, HorarioDTO dto);

        public ResponseModel<ActionResult> Eliminar(int p_horario_oid);

        public ResponseModel<List<HorarioDTOA>> Listar(int p_idpista);

        public ResponseModel<HorarioDTOA> Obtener(int idHorario);

        public ResponseModel<List<HorarioDTOA>> Listartodos();
    }
}
