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
public static class PistaAssembler
{
public static PistaDTOA Convert (PistaEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        PistaDTOA dto = null;
        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;
        PistaCP pistaCP = null;

        if (en != null) {
                dto = new PistaDTOA ();
                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (pistaRESTCAD);
                pistaCP = new PistaCP (session, unitRepo);





                //
                // Attributes

                dto.Idpista = en.Idpista;

                dto.Nombre = en.Nombre;


                dto.Ubicacion = en.Ubicacion;


                dto.Imagen = en.Imagen;


                dto.Maxreservas = en.Maxreservas;


                dto.Visible = en.Visible;


                dto.Precio = en.Precio;


                dto.Latitud = en.Latitud;


                dto.Longitud = en.Longitud;


                //
                // TravesalLink

                /* Rol: Pista o--> Horario */
                dto.ObtenerHorarios = null;
                List<HorarioEN> ObtenerHorarios = pistaRESTCAD.ObtenerHorarios (en.Idpista).ToList ();
                if (ObtenerHorarios != null) {
                        dto.ObtenerHorarios = new List<HorarioDTOA>();
                        foreach (HorarioEN entry in ObtenerHorarios)
                                dto.ObtenerHorarios.Add (HorarioAssembler.Convert (entry, unitRepo, session));
                }

                /* Rol: Pista o--> Instalacion */
                dto.ObtenerInstalaciones = InstalacionAssembler.Convert ((InstalacionEN)en.Instalacion, unitRepo, session);

                /* Rol: Pista o--> Entidad */
                dto.ObtenerEntidadPista = EntidadAssembler.Convert ((EntidadEN)en.Entidad, unitRepo, session);

                /* Rol: Pista o--> Valoracion */
                dto.ObtenerValoracionesPista = null;
                List<ValoracionEN> ObtenerValoracionesPista = pistaRESTCAD.ObtenerValoracionesPista (en.Idpista).ToList ();
                if (ObtenerValoracionesPista != null) {
                        dto.ObtenerValoracionesPista = new List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in ObtenerValoracionesPista)
                                dto.ObtenerValoracionesPista.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
                }

                /* Rol: Pista o--> PistaEstado */
                dto.ObtenerEstado = PistaEstadoAssembler.Convert ((PistaEstadoEN)en.EstadosPista, unitRepo, session);

                /* Rol: Pista o--> Deporte */
                dto.ObtenerDeporte = null;
                List<DeporteEN> ObtenerDeporte = pistaRESTCAD.ObtenerDeporte (en.Idpista).ToList ();
                if (ObtenerDeporte != null) {
                        dto.ObtenerDeporte = new List<DeporteDTOA>();
                        foreach (DeporteEN entry in ObtenerDeporte)
                                dto.ObtenerDeporte.Add (DeporteAssembler.Convert (entry, unitRepo, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
