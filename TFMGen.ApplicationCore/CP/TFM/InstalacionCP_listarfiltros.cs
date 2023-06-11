
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
        public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> Listarfiltros(string filtro, string localidad, string latitud, string longitud, Nullable<DateTime> fecha, int deporte, string orden, bool notClose = false, int idusuario = -1)
        {
            /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Instalacion_listarfiltros) ENABLED START*/

            InstalacionCEN instalacionCEN = null;
            PistaCP pistaCP = null;

            System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> result = null;


            try
            {
                if (!notClose)
                    CPSession.SessionInitializeTransaction();
                instalacionCEN = new InstalacionCEN(unitRepo.instalacionrepository);
                unitRepo.instalacionrepository.setSessionCP(CPSession);

                pistaCP = new PistaCP(CPSession, unitRepo);
                unitRepo.reservarepository.setSessionCP(CPSession);

                if (!fecha.HasValue)
                    fecha = DateTime.Today;

                var instalacion = instalacionCEN.Listartodos(0, -1).Where(i => i.Pistas.Any(p => p.Deporte.Any(d => d.Iddeporte == deporte) && pistaCP.Listarhorariosdisponibles(p.Idpista, fecha, true).Count() > 0) && (!string.IsNullOrEmpty(filtro) ? i.Nombre.Contains(filtro) || i.Entidad.Nombre.Contains(filtro) || i.Entidad.Cifnif.Contains(filtro) : true) && i.Localidad.ToLower().Contains(localidad.ToLower())).ToList();

                if (instalacion.Count() > 0 && !string.IsNullOrEmpty(orden))
                {
                    switch (orden.ToLower())
                    {
                        case "distancia":
                        default:
                            if (!string.IsNullOrEmpty(latitud) && !string.IsNullOrEmpty(longitud))
                            {
                                latitud = latitud.Replace(".", ",");
                                longitud = longitud.Replace(".", ",");
                                double latitudDouble;
                                double longitudDouble;

                                if (double.TryParse(latitud, out latitudDouble) && double.TryParse(longitud, out longitudDouble))
                                {
                                    instalacion = instalacion.OrderBy(reserva =>
                                    {
                                        double distancia = GeoCalculator.GetDistance(latitudDouble, longitudDouble, reserva.Latitud, reserva.Longitud, 1, DistanceUnit.Kilometers);
                                        return distancia;
                                    }).ToList();
                                }
                            }
                            break;

                        case "distancia desc":
                            if (!string.IsNullOrEmpty(latitud) && !string.IsNullOrEmpty(longitud))
                            {
                                latitud = latitud.Replace(".", ",");
                                longitud = longitud.Replace(".", ",");
                                double latitudDouble;
                                double longitudDouble;

                                if (double.TryParse(latitud, out latitudDouble) && double.TryParse(longitud, out longitudDouble))
                                {
                                    instalacion = instalacion.OrderByDescending(reserva =>
                                    {
                                        double distancia = GeoCalculator.GetDistance(latitudDouble, longitudDouble, reserva.Latitud, reserva.Longitud, 1, DistanceUnit.Kilometers);
                                        return distancia;
                                    }).ToList();
                                }
                            }
                            break;

                        case "precio":
                            instalacion = instalacion.OrderByDescending(r => r.Pistas.Any() ? r.Pistas.Average(p => p.Precio) : 0).ToList();
                            break;

                        case "precio desc":
                            instalacion = instalacion.OrderBy(r => r.Pistas.Any()? r.Pistas.Average(p => p.Precio) : 0).ToList();
                            break;

                        case "valoracion":
                            instalacion = instalacion.OrderByDescending(r => r.ValoracionesAInstalaciones.Any() ? r.ValoracionesAInstalaciones.Average(v => v.Estrellas) : 0).ToList();
                            break;

                        case "valoracion desc":
                            instalacion = instalacion.OrderBy(r => r.ValoracionesAInstalaciones.Any()? r.ValoracionesAInstalaciones.Average(v => v.Estrellas) : 0).ToList();
                            break;

                        case "favoritos":
                            if (idusuario > 0)
                                instalacion = instalacion.Where(i => i.Usuario.Any(u => u.Idusuario == idusuario)).ToList();
                            break;
                    }
                }

                result = instalacion;

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
