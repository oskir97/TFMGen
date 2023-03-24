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
public static class PistaEstado_l10nAssembler
{
public static PistaEstado_l10nDTOA Convert (PistaEstado_l10nEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        PistaEstado_l10nDTOA dto = null;
        PistaEstado_l10nRESTCAD pistaEstado_l10nRESTCAD = null;
        PistaEstado_l10nCEN pistaEstado_l10nCEN = null;
        PistaEstado_l10nCP pistaEstado_l10nCP = null;

        if (en != null) {
                dto = new PistaEstado_l10nDTOA ();
                pistaEstado_l10nRESTCAD = new PistaEstado_l10nRESTCAD (session);
                pistaEstado_l10nCEN = new PistaEstado_l10nCEN (pistaEstado_l10nRESTCAD);
                pistaEstado_l10nCP = new PistaEstado_l10nCP (session, unitRepo);





                //
                // Attributes

                dto.Id = en.Id;

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
