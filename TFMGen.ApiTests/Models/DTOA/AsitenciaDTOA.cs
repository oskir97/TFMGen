using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class AsitenciaDTOA
{
private int idasitencia;
public int Idasitencia
{
        get { return idasitencia; }
        set { idasitencia = value; }
}

private Nullable<DateTime> fecha;
public Nullable<DateTime> Fecha
{
        get { return fecha; }
        set { fecha = value; }
}

private bool asiste;
public bool Asiste
{
        get { return asiste; }
        set { asiste = value; }
}

private string notas;
public string Notas
{
        get { return notas; }
        set { notas = value; }
}


/* Rol: Asitencia o--> Evento */
private EventoDTOA obtenerEvento;
public EventoDTOA ObtenerEvento
{
        get { return obtenerEvento; }
        set { obtenerEvento = value; }
}
}
}
