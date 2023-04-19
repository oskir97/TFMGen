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
    public class PistaEstado_l10nRepository : BaseRepository, IPistaEstado_l10nRepository
    {
        public ActionResult<List<PistaEstado_l10nDTOA>> Listar(int p_ididioma)
        {
            var result = Get<List<PistaEstado_l10nDTOA>>(API_URIs.pistaEstado_l10nURI + "/Listar?p_ididioma=" + p_ididioma);
            return result.data != null ? result.data : null;
        }
    }
}
