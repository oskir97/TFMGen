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
public static class UsuarioRegistradoAssembler
{
public static UsuarioRegistradoDTOA Convert (UsuarioEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        UsuarioRegistradoDTOA dto = null;
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;
        UsuarioCP usuarioCP = null;

        if (en != null) {
                dto = new UsuarioRegistradoDTOA ();
                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (usuarioRegistradoRESTCAD);
                usuarioCP = new UsuarioCP (session, unitRepo);





                //
                // Attributes

                dto.Idusuario = en.Idusuario;

                dto.Nombre = en.Nombre;


                dto.Email = en.Email;


                dto.Apellidos = en.Apellidos;


                dto.Domicilio = en.Domicilio;


                dto.Telefono = en.Telefono;


                dto.Telefonoalternativo = en.Telefonoalternativo;


                dto.Fechanacimiento = en.Fechanacimiento;


                dto.Alta = en.Alta;


                dto.Ubicacionactual = en.Ubicacionactual;


                dto.Codigopostal = en.Codigopostal;


                dto.Localidad = en.Localidad;


                dto.Provincia = en.Provincia;


                dto.Baja = en.Baja;


                //
                // TravesalLink

                /* Rol: UsuarioRegistrado o--> Valoracion */
                dto.ObtenerValoracionesTecnicos = null;
                List<ValoracionEN> ObtenerValoracionesTecnicos = usuarioRegistradoRESTCAD.ObtenerValoracionesTecnicos (en.Idusuario).ToList ();
                if (ObtenerValoracionesTecnicos != null) {
                        dto.ObtenerValoracionesTecnicos = new List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in ObtenerValoracionesTecnicos)
                                dto.ObtenerValoracionesTecnicos.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
                }

                /* Rol: UsuarioRegistrado o--> Rol */
                dto.ObtenerRol = RolAssembler.Convert ((RolEN)en.Rol, unitRepo, session);

                /* Rol: UsuarioRegistrado o--> Entidad */
                dto.ObtenerEntidad = EntidadAssembler.Convert ((EntidadEN)en.Entidad, unitRepo, session);


                //
                // Service
        }

        return dto;
}
}
}
