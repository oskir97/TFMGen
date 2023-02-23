
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IIdiomaRepository
{
public void setSessionCP (GenericSessionCP session);

IdiomaEN ReadOIDDefault (int ididioma
                         );

void ModifyDefault (IdiomaEN idioma);

System.Collections.Generic.IList<IdiomaEN> ReadAllDefault (int first, int size);



int Crear (IdiomaEN idioma);
}
}
