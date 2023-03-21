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
public static class UsuarioAssembler
{
public static UsuarioDTOA Convert (UsuarioEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        UsuarioDTOA dto = null;
        UsuarioRESTCAD usuarioRESTCAD = null;
        UsuarioCEN usuarioCEN = null;
        UsuarioCP usuarioCP = null;

        if (en != null) {
                dto = new UsuarioDTOA ();
                usuarioRESTCAD = new UsuarioRESTCAD (session);
                usuarioCEN = new UsuarioCEN (usuarioRESTCAD);
                usuarioCP = new UsuarioCP (session, unitRepo);





                //
                // Attributes

                dto.Idusuario = en.Idusuario;

                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
