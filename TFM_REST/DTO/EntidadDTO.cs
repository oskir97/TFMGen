using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class EntidadDTO
{
private int identidad;
public int Identidad {
        get { return identidad; } set { identidad = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private string email;
public string Email {
        get { return email; } set { email = value;  }
}
private string telefono;
public string Telefono {
        get { return telefono; } set { telefono = value;  }
}
private string domicilio;
public string Domicilio {
        get { return domicilio; } set { domicilio = value;  }
}
private Nullable<DateTime> alta;
public Nullable<DateTime> Alta {
        get { return alta; } set { alta = value;  }
}
private Nullable<DateTime> baja;
public Nullable<DateTime> Baja {
        get { return baja; } set { baja = value;  }
}
private string cifnif;
public string Cifnif {
        get { return cifnif; } set { cifnif = value;  }
}
private string telefonoalternativo;
public string Telefonoalternativo {
        get { return telefonoalternativo; } set { telefonoalternativo = value;  }
}
private System.Collections.Generic.IList<PistaDTO> pistas;
public System.Collections.Generic.IList<PistaDTO> Pistas {
        get { return pistas; } set { pistas = value;  }
}


private System.Collections.Generic.IList<int> notificaciones_oid;
public System.Collections.Generic.IList<int> Notificaciones_oid {
        get { return notificaciones_oid; } set { notificaciones_oid = value;  }
}

private System.Collections.Generic.IList<InstalacionDTO> instalaciones;
public System.Collections.Generic.IList<InstalacionDTO> Instalaciones {
        get { return instalaciones; } set { instalaciones = value;  }
}


private System.Collections.Generic.IList<int> valoracionesAEntidades_oid;
public System.Collections.Generic.IList<int> ValoracionesAEntidades_oid {
        get { return valoracionesAEntidades_oid; } set { valoracionesAEntidades_oid = value;  }
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
private string imagen;
public string Imagen {
        get { return imagen; } set { imagen = value;  }
}
private string configuracion;
public string Configuracion {
        get { return configuracion; } set { configuracion = value;  }
}
private System.Collections.Generic.IList<EventoDTO> eventos;
public System.Collections.Generic.IList<EventoDTO> Eventos {
        get { return eventos; } set { eventos = value;  }
}


private System.Collections.Generic.IList<int> usuarios_oid;
public System.Collections.Generic.IList<int> Usuarios_oid {
        get { return usuarios_oid; } set { usuarios_oid = value;  }
}
}
}
