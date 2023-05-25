using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class PagoTipo_l10nDTOA
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


/* Rol: PagoTipo_l10n o--> Idioma */
private IdiomaDTOA getIdiomaTipoPago;
public IdiomaDTOA GetIdiomaTipoPago
{
        get { return getIdiomaTipoPago; }
        set { getIdiomaTipoPago = value; }
}
}
}
