
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class DiaSemanaNH : DiaSemanaEN {
public DiaSemanaNH ()
{
}

public DiaSemanaNH (DiaSemanaEN dto)
{
        this.Id = dto.Id;


        this.Nombre = dto.Nombre;
}
}
}
