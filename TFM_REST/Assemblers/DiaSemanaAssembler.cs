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
public static class DiaSemanaAssembler
{
public static DiaSemanaDTOA Convert (DiaSemanaEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        DiaSemanaDTOA dto = null;
        DiaSemanaRESTCAD diaSemanaRESTCAD = null;
        DiaSemanaCEN diaSemanaCEN = null;
        DiaSemanaCP diaSemanaCP = null;

        if (en != null) {
                dto = new DiaSemanaDTOA ();
                diaSemanaRESTCAD = new DiaSemanaRESTCAD (session);
                diaSemanaCEN = new DiaSemanaCEN (diaSemanaRESTCAD);
                diaSemanaCP = new DiaSemanaCP (session, unitRepo);





                //
                // Attributes

                dto.Iddiasemana = en.Iddiasemana;

                dto.Nombre = en.Nombre;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
