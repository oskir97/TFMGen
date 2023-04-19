using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class DiaSemana_l10nRepository : BaseRepository, IDiaSemana_l10nRepository
    {
        public ResponseModel<List<DiaSemana_l10nDTOA>> Listar(int p_ididioma)
        {
            var result = Get <List<DiaSemana_l10nDTOA>>(API_URIs.valoracionURI + "/Listar?p_ididioma=" + p_ididioma);
            return result;
        }

        public ResponseModel<List<DiaSemana_l10nDTOA>> Listartodos()
        {
            var result = Get <List<DiaSemana_l10nDTOA>>(API_URIs.valoracionURI + "/Listartodos");
            return result;
        }
    }
}
