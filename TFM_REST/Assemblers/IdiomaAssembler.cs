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
public static class IdiomaAssembler
{
public static IdiomaDTOA Convert (IdiomaEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        IdiomaDTOA dto = null;
        IdiomaRESTCAD idiomaRESTCAD = null;
        IdiomaCEN idiomaCEN = null;
        IdiomaCP idiomaCP = null;

        if (en != null) {
                dto = new IdiomaDTOA ();
                idiomaRESTCAD = new IdiomaRESTCAD (session);
                idiomaCEN = new IdiomaCEN (idiomaRESTCAD);
                idiomaCP = new IdiomaCP (session, unitRepo);





                //
                // Attributes

                dto.Ididioma = en.Ididioma;

                dto.Nombre = en.Nombre;


                dto.Cultura = en.Cultura;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
