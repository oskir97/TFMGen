
using System;
// Definición clase IncidenciaEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class IncidenciaEN
{
/**
 *	Atributo idincidencia
 */
private int idincidencia;



/**
 *	Atributo usuario
 */
private TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario;



/**
 *	Atributo evento
 */
private TFMGen.ApplicationCore.EN.TFM.EventoEN evento;



/**
 *	Atributo asunto
 */
private string asunto;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo fechacancelada
 */
private Nullable<DateTime> fechacancelada;



/**
 *	Atributo fechareemplazada
 */
private Nullable<DateTime> fechareemplazada;






public virtual int Idincidencia {
        get { return idincidencia; } set { idincidencia = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}



public virtual string Asunto {
        get { return asunto; } set { asunto = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual Nullable<DateTime> Fechacancelada {
        get { return fechacancelada; } set { fechacancelada = value;  }
}



public virtual Nullable<DateTime> Fechareemplazada {
        get { return fechareemplazada; } set { fechareemplazada = value;  }
}





public IncidenciaEN()
{
}



public IncidenciaEN(int idincidencia, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, TFMGen.ApplicationCore.EN.TFM.EventoEN evento, string asunto, string descripcion, Nullable<DateTime> fechacancelada, Nullable<DateTime> fechareemplazada
                    )
{
        this.init (Idincidencia, usuario, evento, asunto, descripcion, fechacancelada, fechareemplazada);
}


public IncidenciaEN(IncidenciaEN incidencia)
{
        this.init (Idincidencia, incidencia.Usuario, incidencia.Evento, incidencia.Asunto, incidencia.Descripcion, incidencia.Fechacancelada, incidencia.Fechareemplazada);
}

private void init (int idincidencia
                   , TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, TFMGen.ApplicationCore.EN.TFM.EventoEN evento, string asunto, string descripcion, Nullable<DateTime> fechacancelada, Nullable<DateTime> fechareemplazada)
{
        this.Idincidencia = idincidencia;


        this.Usuario = usuario;

        this.Evento = evento;

        this.Asunto = asunto;

        this.Descripcion = descripcion;

        this.Fechacancelada = fechacancelada;

        this.Fechareemplazada = fechareemplazada;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IncidenciaEN t = obj as IncidenciaEN;
        if (t == null)
                return false;
        if (Idincidencia.Equals (t.Idincidencia))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idincidencia.GetHashCode ();
        return hash;
}
}
}
