using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IDiaSemanaRepository
    {
        public ResponseModel<List<DiaSemanaDTOA>> Listar();

        public ResponseModel<List<DiaSemanaDTOA>> Obtener(string p_dia);
    }
}
