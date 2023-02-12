
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Usuario_dardebaja) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class UsuarioCEN
{
public void Dardebaja (int p_oid, Nullable<DateTime> p_baja)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Usuario_dardebaja) ENABLED START*/

        // Write here your custom code...

        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioRepository.Obtener (p_oid);
        usuarioEN.Baja = p_baja;

        _IUsuarioRepository.Editar (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
