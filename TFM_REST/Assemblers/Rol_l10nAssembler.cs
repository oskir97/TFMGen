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
public static class Rol_l10nAssembler
{
public static Rol_l10nDTOA Convert (Rol_l10nEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        Rol_l10nDTOA dto = null;
        Rol_l10nRESTCAD rol_l10nRESTCAD = null;
        Rol_l10nCEN rol_l10nCEN = null;
        Rol_l10nCP rol_l10nCP = null;

        if (en != null) {
                dto = new Rol_l10nDTOA ();
                rol_l10nRESTCAD = new Rol_l10nRESTCAD (session);
                rol_l10nCEN = new Rol_l10nCEN (rol_l10nRESTCAD);
                rol_l10nCP = new Rol_l10nCP (session, unitRepo);





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
