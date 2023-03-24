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
public static class PistaEstadoAssembler
{
public static PistaEstadoDTOA Convert (PistaEstadoEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        PistaEstadoDTOA dto = null;
        PistaEstadoRESTCAD pistaEstadoRESTCAD = null;
        PistaEstadoCEN pistaEstadoCEN = null;
        PistaEstadoCP pistaEstadoCP = null;

        if (en != null) {
                dto = new PistaEstadoDTOA ();
                pistaEstadoRESTCAD = new PistaEstadoRESTCAD (session);
                pistaEstadoCEN = new PistaEstadoCEN (pistaEstadoRESTCAD);
                pistaEstadoCP = new PistaEstadoCP (session, unitRepo);





                //
                // Attributes

                dto.Idestado = en.Idestado;

                dto.Nombre = en.Nombre;


                //
                // TravesalLink

                /* Rol: PistaEstado o--> PistaEstado_l10n */
                dto.ObtenerTraduccionesEstado = null;
                List<PistaEstado_l10nEN> ObtenerTraduccionesEstado = pistaEstadoRESTCAD.ObtenerTraduccionesEstado (en.Idestado).ToList ();
                if (ObtenerTraduccionesEstado != null) {
                        dto.ObtenerTraduccionesEstado = new List<PistaEstado_l10nDTOA>();
                        foreach (PistaEstado_l10nEN entry in ObtenerTraduccionesEstado)
                                dto.ObtenerTraduccionesEstado.Add (PistaEstado_l10nAssembler.Convert (entry, unitRepo, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
