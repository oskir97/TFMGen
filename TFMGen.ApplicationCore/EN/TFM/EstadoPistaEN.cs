
using System;
// Definición clase EstadoPistaEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class EstadoPistaEN
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
private TFMGen.ApplicationCore.EN.TFM.PistaEN pistas;



/**
 *	Atributo idiomas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> idiomas;






public virtual int Idestado {
        get { return idestado; } set { idestado = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.PistaEN Pistas {
        get { return pistas; } set { pistas = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> Idiomas {
        get { return idiomas; } set { idiomas = value;  }
}





public EstadoPistaEN()
{
        idiomas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.IdiomaEN>();
}



public EstadoPistaEN(int idestado, string nombre, TFMGen.ApplicationCore.EN.TFM.PistaEN pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> idiomas
                     )
{
        this.init (Idestado, nombre, pistas, idiomas);
}


public EstadoPistaEN(EstadoPistaEN estadoPista)
{
        this.init (Idestado, estadoPista.Nombre, estadoPista.Pistas, estadoPista.Idiomas);
}

private void init (int idestado
                   , string nombre, TFMGen.ApplicationCore.EN.TFM.PistaEN pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IdiomaEN> idiomas)
{
        this.Idestado = idestado;


        this.Nombre = nombre;

        this.Pistas = pistas;

        this.Idiomas = idiomas;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EstadoPistaEN t = obj as EstadoPistaEN;
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
