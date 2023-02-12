
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class PagoTipo_l10nNH : PagoTipo_l10nEN {
public PagoTipo_l10nNH ()
{
}

public PagoTipo_l10nNH (PagoTipo_l10nEN dto)
{
        this.Nombre = dto.Nombre;


        this.Id = dto.Id;
}
}
}
