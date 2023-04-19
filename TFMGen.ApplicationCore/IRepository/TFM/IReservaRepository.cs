
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IReservaRepository
{
public void setSessionCP (GenericSessionCP session);

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


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listar (int p_identidad);


void Inscribirsepartido (int p_Reserva_OID, System.Collections.Generic.IList<int> p_inscripciones_OIDs);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listarreservasusuario (int p_idusuario);


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Obtenerinscripciones (int p_idReserva);


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Obtenerreservaspista (int p_idPista, Nullable<DateTime> p_fecha);



System.Collections.Generic.IList<ReservaEN> Listartodos (int first, int size);
}
}
