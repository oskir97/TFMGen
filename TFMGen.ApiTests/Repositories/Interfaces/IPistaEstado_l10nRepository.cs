using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IPistaEstado_l10nRepository
    {
        public ActionResult<System.Collections.Generic.List<PistaEstado_l10nDTOA>> Listar(int p_ididioma);

    }
}
