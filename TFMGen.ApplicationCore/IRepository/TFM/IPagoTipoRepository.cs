
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IPagoTipoRepository
{
public void setSessionCP (GenericSessionCP session);

PagoTipoEN ReadOIDDefault (int idtipo
                           );

void ModifyDefault (PagoTipoEN pagoTipo);

System.Collections.Generic.IList<PagoTipoEN> ReadAllDefault (int first, int size);



int Crear (PagoTipoEN pagoTipo);
}
}
