
using System;
// Definición clase PagoTipoEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class PagoTipoEN
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
 *	Atributo pagoTipo_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> pagoTipo_l10n;






public virtual int Idtipo {
        get { return idtipo; } set { idtipo = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> Pagos {
        get { return pagos; } set { pagos = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> PagoTipo_l10n {
        get { return pagoTipo_l10n; } set { pagoTipo_l10n = value;  }
}





public PagoTipoEN()
{
        pagos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PagoEN>();
        pagoTipo_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN>();
}



public PagoTipoEN(int idtipo, string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> pagos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> pagoTipo_l10n
                  )
{
        this.init (Idtipo, nombre, pagos, pagoTipo_l10n);
}


public PagoTipoEN(PagoTipoEN pagoTipo)
{
        this.init (Idtipo, pagoTipo.Nombre, pagoTipo.Pagos, pagoTipo.PagoTipo_l10n);
}

private void init (int idtipo
                   , string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> pagos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> pagoTipo_l10n)
{
        this.Idtipo = idtipo;


        this.Nombre = nombre;

        this.Pagos = pagos;

        this.PagoTipo_l10n = pagoTipo_l10n;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PagoTipoEN t = obj as PagoTipoEN;
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
