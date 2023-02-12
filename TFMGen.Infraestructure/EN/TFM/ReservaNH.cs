
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class ReservaNH : ReservaEN {
public ReservaNH ()
{
}

public ReservaNH (ReservaEN dto)
{
        this.Idreserva = dto.Idreserva;


        this.Nombre = dto.Nombre;


        this.Apellidos = dto.Apellidos;


        this.Email = dto.Email;


        this.Telefono = dto.Telefono;


        this.Cancelada = dto.Cancelada;


        this.Espartido = dto.Espartido;


        this.Maxparticipantes = dto.Maxparticipantes;


        this.Fecha = dto.Fecha;


        this.Fechapago = dto.Fechapago;
}
}
}
