
using System;
// Definición clase IdiomaEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class IdiomaEN
{
/**
 *	Atributo ididioma
 */
private int ididioma;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo cultura
 */
private string cultura;



/**
 *	Atributo estadosPista
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN> estadosPista;



/**
 *	Atributo tipos
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.TipoEN> tipos;



/**
 *	Atributo roles
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.RolEN> roles;



/**
 *	Atributo deportes
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DeporteEN> deportes;






public virtual int Ididioma {
        get { return ididioma; } set { ididioma = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Cultura {
        get { return cultura; } set { cultura = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN> EstadosPista {
        get { return estadosPista; } set { estadosPista = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.TipoEN> Tipos {
        get { return tipos; } set { tipos = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.RolEN> Roles {
        get { return roles; } set { roles = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DeporteEN> Deportes {
        get { return deportes; } set { deportes = value;  }
}





public IdiomaEN()
{
        estadosPista = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN>();
        tipos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.TipoEN>();
        roles = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.RolEN>();
        deportes = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DeporteEN>();
}



public IdiomaEN(int ididioma, string nombre, string cultura, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN> estadosPista, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.TipoEN> tipos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.RolEN> roles, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DeporteEN> deportes
                )
{
        this.init (Ididioma, nombre, cultura, estadosPista, tipos, roles, deportes);
}


public IdiomaEN(IdiomaEN idioma)
{
        this.init (Ididioma, idioma.Nombre, idioma.Cultura, idioma.EstadosPista, idioma.Tipos, idioma.Roles, idioma.Deportes);
}

private void init (int ididioma
                   , string nombre, string cultura, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN> estadosPista, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.TipoEN> tipos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.RolEN> roles, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DeporteEN> deportes)
{
        this.Ididioma = ididioma;


        this.Nombre = nombre;

        this.Cultura = cultura;

        this.EstadosPista = estadosPista;

        this.Tipos = tipos;

        this.Roles = roles;

        this.Deportes = deportes;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IdiomaEN t = obj as IdiomaEN;
        if (t == null)
                return false;
        if (Ididioma.Equals (t.Ididioma))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Ididioma.GetHashCode ();
        return hash;
}
}
}
