using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class DeporteRepository : BaseRepository, IDeporteRepository
    {
        public ResponseModel<List<DeporteDTOA>> Listar()
        {
            var result = Get <List<DeporteDTOA>>(API_URIs.deporteURI + "/Listar");

            return result;
        }
    }
}
