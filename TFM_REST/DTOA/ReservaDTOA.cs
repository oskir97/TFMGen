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
}
}
