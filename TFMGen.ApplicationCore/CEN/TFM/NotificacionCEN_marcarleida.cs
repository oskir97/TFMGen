
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Notificacion_marcarleida) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class NotificacionCEN
{
public void Marcarleida (int p_oid)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Notificacion_marcarleida) ENABLED START*/

        // Write here your custom code...

        NotificacionEN notificacionEN = null;

        notificacionEN = _INotificacionRepository.Obtener (p_oid);
        notificacionEN.Leida = true;

        _INotificacionRepository.Editar (notificacionEN);

        /*PROTECTED REGION END*/
}
}
}
