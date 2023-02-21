
using System;
// Definición clase ReservaEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class ReservaEN
{
/**
 *	Atributo idreserva
 */
private int idreserva;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo usuario
 */
private TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario;



/**
 *	Atributo cancelada
 */
private bool cancelada;



/**
 *	Atributo pista
 */
private TFMGen.ApplicationCore.EN.TFM.PistaEN pista;



/**
 *	Atributo maxparticipantes
 */
private int maxparticipantes;



/**
 *	Atributo pago
 */
private TFMGen.ApplicationCore.EN.TFM.PagoEN pago;



/**
 *	Atributo horario
 */
private TFMGen.ApplicationCore.EN.TFM.HorarioEN horario;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo inscripciones
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> inscripciones;



/**
 *	Atributo partido
 */
private TFMGen.ApplicationCore.EN.TFM.ReservaEN partido;



/**
 *	Atributo tipo
 */
private TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum tipo;



/**
 *	Atributo notificacion
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificacion;






public virtual int Idreserva {
        get { return idreserva; } set { idreserva = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual bool Cancelada {
        get { return cancelada; } set { cancelada = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.PistaEN Pista {
        get { return pista; } set { pista = value;  }
}



public virtual int Maxparticipantes {
        get { return maxparticipantes; } set { maxparticipantes = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.PagoEN Pago {
        get { return pago; } set { pago = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.HorarioEN Horario {
        get { return horario; } set { horario = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Inscripciones {
        get { return inscripciones; } set { inscripciones = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.ReservaEN Partido {
        get { return partido; } set { partido = value;  }
}



public virtual TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> Notificacion {
        get { return notificacion; } set { notificacion = value;  }
}





public ReservaEN()
{
        inscripciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
        notificacion = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
}



public ReservaEN(int idreserva, string nombre, string apellidos, string email, string telefono, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, bool cancelada, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, int maxparticipantes, TFMGen.ApplicationCore.EN.TFM.PagoEN pago, TFMGen.ApplicationCore.EN.TFM.HorarioEN horario, Nullable<DateTime> fecha, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> inscripciones, TFMGen.ApplicationCore.EN.TFM.ReservaEN partido, TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum tipo, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificacion
                 )
{
        this.init (Idreserva, nombre, apellidos, email, telefono, usuario, cancelada, pista, maxparticipantes, pago, horario, fecha, inscripciones, partido, tipo, notificacion);
}


public ReservaEN(ReservaEN reserva)
{
        this.init (Idreserva, reserva.Nombre, reserva.Apellidos, reserva.Email, reserva.Telefono, reserva.Usuario, reserva.Cancelada, reserva.Pista, reserva.Maxparticipantes, reserva.Pago, reserva.Horario, reserva.Fecha, reserva.Inscripciones, reserva.Partido, reserva.Tipo, reserva.Notificacion);
}

private void init (int idreserva
                   , string nombre, string apellidos, string email, string telefono, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, bool cancelada, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, int maxparticipantes, TFMGen.ApplicationCore.EN.TFM.PagoEN pago, TFMGen.ApplicationCore.EN.TFM.HorarioEN horario, Nullable<DateTime> fecha, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> inscripciones, TFMGen.ApplicationCore.EN.TFM.ReservaEN partido, TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum tipo, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificacion)
{
        this.Idreserva = idreserva;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Email = email;

        this.Telefono = telefono;

        this.Usuario = usuario;

        this.Cancelada = cancelada;

        this.Pista = pista;

        this.Maxparticipantes = maxparticipantes;

        this.Pago = pago;

        this.Horario = horario;

        this.Fecha = fecha;

        this.Inscripciones = inscripciones;

        this.Partido = partido;

        this.Tipo = tipo;

        this.Notificacion = notificacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReservaEN t = obj as ReservaEN;
        if (t == null)
                return false;
        if (Idreserva.Equals (t.Idreserva))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idreserva.GetHashCode ();
        return hash;
}
}
}
