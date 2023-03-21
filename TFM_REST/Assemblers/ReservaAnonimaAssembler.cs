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
public static class ReservaAnonimaAssembler
{
public static ReservaAnonimaDTOA Convert (ReservaEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        ReservaAnonimaDTOA dto = null;
        ReservaAnonimaRESTCAD reservaAnonimaRESTCAD = null;
        ReservaCEN reservaCEN = null;
        ReservaCP reservaCP = null;

        if (en != null) {
                dto = new ReservaAnonimaDTOA ();
                reservaAnonimaRESTCAD = new ReservaAnonimaRESTCAD (session);
                reservaCEN = new ReservaCEN (reservaAnonimaRESTCAD);
                reservaCP = new ReservaCP (session, unitRepo);





                //
                // Attributes

                dto.Idreserva = en.Idreserva;

                dto.Nombre = en.Nombre;


                dto.Apellidos = en.Apellidos;


                dto.Email = en.Email;


                dto.Telefono = en.Telefono;


                dto.Cancelada = en.Cancelada;


                dto.Maxparticipantes = en.Maxparticipantes;


                dto.Fecha = en.Fecha;


                dto.Tipo = en.Tipo;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
