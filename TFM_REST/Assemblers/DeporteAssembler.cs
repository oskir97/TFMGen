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
public static class DeporteAssembler
{
public static DeporteDTOA Convert (DeporteEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        DeporteDTOA dto = null;
        DeporteRESTCAD deporteRESTCAD = null;
        DeporteCEN deporteCEN = null;
        DeporteCP deporteCP = null;

        if (en != null) {
                dto = new DeporteDTOA ();
                deporteRESTCAD = new DeporteRESTCAD (session);
                deporteCEN = new DeporteCEN (deporteRESTCAD);
                deporteCP = new DeporteCP (session, unitRepo);





                //
                // Attributes

                dto.Iddeporte = en.Iddeporte;

                dto.Nombre = en.Nombre;


                dto.Descripcion = en.Descripcion;


                dto.Icono = en.Icono;


                //
                // TravesalLink

                /* Rol: Deporte o--> Deporte_l10n */
                dto.TraduccionesDeporte = null;
                List<Deporte_l10nEN> TraduccionesDeporte = deporteRESTCAD.TraduccionesDeporte (en.Iddeporte).ToList ();
                if (TraduccionesDeporte != null) {
                        dto.TraduccionesDeporte = new List<Deporte_l10nDTOA>();
                        foreach (Deporte_l10nEN entry in TraduccionesDeporte)
                                dto.TraduccionesDeporte.Add (Deporte_l10nAssembler.Convert (entry, unitRepo, session));
                }

                /* Rol: Deporte o--> Evento */
                dto.ObtenerDeporteEvento = null;
                List<EventoEN> ObtenerDeporteEvento = deporteRESTCAD.ObtenerDeporteEvento (en.Iddeporte).ToList ();
                if (ObtenerDeporteEvento != null) {
                        dto.ObtenerDeporteEvento = new List<EventoDTOA>();
                        foreach (EventoEN entry in ObtenerDeporteEvento)
                                dto.ObtenerDeporteEvento.Add (EventoAssembler.Convert (entry, unitRepo, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
