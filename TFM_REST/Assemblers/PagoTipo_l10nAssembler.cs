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
public static class PagoTipo_l10nAssembler
{
public static PagoTipo_l10nDTOA Convert (PagoTipo_l10nEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        PagoTipo_l10nDTOA dto = null;
        PagoTipo_l10nRESTCAD pagoTipo_l10nRESTCAD = null;
        PagoTipo_l10nCEN pagoTipo_l10nCEN = null;
        PagoTipo_l10nCP pagoTipo_l10nCP = null;

        if (en != null) {
                dto = new PagoTipo_l10nDTOA ();
                pagoTipo_l10nRESTCAD = new PagoTipo_l10nRESTCAD (session);
                pagoTipo_l10nCEN = new PagoTipo_l10nCEN (pagoTipo_l10nRESTCAD);
                pagoTipo_l10nCP = new PagoTipo_l10nCP (session, unitRepo);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Nombre = en.Nombre;


                //
                // TravesalLink

                /* Rol: PagoTipo_l10n o--> Idioma */
                dto.GetIdiomaTipoPago = IdiomaAssembler.Convert ((IdiomaEN)en.Idioma, unitRepo, session);


                //
                // Service
        }

        return dto;
}
}
}
