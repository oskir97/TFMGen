
using System;
// Definición clase PistaEstado_l10nEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class PistaEstado_l10nEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo idioma
 */
private TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma;



/**
 *	Atributo estadoPista
 */
private TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN estadoPista;



/**
 *	Atributo id
 */
private int id;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.IdiomaEN Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN EstadoPista {
        get { return estadoPista; } set { estadoPista = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public PistaEstado_l10nEN()
{
}



public PistaEstado_l10nEN(int id, string nombre, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma, TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN estadoPista
                          )
{
        this.init (Id, nombre, idioma, estadoPista);
}


public PistaEstado_l10nEN(PistaEstado_l10nEN pistaEstado_l10n)
{
        this.init (Id, pistaEstado_l10n.Nombre, pistaEstado_l10n.Idioma, pistaEstado_l10n.EstadoPista);
}

private void init (int id
                   , string nombre, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma, TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN estadoPista)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Idioma = idioma;

        this.EstadoPista = estadoPista;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PistaEstado_l10nEN t = obj as PistaEstado_l10nEN;
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
