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
public static class Deporte_l10nAssembler
{
public static Deporte_l10nDTOA Convert (Deporte_l10nEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        Deporte_l10nDTOA dto = null;
        Deporte_l10nRESTCAD deporte_l10nRESTCAD = null;
        Deporte_l10nCEN deporte_l10nCEN = null;
        Deporte_l10nCP deporte_l10nCP = null;

        if (en != null) {
                dto = new Deporte_l10nDTOA ();
                deporte_l10nRESTCAD = new Deporte_l10nRESTCAD (session);
                deporte_l10nCEN = new Deporte_l10nCEN (deporte_l10nRESTCAD);
                deporte_l10nCP = new Deporte_l10nCP (session, unitRepo);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Nombre = en.Nombre;


                //
                // TravesalLink

                /* Rol: Deporte_l10n o--> Idioma */
                dto.GetIdiomaDeporte = IdiomaAssembler.Convert ((IdiomaEN)en.Idioma, unitRepo, session);


                //
                // Service
        }

        return dto;
}
}
}
