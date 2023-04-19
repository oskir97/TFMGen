using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class PistaEstadoRepository : BaseRepository, IPistaEstadoRepository
    {
        public ResponseModel<List<PistaEstadoDTOA>> Listar()
        {
            var result = Get<List<PistaEstadoDTOA>>(API_URIs.pistaEstadoURI + "/Listar");
            return result;
        }
    }
}
