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
public static class MaterialAssembler
{
public static MaterialDTOA Convert (MaterialEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        MaterialDTOA dto = null;
        MaterialRESTCAD materialRESTCAD = null;
        MaterialCEN materialCEN = null;
        MaterialCP materialCP = null;

        if (en != null) {
                dto = new MaterialDTOA ();
                materialRESTCAD = new MaterialRESTCAD (session);
                materialCEN = new MaterialCEN (materialRESTCAD);
                materialCP = new MaterialCP (session, unitRepo);





                //
                // Attributes

                dto.Idmaterial = en.Idmaterial;

                dto.Nombre = en.Nombre;


                dto.Descripcion = en.Descripcion;


                dto.Precio = en.Precio;


                dto.Proveedor = en.Proveedor;


                dto.Numexistencias = en.Numexistencias;


                dto.UrlVenta = en.Urlventa;


                dto.NumeroProveedor = en.Numeroproveedor;


                dto.NumeroAlternativoProveedor = en.Numeroalternativoproveedor;


                dto.EmailProveedor = en.Emailproveedor;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
