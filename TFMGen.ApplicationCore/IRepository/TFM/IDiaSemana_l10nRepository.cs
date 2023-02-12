
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IDiaSemana_l10nRepository
{
DiaSemana_l10nEN ReadOIDDefault (int id
                                 );

void ModifyDefault (DiaSemana_l10nEN diaSemana_l10n);

System.Collections.Generic.IList<DiaSemana_l10nEN> ReadAllDefault (int first, int size);



int Crear (DiaSemana_l10nEN diaSemana_l10n);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> Listar (int p_idIdioma);
}
}