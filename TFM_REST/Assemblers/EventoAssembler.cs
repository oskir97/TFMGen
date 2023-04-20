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
public static class EventoAssembler
{
public static EventoDTOA Convert (EventoEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        EventoDTOA dto = null;
        EventoRESTCAD eventoRESTCAD = null;
        EventoCEN eventoCEN = null;
        EventoCP eventoCP = null;

        if (en != null) {
                dto = new EventoDTOA ();
                eventoRESTCAD = new EventoRESTCAD (session);
                eventoCEN = new EventoCEN (eventoRESTCAD);
                eventoCP = new EventoCP (session, unitRepo);





                //
                // Attributes

                dto.Idevento = en.Idevento;

                dto.Nombre = en.Nombre;


                dto.Descripcion = en.Descripcion;


                dto.Activo = en.Activo;


                dto.Plazas = en.Plazas;


                //
                // TravesalLink

                /* Rol: Evento o--> UsuarioRegistrado */
                dto.ObtenerInstructores = null;
                List<UsuarioEN> ObtenerInstructores = eventoRESTCAD.ObtenerInstructores (en.Idevento).ToList ();
                if (ObtenerInstructores != null) {
                        dto.ObtenerInstructores = new List<UsuarioRegistradoDTOA>();
                        foreach (UsuarioEN entry in ObtenerInstructores)
                                dto.ObtenerInstructores.Add (UsuarioRegistradoAssembler.Convert (entry, unitRepo, session));
                }


                //
                // Service
        }

        return dto;
}
}
}