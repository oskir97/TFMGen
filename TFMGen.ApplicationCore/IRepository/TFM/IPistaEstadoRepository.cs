
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IPistaEstadoRepository
{
PistaEstadoEN ReadOIDDefault (int idestado
                              );

void ModifyDefault (PistaEstadoEN pistaEstado);

System.Collections.Generic.IList<PistaEstadoEN> ReadAllDefault (int first, int size);



int Crear (PistaEstadoEN pistaEstado);
}
}
