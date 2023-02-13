
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





public ValoracionEN()
{
}



public ValoracionEN(int idvaloracion, int estrellas, string comentario, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, TFMGen.ApplicationCore.EN.TFM.UsuarioEN tecnico
                    )
{
        this.init (Idvaloracion, estrellas, comentario, usuario, entidad, instalacion, pista, tecnico);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Idvaloracion, valoracion.Estrellas, valoracion.Comentario, valoracion.Usuario, valoracion.Entidad, valoracion.Instalacion, valoracion.Pista, valoracion.Tecnico);
}

private void init (int idvaloracion
                   , int estrellas, string comentario, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, TFMGen.ApplicationCore.EN.TFM.PistaEN pista, TFMGen.ApplicationCore.EN.TFM.UsuarioEN tecnico)
{
        this.Idvaloracion = idvaloracion;


        this.Estrellas = estrellas;

        this.Comentario = comentario;

        this.Usuario = usuario;

        this.Entidad = entidad;

        this.Instalacion = instalacion;

        this.Pista = pista;

        this.Tecnico = tecnico;
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
