
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IPistaEstadoRepository
{
public void setSessionCP (GenericSessionCP session);

PistaEstadoEN ReadOIDDefault (int idestado
                              );

void ModifyDefault (PistaEstadoEN pistaEstado);

System.Collections.Generic.IList<PistaEstadoEN> ReadAllDefault (int first, int size);



int Crear (PistaEstadoEN pistaEstado);

System.Collections.Generic.IList<PistaEstadoEN> Listar (int first, int size);
}
}
