
using System;
// Definición clase RolEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class RolEN
{
/**
 *	Atributo idrol
 */
private int idrol;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo usuarios
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios;



/**
 *	Atributo rol_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> rol_l10n;






public virtual int Idrol {
        get { return idrol; } set { idrol = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Usuarios {
        get { return usuarios; } set { usuarios = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> Rol_l10n {
        get { return rol_l10n; } set { rol_l10n = value;  }
}





public RolEN()
{
        usuarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
        rol_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN>();
}



public RolEN(int idrol, string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> rol_l10n
             )
{
        this.init (Idrol, nombre, usuarios, rol_l10n);
}


public RolEN(RolEN rol)
{
        this.init (Idrol, rol.Nombre, rol.Usuarios, rol.Rol_l10n);
}

private void init (int idrol
                   , string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> rol_l10n)
{
        this.Idrol = idrol;


        this.Nombre = nombre;

        this.Usuarios = usuarios;

        this.Rol_l10n = rol_l10n;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RolEN t = obj as RolEN;
        if (t == null)
                return false;
        if (Idrol.Equals (t.Idrol))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idrol.GetHashCode ();
        return hash;
}
}
}
