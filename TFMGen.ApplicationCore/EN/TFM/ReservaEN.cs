
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
 *	Atributo creador
 */
private TFMGen.ApplicationCore.EN.TFM.UsuarioEN creador;



/**
 *	Atributo cancelada
 */
private bool cancelada;



/**
 *	Atributo pista
 */
private TFMGen.ApplicationCore.EN.TFM.PistaEN pista;



/**
 *	Atributo espartido
 */
private bool espartido;



/**
 *	Atributo usuarios
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios;



/**
 *	Atributo maxparticipantes
 */
private int maxparticipantes;



/**
 *	Atributo pagos
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> pagos;



/**
 *	Atributo horario
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horario;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo fechapago
 */
private Nullable<DateTime> fechapago;






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



public virtual TFMGen.ApplicationCore.EN.TFM.UsuarioEN Creador {
        get { return creador; } set { creador = value;  }
}



public virtual bool Cancelada {
        get { return cancelada; } set { cancelada = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.PistaEN Pista {
        get { return pista; } set { pista = value;  }
}



public virtual bool Espartido {
        get { return espartido; } set { espartido = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Usuarios {
        get { return usuarios; } set { usuarios = value;  }
}



public virtual int Maxparticipantes {
        get { return maxparticipantes; } set { maxparticipantes = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> Pagos {
        get { return pagos; } set { pagos = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Horario {
        get { return horario; } set { horario = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual Nullable<DateTime> Fechapago {
        get { return fechapago; } set { fechapago = value;  }
}





public ReservaEN()
{
        usuarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
        pagos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PagoEN>();
        horario = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
}



public ReservaEN(int idreserva, string nombre, string apellidos, string email, string telefono, TFMGen.ApplicationCore.EN.TFM.UsuarioEN creador, bool cancelada, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, bool espartido, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, int maxparticipantes, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> pagos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horario, Nullable<DateTime> fecha, Nullable<DateTime> fechapago
                 )
{
        this.init (Idreserva, nombre, apellidos, email, telefono, creador, cancelada, pista, espartido, usuarios, maxparticipantes, pagos, horario, fecha, fechapago);
}


public ReservaEN(ReservaEN reserva)
{
        this.init (Idreserva, reserva.Nombre, reserva.Apellidos, reserva.Email, reserva.Telefono, reserva.Creador, reserva.Cancelada, reserva.Pista, reserva.Espartido, reserva.Usuarios, reserva.Maxparticipantes, reserva.Pagos, reserva.Horario, reserva.Fecha, reserva.Fechapago);
}

private void init (int idreserva
                   , string nombre, string apellidos, string email, string telefono, TFMGen.ApplicationCore.EN.TFM.UsuarioEN creador, bool cancelada, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, bool espartido, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuarios, int maxparticipantes, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> pagos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horario, Nullable<DateTime> fecha, Nullable<DateTime> fechapago)
{
        this.Idreserva = idreserva;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Email = email;

        this.Telefono = telefono;

        this.Creador = creador;

        this.Cancelada = cancelada;

        this.Pista = pista;

        this.Espartido = espartido;

        this.Usuarios = usuarios;

        this.Maxparticipantes = maxparticipantes;

        this.Pagos = pagos;

        this.Horario = horario;

        this.Fecha = fecha;

        this.Fechapago = fechapago;
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
