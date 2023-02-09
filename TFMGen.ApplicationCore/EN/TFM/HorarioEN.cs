
using System;
// Definición clase HorarioEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class HorarioEN
{
/**
 *	Atributo idhorario
 */
private int idhorario;



/**
 *	Atributo inicio
 */
private Nullable<DateTime> inicio;



/**
 *	Atributo fin
 */
private Nullable<DateTime> fin;



/**
 *	Atributo pista
 */
private TFMGen.ApplicationCore.EN.TFM.PistaEN pista;



/**
 *	Atributo reserva
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reserva;






public virtual int Idhorario {
        get { return idhorario; } set { idhorario = value;  }
}



public virtual Nullable<DateTime> Inicio {
        get { return inicio; } set { inicio = value;  }
}



public virtual Nullable<DateTime> Fin {
        get { return fin; } set { fin = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.PistaEN Pista {
        get { return pista; } set { pista = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Reserva {
        get { return reserva; } set { reserva = value;  }
}





public HorarioEN()
{
        reserva = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
}



public HorarioEN(int idhorario, Nullable<DateTime> inicio, Nullable<DateTime> fin, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reserva
                 )
{
        this.init (Idhorario, inicio, fin, pista, reserva);
}


public HorarioEN(HorarioEN horario)
{
        this.init (Idhorario, horario.Inicio, horario.Fin, horario.Pista, horario.Reserva);
}

private void init (int idhorario
                   , Nullable<DateTime> inicio, Nullable<DateTime> fin, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reserva)
{
        this.Idhorario = idhorario;


        this.Inicio = inicio;

        this.Fin = fin;

        this.Pista = pista;

        this.Reserva = reserva;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        HorarioEN t = obj as HorarioEN;
        if (t == null)
                return false;
        if (Idhorario.Equals (t.Idhorario))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idhorario.GetHashCode ();
        return hash;
}
}
}
