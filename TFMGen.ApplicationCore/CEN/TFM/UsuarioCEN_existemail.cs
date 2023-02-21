
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Usuario_existemail) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class UsuarioCEN
{
public bool Existemail (string p_email)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Usuario_existemail) ENABLED START*/

        // Write here your custom code...

        return _IUsuarioRepository.Listar (0, -1).Any (c => c.Email.ToLower () == p_email.ToLower ());

        /*PROTECTED REGION END*/
}
}
}
