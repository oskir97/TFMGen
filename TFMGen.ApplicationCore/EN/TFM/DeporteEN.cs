
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
 *	Atributo idiomas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> idiomas;



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






public virtual int Iddeporte {
        get { return iddeporte; } set { iddeporte = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> Idiomas {
        get { return idiomas; } set { idiomas = value;  }
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





public DeporteEN()
{
        idiomas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.IdiomaEN>();
        pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
}



public DeporteEN(int iddeporte, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> idiomas, string nombre, string descripcion, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas
                 )
{
        this.init (Iddeporte, idiomas, nombre, descripcion, pistas);
}


public DeporteEN(DeporteEN deporte)
{
        this.init (Iddeporte, deporte.Idiomas, deporte.Nombre, deporte.Descripcion, deporte.Pistas);
}

private void init (int iddeporte
                   , System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> idiomas, string nombre, string descripcion, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas)
{
        this.Iddeporte = iddeporte;


        this.Idiomas = idiomas;

        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Pistas = pistas;
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
