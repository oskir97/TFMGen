
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface INotificacionRepository
{
NotificacionEN ReadOIDDefault (int idnotificacion
                               );

void ModifyDefault (NotificacionEN notificacion);

System.Collections.Generic.IList<NotificacionEN> ReadAllDefault (int first, int size);



int Crear (NotificacionEN notificacion);

void Editar (NotificacionEN notificacion);


void Eliminar (int idnotificacion
               );


NotificacionEN Obtener (int idnotificacion
                        );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> Listar (int p_idUsuario);
}
}
