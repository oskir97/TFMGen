
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Instalacion_listarfiltros) ENABLED START*/
//  references to other libraries
using System.Linq;
using System.Collections.Generic;
using Geolocation;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class InstalacionCP : GenericBasicCP
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> Listarfiltros (string filtro, string localidad, string latitud, string longitud, Nullable<DateTime> fecha, int deporte, string orden)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Instalacion_listarfiltros) ENABLED START*/

        InstalacionCEN instalacionCEN = null;
        PistaCP pistaCP = null;

        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN>  result = null;


        try
        {
                CPSession.SessionInitializeTransaction ();
                instalacionCEN = new InstalacionCEN (unitRepo.instalacionrepository);
                unitRepo.instalacionrepository.setSessionCP (CPSession);

                pistaCP = new PistaCP (CPSession, unitRepo);
                unitRepo.reservarepository.setSessionCP (CPSession);

                if (!fecha.HasValue)
                        fecha = DateTime.Today;

                var instalacion = instalacionCEN.Listartodos (0, -1).Where (i => i.Pistas.Any (p => p.Deporte.Any (d => d.Iddeporte == deporte) && pistaCP.Listarhorariosdisponibles (p.Idpista, fecha).Count () > 0) && (!string.IsNullOrEmpty (filtro) ? i.Nombre.Contains (filtro) || i.Entidad.Nombre.Contains (filtro) || i.Entidad.Cifnif.Contains (filtro) : true) && i.Localidad.ToLower ().Contains (localidad.ToLower ())).ToList ();

                if (!string.IsNullOrEmpty (orden)) {
                        switch (orden.ToLower ()) {
                        case "distancia":
                        default:
                                if (!string.IsNullOrEmpty (latitud) && !string.IsNullOrEmpty (longitud)) {
                                        double latitudDouble;
                                        double longitudDouble;

                                        if (double.TryParse (latitud, out latitudDouble) && double.TryParse (longitud, out longitudDouble)) {
                                                instalacion.Sort ((reserva1, reserva2) =>
                                                        {
                                                                double distancia1 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, reserva1.Latitud, reserva1.Longitud, 1, DistanceUnit.Kilometers);
                                                                double distancia2 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, reserva2.Latitud, reserva2.Longitud, 1, DistanceUnit.Kilometers);

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
                                                instalacion.Sort ((reserva1, reserva2) =>
                                                        {
                                                                double distancia1 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, reserva1.Latitud, reserva1.Longitud, 1, DistanceUnit.Kilometers);
                                                                double distancia2 = GeoCalculator.GetDistance (latitudDouble, longitudDouble, reserva2.Latitud, reserva2.Longitud, 1, DistanceUnit.Kilometers);

                                                                return distancia2.CompareTo (distancia1);
                                                        });
                                        }
                                }
                                break;

                        case "precio":
                                instalacion = instalacion.OrderBy (r => r.Pistas.Sum (p => p.Precio)).ToList ();
                                break;

                        case "precio desc":
                                instalacion = instalacion.OrderByDescending (r => r.Pistas.Sum (p => p.Precio)).ToList ();
                                break;

                        case "valoracion":
                                instalacion = instalacion.OrderBy (r => r.ValoracionesAInstalaciones.Sum (v => v.Estrellas)).ToList ();
                                break;

                        case "valoracion desc":
                                instalacion = instalacion.OrderByDescending (r => r.ValoracionesAInstalaciones.Sum (v => v.Estrellas)).ToList ();
                                break;
                        }
                }

                result = instalacion;

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
