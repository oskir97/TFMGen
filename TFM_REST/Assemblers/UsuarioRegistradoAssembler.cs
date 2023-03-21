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


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
