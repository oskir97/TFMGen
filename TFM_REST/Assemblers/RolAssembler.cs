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
public static class RolAssembler
{
public static RolDTOA Convert (RolEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        RolDTOA dto = null;
        RolRESTCAD rolRESTCAD = null;
        RolCEN rolCEN = null;
        RolCP rolCP = null;

        if (en != null) {
                dto = new RolDTOA ();
                rolRESTCAD = new RolRESTCAD (session);
                rolCEN = new RolCEN (rolRESTCAD);
                rolCP = new RolCP (session, unitRepo);





                //
                // Attributes

                dto.Idrol = en.Idrol;

                dto.Nombre = en.Nombre;


                //
                // TravesalLink

                /* Rol: Rol o--> Rol_l10n */
                dto.ObtenerTraduccionesRol = null;
                List<Rol_l10nEN> ObtenerTraduccionesRol = rolRESTCAD.ObtenerTraduccionesRol (en.Idrol).ToList ();
                if (ObtenerTraduccionesRol != null) {
                        dto.ObtenerTraduccionesRol = new List<Rol_l10nDTOA>();
                        foreach (Rol_l10nEN entry in ObtenerTraduccionesRol)
                                dto.ObtenerTraduccionesRol.Add (Rol_l10nAssembler.Convert (entry, unitRepo, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
