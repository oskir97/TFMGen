using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class PistaEstado_l10nRepository : BaseRepository, IPistaEstado_l10nRepository
    {
        public ResponseModel<List<PistaEstado_l10nDTOA>> Listar(int p_ididioma)
        {
            var result = Get<List<PistaEstado_l10nDTOA>>(API_URIs.pistaEstado_l10nURI + "/Listar?p_ididioma=" + p_ididioma);
            return result;
        }

        public ResponseModel<List<PistaEstado_l10nDTOA>> Listartodos()
        {
            var result = Get<List<PistaEstado_l10nDTOA>>(API_URIs.pistaEstado_l10nURI + "/Listartodos");
            return result;
        }
    }
}
