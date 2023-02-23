
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IRolRepository
{
public void setSessionCP (GenericSessionCP session);

RolEN ReadOIDDefault (int idrol
                      );

void ModifyDefault (RolEN rol);

System.Collections.Generic.IList<RolEN> ReadAllDefault (int first, int size);



int Crear (RolEN rol);
}
}
