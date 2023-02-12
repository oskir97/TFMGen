
using System;
// Definición clase PagoTipo_l10nEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class PagoTipo_l10nEN
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
 *	Atributo pagoTipo
 */
private TFMGen.ApplicationCore.EN.TFM.PagoTipoEN pagoTipo;



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



public virtual TFMGen.ApplicationCore.EN.TFM.PagoTipoEN PagoTipo {
        get { return pagoTipo; } set { pagoTipo = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.IdiomaEN Idioma {
        get { return idioma; } set { idioma = value;  }
}





public PagoTipo_l10nEN()
{
}



public PagoTipo_l10nEN(int id, string nombre, TFMGen.ApplicationCore.EN.TFM.PagoTipoEN pagoTipo, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma
                       )
{
        this.init (Id, nombre, pagoTipo, idioma);
}


public PagoTipo_l10nEN(PagoTipo_l10nEN pagoTipo_l10n)
{
        this.init (Id, pagoTipo_l10n.Nombre, pagoTipo_l10n.PagoTipo, pagoTipo_l10n.Idioma);
}

private void init (int id
                   , string nombre, TFMGen.ApplicationCore.EN.TFM.PagoTipoEN pagoTipo, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma)
{
        this.Id = id;


        this.Nombre = nombre;

        this.PagoTipo = pagoTipo;

        this.Idioma = idioma;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PagoTipo_l10nEN t = obj as PagoTipo_l10nEN;
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
