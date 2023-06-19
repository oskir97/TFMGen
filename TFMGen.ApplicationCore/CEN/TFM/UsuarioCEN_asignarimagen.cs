
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Usuario_asignarimagen) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class UsuarioCEN
{
public void Asignarimagen (int p_oid, string p_imagen)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Usuario_asignarimagen) ENABLED START*/

        // Write here your custom code...

        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioRepository.Obtener (p_oid);
        usuarioEN.Imagen = p_imagen;

        _IUsuarioRepository.Editar (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
