using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IDeporteRepository
    {
        public ResponseModel<List<DeporteDTOA>> Listar();
    }
}
