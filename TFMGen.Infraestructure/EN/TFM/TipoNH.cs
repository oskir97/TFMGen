
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class TipoNH : TipoEN {
public TipoNH ()
{
}

public TipoNH (TipoEN dto)
{
        this.Idtipo = dto.Idtipo;


        this.Nombre = dto.Nombre;
}
}
}
