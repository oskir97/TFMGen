using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class DiaSemanaDTOA
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


/* Rol: DiaSemana o--> DiaSemana_l10n */
private IList<DiaSemana_l10nDTOA> obtenerTraduccionesDiaSemana;
public IList<DiaSemana_l10nDTOA> ObtenerTraduccionesDiaSemana
{
        get { return obtenerTraduccionesDiaSemana; }
        set { obtenerTraduccionesDiaSemana = value; }
}
}
}
