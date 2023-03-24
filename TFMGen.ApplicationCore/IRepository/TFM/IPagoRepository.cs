
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IPagoRepository
{
public void setSessionCP (GenericSessionCP session);

PagoEN ReadOIDDefault (int idpago
                       );

void ModifyDefault (PagoEN pago);

System.Collections.Generic.IList<PagoEN> ReadAllDefault (int first, int size);



int Crear (PagoEN pago);

PagoEN Obtener (int idpago
                );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> Listar (int p_idReserva);


TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN ObtenerTipo (int p_idPago, int p_idIdioma);
}
}
