using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class PagoTipo_l10nRepository : BaseRepository, IPagoTipo_l10nRepository
    {
        public ResponseModel<List<PagoTipo_l10nDTOA>> Listar(int p_ididioma)
        {
            var result = Get<List<PagoTipo_l10nDTOA>>(API_URIs.pagoTipo_l10nURI + "/Listar");
            return result;
        }

        public ResponseModel<List<PagoTipo_l10nDTOA>> Listartodos()
        {
            var result = Get<List<PagoTipo_l10nDTOA>>(API_URIs.pagoTipo_l10nURI + "/Listartodos");
            return result;
        }
    }
}
