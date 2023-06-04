
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Evento_listarfiltros) ENABLED START*/
//  references to other libraries
using System.Linq;
using System.Collections.Generic;
using Geolocation;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class EventoCP : GenericBasicCP
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Listarfiltros (string filtro, string localidad, string latitud, string longitud, int deporte, string orden, Nullable<DateTime> fecha)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Evento_listarfiltros) ENABLED START*/

        EventoCEN eventoCEN = null;

        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN>  result = null;


        try
        {
                CPSession.SessionInitializeTransaction ();
                eventoCEN = new  EventoCEN (unitRepo.eventorepository);
                unitRepo.eventorepository.setSessionCP (CPSession);

                if (!fecha.HasValue)
                        fecha = DateTime.Today;

                var eventos = eventoCEN.Listartodos (0, -1).Where (e => e.Deporte.Iddeporte == deporte && (e.Inicio <= fecha.Value && e.Fin >= fecha.Value) && e.Reservas.Count () < e.Plazas && ((e.Instalacion != null && e.Instalacion.Localidad.Contains (localidad)) || (e.Entidad.Localidad.Contains (localidad))) && (!string.IsNullOrEmpty (filtro) ? e.Horarios.Any (h => h.Pista.Nombre.Contains (filtro)) || e.Entidad.Nombre.Contains (filtro) || (e.Instalacion != null && (e.Instalacion.Nombre.Contains (filtro))) || e.Entidad.Cifnif.Contains (filtro) || e.Entidad.Localidad.Contains (filtro) : true)).ToList ();

                if (!string.IsNullOrEmpty (orden)) {
                        switch (orden.ToLower ()) {
                        case "distancia":
                        default:
                                if (!string.IsNullOrEmpty (latitud) && !string.IsNullOrEmpty (longitud)) {
                                        double latitudDouble;
                                        double longitudDouble;

                                        if (double.TryParse (latitud, out latitudDouble) && double.TryParse (longitud, out longitudDouble)) {
                                                eventos.Sort ((reserva1, reserva2) =>
                                                        {
                                                                double latitud1 = reserva1.Instalacion != null ? reserva1.Instalacion.Latitud : reserva1.Instalacion.Latitud;
                                                                double longitud1 = reserva1.Instalacion != null ? reserva1.Instalacion.Longitud : reserva1.Instalacion.Longitud;
                                                                double latitud2 = reserva2.Instalacion != null ? reserva2.Instalacion.Latitud : reserva2.Instalacion.Latitud;
                                                                double longitud2 = reserva2.Instalacion != null ? reserva2.Instalacion.Longitud : reserva2.Instalacion.Longitud;

                                                                double distancia1 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, latitud1, longitud1, 1, DistanceUnit.Kilometers);
                                                                double distancia2 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, latitud2, longitud2, 1, DistanceUnit.Kilometers);

                                                                return distancia1.CompareTo (distancia2);
                                                        });
                                        }
                                }
                                break;

                        case "distancia desc":
                                if (!string.IsNullOrEmpty (latitud) && !string.IsNullOrEmpty (longitud)) {
                                        double latitudDouble;
                                        double longitudDouble;

                                        if (double.TryParse (latitud, out latitudDouble) && double.TryParse (longitud, out longitudDouble)) {
                                                eventos.Sort ((reserva1, reserva2) =>
                                                        {
                                                                double latitud1 = reserva1.Instalacion != null ? reserva1.Instalacion.Latitud : reserva1.Instalacion.Latitud;
                                                                double longitud1 = reserva1.Instalacion != null ? reserva1.Instalacion.Longitud : reserva1.Instalacion.Longitud;
                                                                double latitud2 = reserva2.Instalacion != null ? reserva2.Instalacion.Latitud : reserva2.Instalacion.Latitud;
                                                                double longitud2 = reserva2.Instalacion != null ? reserva2.Instalacion.Longitud : reserva2.Instalacion.Longitud;

                                                                double distancia1 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, latitud1, longitud1, 1, DistanceUnit.Kilometers);
                                                                double distancia2 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, latitud2, longitud2, 1, DistanceUnit.Kilometers);

                                                                return distancia2.CompareTo (distancia1);
                                                        });
                                        }
                                }
                                break;

                        case "precio":
                                eventos = eventos.OrderBy (r => r.Precio).ToList ();
                                break;

                        case "precio desc":
                                eventos = eventos.OrderByDescending (r => r.Precio).ToList ();
                                break;

                        case "valoracion":
                                eventos = eventos.OrderBy (r => r.Valoraciones.Sum (v => v.Estrellas)).ToList ();
                                break;

                        case "valoracion desc":
                                eventos = eventos.OrderByDescending (r => r.Valoraciones.Sum (v => v.Estrellas)).ToList ();
                                break;
                        }
                }

                result = eventos;

                CPSession.Commit ();
        }
        catch (Exception ex)
        {
                CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                CPSession.SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
