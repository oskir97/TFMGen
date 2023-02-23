
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface INotificacionRepository
{
public void setSessionCP (GenericSessionCP session);

NotificacionEN ReadOIDDefault (int idnotificacion
                               );

void ModifyDefault (NotificacionEN notificacion);

System.Collections.Generic.IList<NotificacionEN> ReadAllDefault (int first, int size);



int CrearNotifEvento (NotificacionEN notificacion);

void Editar (NotificacionEN notificacion);


void Eliminar (int idnotificacion
               );


NotificacionEN Obtener (int idnotificacion
                        );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> Listar (int p_idUsuario);




int CrearNotifReserva (NotificacionEN notificacion);
}
}
