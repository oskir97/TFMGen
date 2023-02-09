
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IRolRepository
{
RolEN ReadOIDDefault (int idrol
                      );

void ModifyDefault (RolEN rol);

System.Collections.Generic.IList<RolEN> ReadAllDefault (int first, int size);



int Crear (RolEN rol);
}
}
