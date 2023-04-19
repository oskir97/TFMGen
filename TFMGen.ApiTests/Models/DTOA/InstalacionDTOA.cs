using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;
using TFMTFMGen.ApiTests.Models_REST.DTOA;

namespace TFMGen.ApiTests.Models.DTOA
{
public class InstalacionDTOA
{
private int idinstalacion;
public int Idinstalacion
{
        get { return idinstalacion; }
        set { idinstalacion = value; }
}

private string nombre;
public string Nombre
{
        get { return nombre; }
        set { nombre = value; }
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

private string telefonoalternativo;
public string Telefonoalternativo
{
        get { return telefonoalternativo; }
        set { telefonoalternativo = value; }
}

private bool visible;
public bool Visible
{
        get { return visible; }
        set { visible = value; }
}


/* Rol: Instalacion o--> Entidad */
private EntidadDTOA obtenerEntidadInstalacion;
public EntidadDTOA ObtenerEntidadInstalacion
{
        get { return obtenerEntidadInstalacion; }
        set { obtenerEntidadInstalacion = value; }
}

/* Rol: Instalacion o--> Material */
private IList<MaterialDTOA> obtenerMateriales;
public IList<MaterialDTOA> ObtenerMateriales
{
        get { return obtenerMateriales; }
        set { obtenerMateriales = value; }
}

/* Rol: Instalacion o--> Valoracion */
private IList<ValoracionDTOA> obtenerValoracionesInstalacion;
public IList<ValoracionDTOA> ObtenerValoracionesInstalacion
{
        get { return obtenerValoracionesInstalacion; }
        set { obtenerValoracionesInstalacion = value; }
}
}
}
