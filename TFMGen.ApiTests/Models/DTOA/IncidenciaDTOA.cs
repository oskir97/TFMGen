using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class IncidenciaDTOA
{
private int idincidencia;
public int Idincidencia
{
        get { return idincidencia; }
        set { idincidencia = value; }
}

private string asunto;
public string Asunto
{
        get { return asunto; }
        set { asunto = value; }
}

private string descripcion;
public string Descripcion
{
        get { return descripcion; }
        set { descripcion = value; }
}

private Nullable<DateTime> fechacancelada;
public Nullable<DateTime> Fechacancelada
{
        get { return fechacancelada; }
        set { fechacancelada = value; }
}

private Nullable<DateTime> fechareemplazada;
public Nullable<DateTime> Fechareemplazada
{
        get { return fechareemplazada; }
        set { fechareemplazada = value; }
}
}
}
