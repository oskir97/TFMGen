

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
