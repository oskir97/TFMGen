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
public static class DiaSemana_l10nAssembler
{
public static DiaSemana_l10nDTOA Convert (DiaSemana_l10nEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        DiaSemana_l10nDTOA dto = null;
        DiaSemana_l10nRESTCAD diaSemana_l10nRESTCAD = null;
        DiaSemana_l10nCEN diaSemana_l10nCEN = null;
        DiaSemana_l10nCP diaSemana_l10nCP = null;

        if (en != null) {
                dto = new DiaSemana_l10nDTOA ();
                diaSemana_l10nRESTCAD = new DiaSemana_l10nRESTCAD (session);
                diaSemana_l10nCEN = new DiaSemana_l10nCEN (diaSemana_l10nRESTCAD);
                diaSemana_l10nCP = new DiaSemana_l10nCP (session, unitRepo);





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
