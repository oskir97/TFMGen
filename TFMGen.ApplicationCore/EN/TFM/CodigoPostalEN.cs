
using System;
// Definición clase CodigoPostalEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class CodigoPostalEN
{
/**
 *	Atributo idcodigopostal
 */
private int idcodigopostal;



/**
 *	Atributo codigo
 */
private string codigo;



/**
 *	Atributo localidad
 */
private string localidad;



/**
 *	Atributo comunidad
 */
private string comunidad;



/**
 *	Atributo provincia
 */
private string provincia;



/**
 *	Atributo latitud
 */
private string latitud;



/**
 *	Atributo longitud
 */
private string longitud;



/**
 *	Atributo precision
 */
private string precision;



/**
 *	Atributo usuarios
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios;



/**
 *	Atributo entidades
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EntidadEN> entidades;






public virtual int Idcodigopostal {
        get { return idcodigopostal; } set { idcodigopostal = value;  }
}



public virtual string Codigo {
        get { return codigo; } set { codigo = value;  }
}



public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}



public virtual string Comunidad {
        get { return comunidad; } set { comunidad = value;  }
}



public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}



public virtual string Latitud {
        get { return latitud; } set { latitud = value;  }
}



public virtual string Longitud {
        get { return longitud; } set { longitud = value;  }
}



public virtual string Precision {
        get { return precision; } set { precision = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Usuarios {
        get { return usuarios; } set { usuarios = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EntidadEN> Entidades {
        get { return entidades; } set { entidades = value;  }
}





public CodigoPostalEN()
{
        usuarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
        entidades = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EntidadEN>();
}



public CodigoPostalEN(int idcodigopostal, string codigo, string localidad, string comunidad, string provincia, string latitud, string longitud, string precision, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EntidadEN> entidades
                      )
{
        this.init (Idcodigopostal, codigo, localidad, comunidad, provincia, latitud, longitud, precision, usuarios, entidades);
}


public CodigoPostalEN(CodigoPostalEN codigoPostal)
{
        this.init (Idcodigopostal, codigoPostal.Codigo, codigoPostal.Localidad, codigoPostal.Comunidad, codigoPostal.Provincia, codigoPostal.Latitud, codigoPostal.Longitud, codigoPostal.Precision, codigoPostal.Usuarios, codigoPostal.Entidades);
}

private void init (int idcodigopostal
                   , string codigo, string localidad, string comunidad, string provincia, string latitud, string longitud, string precision, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EntidadEN> entidades)
{
        this.Idcodigopostal = idcodigopostal;


        this.Codigo = codigo;

        this.Localidad = localidad;

        this.Comunidad = comunidad;

        this.Provincia = provincia;

        this.Latitud = latitud;

        this.Longitud = longitud;

        this.Precision = precision;

        this.Usuarios = usuarios;

        this.Entidades = entidades;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CodigoPostalEN t = obj as CodigoPostalEN;
        if (t == null)
                return false;
        if (Idcodigopostal.Equals (t.Idcodigopostal))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idcodigopostal.GetHashCode ();
        return hash;
}
}
}
