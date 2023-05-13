
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class PistaNH : PistaEN {
public PistaNH ()
{
}

public PistaNH (PistaEN dto)
{
        this.Idpista = dto.Idpista;


        this.Nombre = dto.Nombre;


        this.Ubicacion = dto.Ubicacion;


        this.Imagen = dto.Imagen;


        this.Maxreservas = dto.Maxreservas;


        this.Visible = dto.Visible;


        this.Precio = dto.Precio;
}
}
}
