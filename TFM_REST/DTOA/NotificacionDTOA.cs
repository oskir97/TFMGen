using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class NotificacionDTOA
{
private int idnotificacion;
public int Idnotificacion
{
        get { return idnotificacion; }
        set { idnotificacion = value; }
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

private bool leida;
public bool Leida
{
        get { return leida; }
        set { leida = value; }
}

private TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum tipo;
public TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum Tipo
{
        get { return tipo; }
        set { tipo = value; }
}

private Nullable<DateTime> fecha;
public Nullable<DateTime> Fecha
{
        get { return fecha; }
        set { fecha = value; }
}
}
}
