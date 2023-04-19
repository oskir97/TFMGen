using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class IdiomaRepository : BaseRepository, IIdiomaRepository
    {
        public ResponseModel<List<IdiomaDTOA>> Listar()
        {
            var result = Get <List<IdiomaDTOA>>(API_URIs.idiomaURI + "/Listar");

            return result;
        }
    }
}
