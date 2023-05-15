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
public static class EntidadAssembler
{
public static EntidadDTOA Convert (EntidadEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        EntidadDTOA dto = null;
        EntidadRESTCAD entidadRESTCAD = null;
        EntidadCEN entidadCEN = null;
        EntidadCP entidadCP = null;

        if (en != null) {
                dto = new EntidadDTOA ();
                entidadRESTCAD = new EntidadRESTCAD (session);
                entidadCEN = new EntidadCEN (entidadRESTCAD);
                entidadCP = new EntidadCP (session, unitRepo);





                //
                // Attributes

                dto.Identidad = en.Identidad;

                dto.Nombre = en.Nombre;


                dto.Email = en.Email;


                dto.Telefono = en.Telefono;


                dto.Domicilio = en.Domicilio;


                dto.Cifnif = en.Cifnif;


                dto.Telefonoalternativo = en.Telefonoalternativo;


                dto.Codigopostal = en.Codigopostal;


                dto.Localidad = en.Localidad;


                dto.Provincia = en.Provincia;


                dto.Imagen = en.Imagen;


                dto.Configuracion = en.Configuracion;


                dto.Latitud = en.Latitud;


                dto.Longitud = en.Longitud;


                //
                // TravesalLink

                /* Rol: Entidad o--> Valoracion */
                dto.ObtenerValoracionesEntidad = null;
                List<ValoracionEN> ObtenerValoracionesEntidad = entidadRESTCAD.ObtenerValoracionesEntidad (en.Identidad).ToList ();
                if (ObtenerValoracionesEntidad != null) {
                        dto.ObtenerValoracionesEntidad = new List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in ObtenerValoracionesEntidad)
                                dto.ObtenerValoracionesEntidad.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
