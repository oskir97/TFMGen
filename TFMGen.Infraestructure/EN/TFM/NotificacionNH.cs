
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class NotificacionNH : NotificacionEN {
public NotificacionNH ()
{
}

public NotificacionNH (NotificacionEN dto)
{
        this.Idnotificacion = dto.Idnotificacion;


        this.Asunto = dto.Asunto;


        this.Descripcion = dto.Descripcion;


        this.Leida = dto.Leida;


        this.Tipo = dto.Tipo;


        this.Fecha = dto.Fecha;
}
}
}
