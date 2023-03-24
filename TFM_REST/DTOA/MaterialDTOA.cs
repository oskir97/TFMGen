using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class MaterialDTOA
{
private int idmaterial;
public int Idmaterial
{
        get { return idmaterial; }
        set { idmaterial = value; }
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

private double precio;
public double Precio
{
        get { return precio; }
        set { precio = value; }
}

private string proveedor;
public string Proveedor
{
        get { return proveedor; }
        set { proveedor = value; }
}

private int numexistencias;
public int Numexistencias
{
        get { return numexistencias; }
        set { numexistencias = value; }
}

private string urlVenta;
public string UrlVenta
{
        get { return urlVenta; }
        set { urlVenta = value; }
}

private string numeroProveedor;
public string NumeroProveedor
{
        get { return numeroProveedor; }
        set { numeroProveedor = value; }
}

private string numeroAlternativoProveedor;
public string NumeroAlternativoProveedor
{
        get { return numeroAlternativoProveedor; }
        set { numeroAlternativoProveedor = value; }
}

private string emailProveedor;
public string EmailProveedor
{
        get { return emailProveedor; }
        set { emailProveedor = value; }
}
}
}
