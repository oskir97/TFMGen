
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class EventoNH : EventoEN {
public EventoNH ()
{
}

public EventoNH (EventoEN dto)
{
        this.Idevento = dto.Idevento;


        this.Nombre = dto.Nombre;


        this.Descripcion = dto.Descripcion;


        this.Activo = dto.Activo;


        this.Plazas = dto.Plazas;


        this.Inicio = dto.Inicio;


        this.Fin = dto.Fin;


        this.Precio = dto.Precio;
}
}
}
