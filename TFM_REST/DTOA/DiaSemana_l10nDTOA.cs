using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class DiaSemana_l10nDTOA
{
private int iddiasemana;
public int Iddiasemana
{
        get { return iddiasemana; }
        set { iddiasemana = value; }
}

private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}


/* Rol: DiaSemana_l10n o--> Idioma */
private IdiomaDTOA getIdiomaDiaSemana;
public IdiomaDTOA GetIdiomaDiaSemana
{
        get { return getIdiomaDiaSemana; }
        set { getIdiomaDiaSemana = value; }
}
}
}
