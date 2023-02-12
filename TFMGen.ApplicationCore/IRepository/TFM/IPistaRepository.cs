
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IPistaRepository
{
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


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Listar (int p_idEntidad);
}
}