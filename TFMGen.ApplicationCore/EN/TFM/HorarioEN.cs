
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



/**
 *	Atributo diaSemana
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> diaSemana;



/**
 *	Atributo eventos
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos;






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



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> DiaSemana {
        get { return diaSemana; } set { diaSemana = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Eventos {
        get { return eventos; } set { eventos = value;  }
}





public HorarioEN()
{
        reserva = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
        diaSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
        eventos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
}



public HorarioEN(int idhorario, Nullable<DateTime> inicio, Nullable<DateTime> fin, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reserva, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> diaSemana, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos
                 )
{
        this.init (Idhorario, inicio, fin, pista, reserva, diaSemana, eventos);
}


public HorarioEN(HorarioEN horario)
{
        this.init (Idhorario, horario.Inicio, horario.Fin, horario.Pista, horario.Reserva, horario.DiaSemana, horario.Eventos);
}

private void init (int idhorario
                   , Nullable<DateTime> inicio, Nullable<DateTime> fin, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reserva, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> diaSemana, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos)
{
        this.Idhorario = idhorario;


        this.Inicio = inicio;

        this.Fin = fin;

        this.Pista = pista;

        this.Reserva = reserva;

        this.DiaSemana = diaSemana;

        this.Eventos = eventos;
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
