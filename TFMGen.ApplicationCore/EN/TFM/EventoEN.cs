
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



/**
 *	Atributo activo
 */
private bool activo;



/**
 *	Atributo plazas
 */
private int plazas;



/**
 *	Atributo deporte
 */
private TFMGen.ApplicationCore.EN.TFM.DeporteEN deporte;



/**
 *	Atributo inicio
 */
private Nullable<DateTime> inicio;



/**
 *	Atributo fin
 */
private Nullable<DateTime> fin;



/**
 *	Atributo reservas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservas;



/**
 *	Atributo instalacion
 */
private TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion;



/**
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo valoraciones
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoraciones;






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



public virtual bool Activo {
        get { return activo; } set { activo = value;  }
}



public virtual int Plazas {
        get { return plazas; } set { plazas = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.DeporteEN Deporte {
        get { return deporte; } set { deporte = value;  }
}



public virtual Nullable<DateTime> Inicio {
        get { return inicio; } set { inicio = value;  }
}



public virtual Nullable<DateTime> Fin {
        get { return fin; } set { fin = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Reservas {
        get { return reservas; } set { reservas = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.InstalacionEN Instalacion {
        get { return instalacion; } set { instalacion = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Valoraciones {
        get { return valoraciones; } set { valoraciones = value;  }
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
        reservas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
        valoraciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
}



public EventoEN(int idevento, string nombre, string descripcion, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificaciones, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> asitencias, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> tecnicos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> incidencia, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> diasSemana, bool activo, int plazas, TFMGen.ApplicationCore.EN.TFM.DeporteEN deporte, Nullable<DateTime> inicio, Nullable<DateTime> fin, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservas, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, double precio, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoraciones
                )
{
        this.init (Idevento, nombre, descripcion, notificaciones, entidad, asitencias, usuarios, tecnicos, horarios, incidencia, diasSemana, activo, plazas, deporte, inicio, fin, reservas, instalacion, precio, valoraciones);
}


public EventoEN(EventoEN evento)
{
        this.init (Idevento, evento.Nombre, evento.Descripcion, evento.Notificaciones, evento.Entidad, evento.Asitencias, evento.Usuarios, evento.Tecnicos, evento.Horarios, evento.Incidencia, evento.DiasSemana, evento.Activo, evento.Plazas, evento.Deporte, evento.Inicio, evento.Fin, evento.Reservas, evento.Instalacion, evento.Precio, evento.Valoraciones);
}

private void init (int idevento
                   , string nombre, string descripcion, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificaciones, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> asitencias, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> tecnicos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> incidencia, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> diasSemana, bool activo, int plazas, TFMGen.ApplicationCore.EN.TFM.DeporteEN deporte, Nullable<DateTime> inicio, Nullable<DateTime> fin, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservas, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, double precio, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoraciones)
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

        this.Activo = activo;

        this.Plazas = plazas;

        this.Deporte = deporte;

        this.Inicio = inicio;

        this.Fin = fin;

        this.Reservas = reservas;

        this.Instalacion = instalacion;

        this.Precio = precio;

        this.Valoraciones = valoraciones;
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
