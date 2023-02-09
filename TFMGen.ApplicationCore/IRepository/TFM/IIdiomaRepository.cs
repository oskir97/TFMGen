
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IIdiomaRepository
{
IdiomaEN ReadOIDDefault (int ididioma
                         );

void ModifyDefault (IdiomaEN idioma);

System.Collections.Generic.IList<IdiomaEN> ReadAllDefault (int first, int size);



int Crear (IdiomaEN idioma);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> ListarEstadosPista (int p_idPista);
}
}
