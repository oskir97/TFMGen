using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IPagoTipoRepository
    {
        public ResponseModel<List<PagoTipoDTOA>> Listar();

    }
}
