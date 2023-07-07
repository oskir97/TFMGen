using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class UsuarioDTO
{
private int idusuario;
public int Idusuario {
        get { return idusuario; } set { idusuario = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private string email;
public string Email {
        get { return email; } set { email = value;  }
}
private string domicilio;
public string Domicilio {
        get { return domicilio; } set { domicilio = value;  }
}
private string telefono;
public string Telefono {
        get { return telefono; } set { telefono = value;  }
}
private string telefonoalternativo;
public string Telefonoalternativo {
        get { return telefonoalternativo; } set { telefonoalternativo = value;  }
}
private Nullable<DateTime> fechanacimiento;
public Nullable<DateTime> Fechanacimiento {
        get { return fechanacimiento; } set { fechanacimiento = value;  }
}
private Nullable<DateTime> alta;
public Nullable<DateTime> Alta {
        get { return alta; } set { alta = value;  }
}
private Nullable<DateTime> baja;
public Nullable<DateTime> Baja {
        get { return baja; } set { baja = value;  }
}
private string ubicacionactual;
public string Ubicacionactual {
        get { return ubicacionactual; } set { ubicacionactual = value;  }
}
private string apellidos;
public string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}
private String password;
public String Password {
        get { return password; } set { password = value;  }
}


private System.Collections.Generic.IList<int> reservas_oid;
public System.Collections.Generic.IList<int> Reservas_oid {
        get { return reservas_oid; } set { reservas_oid = value;  }
}

private System.Collections.Generic.IList<AsitenciaDTO> asitencias;
public System.Collections.Generic.IList<AsitenciaDTO> Asitencias {
        get { return asitencias; } set { asitencias = value;  }
}


private System.Collections.Generic.IList<int> notificacionesRecibidas_oid;
public System.Collections.Generic.IList<int> NotificacionesRecibidas_oid {
        get { return notificacionesRecibidas_oid; } set { notificacionesRecibidas_oid = value;  }
}



private int rol_oid;
public int Rol_oid {
        get { return rol_oid; } set { rol_oid = value;  }
}



private System.Collections.Generic.IList<int> notificacionesEnviadas_oid;
public System.Collections.Generic.IList<int> NotificacionesEnviadas_oid {
        get { return notificacionesEnviadas_oid; } set { notificacionesEnviadas_oid = value;  }
}



private System.Collections.Generic.IList<int> valoracionesUsuario_oid;
public System.Collections.Generic.IList<int> ValoracionesUsuario_oid {
        get { return valoracionesUsuario_oid; } set { valoracionesUsuario_oid = value;  }
}



private System.Collections.Generic.IList<int> valoracionesAInstructores_oid;
public System.Collections.Generic.IList<int> ValoracionesAInstructores_oid {
        get { return valoracionesAInstructores_oid; } set { valoracionesAInstructores_oid = value;  }
}

private string codigopostal;
public string Codigopostal {
        get { return codigopostal; } set { codigopostal = value;  }
}
private string localidad;
public string Localidad {
        get { return localidad; } set { localidad = value;  }
}
private string provincia;
public string Provincia {
        get { return provincia; } set { provincia = value;  }
}


private System.Collections.Generic.IList<int> eventos_oid;
public System.Collections.Generic.IList<int> Eventos_oid {
        get { return eventos_oid; } set { eventos_oid = value;  }
}



private System.Collections.Generic.IList<int> eventosImpartidos_oid;
public System.Collections.Generic.IList<int> EventosImpartidos_oid {
        get { return eventosImpartidos_oid; } set { eventosImpartidos_oid = value;  }
}



private System.Collections.Generic.IList<int> incidencia_oid;
public System.Collections.Generic.IList<int> Incidencia_oid {
        get { return incidencia_oid; } set { incidencia_oid = value;  }
}



private int entidad_oid;
public int Entidad_oid {
        get { return entidad_oid; } set { entidad_oid = value;  }
}

private string numero;
public string Numero {
        get { return numero; } set { numero = value;  }
}


private System.Collections.Generic.IList<int> instalacion_oid;
public System.Collections.Generic.IList<int> Instalacion_oid {
        get { return instalacion_oid; } set { instalacion_oid = value;  }
}

private string imagen;
public string Imagen {
        get { return imagen; } set { imagen = value;  }
}


private System.Collections.Generic.IList<int> valoracionesAUsuarioPartido_oid;
public System.Collections.Generic.IList<int> ValoracionesAUsuarioPartido_oid {
        get { return valoracionesAUsuarioPartido_oid; } set { valoracionesAUsuarioPartido_oid = value;  }
}
}
}
