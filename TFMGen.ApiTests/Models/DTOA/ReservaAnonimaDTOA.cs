using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class ReservaAnonimaDTOA
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
}
}
