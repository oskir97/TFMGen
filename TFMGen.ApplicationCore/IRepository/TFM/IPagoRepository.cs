
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IPagoRepository
{
PagoEN ReadOIDDefault (int idpago
                       );

void ModifyDefault (PagoEN pago);

System.Collections.Generic.IList<PagoEN> ReadAllDefault (int first, int size);



int Crear (PagoEN pago);

PagoEN Obtener (int idpago
                );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> Listar (int p_idReserva);
}
}
