using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class ValoracionDTOA
{
private int idvaloracion;
public int Idvaloracion
{
        get { return idvaloracion; }
        set { idvaloracion = value; }
}

private int estrellas;
public int Estrellas
{
        get { return estrellas; }
        set { estrellas = value; }
}

private string comentario;
public string Comentario
{
        get { return comentario; }
        set { comentario = value; }
}
}
}
