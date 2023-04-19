using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IRol_l10nRepository
    {
        public ResponseModel<List<Rol_l10nDTOA>> Listar(int p_ididioma);

        public ResponseModel<List<Rol_l10nDTOA>> Listartodos();
    }
}
