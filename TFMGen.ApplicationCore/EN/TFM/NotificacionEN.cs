
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





public NotificacionEN()
{
}



public NotificacionEN(int idnotificacion, TFMGen.ApplicationCore.EN.TFM.UsuarioEN receptor, string asunto, string descripcion, bool leida, TFMGen.ApplicationCore.EN.TFM.UsuarioEN emisor, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum tipo
                      )
{
        this.init (Idnotificacion, receptor, asunto, descripcion, leida, emisor, entidad, tipo);
}


public NotificacionEN(NotificacionEN notificacion)
{
        this.init (Idnotificacion, notificacion.Receptor, notificacion.Asunto, notificacion.Descripcion, notificacion.Leida, notificacion.Emisor, notificacion.Entidad, notificacion.Tipo);
}

private void init (int idnotificacion
                   , TFMGen.ApplicationCore.EN.TFM.UsuarioEN receptor, string asunto, string descripcion, bool leida, TFMGen.ApplicationCore.EN.TFM.UsuarioEN emisor, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum tipo)
{
        this.Idnotificacion = idnotificacion;


        this.Receptor = receptor;

        this.Asunto = asunto;

        this.Descripcion = descripcion;

        this.Leida = leida;

        this.Emisor = emisor;

        this.Entidad = entidad;

        this.Tipo = tipo;
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
