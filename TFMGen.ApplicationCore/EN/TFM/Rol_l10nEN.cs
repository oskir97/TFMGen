
using System;
// Definición clase Rol_l10nEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class Rol_l10nEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo rol
 */
private TFMGen.ApplicationCore.EN.TFM.RolEN rol;



/**
 *	Atributo idioma
 */
private TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.RolEN Rol {
        get { return rol; } set { rol = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.IdiomaEN Idioma {
        get { return idioma; } set { idioma = value;  }
}





public Rol_l10nEN()
{
}



public Rol_l10nEN(int id, string nombre, TFMGen.ApplicationCore.EN.TFM.RolEN rol, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma
                  )
{
        this.init (Id, nombre, rol, idioma);
}


public Rol_l10nEN(Rol_l10nEN rol_l10n)
{
        this.init (Id, rol_l10n.Nombre, rol_l10n.Rol, rol_l10n.Idioma);
}

private void init (int id
                   , string nombre, TFMGen.ApplicationCore.EN.TFM.RolEN rol, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Rol = rol;

        this.Idioma = idioma;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Rol_l10nEN t = obj as Rol_l10nEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
