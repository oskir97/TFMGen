
using System;
// Definición clase EventoEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class EventoEN
{
/**
 *	Atributo idevento
 */
private int idevento;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo notificaciones
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificaciones;



/**
 *	Atributo entidad
 */
private TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad;



/**
 *	Atributo asitencias
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> asitencias;



/**
 *	Atributo usuarios
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios;



/**
 *	Atributo tecnicos
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> tecnicos;



/**
 *	Atributo horarios
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horarios;



/**
 *	Atributo incidencia
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> incidencia;



/**
 *	Atributo diasSemana
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> diasSemana;






public virtual int Idevento {
        get { return idevento; } set { idevento = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> Notificaciones {
        get { return notificaciones; } set { notificaciones = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.EntidadEN Entidad {
        get { return entidad; } set { entidad = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> Asitencias {
        get { return asitencias; } set { asitencias = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Usuarios {
        get { return usuarios; } set { usuarios = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Tecnicos {
        get { return tecnicos; } set { tecnicos = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Horarios {
        get { return horarios; } set { horarios = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> Incidencia {
        get { return incidencia; } set { incidencia = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> DiasSemana {
        get { return diasSemana; } set { diasSemana = value;  }
}





public EventoEN()
{
        notificaciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
        asitencias = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN>();
        usuarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
        tecnicos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
        horarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
        incidencia = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN>();
        diasSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
}



public EventoEN(int idevento, string nombre, string descripcion, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificaciones, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> asitencias, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> tecnicos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> incidencia, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> diasSemana
                )
{
        this.init (Idevento, nombre, descripcion, notificaciones, entidad, asitencias, usuarios, tecnicos, horarios, incidencia, diasSemana);
}


public EventoEN(EventoEN evento)
{
        this.init (Idevento, evento.Nombre, evento.Descripcion, evento.Notificaciones, evento.Entidad, evento.Asitencias, evento.Usuarios, evento.Tecnicos, evento.Horarios, evento.Incidencia, evento.DiasSemana);
}

private void init (int idevento
                   , string nombre, string descripcion, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificaciones, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> asitencias, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> tecnicos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> incidencia, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> diasSemana)
{
        this.Idevento = idevento;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Notificaciones = notificaciones;

        this.Entidad = entidad;

        this.Asitencias = asitencias;

        this.Usuarios = usuarios;

        this.Tecnicos = tecnicos;

        this.Horarios = horarios;

        this.Incidencia = incidencia;

        this.DiasSemana = diasSemana;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EventoEN t = obj as EventoEN;
        if (t == null)
                return false;
        if (Idevento.Equals (t.Idevento))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idevento.GetHashCode ();
        return hash;
}
}
}
