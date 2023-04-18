using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;
using TFM_REST.DTOA;
using TFMGen.ApiTests.Repositories.Interfaces;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class ReservaRepository : BaseRepository, IReservaRepository
    {
        public ActionResult Cancelar(int p_oid)
        {
            var result = Post<string, ActionResult>(API_URIs.reservaURI + "/Cancelar?p_oid=" + p_oid, "");
            return result.data != null ? result.data : null;
        }

        public ActionResult<ReservaDTOA> Crear(ReservaDTO dto)
        {
            var result = Post<ReservaDTO, ActionResult<ReservaDTOA>>(API_URIs.reservaURI + "/Crear", dto);
            return result.data != null ? result.data : null;
        }

        public ActionResult Inscribirsepartido(int p_reserva_oid, IList<int> p_inscripciones_oids)
        {
            var result = Post<IList<int>, ActionResult>(API_URIs.reservaURI + "/Inscribirsepartido?p_reserva_oid=" + p_reserva_oid, p_inscripciones_oids);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<ReservaDTOA>> Listarreservasusuario()
        {
            var result = Get<List<ReservaDTOA>>(API_URIs.reservaURI + "/Listarreservasusuario");
            return result.data != null ? result.data : null;
        }

        public ActionResult<ReservaDTOA> Obtener(int idReserva)
        {
            var result = Get<ReservaDTOA>(API_URIs.reservaURI + "/" + idReserva);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<ReservaDTOA>> ObtenerReservas(int idUsuarioRegistrado)
        {
            var result = Get<List<ReservaDTOA>>(API_URIs.reservaURI + "/ObtenerReservas?idUsuarioRegistrado=" + idUsuarioRegistrado);
            return result.data != null ? result.data : null;
        }

        public ActionResult<List<ReservaDTOA>> Reserva_obtenerinscripciones(int p_idreserva)
        {
            var result = Get<List<ReservaDTOA>>(API_URIs.reservaURI + "/Reserva_obtenerinscripciones?p_idreserva=" + p_idreserva);
            return result.data != null ? result.data : null;
        }
    }
}
