
using System;
// Definición clase InstalacionEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class InstalacionEN
{
/**
 *	Atributo idinstalacion
 */
private int idinstalacion;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo domicilio
 */
private string domicilio;



/**
 *	Atributo ubicacion
 */
private string ubicacion;



/**
 *	Atributo imagen
 */
private string imagen;



/**
 *	Atributo pistas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas;



/**
 *	Atributo materiales
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.MaterialEN> materiales;



/**
 *	Atributo entidad
 */
private TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad;



/**
 *	Atributo valoracionesAInstalaciones
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAInstalaciones;



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
 *	Atributo telefonoalternativo
 */
private string telefonoalternativo;



/**
 *	Atributo visible
 */
private bool visible;



/**
 *	Atributo latitud
 */
private double latitud;



/**
 *	Atributo longitud
 */
private double longitud;



/**
 *	Atributo eventos
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuario;






public virtual int Idinstalacion {
        get { return idinstalacion; } set { idinstalacion = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual string Domicilio {
        get { return domicilio; } set { domicilio = value;  }
}



public virtual string Ubicacion {
        get { return ubicacion; } set { ubicacion = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Pistas {
        get { return pistas; } set { pistas = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.MaterialEN> Materiales {
        get { return materiales; } set { materiales = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.EntidadEN Entidad {
        get { return entidad; } set { entidad = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> ValoracionesAInstalaciones {
        get { return valoracionesAInstalaciones; } set { valoracionesAInstalaciones = value;  }
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



public virtual string Telefonoalternativo {
        get { return telefonoalternativo; } set { telefonoalternativo = value;  }
}



public virtual bool Visible {
        get { return visible; } set { visible = value;  }
}



public virtual double Latitud {
        get { return latitud; } set { latitud = value;  }
}



public virtual double Longitud {
        get { return longitud; } set { longitud = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Eventos {
        get { return eventos; } set { eventos = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}





public InstalacionEN()
{
        pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
        materiales = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.MaterialEN>();
        valoracionesAInstalaciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
        eventos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
        usuario = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
}



public InstalacionEN(int idinstalacion, string nombre, string telefono, string domicilio, string ubicacion, string imagen, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.MaterialEN> materiales, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAInstalaciones, string codigopostal, string localidad, string provincia, string telefonoalternativo, bool visible, double latitud, double longitud, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuario
                     )
{
        this.init (Idinstalacion, nombre, telefono, domicilio, ubicacion, imagen, pistas, materiales, entidad, valoracionesAInstalaciones, codigopostal, localidad, provincia, telefonoalternativo, visible, latitud, longitud, eventos, usuario);
}


public InstalacionEN(InstalacionEN instalacion)
{
        this.init (Idinstalacion, instalacion.Nombre, instalacion.Telefono, instalacion.Domicilio, instalacion.Ubicacion, instalacion.Imagen, instalacion.Pistas, instalacion.Materiales, instalacion.Entidad, instalacion.ValoracionesAInstalaciones, instalacion.Codigopostal, instalacion.Localidad, instalacion.Provincia, instalacion.Telefonoalternativo, instalacion.Visible, instalacion.Latitud, instalacion.Longitud, instalacion.Eventos, instalacion.Usuario);
}

private void init (int idinstalacion
                   , string nombre, string telefono, string domicilio, string ubicacion, string imagen, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> pistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.MaterialEN> materiales, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAInstalaciones, string codigopostal, string localidad, string provincia, string telefonoalternativo, bool visible, double latitud, double longitud, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> usuario)
{
        this.Idinstalacion = idinstalacion;


        this.Nombre = nombre;

        this.Telefono = telefono;

        this.Domicilio = domicilio;

        this.Ubicacion = ubicacion;

        this.Imagen = imagen;

        this.Pistas = pistas;

        this.Materiales = materiales;

        this.Entidad = entidad;

        this.ValoracionesAInstalaciones = valoracionesAInstalaciones;

        this.Codigopostal = codigopostal;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Telefonoalternativo = telefonoalternativo;

        this.Visible = visible;

        this.Latitud = latitud;

        this.Longitud = longitud;

        this.Eventos = eventos;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        InstalacionEN t = obj as InstalacionEN;
        if (t == null)
                return false;
        if (Idinstalacion.Equals (t.Idinstalacion))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idinstalacion.GetHashCode ();
        return hash;
}
}
}
