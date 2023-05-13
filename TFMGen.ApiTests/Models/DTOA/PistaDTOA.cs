using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class PistaDTOA
{
private int idpista;
public int Idpista
{
        get { return idpista; }
        set { idpista = value; }
}

private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}

private string ubicacion;
public string Ubicacion
{
        get { return ubicacion; }
        set { ubicacion = value; }
}

private string imagen;
public string Imagen
{
        get { return imagen; }
        set { imagen = value; }
}

private int maxreservas;
public int Maxreservas
{
        get { return maxreservas; }
        set { maxreservas = value; }
}

private bool visible;
public bool Visible
{
        get { return visible; }
        set { visible = value; }
}


/* Rol: Pista o--> Horario */
private IList<HorarioDTOA> obtenerHorarios;
public IList<HorarioDTOA> ObtenerHorarios
{
        get { return obtenerHorarios; }
        set { obtenerHorarios = value; }
}

/* Rol: Pista o--> Instalacion */
private InstalacionDTOA obtenerInstalaciones;
public InstalacionDTOA ObtenerInstalaciones
{
        get { return obtenerInstalaciones; }
        set { obtenerInstalaciones = value; }
}

/* Rol: Pista o--> Entidad */
private EntidadDTOA obtenerEntidadPista;
public EntidadDTOA ObtenerEntidadPista
{
        get { return obtenerEntidadPista; }
        set { obtenerEntidadPista = value; }
}

/* Rol: Pista o--> Valoracion */
private IList<ValoracionDTOA> obtenerValoracionesPista;
public IList<ValoracionDTOA> ObtenerValoracionesPista
{
        get { return obtenerValoracionesPista; }
        set { obtenerValoracionesPista = value; }
}

/* Rol: Pista o--> PistaEstado */
private PistaEstadoDTOA obtenerEstado;
public PistaEstadoDTOA ObtenerEstado
{
        get { return obtenerEstado; }
        set { obtenerEstado = value; }
}
        private decimal precio;
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
