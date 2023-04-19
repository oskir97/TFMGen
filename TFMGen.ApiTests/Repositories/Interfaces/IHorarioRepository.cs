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
    public interface IHorarioRepository
    {
        public ActionResult<HorarioDTOA> Obtener(int idHorario);
        public ActionResult<System.Collections.Generic.List<HorarioDTOA>> Listar(int p_idpista);
        public ActionResult<HorarioDTOA> Crear(HorarioDTO dto);
        public ActionResult<HorarioDTOA> Editar(int idHorario, HorarioDTO dto);
        public ActionResult Eliminar(int p_horario_oid);

    }
}
