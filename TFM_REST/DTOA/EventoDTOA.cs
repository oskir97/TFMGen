using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class EventoDTOA
{
private int idevento;
public int Idevento
{
        get { return idevento; }
        set { idevento = value; }
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

private bool activo;
public bool Activo
{
        get { return activo; }
        set { activo = value; }
}

private int plazas;
public int Plazas
{
        get { return plazas; }
        set { plazas = value; }
}


/* Rol: Evento o--> UsuarioRegistrado */
private IList<UsuarioRegistradoDTOA> obtenerInstructores;
public IList<UsuarioRegistradoDTOA> ObtenerInstructores
{
        get { return obtenerInstructores; }
        set { obtenerInstructores = value; }
}
}
}