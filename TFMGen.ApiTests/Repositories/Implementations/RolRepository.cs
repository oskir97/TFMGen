using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class RolRepository : BaseRepository, IRolRepository
    {
        public ResponseModel<List<RolDTOA>> Listar()
        {
            var result = Get <List<RolDTOA>>(API_URIs.rolURI + "/Listar");

            return result;
        }
    }
}
