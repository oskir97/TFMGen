using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IDiaSemana_l10nRepository
    {
        public ResponseModel<List<DiaSemana_l10nDTOA>> Listar(int p_ididioma);

        public ResponseModel<List<DiaSemana_l10nDTOA>> Listartodos();
    }
}
