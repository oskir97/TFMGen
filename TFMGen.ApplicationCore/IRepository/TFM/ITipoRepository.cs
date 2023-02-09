
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface ITipoRepository
{
TipoEN ReadOIDDefault (int idtipo
                       );

void ModifyDefault (TipoEN tipo);

System.Collections.Generic.IList<TipoEN> ReadAllDefault (int first, int size);



int Crear (TipoEN tipo);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.TipoEN> Listar (int p_idIdioma);
}
}
