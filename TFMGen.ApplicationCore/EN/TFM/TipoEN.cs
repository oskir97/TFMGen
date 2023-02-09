
using System;
// Definición clase TipoEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class TipoEN
{
/**
 *	Atributo idtipo
 */
private int idtipo;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo pagos
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> pagos;



/**
 *	Atributo idiomas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> idiomas;






public virtual int Idtipo {
        get { return idtipo; } set { idtipo = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> Pagos {
        get { return pagos; } set { pagos = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> Idiomas {
        get { return idiomas; } set { idiomas = value;  }
}





public TipoEN()
{
        pagos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PagoEN>();
        idiomas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.IdiomaEN>();
}



public TipoEN(int idtipo, string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> pagos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> idiomas
              )
{
        this.init (Idtipo, nombre, pagos, idiomas);
}


public TipoEN(TipoEN tipo)
{
        this.init (Idtipo, tipo.Nombre, tipo.Pagos, tipo.Idiomas);
}

private void init (int idtipo
                   , string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> pagos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> idiomas)
{
        this.Idtipo = idtipo;


        this.Nombre = nombre;

        this.Pagos = pagos;

        this.Idiomas = idiomas;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TipoEN t = obj as TipoEN;
        if (t == null)
                return false;
        if (Idtipo.Equals (t.Idtipo))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idtipo.GetHashCode ();
        return hash;
}
}
}
