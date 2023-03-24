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
public static class PagoAssembler
{
public static PagoDTOA Convert (PagoEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        PagoDTOA dto = null;
        PagoRESTCAD pagoRESTCAD = null;
        PagoCEN pagoCEN = null;
        PagoCP pagoCP = null;

        if (en != null) {
                dto = new PagoDTOA ();
                pagoRESTCAD = new PagoRESTCAD (session);
                pagoCEN = new PagoCEN (pagoRESTCAD);
                pagoCP = new PagoCP (session, unitRepo);





                //
                // Attributes

                dto.Idpago = en.Idpago;

                dto.Subtotal = en.Subtotal;


                dto.Total = en.Total;


                dto.Iva = en.Iva;


                dto.Fecha = en.Fecha;


                //
                // TravesalLink

                /* Rol: Pago o--> PagoTipo */
                dto.ObtenerTipo = PagoTipoAssembler.Convert ((PagoTipoEN)en.Tipo, unitRepo, session);


                //
                // Service
        }

        return dto;
}
}
}
