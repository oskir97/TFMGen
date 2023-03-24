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
public static class PagoTipoAssembler
{
public static PagoTipoDTOA Convert (PagoTipoEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        PagoTipoDTOA dto = null;
        PagoTipoRESTCAD pagoTipoRESTCAD = null;
        PagoTipoCEN pagoTipoCEN = null;
        PagoTipoCP pagoTipoCP = null;

        if (en != null) {
                dto = new PagoTipoDTOA ();
                pagoTipoRESTCAD = new PagoTipoRESTCAD (session);
                pagoTipoCEN = new PagoTipoCEN (pagoTipoRESTCAD);
                pagoTipoCP = new PagoTipoCP (session, unitRepo);





                //
                // Attributes

                dto.Idtipo = en.Idtipo;

                dto.Nombre = en.Nombre;


                //
                // TravesalLink

                /* Rol: PagoTipo o--> PagoTipo_l10n */
                dto.ObtenerTraduccionesTipos = null;
                List<PagoTipo_l10nEN> ObtenerTraduccionesTipos = pagoTipoRESTCAD.ObtenerTraduccionesTipos (en.Idtipo).ToList ();
                if (ObtenerTraduccionesTipos != null) {
                        dto.ObtenerTraduccionesTipos = new List<PagoTipo_l10nDTOA>();
                        foreach (PagoTipo_l10nEN entry in ObtenerTraduccionesTipos)
                                dto.ObtenerTraduccionesTipos.Add (PagoTipo_l10nAssembler.Convert (entry, unitRepo, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
