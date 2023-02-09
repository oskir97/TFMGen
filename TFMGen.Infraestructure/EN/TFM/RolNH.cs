
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class RolNH : RolEN {
public RolNH ()
{
}

public RolNH (RolEN dto)
{
        this.Idrol = dto.Idrol;


        this.Nombre = dto.Nombre;
}
}
}
