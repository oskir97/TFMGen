
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
        public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Listarfiltros(string filtro, string localidad, string latitud, string longitud, int deporte, string orden, Nullable<DateTime> fecha, bool notClose = false)
        {
            /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Evento_listarfiltros) ENABLED START*/

            EventoCEN eventoCEN = null;

            System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> result = null;


            try
            {
                if (!notClose)
                    CPSession.SessionInitializeTransaction();
                eventoCEN = new EventoCEN(unitRepo.eventorepository);
                unitRepo.eventorepository.setSessionCP(CPSession);

                if (!fecha.HasValue)
                    fecha = DateTime.Today;

                var eventos = eventoCEN.Listartodos(0, -1).Where(e => e.Deporte.Iddeporte == deporte && (e.Inicio <= fecha.Value && e.Fin >= fecha.Value) && e.Reservas.Count() < e.Plazas && ((e.Instalacion != null && e.Instalacion.Localidad.Contains(localidad)) || (e.Entidad.Localidad.Contains(localidad))) && (!string.IsNullOrEmpty(filtro) ? e.Horarios.Any(h => h.Pista.Nombre.Contains(filtro)) || e.Entidad.Nombre.Contains(filtro) || (e.Instalacion != null && (e.Instalacion.Nombre.Contains(filtro))) || e.Entidad.Cifnif.Contains(filtro) || e.Entidad.Localidad.Contains(filtro) : true)).ToList();

                if (eventos.Count() > 0 && !string.IsNullOrEmpty(orden))
                {
                    switch (orden.ToLower())
                    {
                        case "distancia":
                        default:
                            if (!string.IsNullOrEmpty(latitud) && !string.IsNullOrEmpty(longitud))
                            {
                                double latitudDouble;
                                double longitudDouble;

                                if (double.TryParse(latitud, out latitudDouble) && double.TryParse(longitud, out longitudDouble))
                                {
                                    eventos.OrderBy(reserva =>
                                    {
                                        double latitud1 = reserva.Instalacion != null ? reserva.Instalacion.Latitud : reserva.Instalacion.Latitud;
                                        double longitud1 = reserva.Instalacion != null ? reserva.Instalacion.Longitud : reserva.Instalacion.Longitud;
                                        double distancia = GeoCalculator.GetDistance(latitudDouble, longitudDouble, latitud1, longitud1, 1, DistanceUnit.Kilometers);
                                        return distancia;
                                    }).ToList();
                                }
                            }
                            break;

                        case "distancia desc":
                            if (!string.IsNullOrEmpty(latitud) && !string.IsNullOrEmpty(longitud))
                            {
                                double latitudDouble;
                                double longitudDouble;

                                if (double.TryParse(latitud, out latitudDouble) && double.TryParse(longitud, out longitudDouble))
                                {
                                    eventos.OrderByDescending(reserva =>
                                    {
                                        double latitud1 = reserva.Instalacion != null ? reserva.Instalacion.Latitud : reserva.Instalacion.Latitud;
                                        double longitud1 = reserva.Instalacion != null ? reserva.Instalacion.Longitud : reserva.Instalacion.Longitud;
                                        double distancia = GeoCalculator.GetDistance(latitudDouble, longitudDouble, latitud1, longitud1, 1, DistanceUnit.Kilometers);
                                        return distancia;
                                    }).ToList();
                                }
                            }
                            break;

                        case "precio":
                            eventos = eventos.OrderByDescending(r => r.Precio).ToList();
                            break;

                        case "precio desc":
                            eventos = eventos.OrderBy(r => r.Precio).ToList();
                            break;

                        case "valoracion":
                            eventos = eventos.OrderByDescending(r => r.Valoraciones.Any()?r.Valoraciones.Average(v => v.Estrellas):0).ToList();
                            break;

                        case "valoracion desc":
                            eventos = eventos.OrderBy(r => r.Valoraciones.Any()? r.Valoraciones.Average(v => v.Estrellas):0).ToList();
                            break;
                    }
                }

                result = eventos;

                if (!notClose)
                    CPSession.Commit();
            }
            catch (Exception ex)
            {
                if (!notClose)
                    CPSession.RollBack();
                throw ex;
            }
            finally
            {
                if (!notClose)
                    CPSession.SessionClose();
            }
            return result;


            /*PROTECTED REGION END*/
        }
    }
}
