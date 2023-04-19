using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class DiaSemanaRepository : BaseRepository, IDiaSemanaRepository
    {
        public ActionResult<List<DiaSemanaDTOA>> Listar()
        {
            var result = Get<List<DiaSemanaDTOA>>(API_URIs.diaSemanaURI + "/Listar");
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<DiaSemanaDTOA>> Obtener(string p_dia)
        {
            var result = Get<List<DiaSemanaDTOA>>(API_URIs.diaSemanaURI + "/" + p_dia);
            return result.data != null ? result.data : null;
        }
    }
}
