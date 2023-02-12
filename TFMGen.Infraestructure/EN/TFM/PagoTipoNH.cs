
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class PagoTipoNH : PagoTipoEN {
public PagoTipoNH ()
{
}

public PagoTipoNH (PagoTipoEN dto)
{
        this.Idtipo = dto.Idtipo;


        this.Nombre = dto.Nombre;
}
}
}
