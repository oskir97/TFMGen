
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class IncidenciaNH : IncidenciaEN {
public IncidenciaNH ()
{
}

public IncidenciaNH (IncidenciaEN dto)
{
        this.Idincidencia = dto.Idincidencia;


        this.Asunto = dto.Asunto;


        this.Descripcion = dto.Descripcion;


        this.Fechacancelada = dto.Fechacancelada;


        this.Fechareemplazada = dto.Fechareemplazada;
}
}
}
