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
public static class InstalacionAssembler
{
public static InstalacionDTOA Convert (InstalacionEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        InstalacionDTOA dto = null;
        InstalacionRESTCAD instalacionRESTCAD = null;
        InstalacionCEN instalacionCEN = null;
        InstalacionCP instalacionCP = null;

        if (en != null) {
                dto = new InstalacionDTOA ();
                instalacionRESTCAD = new InstalacionRESTCAD (session);
                instalacionCEN = new InstalacionCEN (instalacionRESTCAD);
                instalacionCP = new InstalacionCP (session, unitRepo);





                //
                // Attributes

                dto.Idinstalacion = en.Idinstalacion;

                dto.Nombre = en.Nombre;


                dto.Telefono = en.Telefono;


                dto.Domicilio = en.Domicilio;


                dto.Ubicacion = en.Ubicacion;


                dto.Imagen = en.Imagen;


                dto.Codigopostal = en.Codigopostal;


                dto.Localidad = en.Localidad;


                dto.Provincia = en.Provincia;


                dto.Telefonoalternativo = en.Telefonoalternativo;


                dto.Visible = en.Visible;


                dto.Latitud = en.Latitud;


                dto.Longitud = en.Longitud;


                //
                // TravesalLink

                /* Rol: Instalacion o--> Entidad */
                dto.ObtenerEntidadInstalacion = EntidadAssembler.Convert ((EntidadEN)en.Entidad, unitRepo, session);

                /* Rol: Instalacion o--> Material */
                dto.ObtenerMateriales = null;
                List<MaterialEN> ObtenerMateriales = instalacionRESTCAD.ObtenerMateriales (en.Idinstalacion).ToList ();
                if (ObtenerMateriales != null) {
                        dto.ObtenerMateriales = new List<MaterialDTOA>();
                        foreach (MaterialEN entry in ObtenerMateriales)
                                dto.ObtenerMateriales.Add (MaterialAssembler.Convert (entry, unitRepo, session));
                }

                /* Rol: Instalacion o--> Valoracion */
                dto.ObtenerValoracionesInstalacion = null;
                List<ValoracionEN> ObtenerValoracionesInstalacion = instalacionRESTCAD.ObtenerValoracionesInstalacion (en.Idinstalacion).ToList ();
                if (ObtenerValoracionesInstalacion != null) {
                        dto.ObtenerValoracionesInstalacion = new List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in ObtenerValoracionesInstalacion)
                                dto.ObtenerValoracionesInstalacion.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
