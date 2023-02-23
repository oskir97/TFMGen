
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IDeporteRepository
{
public void setSessionCP (GenericSessionCP session);

DeporteEN ReadOIDDefault (int iddeporte
                          );

void ModifyDefault (DeporteEN deporte);

System.Collections.Generic.IList<DeporteEN> ReadAllDefault (int first, int size);



int Crear (DeporteEN deporte);

void Editar (DeporteEN deporte);


void Eliminar (int iddeporte
               );


DeporteEN Obtener (int iddeporte
                   );


System.Collections.Generic.IList<DeporteEN> Listar (int first, int size);
}
}
