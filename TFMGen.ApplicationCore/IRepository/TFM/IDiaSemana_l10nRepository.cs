
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IDiaSemana_l10nRepository
{
public void setSessionCP (GenericSessionCP session);

DiaSemana_l10nEN ReadOIDDefault (int iddiasemana
                                 );

void ModifyDefault (DiaSemana_l10nEN diaSemana_l10n);

System.Collections.Generic.IList<DiaSemana_l10nEN> ReadAllDefault (int first, int size);



int Crear (DiaSemana_l10nEN diaSemana_l10n);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> Listar (int p_idIdioma);


System.Collections.Generic.IList<DiaSemana_l10nEN> Listartodos (int first, int size);
}
}
