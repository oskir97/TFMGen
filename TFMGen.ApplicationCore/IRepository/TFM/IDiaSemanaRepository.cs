
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IDiaSemanaRepository
{
DiaSemanaEN ReadOIDDefault (int id
                            );

void ModifyDefault (DiaSemanaEN diaSemana);

System.Collections.Generic.IList<DiaSemanaEN> ReadAllDefault (int first, int size);



int Crear (DiaSemanaEN diaSemana);
}
}