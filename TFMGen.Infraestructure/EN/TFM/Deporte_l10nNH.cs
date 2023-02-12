
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class Deporte_l10nNH : Deporte_l10nEN {
public Deporte_l10nNH ()
{
}

public Deporte_l10nNH (Deporte_l10nEN dto)
{
        this.Nombre = dto.Nombre;


        this.Id = dto.Id;
}
}
}
