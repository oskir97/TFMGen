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
    public class PagoTipo_l10nRepository : BaseRepository, IPagoTipo_l10nRepository
    {
        public ActionResult<List<PagoTipo_l10nDTOA>> Listar(int p_ididioma)
        {
            var result = Get<List<PagoTipo_l10nDTOA>>(API_URIs.pagoTipo_l10nURI + "/Listar");
            return result.data != null ? result.data : null;
        }
    }
}
