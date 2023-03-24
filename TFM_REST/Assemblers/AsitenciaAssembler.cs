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
public static class AsitenciaAssembler
{
public static AsitenciaDTOA Convert (AsitenciaEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        AsitenciaDTOA dto = null;
        AsitenciaRESTCAD asitenciaRESTCAD = null;
        AsitenciaCEN asitenciaCEN = null;
        AsitenciaCP asitenciaCP = null;

        if (en != null) {
                dto = new AsitenciaDTOA ();
                asitenciaRESTCAD = new AsitenciaRESTCAD (session);
                asitenciaCEN = new AsitenciaCEN (asitenciaRESTCAD);
                asitenciaCP = new AsitenciaCP (session, unitRepo);





                //
                // Attributes

                dto.Idasitencia = en.Idasitencia;

                dto.Fecha = en.Fecha;


                dto.Asiste = en.Asiste;


                dto.Notas = en.Notas;


                //
                // TravesalLink

                /* Rol: Asitencia o--> Evento */
                dto.ObtenerEvento = EventoAssembler.Convert ((EventoEN)en.Evento, unitRepo, session);


                //
                // Service
        }

        return dto;
}
}
}
