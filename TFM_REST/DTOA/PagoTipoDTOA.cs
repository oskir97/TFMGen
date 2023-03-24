using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class PagoTipoDTOA
{
private int idtipo;
public int Idtipo
{
        get { return idtipo; }
        set { idtipo = value; }
}

private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}


/* Rol: PagoTipo o--> PagoTipo_l10n */
private IList<PagoTipo_l10nDTOA> obtenerTraduccionesTipos;
public IList<PagoTipo_l10nDTOA> ObtenerTraduccionesTipos
{
        get { return obtenerTraduccionesTipos; }
        set { obtenerTraduccionesTipos = value; }
}
}
}
