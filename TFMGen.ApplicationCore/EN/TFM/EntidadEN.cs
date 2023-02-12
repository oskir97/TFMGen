
using System;
// Definición clase EntidadEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class EntidadEN
{
/**
 *	Atributo identidad
 */
private int identidad;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo domicilio
 */
private string domicilio;



/**
 *	Atributo alta
 */
private Nullable<DateTime> alta;



/**
 *	Atributo baja
 */
private Nullable<DateTime> baja;



/**
 *	Atributo cifnif
 */
private string cifnif;



/**
 *	Atributo telefonoalternativo
 */
private string telefonoalternativo;



/**
 *	Atributo pistas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas;



/**
 *	Atributo notificaciones
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificaciones;



/**
 *	Atributo instalaciones
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> instalaciones;



/**
 *	Atributo valoracionesAEntidades
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAEntidades;



/**
 *	Atributo codigopostal
 */
private string codigopostal;



/**
 *	Atributo localidad
 */
private string localidad;



/**
 *	Atributo provincia
 */
private string provincia;



/**
 *	Atributo imagen
 */
private string imagen;






public virtual int Identidad {
        get { return identidad; } set { identidad = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual string Domicilio {
        get { return domicilio; } set { domicilio = value;  }
}



public virtual Nullable<DateTime> Alta {
        get { return alta; } set { alta = value;  }
}



public virtual Nullable<DateTime> Baja {
        get { return baja; } set { baja = value;  }
}



public virtual string Cifnif {
        get { return cifnif; } set { cifnif = value;  }
}



public virtual string Telefonoalternativo {
        get { return telefonoalternativo; } set { telefonoalternativo = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Pistas {
        get { return pistas; } set { pistas = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> Notificaciones {
        get { return notificaciones; } set { notificaciones = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> Instalaciones {
        get { return instalaciones; } set { instalaciones = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> ValoracionesAEntidades {
        get { return valoracionesAEntidades; } set { valoracionesAEntidades = value;  }
}



public virtual string Codigopostal {
        get { return codigopostal; } set { codigopostal = value;  }
}



public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}



public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}





public EntidadEN()
{
        pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
        notificaciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
        instalaciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.InstalacionEN>();
        valoracionesAEntidades = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
}



public EntidadEN(int identidad, string nombre, string email, string telefono, string domicilio, Nullable<DateTime> alta, Nullable<DateTime> baja, string cifnif, string telefonoalternativo, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificaciones, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> instalaciones, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAEntidades, string codigopostal, string localidad, string provincia, string imagen
                 )
{
        this.init (Identidad, nombre, email, telefono, domicilio, alta, baja, cifnif, telefonoalternativo, pistas, notificaciones, instalaciones, valoracionesAEntidades, codigopostal, localidad, provincia, imagen);
}


public EntidadEN(EntidadEN entidad)
{
        this.init (Identidad, entidad.Nombre, entidad.Email, entidad.Telefono, entidad.Domicilio, entidad.Alta, entidad.Baja, entidad.Cifnif, entidad.Telefonoalternativo, entidad.Pistas, entidad.Notificaciones, entidad.Instalaciones, entidad.ValoracionesAEntidades, entidad.Codigopostal, entidad.Localidad, entidad.Provincia, entidad.Imagen);
}

private void init (int identidad
                   , string nombre, string email, string telefono, string domicilio, Nullable<DateTime> alta, Nullable<DateTime> baja, string cifnif, string telefonoalternativo, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificaciones, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> instalaciones, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAEntidades, string codigopostal, string localidad, string provincia, string imagen)
{
        this.Identidad = identidad;


        this.Nombre = nombre;

        this.Email = email;

        this.Telefono = telefono;

        this.Domicilio = domicilio;

        this.Alta = alta;

        this.Baja = baja;

        this.Cifnif = cifnif;

        this.Telefonoalternativo = telefonoalternativo;

        this.Pistas = pistas;

        this.Notificaciones = notificaciones;

        this.Instalaciones = instalaciones;

        this.ValoracionesAEntidades = valoracionesAEntidades;

        this.Codigopostal = codigopostal;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Imagen = imagen;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EntidadEN t = obj as EntidadEN;
        if (t == null)
                return false;
        if (Identidad.Equals (t.Identidad))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Identidad.GetHashCode ();
        return hash;
}
}
}