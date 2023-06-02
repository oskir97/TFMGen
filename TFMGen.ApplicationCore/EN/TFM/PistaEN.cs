
using System;
// Definición clase PistaEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class PistaEN
{
/**
 *	Atributo idpista
 */
private int idpista;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo ubicacion
 */
private string ubicacion;



/**
 *	Atributo imagen
 */
private string imagen;



/**
 *	Atributo maxreservas
 */
private int maxreservas;



/**
 *	Atributo reservasCreadas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservasCreadas;



/**
 *	Atributo entidad
 */
private TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad;



/**
 *	Atributo instalacion
 */
private TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion;



/**
 *	Atributo estadosPista
 */
private TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN estadosPista;



/**
 *	Atributo valoracionesAPistas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAPistas;



/**
 *	Atributo horarios
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horarios;



/**
 *	Atributo deporte
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DeporteEN> deporte;



/**
 *	Atributo visible
 */
private bool visible;



/**
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo latitud
 */
private double latitud;



/**
 *	Atributo longitud
 */
private double longitud;






public virtual int Idpista {
        get { return idpista; } set { idpista = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Ubicacion {
        get { return ubicacion; } set { ubicacion = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}



public virtual int Maxreservas {
        get { return maxreservas; } set { maxreservas = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> ReservasCreadas {
        get { return reservasCreadas; } set { reservasCreadas = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.EntidadEN Entidad {
        get { return entidad; } set { entidad = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.InstalacionEN Instalacion {
        get { return instalacion; } set { instalacion = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN EstadosPista {
        get { return estadosPista; } set { estadosPista = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> ValoracionesAPistas {
        get { return valoracionesAPistas; } set { valoracionesAPistas = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Horarios {
        get { return horarios; } set { horarios = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DeporteEN> Deporte {
        get { return deporte; } set { deporte = value;  }
}



public virtual bool Visible {
        get { return visible; } set { visible = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual double Latitud {
        get { return latitud; } set { latitud = value;  }
}



public virtual double Longitud {
        get { return longitud; } set { longitud = value;  }
}





public PistaEN()
{
        reservasCreadas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
        valoracionesAPistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
        horarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
        deporte = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DeporteEN>();
}



public PistaEN(int idpista, string nombre, string ubicacion, string imagen, int maxreservas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservasCreadas, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN estadosPista, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAPistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DeporteEN> deporte, bool visible, double precio, double latitud, double longitud
               )
{
        this.init (Idpista, nombre, ubicacion, imagen, maxreservas, reservasCreadas, entidad, instalacion, estadosPista, valoracionesAPistas, horarios, deporte, visible, precio, latitud, longitud);
}


public PistaEN(PistaEN pista)
{
        this.init (Idpista, pista.Nombre, pista.Ubicacion, pista.Imagen, pista.Maxreservas, pista.ReservasCreadas, pista.Entidad, pista.Instalacion, pista.EstadosPista, pista.ValoracionesAPistas, pista.Horarios, pista.Deporte, pista.Visible, pista.Precio, pista.Latitud, pista.Longitud);
}

private void init (int idpista
                   , string nombre, string ubicacion, string imagen, int maxreservas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservasCreadas, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacion, TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN estadosPista, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAPistas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> horarios, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DeporteEN> deporte, bool visible, double precio, double latitud, double longitud)
{
        this.Idpista = idpista;


        this.Nombre = nombre;

        this.Ubicacion = ubicacion;

        this.Imagen = imagen;

        this.Maxreservas = maxreservas;

        this.ReservasCreadas = reservasCreadas;

        this.Entidad = entidad;

        this.Instalacion = instalacion;

        this.EstadosPista = estadosPista;

        this.ValoracionesAPistas = valoracionesAPistas;

        this.Horarios = horarios;

        this.Deporte = deporte;

        this.Visible = visible;

        this.Precio = precio;

        this.Latitud = latitud;

        this.Longitud = longitud;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PistaEN t = obj as PistaEN;
        if (t == null)
                return false;
        if (Idpista.Equals (t.Idpista))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idpista.GetHashCode ();
        return hash;
}
}
}
