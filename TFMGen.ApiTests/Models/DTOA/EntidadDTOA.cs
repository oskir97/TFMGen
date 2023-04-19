using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class EntidadDTOA
{
private int identidad;
public int Identidad
{
        get { return identidad; }
        set { identidad = value; }
}

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

private string telefono;
public string Telefono
{
        get { return telefono; }
        set { telefono = value; }
}

private string domicilio;
public string Domicilio
{
        get { return domicilio; }
        set { domicilio = value; }
}

private string cifnif;
public string Cifnif
{
        get { return cifnif; }
        set { cifnif = value; }
}

private string telefonoalternativo;
public string Telefonoalternativo
{
        get { return telefonoalternativo; }
        set { telefonoalternativo = value; }
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

private string imagen;
public string Imagen
{
        get { return imagen; }
        set { imagen = value; }
}

private string configuracion;
public string Configuracion
{
        get { return configuracion; }
        set { configuracion = value; }
}


/* Rol: Entidad o--> Valoracion */
private IList<ValoracionDTOA> obtenerValoracionesEntidad;
public IList<ValoracionDTOA> ObtenerValoracionesEntidad
{
        get { return obtenerValoracionesEntidad; }
        set { obtenerValoracionesEntidad = value; }
}
}
}
