
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Notificacion_enviarAEntidad) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class NotificacionCEN
{
public void EnviarAEntidad (TFMGen.ApplicationCore.EN.TFM.NotificacionEN p_notificacion, TFMGen.ApplicationCore.EN.TFM.EntidadEN p_entidad, TFMGen.ApplicationCore.EN.TFM.UsuarioEN p_emisor)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Notificacion_enviarAEntidad) ENABLED START*/

        // Write here your custom code...

        p_notificacion.Emisor = p_emisor;
        p_notificacion.Entidad = p_entidad;
        _INotificacionRepository.Editar (p_notificacion);

        /*PROTECTED REGION END*/
}
}
}
