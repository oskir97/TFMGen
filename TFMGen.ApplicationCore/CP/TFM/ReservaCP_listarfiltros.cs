
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
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listarfiltros (string filtro, string localidad, string latitud, string longitud, Nullable<DateTime> fecha, int deporte, string orden, bool notClose)
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

                var reservas = reservaCEN.Listartodos (0, -1).Where (r => r.Deporte.Iddeporte == deporte && r.Tipo == Enumerated.TFM.TipoReservaEnum.partido && r.Fecha == fecha.Value && r.Inscripciones.Count () < r.Maxparticipantes && (!string.IsNullOrEmpty (filtro) ? r.Pista.Nombre.Contains (filtro) || r.Pista.Instalacion.Nombre.Contains (filtro) || r.Pista.Instalacion.Entidad.Nombre.Contains (filtro) || r.Pista.Instalacion.Entidad.Cifnif.Contains (filtro) : true) && ((r.Pista.Instalacion != null && r.Pista.Instalacion.Localidad.ToLower ().Contains (localidad.ToLower ())) || (r.Pista.Entidad.Localidad.Contains (localidad)))).ToList ();

                if (reservas.Count () > 0) {
                        if (orden == null)
                                orden = "distancia";
                        switch (orden.ToLower ()) {
                        case "distancia":
                        default:
                                if (!string.IsNullOrEmpty (latitud) && !string.IsNullOrEmpty (longitud)) {
                                        latitud = latitud.Replace (".", ",");
                                        longitud = longitud.Replace (".", ",");
                                        double latitudDouble;
                                        double longitudDouble;

                                        if (double.TryParse (latitud, out latitudDouble) && double.TryParse (longitud, out longitudDouble)) {
                                                reservas.OrderBy (reserva =>
                                                        {
                                                                double latitud1 = reserva.Pista.Instalacion != null ? reserva.Pista.Instalacion.Latitud : (reserva.Pista != null ? reserva.Pista.Latitud : reserva.Pista.Entidad.Latitud);
                                                                double longitud1 = reserva.Pista.Instalacion != null ? reserva.Pista.Instalacion.Longitud : (reserva.Pista != null ? reserva.Pista.Longitud : reserva.Pista.Entidad.Longitud);
                                                                double distancia = GeoCalculator.GetDistance (latitudDouble, longitudDouble, latitud1, longitud1, 1, DistanceUnit.Kilometers);
                                                                return distancia;
                                                        }).ToList ();
                                        }
                                }
                                break;

                        case "distancia desc":
                                if (!string.IsNullOrEmpty (latitud) && !string.IsNullOrEmpty (longitud)) {
                                        latitud = latitud.Replace (".", ",");
                                        longitud = longitud.Replace (".", ",");
                                        double latitudDouble;
                                        double longitudDouble;

                                        if (double.TryParse (latitud, out latitudDouble) && double.TryParse (longitud, out longitudDouble)) {
                                                reservas.OrderByDescending (reserva =>
                                                        {
                                                                double latitud1 = reserva.Pista.Instalacion != null ? reserva.Pista.Instalacion.Latitud : (reserva.Pista != null ? reserva.Pista.Latitud : reserva.Pista.Entidad.Latitud);
                                                                double longitud1 = reserva.Pista.Instalacion != null ? reserva.Pista.Instalacion.Longitud : (reserva.Pista != null ? reserva.Pista.Longitud : reserva.Pista.Entidad.Longitud);
                                                                double distancia = GeoCalculator.GetDistance (latitudDouble, longitudDouble, latitud1, longitud1, 1, DistanceUnit.Kilometers);
                                                                return distancia;
                                                        }).ToList ();
                                        }
                                }
                                break;

                        case "precio":
                                reservas = reservas.OrderByDescending (r => r.Pista.Precio).ToList ();
                                break;

                        case "precio desc":
                                reservas = reservas.OrderBy (r => r.Pista.Precio).ToList ();
                                break;

                        case "valoracion":
                                reservas = reservas.OrderByDescending (r => r.Pista.ValoracionesAPistas.Any () ? r.Pista.ValoracionesAPistas.Average (v => v.Estrellas) : 0).ToList ();
                                break;

                        case "valoracion desc":
                                reservas = reservas.OrderBy (r => r.Pista.ValoracionesAPistas.Any () ? r.Pista.ValoracionesAPistas.Average (v => v.Estrellas) : 0).ToList ();
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
