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
public static class ValoracionAssembler
{
public static ValoracionDTOA Convert (ValoracionEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        ValoracionDTOA dto = null;
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;
        ValoracionCP valoracionCP = null;

        if (en != null) {
                dto = new ValoracionDTOA ();
                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (valoracionRESTCAD);
                valoracionCP = new ValoracionCP (session, unitRepo);





                //
                // Attributes

                dto.Idvaloracion = en.Idvaloracion;

                dto.Estrellas = en.Estrellas;


                dto.Comentario = en.Comentario;


                dto.Fecha = en.Fecha;


                //
                // TravesalLink

                /* Rol: Valoracion o--> UsuarioRegistrado */
                dto.ObtenerUsuarioCreadorValoracion = UsuarioRegistradoAssembler.Convert ((UsuarioEN)en.Usuario, unitRepo, session);


                //
                // Service
        }

        return dto;
}
}
}
