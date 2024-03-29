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


                dto.Precio = en.Precio;


                dto.Inicio = en.Inicio;


                dto.Fin = en.Fin;


                dto.Imagen = en.Imagen;


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

                /* Rol: Evento o--> Horario */
                dto.ObtenerHorariosEvento = null;
                List<HorarioEN> ObtenerHorariosEvento = eventoRESTCAD.ObtenerHorariosEvento (en.Idevento).ToList ();
                if (ObtenerHorariosEvento != null) {
                        dto.ObtenerHorariosEvento = new List<HorarioDTOA>();
                        foreach (HorarioEN entry in ObtenerHorariosEvento)
                                dto.ObtenerHorariosEvento.Add (HorarioAssembler.Convert (entry, unitRepo, session));
                }

                /* Rol: Evento o--> Deporte */
                dto.ObtenerDeporteEvento = DeporteAssembler.Convert ((DeporteEN)en.Deporte, unitRepo, session);

                /* Rol: Evento o--> Valoracion */
                dto.ObtenerValoracionesEvento = null;
                List<ValoracionEN> ObtenerValoracionesEvento = eventoRESTCAD.ObtenerValoracionesEvento (en.Idevento).ToList ();
                if (ObtenerValoracionesEvento != null) {
                        dto.ObtenerValoracionesEvento = new List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in ObtenerValoracionesEvento)
                                dto.ObtenerValoracionesEvento.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
                }

                /* Rol: Evento o--> Instalacion */
                dto.ObtenerInstalacion = InstalacionAssembler.Convert ((InstalacionEN)en.Instalacion, unitRepo, session);

                /* Rol: Evento o--> Pista */
                dto.ObtenerPistaEvento = PistaAssembler.Convert ((PistaEN)en.Pista, unitRepo, session);


                //
                // Service
        }

        return dto;
}
}
}
