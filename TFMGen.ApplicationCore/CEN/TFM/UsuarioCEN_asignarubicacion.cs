
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Usuario_asignarubicacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class UsuarioCEN
{
public void Asignarubicacion (int p_oid, string p_ubicacion)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Usuario_asignarubicacion) ENABLED START*/

        // Write here your custom code...

        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioRepository.Obtener (p_oid);
        usuarioEN.Ubicacionactual = p_ubicacion;

        _IUsuarioRepository.Editar (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
