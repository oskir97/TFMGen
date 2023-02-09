

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class NotificacionCEN
 *
 */
public partial class NotificacionCEN
{
private INotificacionRepository _INotificacionRepository;

public NotificacionCEN(INotificacionRepository _INotificacionRepository)
{
        this._INotificacionRepository = _INotificacionRepository;
}

public INotificacionRepository get_INotificacionRepository ()
{
        return this._INotificacionRepository;
}

public int Crear (string p_asunto, string p_descripcion, bool p_leida, TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum p_tipo)
{
        NotificacionEN notificacionEN = null;
        int oid;

        //Initialized NotificacionEN
        notificacionEN = new NotificacionEN ();
        notificacionEN.Asunto = p_asunto;

        notificacionEN.Descripcion = p_descripcion;

        notificacionEN.Leida = p_leida;

        notificacionEN.Tipo = p_tipo;



        oid = _INotificacionRepository.Crear (notificacionEN);
        return oid;
}

public void Editar (int p_Notificacion_OID, string p_asunto, string p_descripcion, bool p_leida, TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum p_tipo)
{
        NotificacionEN notificacionEN = null;

        //Initialized NotificacionEN
        notificacionEN = new NotificacionEN ();
        notificacionEN.Idnotificacion = p_Notificacion_OID;
        notificacionEN.Asunto = p_asunto;
        notificacionEN.Descripcion = p_descripcion;
        notificacionEN.Leida = p_leida;
        notificacionEN.Tipo = p_tipo;
        //Call to NotificacionRepository

        _INotificacionRepository.Editar (notificacionEN);
}

public void Eliminar (int idnotificacion
                      )
{
        _INotificacionRepository.Eliminar (idnotificacion);
}

public NotificacionEN Obtener (int idnotificacion
                               )
{
        NotificacionEN notificacionEN = null;

        notificacionEN = _INotificacionRepository.Obtener (idnotificacion);
        return notificacionEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> Listar (int p_idUsuario)
{
        return _INotificacionRepository.Listar (p_idUsuario);
}
}
}
