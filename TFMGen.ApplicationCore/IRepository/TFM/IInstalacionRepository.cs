
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IInstalacionRepository
{
public void setSessionCP (GenericSessionCP session);

InstalacionEN ReadOIDDefault (int idinstalacion
                              );

void ModifyDefault (InstalacionEN instalacion);

System.Collections.Generic.IList<InstalacionEN> ReadAllDefault (int first, int size);



int Crear (InstalacionEN instalacion);

void Editar (InstalacionEN instalacion);


void Eliminar (int idinstalacion
               );


InstalacionEN Obtener (int idinstalacion
                       );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> Listar (int p_idEntidad);



void Asignarpista (int p_Instalacion_OID, System.Collections.Generic.IList<int> p_pistas_OID);

System.Collections.Generic.IList<InstalacionEN> Listartodos (int first, int size);
}
}
