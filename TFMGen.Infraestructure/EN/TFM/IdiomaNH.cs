
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class IdiomaNH : IdiomaEN {
public IdiomaNH ()
{
}

public IdiomaNH (IdiomaEN dto)
{
        this.Ididioma = dto.Ididioma;


        this.Nombre = dto.Nombre;


        this.Cultura = dto.Cultura;
}
}
}
