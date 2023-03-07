
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IAsitenciaRepository
{
public void setSessionCP (GenericSessionCP session);

AsitenciaEN ReadOIDDefault (int idasitencia
                            );

void ModifyDefault (AsitenciaEN asitencia);

System.Collections.Generic.IList<AsitenciaEN> ReadAllDefault (int first, int size);



int Crear (AsitenciaEN asitencia);

void Editar (AsitenciaEN asitencia);


void Eliminar (int idasitencia
               );


AsitenciaEN Obtener (int idasitencia
                     );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> Listar (int p_idUsuario);
}
}
