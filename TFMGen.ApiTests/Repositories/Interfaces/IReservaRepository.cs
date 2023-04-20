using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IReservaRepository
    {
        public ResponseModel<ActionResult> Cancelar(int p_oid);

        public ResponseModel<ReservaDTOA> Crear(ReservaDTO dto);

        public ResponseModel<ActionResult> Inscribirsepartido(int p_reserva_oid, IList<int> p_inscripciones_oids);

        public ResponseModel<List<ReservaDTOA>> Listarreservasusuario();

        public ResponseModel<ReservaDTOA> Obtener(int idReserva);

        public ResponseModel<List<ReservaDTOA>> ObtenerReservas(int idUsuarioRegistrado);

        public ResponseModel<List<ReservaDTOA>> Reserva_obtenerinscripciones(int p_idreserva);

        public ResponseModel<List<ReservaDTOA>> Listartodos();

        public ResponseModel<List<ReservaDTOA>> ListarPartidos();

        public ResponseModel<List<ReservaDTOA>> ListarReservas();

        public ResponseModel<List<ReservaDTOA>> ListarInscripciones();
    }
}
