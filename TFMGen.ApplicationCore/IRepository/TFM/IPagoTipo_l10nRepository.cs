
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IPagoTipo_l10nRepository
{
public void setSessionCP (GenericSessionCP session);

PagoTipo_l10nEN ReadOIDDefault (int id
                                );

void ModifyDefault (PagoTipo_l10nEN pagoTipo_l10n);

System.Collections.Generic.IList<PagoTipo_l10nEN> ReadAllDefault (int first, int size);



int Crear (PagoTipo_l10nEN pagoTipo_l10n);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> Listar (int p_idIdioma);
}
}
