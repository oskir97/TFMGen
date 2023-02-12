
using System;
// Definición clase AsitenciaEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class AsitenciaEN
{
/**
 *	Atributo idasitencia
 */
private int idasitencia;



/**
 *	Atributo usuario
 */
private TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo asiste
 */
private bool asiste;



/**
 *	Atributo notas
 */
private string notas;






public virtual int Idasitencia {
        get { return idasitencia; } set { idasitencia = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual bool Asiste {
        get { return asiste; } set { asiste = value;  }
}



public virtual string Notas {
        get { return notas; } set { notas = value;  }
}





public AsitenciaEN()
{
}



public AsitenciaEN(int idasitencia, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, Nullable<DateTime> fecha, bool asiste, string notas
                   )
{
        this.init (Idasitencia, usuario, fecha, asiste, notas);
}


public AsitenciaEN(AsitenciaEN asitencia)
{
        this.init (Idasitencia, asitencia.Usuario, asitencia.Fecha, asitencia.Asiste, asitencia.Notas);
}

private void init (int idasitencia
                   , TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, Nullable<DateTime> fecha, bool asiste, string notas)
{
        this.Idasitencia = idasitencia;


        this.Usuario = usuario;

        this.Fecha = fecha;

        this.Asiste = asiste;

        this.Notas = notas;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AsitenciaEN t = obj as AsitenciaEN;
        if (t == null)
                return false;
        if (Idasitencia.Equals (t.Idasitencia))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idasitencia.GetHashCode ();
        return hash;
}
}
}
