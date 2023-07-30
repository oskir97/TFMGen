using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class ReservaDTO
{
private int idreserva;
public int Idreserva {
        get { return idreserva; } set { idreserva = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private string apellidos;
public string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}
private string email;
public string Email {
        get { return email; } set { email = value;  }
}
private string telefono;
public string Telefono {
        get { return telefono; } set { telefono = value;  }
}


private int usuario_oid;
public int Usuario_oid {
        get { return usuario_oid; } set { usuario_oid = value;  }
}

private bool cancelada;
public bool Cancelada {
        get { return cancelada; } set { cancelada = value;  }
}


private int pista_oid;
public int Pista_oid {
        get { return pista_oid; } set { pista_oid = value;  }
}

private int maxparticipantes;
public int Maxparticipantes {
        get { return maxparticipantes; } set { maxparticipantes = value;  }
}


private int pago_oid;
public int Pago_oid {
        get { return pago_oid; } set { pago_oid = value;  }
}



private int horario_oid;
public int Horario_oid {
        get { return horario_oid; } set { horario_oid = value;  }
}

private Nullable<DateTime> fecha;
public Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}
private System.Collections.Generic.IList<ReservaDTO> inscripciones;
public System.Collections.Generic.IList<ReservaDTO> Inscripciones {
        get { return inscripciones; } set { inscripciones = value;  }
}


private int partido_oid;
public int Partido_oid {
        get { return partido_oid; } set { partido_oid = value;  }
}

private TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum tipo;
public TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}


private System.Collections.Generic.IList<int> notificacion_oid;
public System.Collections.Generic.IList<int> Notificacion_oid {
        get { return notificacion_oid; } set { notificacion_oid = value;  }
}

private Nullable<DateTime> fechaCreacion;
public Nullable<DateTime> FechaCreacion {
        get { return fechaCreacion; } set { fechaCreacion = value;  }
}
private Nullable<DateTime> fechaCancelada;
public Nullable<DateTime> FechaCancelada {
        get { return fechaCancelada; } set { fechaCancelada = value;  }
}


private int deporte_oid;
public int Deporte_oid {
        get { return deporte_oid; } set { deporte_oid = value;  }
}



private int evento_oid;
public int Evento_oid {
        get { return evento_oid; } set { evento_oid = value;  }
}

private TFMGen.ApplicationCore.Enumerated.TFM.NivelPartidoEnum nivelpartido;
public TFMGen.ApplicationCore.Enumerated.TFM.NivelPartidoEnum Nivelpartido {
        get { return nivelpartido; } set { nivelpartido = value;  }
}
private string descripcionpartido;
public string Descripcionpartido {
        get { return descripcionpartido; } set { descripcionpartido = value;  }
}
private string imagen;
public string Imagen {
        get { return imagen; } set { imagen = value;  }
}
}
}
