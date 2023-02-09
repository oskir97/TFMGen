
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class HorarioNH : HorarioEN {
public HorarioNH ()
{
}

public HorarioNH (HorarioEN dto)
{
        this.Idhorario = dto.Idhorario;


        this.Inicio = dto.Inicio;


        this.Fin = dto.Fin;
}
}
}
