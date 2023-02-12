
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IDeporte_l10nRepository
{
Deporte_l10nEN ReadOIDDefault (int id
                               );

void ModifyDefault (Deporte_l10nEN deporte_l10n);

System.Collections.Generic.IList<Deporte_l10nEN> ReadAllDefault (int first, int size);



int Crear (Deporte_l10nEN deporte_l10n);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> Listar (int p_idIdioma);
}
}
