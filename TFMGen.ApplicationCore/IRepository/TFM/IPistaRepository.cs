
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IPistaRepository
{
public void setSessionCP (GenericSessionCP session);

PistaEN ReadOIDDefault (int idpista
                        );

void ModifyDefault (PistaEN pista);

System.Collections.Generic.IList<PistaEN> ReadAllDefault (int first, int size);



int Crear (PistaEN pista);

void Editar (PistaEN pista);


void Eliminar (int idpista
               );


PistaEN Obtener (int idpista
                 );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> ListarEntidad (int p_idEntidad);


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Buscar (string p_busqueda);



System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Listar ();





System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Obtenerpistasinstalacion (int p_idinstalacion);


System.Collections.Generic.IList<PistaEN> Listartodas (int first, int size);
}
}
