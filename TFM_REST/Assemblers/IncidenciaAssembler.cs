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
public static class IncidenciaAssembler
{
public static IncidenciaDTOA Convert (IncidenciaEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        IncidenciaDTOA dto = null;
        IncidenciaRESTCAD incidenciaRESTCAD = null;
        IncidenciaCEN incidenciaCEN = null;
        IncidenciaCP incidenciaCP = null;

        if (en != null) {
                dto = new IncidenciaDTOA ();
                incidenciaRESTCAD = new IncidenciaRESTCAD (session);
                incidenciaCEN = new IncidenciaCEN (incidenciaRESTCAD);
                incidenciaCP = new IncidenciaCP (session, unitRepo);





                //
                // Attributes

                dto.Idincidencia = en.Idincidencia;

                dto.Asunto = en.Asunto;


                dto.Descripcion = en.Descripcion;


                dto.Fechacancelada = en.Fechacancelada;


                dto.Fechareemplazada = en.Fechareemplazada;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
