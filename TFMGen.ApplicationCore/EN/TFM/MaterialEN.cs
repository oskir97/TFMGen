
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
private decimal precio;



/**
 *	Atributo proveedor
 */
private string proveedor;



/**
 *	Atributo instalacion
 */
private TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion;






public virtual int Idmaterial {
        get { return idmaterial; } set { idmaterial = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual decimal Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Proveedor {
        get { return proveedor; } set { proveedor = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.InstalacionEN Instalacion {
        get { return instalacion; } set { instalacion = value;  }
}





public MaterialEN()
{
}



public MaterialEN(int idmaterial, string nombre, string descripcion, decimal precio, string proveedor, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion
                  )
{
        this.init (Idmaterial, nombre, descripcion, precio, proveedor, instalacion);
}


public MaterialEN(MaterialEN material)
{
        this.init (Idmaterial, material.Nombre, material.Descripcion, material.Precio, material.Proveedor, material.Instalacion);
}

private void init (int idmaterial
                   , string nombre, string descripcion, decimal precio, string proveedor, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion)
{
        this.Idmaterial = idmaterial;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Precio = precio;

        this.Proveedor = proveedor;

        this.Instalacion = instalacion;
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
