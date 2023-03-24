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
public static class NotificacionAssembler
{
public static NotificacionDTOA Convert (NotificacionEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        NotificacionDTOA dto = null;
        NotificacionRESTCAD notificacionRESTCAD = null;
        NotificacionCEN notificacionCEN = null;
        NotificacionCP notificacionCP = null;

        if (en != null) {
                dto = new NotificacionDTOA ();
                notificacionRESTCAD = new NotificacionRESTCAD (session);
                notificacionCEN = new NotificacionCEN (notificacionRESTCAD);
                notificacionCP = new NotificacionCP (session, unitRepo);





                //
                // Attributes

                dto.Idnotificacion = en.Idnotificacion;

                dto.Asunto = en.Asunto;


                dto.Descripcion = en.Descripcion;


                dto.Leida = en.Leida;


                dto.Tipo = en.Tipo;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
