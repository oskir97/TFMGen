
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class ValoracionNH : ValoracionEN {
public ValoracionNH ()
{
}

public ValoracionNH (ValoracionEN dto)
{
        this.Idvaloracion = dto.Idvaloracion;


        this.Estrellas = dto.Estrellas;


        this.Comentario = dto.Comentario;
}
}
}
