
using System;
// Definición clase DiaSemana_l10nEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class DiaSemana_l10nEN
{
/**
 *	Atributo diaSemana
 */
private TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN diaSemana;



/**
 *	Atributo idioma
 */
private TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;






public virtual TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN DiaSemana {
        get { return diaSemana; } set { diaSemana = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.IdiomaEN Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}





public DiaSemana_l10nEN()
{
}



public DiaSemana_l10nEN(int id, TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN diaSemana, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma, string nombre
                        )
{
        this.init (Id, diaSemana, idioma, nombre);
}


public DiaSemana_l10nEN(DiaSemana_l10nEN diaSemana_l10n)
{
        this.init (Id, diaSemana_l10n.DiaSemana, diaSemana_l10n.Idioma, diaSemana_l10n.Nombre);
}

private void init (int id
                   , TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN diaSemana, TFMGen.ApplicationCore.EN.TFM.IdiomaEN idioma, string nombre)
{
        this.Id = id;


        this.DiaSemana = diaSemana;

        this.Idioma = idioma;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DiaSemana_l10nEN t = obj as DiaSemana_l10nEN;
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
