
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IMaterialRepository
{
MaterialEN ReadOIDDefault (int idmaterial
                           );

void ModifyDefault (MaterialEN material);

System.Collections.Generic.IList<MaterialEN> ReadAllDefault (int first, int size);



int Crear (MaterialEN material);

void Editar (MaterialEN material);


void Eliminar (int idmaterial
               );


MaterialEN Obtener (int idmaterial
                    );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.MaterialEN> Listar (int p_idInstalacion);
}
}
