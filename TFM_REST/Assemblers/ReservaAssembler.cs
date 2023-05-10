using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using TFM_REST.DTOA;
using TFM_REST.CAD;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFM_REST.Assemblers
{
public static class ReservaAssembler
{
public static ReservaDTOA Convert (ReservaEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        ReservaDTOA dto = null;
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;
        ReservaCP reservaCP = null;

        if (en != null) {
                dto = new ReservaDTOA ();
                reservaRESTCAD = new ReservaRESTCAD (session);
                reservaCEN = new ReservaCEN (reservaRESTCAD);
                reservaCP = new ReservaCP (session, unitRepo);





                //
                // Attributes

                dto.Idreserva = en.Idreserva;

                dto.Cancelada = en.Cancelada;


                dto.Maxparticipantes = en.Maxparticipantes;


                dto.Fecha = en.Fecha;


                dto.Tipo = en.Tipo;


                //
                // TravesalLink

                /* Rol: Reserva o--> Pista */
                dto.ObtenerPista = PistaAssembler.Convert ((PistaEN)en.Pista, unitRepo, session);

                /* Rol: Reserva o--> Pago */
                dto.GetPagoOfReserva = PagoAssembler.Convert ((PagoEN)en.Pago, unitRepo, session);

                /* Rol: Reserva o--> UsuarioRegistrado */
                dto.ObtenerUsuarioCreador = UsuarioRegistradoAssembler.Convert ((UsuarioEN)en.Usuario, unitRepo, session);

                /* Rol: Reserva o--> Horario */
                dto.ObtenerHorarioReserva = HorarioAssembler.Convert ((HorarioEN)en.Horario, unitRepo, session);


                //
                // Service
        }

        return dto;
}
}
}
