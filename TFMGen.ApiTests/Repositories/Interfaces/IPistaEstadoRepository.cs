using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IPistaEstadoRepository
    {
        public ResponseModel<List<PistaEstadoDTOA>> Listar();

    }
}
