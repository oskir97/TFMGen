
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class DiaSemana_l10nNH : DiaSemana_l10nEN {
public DiaSemana_l10nNH ()
{
}

public DiaSemana_l10nNH (DiaSemana_l10nEN dto)
{
        this.Iddiasemana = dto.Iddiasemana;


        this.Nombre = dto.Nombre;
}
}
}
