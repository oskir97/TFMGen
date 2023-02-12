
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Usuario_dardealta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class UsuarioCEN
{
public void Dardealta (int p_oid, Nullable<DateTime> p_alta)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Usuario_dardealta) ENABLED START*/

        // Write here your custom code...

        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioRepository.Obtener (p_oid);
        usuarioEN.Alta = p_alta;

        _IUsuarioRepository.Editar (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
