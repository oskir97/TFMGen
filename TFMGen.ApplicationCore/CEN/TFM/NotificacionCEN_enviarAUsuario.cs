
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Notificacion_enviarAUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class NotificacionCEN
{
public void EnviarAUsuario (TFMGen.ApplicationCore.EN.TFM.NotificacionEN p_notificacion, TFMGen.ApplicationCore.EN.TFM.UsuarioEN p_receptor, TFMGen.ApplicationCore.EN.TFM.UsuarioEN p_emisorUsuario, TFMGen.ApplicationCore.EN.TFM.EntidadEN p_emisorEntidad)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Notificacion_enviarAUsuario) ENABLED START*/

        // Write here your custom code...

        if (p_emisorEntidad != null)
                p_notificacion.Entidad = p_emisorEntidad;
        else
                p_notificacion.Emisor = p_emisorUsuario;

        p_notificacion.Receptor = p_receptor;
        _INotificacionRepository.Editar (p_notificacion);

        /*PROTECTED REGION END*/
}
}
}
