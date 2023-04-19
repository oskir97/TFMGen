using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class PagoTipoRepository : BaseRepository, IPagoTipoRepository
    {
        public ResponseModel<List<PagoTipoDTOA>> Listar()
        {
            var result = Get <List<PagoTipoDTOA>>(API_URIs.pagoTipoURI + "/Listar");

            return result;
        }
    }
}
