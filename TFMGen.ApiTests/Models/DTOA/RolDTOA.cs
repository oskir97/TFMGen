using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class RolDTOA
{
private int idrol;
public int Idrol
{
        get { return idrol; }
        set { idrol = value; }
}

private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}


/* Rol: Rol o--> Rol_l10n */
private IList<Rol_l10nDTOA> obtenerTraduccionesRol;
public IList<Rol_l10nDTOA> ObtenerTraduccionesRol
{
        get { return obtenerTraduccionesRol; }
        set { obtenerTraduccionesRol = value; }
}
}
}
