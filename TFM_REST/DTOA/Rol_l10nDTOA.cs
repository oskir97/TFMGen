using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class Rol_l10nDTOA
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


/* Rol: Rol_l10n o--> Idioma */
private IdiomaDTOA getIdiomaRol;
public IdiomaDTOA GetIdiomaRol
{
        get { return getIdiomaRol; }
        set { getIdiomaRol = value; }
}
}
}
