
using System;
// Definición clase UsuarioEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class UsuarioEN
{
/**
 *	Atributo idusuario
 */
private int idusuario;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo domicilio
 */
private string domicilio;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo telefonoalternativo
 */
private string telefonoalternativo;



/**
 *	Atributo fechanacimiento
 */
private Nullable<DateTime> fechanacimiento;



/**
 *	Atributo alta
 */
private Nullable<DateTime> alta;



/**
 *	Atributo baja
 */
private Nullable<DateTime> baja;



/**
 *	Atributo ubicacionactual
 */
private string ubicacionactual;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo password
 */
private String password;



/**
 *	Atributo reservas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservas;



/**
 *	Atributo asitencias
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> asitencias;



/**
 *	Atributo notificacionesRecibidas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificacionesRecibidas;



/**
 *	Atributo rol
 */
private TFMGen.ApplicationCore.EN.TFM.RolEN rol;



/**
 *	Atributo notificacionesEnviadas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificacionesEnviadas;



/**
 *	Atributo valoracionesUsuario
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesUsuario;



/**
 *	Atributo valoracionesAInstructores
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAInstructores;



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
 *	Atributo eventos
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos;



/**
 *	Atributo eventosImpartidos
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventosImpartidos;



/**
 *	Atributo incidencia
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> incidencia;



/**
 *	Atributo entidad
 */
private TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad;



/**
 *	Atributo numero
 */
private string numero;



/**
 *	Atributo instalacion
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> instalacion;



/**
 *	Atributo imagen
 */
private string imagen;



/**
 *	Atributo valoracionesAUsuarioPartido
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAUsuarioPartido;






public virtual int Idusuario {
        get { return idusuario; } set { idusuario = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Domicilio {
        get { return domicilio; } set { domicilio = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual string Telefonoalternativo {
        get { return telefonoalternativo; } set { telefonoalternativo = value;  }
}



public virtual Nullable<DateTime> Fechanacimiento {
        get { return fechanacimiento; } set { fechanacimiento = value;  }
}



public virtual Nullable<DateTime> Alta {
        get { return alta; } set { alta = value;  }
}



public virtual Nullable<DateTime> Baja {
        get { return baja; } set { baja = value;  }
}



public virtual string Ubicacionactual {
        get { return ubicacionactual; } set { ubicacionactual = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Reservas {
        get { return reservas; } set { reservas = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> Asitencias {
        get { return asitencias; } set { asitencias = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> NotificacionesRecibidas {
        get { return notificacionesRecibidas; } set { notificacionesRecibidas = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.RolEN Rol {
        get { return rol; } set { rol = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> NotificacionesEnviadas {
        get { return notificacionesEnviadas; } set { notificacionesEnviadas = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> ValoracionesUsuario {
        get { return valoracionesUsuario; } set { valoracionesUsuario = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> ValoracionesAInstructores {
        get { return valoracionesAInstructores; } set { valoracionesAInstructores = value;  }
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



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Eventos {
        get { return eventos; } set { eventos = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> EventosImpartidos {
        get { return eventosImpartidos; } set { eventosImpartidos = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> Incidencia {
        get { return incidencia; } set { incidencia = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.EntidadEN Entidad {
        get { return entidad; } set { entidad = value;  }
}



public virtual string Numero {
        get { return numero; } set { numero = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> Instalacion {
        get { return instalacion; } set { instalacion = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> ValoracionesAUsuarioPartido {
        get { return valoracionesAUsuarioPartido; } set { valoracionesAUsuarioPartido = value;  }
}





public UsuarioEN()
{
        reservas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
        asitencias = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN>();
        notificacionesRecibidas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
        notificacionesEnviadas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
        valoracionesUsuario = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
        valoracionesAInstructores = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
        eventos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
        eventosImpartidos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
        incidencia = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN>();
        instalacion = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.InstalacionEN>();
        valoracionesAUsuarioPartido = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
}



public UsuarioEN(int idusuario, string nombre, string email, string domicilio, string telefono, string telefonoalternativo, Nullable<DateTime> fechanacimiento, Nullable<DateTime> alta, Nullable<DateTime> baja, string ubicacionactual, string apellidos, String password, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> asitencias, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificacionesRecibidas, TFMGen.ApplicationCore.EN.TFM.RolEN rol, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificacionesEnviadas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesUsuario, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAInstructores, string codigopostal, string localidad, string provincia, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventosImpartidos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> incidencia, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, string numero, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> instalacion, string imagen, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAUsuarioPartido
                 )
{
        this.init (Idusuario, nombre, email, domicilio, telefono, telefonoalternativo, fechanacimiento, alta, baja, ubicacionactual, apellidos, password, reservas, asitencias, notificacionesRecibidas, rol, notificacionesEnviadas, valoracionesUsuario, valoracionesAInstructores, codigopostal, localidad, provincia, eventos, eventosImpartidos, incidencia, entidad, numero, instalacion, imagen, valoracionesAUsuarioPartido);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Idusuario, usuario.Nombre, usuario.Email, usuario.Domicilio, usuario.Telefono, usuario.Telefonoalternativo, usuario.Fechanacimiento, usuario.Alta, usuario.Baja, usuario.Ubicacionactual, usuario.Apellidos, usuario.Password, usuario.Reservas, usuario.Asitencias, usuario.NotificacionesRecibidas, usuario.Rol, usuario.NotificacionesEnviadas, usuario.ValoracionesUsuario, usuario.ValoracionesAInstructores, usuario.Codigopostal, usuario.Localidad, usuario.Provincia, usuario.Eventos, usuario.EventosImpartidos, usuario.Incidencia, usuario.Entidad, usuario.Numero, usuario.Instalacion, usuario.Imagen, usuario.ValoracionesAUsuarioPartido);
}

private void init (int idusuario
                   , string nombre, string email, string domicilio, string telefono, string telefonoalternativo, Nullable<DateTime> fechanacimiento, Nullable<DateTime> alta, Nullable<DateTime> baja, string ubicacionactual, string apellidos, String password, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> asitencias, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificacionesRecibidas, TFMGen.ApplicationCore.EN.TFM.RolEN rol, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> notificacionesEnviadas, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesUsuario, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAInstructores, string codigopostal, string localidad, string provincia, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> eventosImpartidos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> incidencia, TFMGen.ApplicationCore.EN.TFM.EntidadEN entidad, string numero, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> instalacion, string imagen, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> valoracionesAUsuarioPartido)
{
        this.Idusuario = idusuario;


        this.Nombre = nombre;

        this.Email = email;

        this.Domicilio = domicilio;

        this.Telefono = telefono;

        this.Telefonoalternativo = telefonoalternativo;

        this.Fechanacimiento = fechanacimiento;

        this.Alta = alta;

        this.Baja = baja;

        this.Ubicacionactual = ubicacionactual;

        this.Apellidos = apellidos;

        this.Password = password;

        this.Reservas = reservas;

        this.Asitencias = asitencias;

        this.NotificacionesRecibidas = notificacionesRecibidas;

        this.Rol = rol;

        this.NotificacionesEnviadas = notificacionesEnviadas;

        this.ValoracionesUsuario = valoracionesUsuario;

        this.ValoracionesAInstructores = valoracionesAInstructores;

        this.Codigopostal = codigopostal;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Eventos = eventos;

        this.EventosImpartidos = eventosImpartidos;

        this.Incidencia = incidencia;

        this.Entidad = entidad;

        this.Numero = numero;

        this.Instalacion = instalacion;

        this.Imagen = imagen;

        this.ValoracionesAUsuarioPartido = valoracionesAUsuarioPartido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Idusuario.Equals (t.Idusuario))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idusuario.GetHashCode ();
        return hash;
}
}
}
