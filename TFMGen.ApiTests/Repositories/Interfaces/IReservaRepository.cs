using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFM_REST.DTO;
using TFM_REST.DTOA;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IReservaRepository
    {
        public ActionResult<List<ReservaDTOA>> ObtenerReservas(int idUsuarioRegistrado);
        public ActionResult<ReservaDTOA> Obtener(int idReserva);
        public ActionResult<System.Collections.Generic.List<ReservaDTOA>> Listarreservasusuario();
        public ActionResult<List<ReservaDTOA>> Reserva_obtenerinscripciones(int p_idreserva);
        public ActionResult<ReservaDTOA> Crear(ReservaDTO dto);
        public ActionResult Inscribirsepartido(int p_reserva_oid, System.Collections.Generic.IList<int> p_inscripciones_oids);
        public ActionResult Cancelar(int p_oid);

    }
}
