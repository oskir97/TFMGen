
using System;
// Definición clase PistaEstadoEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class PistaEstadoEN
{
/**
 *	Atributo idestado
 */
private int idestado;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo pistas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas;



/**
 *	Atributo estadoPista_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> estadoPista_l10n;






public virtual int Idestado {
        get { return idestado; } set { idestado = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Pistas {
        get { return pistas; } set { pistas = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> EstadoPista_l10n {
        get { return estadoPista_l10n; } set { estadoPista_l10n = value;  }
}





public PistaEstadoEN()
{
        pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
        estadoPista_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN>();
}



public PistaEstadoEN(int idestado, string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> estadoPista_l10n
                     )
{
        this.init (Idestado, nombre, pistas, estadoPista_l10n);
}


public PistaEstadoEN(PistaEstadoEN pistaEstado)
{
        this.init (Idestado, pistaEstado.Nombre, pistaEstado.Pistas, pistaEstado.EstadoPista_l10n);
}

private void init (int idestado
                   , string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> estadoPista_l10n)
{
        this.Idestado = idestado;


        this.Nombre = nombre;

        this.Pistas = pistas;

        this.EstadoPista_l10n = estadoPista_l10n;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PistaEstadoEN t = obj as PistaEstadoEN;
        if (t == null)
                return false;
        if (Idestado.Equals (t.Idestado))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idestado.GetHashCode ();
        return hash;
}
}
}
