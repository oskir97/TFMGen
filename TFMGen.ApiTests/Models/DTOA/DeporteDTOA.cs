using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class DeporteDTOA
{
private int iddeporte;
public int Iddeporte
{
        get { return iddeporte; }
        set { iddeporte = value; }
}

private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}

private string descripcion;
public string Descripcion
{
        get { return descripcion; }
        set { descripcion = value; }
}


/* Rol: Deporte o--> Deporte_l10n */
private IList<Deporte_l10nDTOA> traduccionesDeporte;
public IList<Deporte_l10nDTOA> TraduccionesDeporte
{
        get { return traduccionesDeporte; }
        set { traduccionesDeporte = value; }
}
}
}
