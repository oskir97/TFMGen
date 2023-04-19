using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class HorarioRepository : BaseRepository, IHorarioRepository
    {
        public ResponseModel<HorarioDTOA> Crear(HorarioDTO dto)
        {
            var result = Post<HorarioDTO,HorarioDTOA>(API_URIs.horarioURI + "/Crear", dto);

            return result;
        }

        public ResponseModel<HorarioDTOA> Editar(int idHorario, HorarioDTO dto)
        {
            var result = Put<HorarioDTO, HorarioDTOA>(API_URIs.horarioURI + "/Editar?idHorario=" + idHorario, dto);

            return result;
        }

        public ResponseModel<ActionResult> Eliminar(int p_horario_oid)
        {
            var result = Delete<ActionResult>(API_URIs.horarioURI + "/Eliminar?p_horario_oid=" + p_horario_oid);

            return result;
        }

        public ResponseModel<List<HorarioDTOA>> Listar(int p_idpista)
        {
            var result = Get<List<HorarioDTOA>>(API_URIs.horarioURI + "/Listar?p_idpista=" + p_idpista);

            return result;
        }

        public ResponseModel<HorarioDTOA> Obtener(int idHorario)
        {
            var result = Get<HorarioDTOA>(API_URIs.horarioURI + "/" + idHorario);

            return result;
        }

        public ResponseModel<List<HorarioDTOA>> Listartodos()
        {
            var result = Get<List<HorarioDTOA>>(API_URIs.horarioURI + "/Listartodos");

            return result;
        }
    }
}
