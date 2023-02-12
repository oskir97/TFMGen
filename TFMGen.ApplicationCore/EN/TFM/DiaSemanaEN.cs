
using System;
// Definición clase DiaSemanaEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class DiaSemanaEN
{
/**
 *	Atributo id
 */
private int id;



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






public virtual int Id {
        get { return id; } set { id = value;  }
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





public DiaSemanaEN()
{
        diaSemana_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN>();
        horario = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
}



public DiaSemanaEN(int id, string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> diaSemana_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horario
                   )
{
        this.init (Id, nombre, diaSemana_l10n, horario);
}


public DiaSemanaEN(DiaSemanaEN diaSemana)
{
        this.init (Id, diaSemana.Nombre, diaSemana.DiaSemana_l10n, diaSemana.Horario);
}

private void init (int id
                   , string nombre, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> diaSemana_l10n, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horario)
{
        this.Id = id;


        this.Nombre = nombre;

        this.DiaSemana_l10n = diaSemana_l10n;

        this.Horario = horario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DiaSemanaEN t = obj as DiaSemanaEN;
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
