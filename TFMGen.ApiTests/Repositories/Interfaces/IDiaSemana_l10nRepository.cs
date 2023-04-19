using Microsoft.AspNetCore.Mvc;
using TFM_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IDiaSemana_l10nRepository
    {
        public ActionResult<List<DiaSemana_l10nDTOA>> Listar(int p_ididioma);
    }
}
