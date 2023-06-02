
using System;
// Definición clase MaterialEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class MaterialEN
{
/**
 *	Atributo idmaterial
 */
private int idmaterial;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo proveedor
 */
private string proveedor;



/**
 *	Atributo instalacion
 */
private TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion;



/**
 *	Atributo numexistencias
 */
private int numexistencias;



/**
 *	Atributo urlventa
 */
private string urlventa;



/**
 *	Atributo numeroproveedor
 */
private string numeroproveedor;



/**
 *	Atributo numeroalternativoproveedor
 */
private string numeroalternativoproveedor;



/**
 *	Atributo emailproveedor
 */
private string emailproveedor;






public virtual int Idmaterial {
        get { return idmaterial; } set { idmaterial = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Proveedor {
        get { return proveedor; } set { proveedor = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.InstalacionEN Instalacion {
        get { return instalacion; } set { instalacion = value;  }
}



public virtual int Numexistencias {
        get { return numexistencias; } set { numexistencias = value;  }
}



public virtual string Urlventa {
        get { return urlventa; } set { urlventa = value;  }
}



public virtual string Numeroproveedor {
        get { return numeroproveedor; } set { numeroproveedor = value;  }
}



public virtual string Numeroalternativoproveedor {
        get { return numeroalternativoproveedor; } set { numeroalternativoproveedor = value;  }
}



public virtual string Emailproveedor {
        get { return emailproveedor; } set { emailproveedor = value;  }
}





public MaterialEN()
{
}



public MaterialEN(int idmaterial, string nombre, string descripcion, double precio, string proveedor, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, int numexistencias, string urlventa, string numeroproveedor, string numeroalternativoproveedor, string emailproveedor
                  )
{
        this.init (Idmaterial, nombre, descripcion, precio, proveedor, instalacion, numexistencias, urlventa, numeroproveedor, numeroalternativoproveedor, emailproveedor);
}


public MaterialEN(MaterialEN material)
{
        this.init (Idmaterial, material.Nombre, material.Descripcion, material.Precio, material.Proveedor, material.Instalacion, material.Numexistencias, material.Urlventa, material.Numeroproveedor, material.Numeroalternativoproveedor, material.Emailproveedor);
}

private void init (int idmaterial
                   , string nombre, string descripcion, double precio, string proveedor, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, int numexistencias, string urlventa, string numeroproveedor, string numeroalternativoproveedor, string emailproveedor)
{
        this.Idmaterial = idmaterial;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Precio = precio;

        this.Proveedor = proveedor;

        this.Instalacion = instalacion;

        this.Numexistencias = numexistencias;

        this.Urlventa = urlventa;

        this.Numeroproveedor = numeroproveedor;

        this.Numeroalternativoproveedor = numeroalternativoproveedor;

        this.Emailproveedor = emailproveedor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MaterialEN t = obj as MaterialEN;
        if (t == null)
                return false;
        if (Idmaterial.Equals (t.Idmaterial))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idmaterial.GetHashCode ();
        return hash;
}
}
}
