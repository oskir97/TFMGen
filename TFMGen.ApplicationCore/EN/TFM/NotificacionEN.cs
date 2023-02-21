
using System;
// Definición clase NotificacionEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class NotificacionEN
{
/**
 *	Atributo receptor
 */
private TFMGen.ApplicationCore.EN.TFM.UsuarioEN receptor;



/**
 *	Atributo idnotificacion
 */
private int idnotificacion;



/**
 *	Atributo asunto
 */
private string asunto;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo leida
 */
private bool leida;



/**
 *	Atributo emisor
 */
private TFMGen.ApplicationCore.EN.TFM.UsuarioEN emisor;



/**
 *	Atributo entidad
 */
private TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad;



/**
 *	Atributo tipo
 */
private TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum tipo;



/**
 *	Atributo evento
 */
private TFMGen.ApplicationCore.EN.TFM.EventoEN evento;



/**
 *	Atributo reserva
 */
private TFMGen.ApplicationCore.EN.TFM.ReservaEN reserva;






public virtual TFMGen.ApplicationCore.EN.TFM.UsuarioEN Receptor {
        get { return receptor; } set { receptor = value;  }
}



public virtual int Idnotificacion {
        get { return idnotificacion; } set { idnotificacion = value;  }
}



public virtual string Asunto {
        get { return asunto; } set { asunto = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual bool Leida {
        get { return leida; } set { leida = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.UsuarioEN Emisor {
        get { return emisor; } set { emisor = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.EntidadEN Entidad {
        get { return entidad; } set { entidad = value;  }
}



public virtual TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.ReservaEN Reserva {
        get { return reserva; } set { reserva = value;  }
}





public NotificacionEN()
{
}



public NotificacionEN(int idnotificacion, TFMGen.ApplicationCore.EN.TFM.UsuarioEN receptor, string asunto, string descripcion, bool leida, TFMGen.ApplicationCore.EN.TFM.UsuarioEN emisor, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum tipo, TFMGen.ApplicationCore.EN.TFM.EventoEN evento, TFMGen.ApplicationCore.EN.TFM.ReservaEN reserva
                      )
{
        this.init (Idnotificacion, receptor, asunto, descripcion, leida, emisor, entidad, tipo, evento, reserva);
}


public NotificacionEN(NotificacionEN notificacion)
{
        this.init (Idnotificacion, notificacion.Receptor, notificacion.Asunto, notificacion.Descripcion, notificacion.Leida, notificacion.Emisor, notificacion.Entidad, notificacion.Tipo, notificacion.Evento, notificacion.Reserva);
}

private void init (int idnotificacion
                   , TFMGen.ApplicationCore.EN.TFM.UsuarioEN receptor, string asunto, string descripcion, bool leida, TFMGen.ApplicationCore.EN.TFM.UsuarioEN emisor, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum tipo, TFMGen.ApplicationCore.EN.TFM.EventoEN evento, TFMGen.ApplicationCore.EN.TFM.ReservaEN reserva)
{
        this.Idnotificacion = idnotificacion;


        this.Receptor = receptor;

        this.Asunto = asunto;

        this.Descripcion = descripcion;

        this.Leida = leida;

        this.Emisor = emisor;

        this.Entidad = entidad;

        this.Tipo = tipo;

        this.Evento = evento;

        this.Reserva = reserva;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NotificacionEN t = obj as NotificacionEN;
        if (t == null)
                return false;
        if (Idnotificacion.Equals (t.Idnotificacion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idnotificacion.GetHashCode ();
        return hash;
}
}
}
