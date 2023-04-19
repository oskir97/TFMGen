
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IIncidenciaRepository
{
public void setSessionCP (GenericSessionCP session);

IncidenciaEN ReadOIDDefault (int idincidencia
                             );

void ModifyDefault (IncidenciaEN incidencia);

System.Collections.Generic.IList<IncidenciaEN> ReadAllDefault (int first, int size);



int Crear (IncidenciaEN incidencia);

void Modificar (IncidenciaEN incidencia);


void Eliminar (int idincidencia
               );


IncidenciaEN Obtener (int idincidencia
                      );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> Listar (int p_idEvento);


System.Collections.Generic.IList<IncidenciaEN> Listartodas (int first, int size);
}
}
