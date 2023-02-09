
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IEstadoPistaRepository
{
EstadoPistaEN ReadOIDDefault (int idestado
                              );

void ModifyDefault (EstadoPistaEN estadoPista);

System.Collections.Generic.IList<EstadoPistaEN> ReadAllDefault (int first, int size);



int Crear (EstadoPistaEN estadoPista);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN> Listar (int p_idIdioma);
}
}
