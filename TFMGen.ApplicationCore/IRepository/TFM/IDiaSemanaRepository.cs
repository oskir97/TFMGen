
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IDiaSemanaRepository
{
public void setSessionCP (GenericSessionCP session);

DiaSemanaEN ReadOIDDefault (int iddiasemana
                            );

void ModifyDefault (DiaSemanaEN diaSemana);

System.Collections.Generic.IList<DiaSemanaEN> ReadAllDefault (int first, int size);



int Crear (DiaSemanaEN diaSemana);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> Obtener (string p_dia);


System.Collections.Generic.IList<DiaSemanaEN> Listar (int first, int size);
}
}
