
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IValoracionRepository
{
ValoracionEN ReadOIDDefault (int idvaloracion
                             );

void ModifyDefault (ValoracionEN valoracion);

System.Collections.Generic.IList<ValoracionEN> ReadAllDefault (int first, int size);



int Crear (ValoracionEN valoracion);

void Editar (ValoracionEN valoracion);


void Eliminar (int idvaloracion
               );


ValoracionEN Obtener (int idvaloracion
                      );


System.Collections.Generic.IList<ValoracionEN> Listar (int first, int size);
}
}
