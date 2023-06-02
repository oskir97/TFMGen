
using System;
// Definición clase DeporteEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class DeporteEN
{
/**
 *	Atributo iddeporte
 */
private int iddeporte;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo pistas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas;



/**
 *	Atributo deporte_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> deporte_l10n;



/**
 *	Atributo icono
 */
private string icono;






public virtual int Iddeporte {
        get { return iddeporte; } set { iddeporte = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Pistas {
        get { return pistas; } set { pistas = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> Deporte_l10n {
        get { return deporte_l10n; } set { deporte_l10n = value;  }
}



public virtual string Icono {
        get { return icono; } set { icono = value;  }
}





public DeporteEN()
{
        pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
        deporte_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN>();
}



public DeporteEN(int iddeporte, string nombre, string descripcion, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> deporte_l10n, string icono
                 )
{
        this.init (Iddeporte, nombre, descripcion, pistas, deporte_l10n, icono);
}


public DeporteEN(DeporteEN deporte)
{
        this.init (Iddeporte, deporte.Nombre, deporte.Descripcion, deporte.Pistas, deporte.Deporte_l10n, deporte.Icono);
}

private void init (int iddeporte
                   , string nombre, string descripcion, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> deporte_l10n, string icono)
{
        this.Iddeporte = iddeporte;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Pistas = pistas;

        this.Deporte_l10n = deporte_l10n;

        this.Icono = icono;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DeporteEN t = obj as DeporteEN;
        if (t == null)
                return false;
        if (Iddeporte.Equals (t.Iddeporte))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Iddeporte.GetHashCode ();
        return hash;
}
}
}
