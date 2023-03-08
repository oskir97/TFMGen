
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IEntidadRepository
{
public void setSessionCP (GenericSessionCP session);

EntidadEN ReadOIDDefault (int identidad
                          );

void ModifyDefault (EntidadEN entidad);

System.Collections.Generic.IList<EntidadEN> ReadAllDefault (int first, int size);



int Crear (EntidadEN entidad);

void Editar (EntidadEN entidad);


void Eliminar (int identidad
               );


EntidadEN Obtener (int identidad
                   );


System.Collections.Generic.IList<EntidadEN> Listar (int first, int size);
}
}
