
using System;
// Definición clase DiaSemanaEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class DiaSemanaEN
{
/**
 *	Atributo iddiasemana
 */
private int iddiasemana;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo diaSemana_l10n
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> diaSemana_l10n;



/**
 *	Atributo horario
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horario;



/**
 *	Atributo eventos
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos;






public virtual int Iddiasemana {
        get { return iddiasemana; } set { iddiasemana = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> DiaSemana_l10n {
        get { return diaSemana_l10n; } set { diaSemana_l10n = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Horario {
        get { return horario; } set { horario = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Eventos {
        get { return eventos; } set { eventos = value;  }
}





public DiaSemanaEN()
{
        diaSemana_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN>();
        horario = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
        eventos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
}



public DiaSemanaEN(int iddiasemana, string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> diaSemana_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horario, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos
                   )
{
        this.init (Iddiasemana, nombre, diaSemana_l10n, horario, eventos);
}


public DiaSemanaEN(DiaSemanaEN diaSemana)
{
        this.init (Iddiasemana, diaSemana.Nombre, diaSemana.DiaSemana_l10n, diaSemana.Horario, diaSemana.Eventos);
}

private void init (int iddiasemana
                   , string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> diaSemana_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horario, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos)
{
        this.Iddiasemana = iddiasemana;


        this.Nombre = nombre;

        this.DiaSemana_l10n = diaSemana_l10n;

        this.Horario = horario;

        this.Eventos = eventos;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DiaSemanaEN t = obj as DiaSemanaEN;
        if (t == null)
                return false;
        if (Iddiasemana.Equals (t.Iddiasemana))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Iddiasemana.GetHashCode ();
        return hash;
}
}
}
