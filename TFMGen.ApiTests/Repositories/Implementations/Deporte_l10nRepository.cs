using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class Deporte_l10nRepository : BaseRepository, IDeporte_l10nRepository
    {
        public ResponseModel<List<Deporte_l10nDTOA>> Listartodos()
        {
            var result = Get <List<Deporte_l10nDTOA>>(API_URIs.deporte_l10nURI + "/Listar");
            return result;
        }

        public ResponseModel<List<Deporte_l10nDTOA>> Listar(int p_ididioma)
        {
            var result = Get<List<Deporte_l10nDTOA>>(API_URIs.deporte_l10nURI + "/Listar?p_ididioma=" + p_ididioma);
            return result;
        }
    }
}
