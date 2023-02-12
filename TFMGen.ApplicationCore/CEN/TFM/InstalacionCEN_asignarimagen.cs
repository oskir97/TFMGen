
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Instalacion_asignarimagen) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class InstalacionCEN
{
public void Asignarimagen (int p_oid, string p_imagen)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Instalacion_asignarimagen) ENABLED START*/

        // Write here your custom code...

        InstalacionEN instalacionEN = null;

        instalacionEN = _IInstalacionRepository.Obtener (p_oid);
        instalacionEN.Imagen = p_imagen;

        _IInstalacionRepository.Editar (instalacionEN);

        /*PROTECTED REGION END*/
}
}
}
