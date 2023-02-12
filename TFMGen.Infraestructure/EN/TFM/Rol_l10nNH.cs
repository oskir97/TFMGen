
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class Rol_l10nNH : Rol_l10nEN {
public Rol_l10nNH ()
{
}

public Rol_l10nNH (Rol_l10nEN dto)
{
        this.Nombre = dto.Nombre;


        this.Id = dto.Id;
}
}
}
