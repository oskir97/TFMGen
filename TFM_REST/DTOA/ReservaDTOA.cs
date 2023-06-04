using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class ReservaDTOA
{
private int idreserva;
public int Idreserva
{
        get { return idreserva; }
        set { idreserva = value; }
}

private bool cancelada;
public bool Cancelada
{
        get { return cancelada; }
        set { cancelada = value; }
}

private int maxparticipantes;
public int Maxparticipantes
{
        get { return maxparticipantes; }
        set { maxparticipantes = value; }
}

private Nullable<DateTime> fecha;
public Nullable<DateTime> Fecha
{
        get { return fecha; }
        set { fecha = value; }
}

private TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum tipo;
public TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum Tipo
{
        get { return tipo; }
        set { tipo = value; }
}

private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}

private string apellidos;
public string Apellidos
{
        get { return apellidos; }
        set { apellidos = value; }
}

private string email;
public string Email
{
        get { return email; }
        set { email = value; }
}

private string telefono;
public string Telefono
{
        get { return telefono; }
        set { telefono = value; }
}

private Nullable<DateTime> fechaCreacion;
public Nullable<DateTime> FechaCreacion
{
        get { return fechaCreacion; }
        set { fechaCreacion = value; }
}

private Nullable<DateTime> fechaCancelada;
public Nullable<DateTime> FechaCancelada
{
        get { return fechaCancelada; }
        set { fechaCancelada = value; }
}


/* Rol: Reserva o--> Pista */
private PistaDTOA obtenerPista;
public PistaDTOA ObtenerPista
{
        get { return obtenerPista; }
        set { obtenerPista = value; }
}

/* Rol: Reserva o--> Pago */
private PagoDTOA getPagoOfReserva;
public PagoDTOA GetPagoOfReserva
{
        get { return getPagoOfReserva; }
        set { getPagoOfReserva = value; }
}

/* Rol: Reserva o--> UsuarioRegistrado */
private UsuarioRegistradoDTOA obtenerUsuarioCreador;
public UsuarioRegistradoDTOA ObtenerUsuarioCreador
{
        get { return obtenerUsuarioCreador; }
        set { obtenerUsuarioCreador = value; }
}

/* Rol: Reserva o--> Horario */
private HorarioDTOA obtenerHorarioReserva;
public HorarioDTOA ObtenerHorarioReserva
{
        get { return obtenerHorarioReserva; }
        set { obtenerHorarioReserva = value; }
}

/* Rol: Reserva o--> Deporte */
private DeporteDTOA obtenerDeporteReserva;
public DeporteDTOA ObtenerDeporteReserva
{
        get { return obtenerDeporteReserva; }
        set { obtenerDeporteReserva = value; }
}
}
}
