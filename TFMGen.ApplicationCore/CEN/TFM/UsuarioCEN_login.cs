
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Usuario_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class UsuarioCEN
{
public string Login (string p_pass, string p_email)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Usuario_login) ENABLED START*/
        string result = null;
        UsuarioEN en = _IUsuarioRepository.ObtenerEmailPass (p_email, Utils.Util.GetEncondeMD5 (p_pass));

        if (en != null)
                result = this.GetToken (en.Idusuario);

        return result;
        /*PROTECTED REGION END*/
}
}
}
