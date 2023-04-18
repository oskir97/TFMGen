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
    public interface IDiaSemanaRepository
    {
        public ActionResult<List<DiaSemanaDTOA>> Listar();
        public ActionResult<List<DiaSemanaDTOA>> Obtener(string p_dia);
    }
}
