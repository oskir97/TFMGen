
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Reserva_listarfiltros) ENABLED START*/
//  references to other libraries
using System.Linq;
using System.Collections.Generic;
using Geolocation;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class ReservaCP : GenericBasicCP
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listarfiltros (string filtro, string localidad, string latitud, string longitud, Nullable<DateTime> fecha, int deporte, string orden, bool notClose = false)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Reserva_listarfiltros) ENABLED START*/

        ReservaCEN reservaCEN = null;

        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> result = null;


        try
        {
                if (!notClose)
                    CPSession.SessionInitializeTransaction ();
                reservaCEN = new ReservaCEN (unitRepo.reservarepository);
                unitRepo.reservarepository.setSessionCP (CPSession);

                if (!fecha.HasValue)
                        fecha = DateTime.Today;

                var reservas = reservaCEN.Listartodos (0, -1).Where (r => r.Deporte.Iddeporte == deporte && r.Partido.Tipo == Enumerated.TFM.TipoReservaEnum.partido && r.Fecha == fecha.Value && r.Inscripciones.Count () < r.Maxparticipantes && (!string.IsNullOrEmpty (filtro) ? r.Pista.Nombre.Contains (filtro) || r.Pista.Instalacion.Nombre.Contains (filtro) || r.Pista.Instalacion.Entidad.Nombre.Contains (filtro) || r.Pista.Instalacion.Entidad.Cifnif.Contains (filtro) : true) && ((r.Pista.Instalacion != null && r.Pista.Instalacion.Localidad.ToLower ().Contains (localidad.ToLower ())) || (r.Pista.Entidad.Localidad.Contains (localidad)))).ToList ();

                if (!string.IsNullOrEmpty (orden)) {
                        switch (orden.ToLower ()) {
                        case "distancia":
                        default:
                                if (!string.IsNullOrEmpty (latitud) && !string.IsNullOrEmpty (longitud)) {
                                        double latitudDouble;
                                        double longitudDouble;

                                        if (double.TryParse (latitud, out latitudDouble) && double.TryParse (longitud, out longitudDouble)) {
                                                reservas.Sort ((reserva1, reserva2) =>
                                                        {
                                                                double latitud1 = reserva1.Pista.Instalacion != null ? reserva1.Pista.Instalacion.Latitud : reserva1.Pista.Instalacion.Latitud;
                                                                double longitud1 = reserva1.Pista.Instalacion != null ? reserva1.Pista.Instalacion.Longitud : reserva1.Pista.Instalacion.Longitud;
                                                                double latitud2 = reserva2.Pista.Instalacion != null ? reserva2.Pista.Instalacion.Latitud : reserva2.Pista.Instalacion.Latitud;
                                                                double longitud2 = reserva2.Pista.Instalacion != null ? reserva2.Pista.Instalacion.Longitud : reserva2.Pista.Instalacion.Longitud;

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
                                                reservas.Sort ((reserva1, reserva2) =>
                                                        {
                                                                double latitud1 = reserva1.Pista.Instalacion != null ? reserva1.Pista.Instalacion.Latitud : reserva1.Pista.Instalacion.Latitud;
                                                                double longitud1 = reserva1.Pista.Instalacion != null ? reserva1.Pista.Instalacion.Longitud : reserva1.Pista.Instalacion.Longitud;
                                                                double latitud2 = reserva2.Pista.Instalacion != null ? reserva2.Pista.Instalacion.Latitud : reserva2.Pista.Instalacion.Latitud;
                                                                double longitud2 = reserva2.Pista.Instalacion != null ? reserva2.Pista.Instalacion.Longitud : reserva2.Pista.Instalacion.Longitud;

                                                                double distancia1 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, latitud1, longitud1, 1, DistanceUnit.Kilometers);
                                                                double distancia2 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, latitud2, longitud2, 1, DistanceUnit.Kilometers);

                                                                return distancia2.CompareTo (distancia1);
                                                        });
                                        }
                                }
                                break;

                        case "precio":
                                reservas = reservas.OrderBy (r => r.Pista.Precio).ToList ();
                                break;

                        case "precio desc":
                                reservas = reservas.OrderByDescending (r => r.Pista.Precio).ToList ();
                                break;

                        case "valoracion":
                                reservas = reservas.OrderBy (r => r.Pista.ValoracionesAPistas.Sum (v => v.Estrellas)).ToList ();
                                break;

                        case "valoracion desc":
                                reservas = reservas.OrderByDescending (r => r.Pista.ValoracionesAPistas.Sum (v => v.Estrellas)).ToList ();
                                break;
                        }
                }

                result = reservas;

                if (!notClose)
                    CPSession.Commit ();
        }
        catch (Exception ex)
        {
                if (!notClose)
                    CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                if (!notClose)
                    CPSession.SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
