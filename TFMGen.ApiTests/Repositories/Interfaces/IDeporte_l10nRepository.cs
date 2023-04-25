using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IDeporte_l10nRepository
    {
        public ResponseModel<List<Deporte_l10nDTOA>> Listartodos();
        public ResponseModel<List<Deporte_l10nDTOA>> Listar(int p_ididioma);
    }
}
