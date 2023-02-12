
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class PistaEstado_l10nNH : PistaEstado_l10nEN {
public PistaEstado_l10nNH ()
{
}

public PistaEstado_l10nNH (PistaEstado_l10nEN dto)
{
        this.Nombre = dto.Nombre;


        this.Id = dto.Id;
}
}
}
