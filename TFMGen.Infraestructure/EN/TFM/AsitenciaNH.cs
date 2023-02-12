
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class AsitenciaNH : AsitenciaEN {
public AsitenciaNH ()
{
}

public AsitenciaNH (AsitenciaEN dto)
{
        this.Idasitencia = dto.Idasitencia;


        this.Fecha = dto.Fecha;


        this.Asiste = dto.Asiste;


        this.Notas = dto.Notas;
}
}
}
