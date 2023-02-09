
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface ICodigoPostalRepository
{
CodigoPostalEN ReadOIDDefault (int idcodigopostal
                               );

void ModifyDefault (CodigoPostalEN codigoPostal);

System.Collections.Generic.IList<CodigoPostalEN> ReadAllDefault (int first, int size);



int Crear (CodigoPostalEN codigoPostal);
}
}
