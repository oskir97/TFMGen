using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IPagoRepository
    {
        public ResponseModel<PagoDTOA> Crear(PagoDTO dto);

        public ResponseModel<List<PagoDTOA>> Listar(int p_idreserva);

        public ResponseModel<PagoDTOA> Obtener(int idPago);

        public ResponseModel<List<PagoDTOA>> Listartodos();
    }
}
