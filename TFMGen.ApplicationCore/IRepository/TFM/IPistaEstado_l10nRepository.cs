
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IPistaEstado_l10nRepository
{
PistaEstado_l10nEN ReadOIDDefault (int id
                                   );

void ModifyDefault (PistaEstado_l10nEN pistaEstado_l10n);

System.Collections.Generic.IList<PistaEstado_l10nEN> ReadAllDefault (int first, int size);



int Crear (PistaEstado_l10nEN pistaEstado_l10n);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> Listar (int p_idIdioma);
}
}
