
using System;
// Definición clase Deporte_l10nEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class Deporte_l10nEN
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
 *	Atributo idioma
 */
private TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma;



/**
 *	Atributo deporte
 */
private TFMGen.ApplicationCore.EN.TFM.DeporteEN deporte;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.IdiomaEN Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.DeporteEN Deporte {
        get { return deporte; } set { deporte = value;  }
}





public Deporte_l10nEN()
{
}



public Deporte_l10nEN(int id, string nombre, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma, TFMGen.ApplicationCore.EN.TFM.DeporteEN deporte
                      )
{
        this.init (Id, nombre, idioma, deporte);
}


public Deporte_l10nEN(Deporte_l10nEN deporte_l10n)
{
        this.init (Id, deporte_l10n.Nombre, deporte_l10n.Idioma, deporte_l10n.Deporte);
}

private void init (int id
                   , string nombre, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma, TFMGen.ApplicationCore.EN.TFM.DeporteEN deporte)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Idioma = idioma;

        this.Deporte = deporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Deporte_l10nEN t = obj as Deporte_l10nEN;
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
