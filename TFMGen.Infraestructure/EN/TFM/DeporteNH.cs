
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class DeporteNH : DeporteEN {
public DeporteNH ()
{
}

public DeporteNH (DeporteEN dto)
{
        this.Iddeporte = dto.Iddeporte;


        this.Nombre = dto.Nombre;


        this.Descripcion = dto.Descripcion;


        this.Icono = dto.Icono;
}
}
}
