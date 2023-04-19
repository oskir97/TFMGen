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
    public interface IIncidenciaRepository
    {
        public ActionResult<List<IncidenciaDTOA>> ObtenerIncidencias(int idEvento);
        public ActionResult<IncidenciaDTOA> Obtener(int idIncidencia);
        public ActionResult<System.Collections.Generic.List<IncidenciaDTOA>> Listar(int p_idevento);
        public ActionResult<IncidenciaDTOA> Crear(IncidenciaDTO dto);
        public ActionResult<IncidenciaDTOA> Modificar(int idIncidencia, IncidenciaDTO dto);
        public ActionResult Eliminar(int p_incidencia_oid);

    }
}
