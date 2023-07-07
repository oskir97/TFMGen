
using System;
// Definición clase ValoracionEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class ValoracionEN
{
/**
 *	Atributo idvaloracion
 */
private int idvaloracion;



/**
 *	Atributo estrellas
 */
private int estrellas;



/**
 *	Atributo comentario
 */
private string comentario;



/**
 *	Atributo usuario
 */
private TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario;



/**
 *	Atributo entidad
 */
private TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad;



/**
 *	Atributo instalacion
 */
private TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion;



/**
 *	Atributo pista
 */
private TFMGen.ApplicationCore.EN.TFM.PistaEN pista;



/**
 *	Atributo tecnico
 */
private TFMGen.ApplicationCore.EN.TFM.UsuarioEN tecnico;



/**
 *	Atributo evento
 */
private TFMGen.ApplicationCore.EN.TFM.EventoEN evento;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo usuariopartido
 */
private TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuariopartido;






public virtual int Idvaloracion {
        get { return idvaloracion; } set { idvaloracion = value;  }
}



public virtual int Estrellas {
        get { return estrellas; } set { estrellas = value;  }
}



public virtual string Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.EntidadEN Entidad {
        get { return entidad; } set { entidad = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.InstalacionEN Instalacion {
        get { return instalacion; } set { instalacion = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.PistaEN Pista {
        get { return pista; } set { pista = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.UsuarioEN Tecnico {
        get { return tecnico; } set { tecnico = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.UsuarioEN Usuariopartido {
        get { return usuariopartido; } set { usuariopartido = value;  }
}





public ValoracionEN()
{
}



public ValoracionEN(int idvaloracion, int estrellas, string comentario, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, TFMGen.ApplicationCore.EN.TFM.UsuarioEN tecnico, TFMGen.ApplicationCore.EN.TFM.EventoEN evento, Nullable<DateTime> fecha, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuariopartido
                    )
{
        this.init (Idvaloracion, estrellas, comentario, usuario, entidad, instalacion, pista, tecnico, evento, fecha, usuariopartido);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Idvaloracion, valoracion.Estrellas, valoracion.Comentario, valoracion.Usuario, valoracion.Entidad, valoracion.Instalacion, valoracion.Pista, valoracion.Tecnico, valoracion.Evento, valoracion.Fecha, valoracion.Usuariopartido);
}

private void init (int idvaloracion
                   , int estrellas, string comentario, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, TFMGen.ApplicationCore.EN.TFM.UsuarioEN tecnico, TFMGen.ApplicationCore.EN.TFM.EventoEN evento, Nullable<DateTime> fecha, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuariopartido)
{
        this.Idvaloracion = idvaloracion;


        this.Estrellas = estrellas;

        this.Comentario = comentario;

        this.Usuario = usuario;

        this.Entidad = entidad;

        this.Instalacion = instalacion;

        this.Pista = pista;

        this.Tecnico = tecnico;

        this.Evento = evento;

        this.Fecha = fecha;

        this.Usuariopartido = usuariopartido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionEN t = obj as ValoracionEN;
        if (t == null)
                return false;
        if (Idvaloracion.Equals (t.Idvaloracion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idvaloracion.GetHashCode ();
        return hash;
}
}
}
