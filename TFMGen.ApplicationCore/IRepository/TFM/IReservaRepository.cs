
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IReservaRepository
{
ReservaEN ReadOIDDefault (int idreserva
                          );

void ModifyDefault (ReservaEN reserva);

System.Collections.Generic.IList<ReservaEN> ReadAllDefault (int first, int size);



int Crear (ReservaEN reserva);

void Editar (ReservaEN reserva);


void Eliminar (int idreserva
               );


ReservaEN Obtener (int idreserva
                   );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listar (int p_idUsuario);
}
}
