using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class UsuarioRegistradoDTOA
{
private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
}

private string email;
public string Email
{
        get { return email; }
        set { email = value; }
}

private string apellidos;
public string Apellidos
{
        get { return apellidos; }
        set { apellidos = value; }
}

private string domicilio;
public string Domicilio
{
        get { return domicilio; }
        set { domicilio = value; }
}

private string telefono;
public string Telefono
{
        get { return telefono; }
        set { telefono = value; }
}

private string telefonoalternativo;
public string Telefonoalternativo
{
        get { return telefonoalternativo; }
        set { telefonoalternativo = value; }
}

private Nullable<DateTime> fechanacimiento;
public Nullable<DateTime> Fechanacimiento
{
        get { return fechanacimiento; }
        set { fechanacimiento = value; }
}

private Nullable<DateTime> alta;
public Nullable<DateTime> Alta
{
        get { return alta; }
        set { alta = value; }
}

private string ubicacionactual;
public string Ubicacionactual
{
        get { return ubicacionactual; }
        set { ubicacionactual = value; }
}

private string codigopostal;
public string Codigopostal
{
        get { return codigopostal; }
        set { codigopostal = value; }
}

private string localidad;
public string Localidad
{
        get { return localidad; }
        set { localidad = value; }
}

private string provincia;
public string Provincia
{
        get { return provincia; }
        set { provincia = value; }
}

private int idusuario;
public int Idusuario
{
        get { return idusuario; }
        set { idusuario = value; }
}


/* Rol: UsuarioRegistrado o--> Valoracion */
private IList<ValoracionDTOA> obtenerValoracionesTecnicos;
public IList<ValoracionDTOA> ObtenerValoracionesTecnicos
{
        get { return obtenerValoracionesTecnicos; }
        set { obtenerValoracionesTecnicos = value; }
}

/* Rol: UsuarioRegistrado o--> Rol */
private RolDTOA obtenerRol;
public RolDTOA ObtenerRol
{
        get { return obtenerRol; }
        set { obtenerRol = value; }
}

/* Rol: UsuarioRegistrado o--> Entidad */
private EntidadDTOA obtenerEntidad;
public EntidadDTOA ObtenerEntidad
{
        get { return obtenerEntidad; }
        set { obtenerEntidad = value; }
}
}
}
