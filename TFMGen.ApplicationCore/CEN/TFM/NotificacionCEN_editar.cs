
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Notificacion_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class NotificacionCEN
{
public void Editar (int p_Notificacion_OID, string p_asunto, string p_descripcion, bool p_leida, TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum p_tipo, TFMGen.ApplicationCore.EN.TFM.EventoEN p_evento, TFMGen.ApplicationCore.EN.TFM.ReservaEN p_reserva)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Notificacion_editar_customized) START*/

        NotificacionEN notificacionEN = null;

        //Initialized NotificacionEN
        notificacionEN = new NotificacionEN ();
        notificacionEN.Idnotificacion = p_Notificacion_OID;
        notificacionEN.Asunto = p_asunto;
        notificacionEN.Descripcion = p_descripcion;
        notificacionEN.Leida = p_leida;
        notificacionEN.Tipo = p_tipo;
        notificacionEN.Evento = p_evento;
        notificacionEN.Reserva = p_reserva;
        //Call to NotificacionRepository

        _INotificacionRepository.Editar (notificacionEN);

        /*PROTECTED REGION END*/
}
}
}
