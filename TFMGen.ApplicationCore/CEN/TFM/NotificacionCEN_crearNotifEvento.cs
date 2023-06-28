
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Notificacion_crearNotifEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class NotificacionCEN
{
public int CrearNotifEvento (string p_asunto, string p_descripcion, bool p_leida, TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum p_tipo, int p_evento)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Notificacion_crearNotifEvento_customized) START*/

        NotificacionEN notificacionEN = null;

        int oid;

        //Initialized NotificacionEN
        notificacionEN = new NotificacionEN ();
        notificacionEN.Asunto = p_asunto;

        notificacionEN.Descripcion = p_descripcion;

        notificacionEN.Leida = p_leida;

        notificacionEN.Tipo = p_tipo;
            notificacionEN.Fecha = DateTime.Now;


        if (p_evento != -1) {
                notificacionEN.Evento = new TFMGen.ApplicationCore.EN.TFM.EventoEN ();
                notificacionEN.Evento.Idevento = p_evento;
        }

        //Call to NotificacionRepository

        oid = _INotificacionRepository.CrearNotifEvento (notificacionEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
