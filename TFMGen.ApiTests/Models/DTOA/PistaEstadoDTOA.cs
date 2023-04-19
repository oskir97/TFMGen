using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class PistaEstadoDTOA
{
private int idestado;
public int Idestado
{
        get { return idestado; }
        set { idestado = value; }
}

private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}


/* Rol: PistaEstado o--> PistaEstado_l10n */
private IList<PistaEstado_l10nDTOA> obtenerTraduccionesEstado;
public IList<PistaEstado_l10nDTOA> ObtenerTraduccionesEstado
{
        get { return obtenerTraduccionesEstado; }
        set { obtenerTraduccionesEstado = value; }
}
}
}
