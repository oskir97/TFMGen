using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class Deporte_l10nDTOA
{
private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}

private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


/* Rol: Deporte_l10n o--> Idioma */
private IdiomaDTOA getIdiomaDeporte;
public IdiomaDTOA GetIdiomaDeporte
{
        get { return getIdiomaDeporte; }
        set { getIdiomaDeporte = value; }
}
}
}
