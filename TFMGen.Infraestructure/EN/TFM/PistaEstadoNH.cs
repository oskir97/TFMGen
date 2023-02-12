
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class PistaEstadoNH : PistaEstadoEN {
public PistaEstadoNH ()
{
}

public PistaEstadoNH (PistaEstadoEN dto)
{
        this.Idestado = dto.Idestado;


        this.Nombre = dto.Nombre;
}
}
}
