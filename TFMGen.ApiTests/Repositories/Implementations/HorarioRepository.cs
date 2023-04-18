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
    public class HorarioRepository : BaseRepository, IHorarioRepository
    {
        public ActionResult<HorarioDTOA> Crear(HorarioDTO dto)
        {
            var result = Post<HorarioDTO, ActionResult<HorarioDTOA>>(API_URIs.horarioURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult<HorarioDTOA> Editar(int idHorario, HorarioDTO dto)
        {
            var result = Put<HorarioDTO, ActionResult<HorarioDTOA>>(API_URIs.horarioURI + "/Editar?idHorario=" + idHorario, dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Eliminar(int p_horario_oid)
        {
            var result = Delete<ActionResult>(API_URIs.horarioURI + "/Eliminar/" + p_horario_oid);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<HorarioDTOA>> Listar(int p_idpista)
        {
            var result = Get<List<HorarioDTOA>>(API_URIs.horarioURI + "/Listar?p_idpista=" + p_idpista);
            return result.data != null ? result.data : null;
        }

        public ActionResult<HorarioDTOA> Obtener(int idHorario)
        {
            var result = Get<HorarioDTOA>(API_URIs.horarioURI + "/" + idHorario);
            return result.data != null ? result.data : null;
        }
    }
}
