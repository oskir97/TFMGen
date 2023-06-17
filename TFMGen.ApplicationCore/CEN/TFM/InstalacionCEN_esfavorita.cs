
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Instalacion_esfavorita) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class InstalacionCEN
{
public bool Esfavorita (int p_oid, int p_idusuario)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Instalacion_esfavorita) ENABLED START*/

        // Write here your custom code...

        var instalacion = _IInstalacionRepository.Obtener (p_oid);

        return instalacion.Usuario != null && instalacion.Usuario.Any (u => u.Idusuario == p_idusuario);

        /*PROTECTED REGION END*/
}
}
}
