using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class Rol_l10nRepository : BaseRepository, IRol_l10nRepository
    {
        public ResponseModel<List<Rol_l10nDTOA>> Listar(int p_ididioma)
        {
            var result = Get <List<Rol_l10nDTOA>>(API_URIs.rol_l10nURI + "/Listar");
            return result;
        }

        public ResponseModel<List<Rol_l10nDTOA>> Listartodos()
        {
            var result = Get <List<Rol_l10nDTOA>>(API_URIs.rol_l10nURI + "/Listartodos");
            return result;
        }
    }
}
