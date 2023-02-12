
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
 *	Atributo estadoPista_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> estadoPista_l10n;



/**
 *	Atributo deporte_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> deporte_l10n;



/**
 *	Atributo pagoTipo_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> pagoTipo_l10n;



/**
 *	Atributo rol_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> rol_l10n;



/**
 *	Atributo diaSemana_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> diaSemana_l10n;






public virtual int Ididioma {
        get { return ididioma; } set { ididioma = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Cultura {
        get { return cultura; } set { cultura = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> EstadoPista_l10n {
        get { return estadoPista_l10n; } set { estadoPista_l10n = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> Deporte_l10n {
        get { return deporte_l10n; } set { deporte_l10n = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> PagoTipo_l10n {
        get { return pagoTipo_l10n; } set { pagoTipo_l10n = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> Rol_l10n {
        get { return rol_l10n; } set { rol_l10n = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> DiaSemana_l10n {
        get { return diaSemana_l10n; } set { diaSemana_l10n = value;  }
}





public IdiomaEN()
{
        estadoPista_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN>();
        deporte_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN>();
        pagoTipo_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN>();
        rol_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN>();
        diaSemana_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN>();
}



public IdiomaEN(int ididioma, string nombre, string cultura, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> estadoPista_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> deporte_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> pagoTipo_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> rol_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> diaSemana_l10n
                )
{
        this.init (Ididioma, nombre, cultura, estadoPista_l10n, deporte_l10n, pagoTipo_l10n, rol_l10n, diaSemana_l10n);
}


public IdiomaEN(IdiomaEN idioma)
{
        this.init (Ididioma, idioma.Nombre, idioma.Cultura, idioma.EstadoPista_l10n, idioma.Deporte_l10n, idioma.PagoTipo_l10n, idioma.Rol_l10n, idioma.DiaSemana_l10n);
}

private void init (int ididioma
                   , string nombre, string cultura, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> estadoPista_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> deporte_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> pagoTipo_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> rol_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> diaSemana_l10n)
{
        this.Ididioma = ididioma;


        this.Nombre = nombre;

        this.Cultura = cultura;

        this.EstadoPista_l10n = estadoPista_l10n;

        this.Deporte_l10n = deporte_l10n;

        this.PagoTipo_l10n = pagoTipo_l10n;

        this.Rol_l10n = rol_l10n;

        this.DiaSemana_l10n = diaSemana_l10n;
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
