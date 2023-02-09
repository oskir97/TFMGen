
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class EstadoPistaNH : EstadoPistaEN {
public EstadoPistaNH ()
{
}

public EstadoPistaNH (EstadoPistaEN dto)
{
        this.Idestado = dto.Idestado;


        this.Nombre = dto.Nombre;
}
}
}
