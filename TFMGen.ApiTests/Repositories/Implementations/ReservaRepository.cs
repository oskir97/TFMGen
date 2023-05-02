using Microsoft.AspNetCore.Mvc;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTO;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class ReservaRepository : BaseRepository, IReservaRepository
    {
        public ResponseModel<ActionResult> Cancelar(int p_oid)
        {
            var result = Post<string, ActionResult>(API_URIs.reservaURI + "/Cancelar?p_oid=" + p_oid, "");

            return result;
        }

        public ResponseModel<ReservaDTOA> Crear(ReservaDTO dto)
        {
            var result = Post<ReservaDTO, ReservaDTOA>(API_URIs.reservaURI + "/Crear", dto);

            return result;
        }

        public ResponseModel<ActionResult> Inscribirsepartido(int p_reserva_oid, IList<int> p_inscripciones_oids)
        {
            var result = Put<IList<int>, ActionResult>(API_URIs.reservaURI + "/Inscribirsepartido?p_reserva_oid=" + p_reserva_oid, p_inscripciones_oids);

            return result;
        }

        public ResponseModel<List<ReservaDTOA>> Listarreservasusuario()
        {
            var result = Get <List<ReservaDTOA>>(API_URIs.reservaURI + "/Listarreservasusuario");

            return result;
        }

        public ResponseModel<ReservaDTOA> Obtener(int idReserva)
        {
            var result = Get <ReservaDTOA>(API_URIs.reservaURI + "/" + idReserva);

            return result;
        }

        public ResponseModel<List<ReservaDTOA>> ObtenerReservas(int idUsuarioRegistrado)
        {
            var result = Get<List<ReservaDTOA>>(API_URIs.reservaURI + "/ObtenerReservas?idUsuarioRegistrado=" + idUsuarioRegistrado);

            return result;
        }

        public ResponseModel<List<ReservaDTOA>> Reserva_obtenerinscripciones(int p_idreserva)
        {
            var result = Get <List<ReservaDTOA>>(API_URIs.reservaURI + "/Reserva_obtenerinscripciones?p_idreserva=" + p_idreserva);

            return result;
        }

        public ResponseModel<List<ReservaDTOA>> Listartodos()
        {
            var result = Get <List<ReservaDTOA>>(API_URIs.reservaURI + "/Listartodos");

            return result;
        }

        public ResponseModel<List<ReservaDTOA>> ListarPartidos()
        {
            var result = Get<List<ReservaDTOA>>(API_URIs.reservaURI + "/ListarPartidos");

            return result;
        }

        public ResponseModel<List<ReservaDTOA>> ListarReservas()
        {
            var result = Get<List<ReservaDTOA>>(API_URIs.reservaURI + "/ListarReservas");

            return result;
        }

        public ResponseModel<List<ReservaDTOA>> ListarInscripciones()
        {
            var result = Get<List<ReservaDTOA>>(API_URIs.reservaURI + "/ListarInscripciones");

            return result;
        }
    }
}
