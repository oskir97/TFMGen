using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class PagoRepository : BaseRepository, IPagoRepository
    {
        public ResponseModel<PagoDTOA> Crear(PagoDTO dto)
        {
            var result = Post<PagoDTO, PagoDTOA>(API_URIs.pagoURI + "/Crear", dto);

            return result;
        }

        public ResponseModel<List<PagoDTOA>> Listar(int p_idreserva)
        {
            var result = Get <List<PagoDTOA>>(API_URIs.pagoURI + "/Listar?p_idreserva=" + p_idreserva);
            return result;
        }

        public ResponseModel<PagoDTOA> Obtener(int idPago)
        {
            var result = Get <PagoDTOA>(API_URIs.pagoURI + "/" + idPago);
            return result;
        }

        public ResponseModel<List<PagoDTOA>> Listartodos()
        {
            var result = Get <List<PagoDTOA>>(API_URIs.pagoURI + "/Listartodos");
            return result;
        }
    }
}
