
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IRol_l10nRepository
{
public void setSessionCP (GenericSessionCP session);

Rol_l10nEN ReadOIDDefault (int id
                           );

void ModifyDefault (Rol_l10nEN rol_l10n);

System.Collections.Generic.IList<Rol_l10nEN> ReadAllDefault (int first, int size);



int Crear (Rol_l10nEN rol_l10n);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> Listar (int p_idIdioma);
}
}
