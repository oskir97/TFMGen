using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IIdiomaRepository
    {
        public ResponseModel<List<IdiomaDTOA>> Listar();

    }
}
