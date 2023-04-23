using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class DiaSemanaRepository : BaseRepository, IDiaSemanaRepository
    {
        public ResponseModel<List<DiaSemanaDTOA>> Listar()
        {
            var result = Get <List<DiaSemanaDTOA>>(API_URIs.diaSemanaURI + "/Listar");

            return result;
        }

        public ResponseModel<List<DiaSemanaDTOA>> Obtener(string p_dia)
        {
            //var result = Get <List<DiaSemanaDTOA>>(API_URIs.diaSemanaURI + "/" + p_dia);
            var result = Get<List<DiaSemanaDTOA>>(API_URIs.diaSemanaURI + "/Obtener?p_dia" + p_dia);
            return result;
        }
    }
}
