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
    public class Rol_l10nRepository : BaseRepository, IRol_l10nRepository
    {
        public ActionResult<List<Rol_l10nDTOA>> Listar(int p_ididioma)
        {
            var result = Get<List<Rol_l10nDTOA>>(API_URIs.rol_l10nURI + "/Listar");
            return result.data != null ? result.data : null;
        }
    }
}
