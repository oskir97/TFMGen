using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
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
}
}
