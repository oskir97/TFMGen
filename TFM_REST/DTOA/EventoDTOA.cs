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

private double precio;
public double Precio
{
        get { return precio; }
        set { precio = value; }
}

private Nullable<DateTime> inicio;
public Nullable<DateTime> Inicio
{
        get { return inicio; }
        set { inicio = value; }
}

private Nullable<DateTime> fin;
public Nullable<DateTime> Fin
{
        get { return fin; }
        set { fin = value; }
}


/* Rol: Evento o--> UsuarioRegistrado */
private IList<UsuarioRegistradoDTOA> obtenerInstructores;
public IList<UsuarioRegistradoDTOA> ObtenerInstructores
{
        get { return obtenerInstructores; }
        set { obtenerInstructores = value; }
}

/* Rol: Evento o--> Horario */
private IList<HorarioDTOA> obtenerHorariosEvento;
public IList<HorarioDTOA> ObtenerHorariosEvento
{
        get { return obtenerHorariosEvento; }
        set { obtenerHorariosEvento = value; }
}

/* Rol: Evento o--> Deporte */
private DeporteDTOA obtenerDeporteEvento;
public DeporteDTOA ObtenerDeporteEvento
{
        get { return obtenerDeporteEvento; }
        set { obtenerDeporteEvento = value; }
}

/* Rol: Evento o--> Valoracion */
private IList<ValoracionDTOA> obtenerValoracionesEvento;
public IList<ValoracionDTOA> ObtenerValoracionesEvento
{
        get { return obtenerValoracionesEvento; }
        set { obtenerValoracionesEvento = value; }
}

/* Rol: Evento o--> Instalacion */
private InstalacionDTOA obtenerInstalacion;
public InstalacionDTOA ObtenerInstalacion
{
        get { return obtenerInstalacion; }
        set { obtenerInstalacion = value; }
}

/* Rol: Evento o--> Pista */
private PistaDTOA obtenerPistaEvento;
public PistaDTOA ObtenerPistaEvento
{
        get { return obtenerPistaEvento; }
        set { obtenerPistaEvento = value; }
}
}
}
