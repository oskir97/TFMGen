using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class EventoDTO
{
private int idevento;
public int Idevento {
        get { return idevento; } set { idevento = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private string descripcion;
public string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


private System.Collections.Generic.IList<int> notificaciones_oid;
public System.Collections.Generic.IList<int> Notificaciones_oid {
        get { return notificaciones_oid; } set { notificaciones_oid = value;  }
}



private int entidad_oid;
public int Entidad_oid {
        get { return entidad_oid; } set { entidad_oid = value;  }
}



private System.Collections.Generic.IList<int> asitencias_oid;
public System.Collections.Generic.IList<int> Asitencias_oid {
        get { return asitencias_oid; } set { asitencias_oid = value;  }
}



private System.Collections.Generic.IList<int> usuarios_oid;
public System.Collections.Generic.IList<int> Usuarios_oid {
        get { return usuarios_oid; } set { usuarios_oid = value;  }
}



private System.Collections.Generic.IList<int> tecnicos_oid;
public System.Collections.Generic.IList<int> Tecnicos_oid {
        get { return tecnicos_oid; } set { tecnicos_oid = value;  }
}



private System.Collections.Generic.IList<int> horarios_oid;
public System.Collections.Generic.IList<int> Horarios_oid {
        get { return horarios_oid; } set { horarios_oid = value;  }
}



private System.Collections.Generic.IList<int> incidencia_oid;
public System.Collections.Generic.IList<int> Incidencia_oid {
        get { return incidencia_oid; } set { incidencia_oid = value;  }
}



private System.Collections.Generic.IList<int> diasSemana_oid;
public System.Collections.Generic.IList<int> DiasSemana_oid {
        get { return diasSemana_oid; } set { diasSemana_oid = value;  }
}

private bool activo;
public bool Activo {
        get { return activo; } set { activo = value;  }
}
private int plazas;
public int Plazas {
        get { return plazas; } set { plazas = value;  }
}


private int deporte_oid;
public int Deporte_oid {
        get { return deporte_oid; } set { deporte_oid = value;  }
}

private Nullable<DateTime> inicio;
public Nullable<DateTime> Inicio {
        get { return inicio; } set { inicio = value;  }
}
private Nullable<DateTime> fin;
public Nullable<DateTime> Fin {
        get { return fin; } set { fin = value;  }
}


private System.Collections.Generic.IList<int> reservas_oid;
public System.Collections.Generic.IList<int> Reservas_oid {
        get { return reservas_oid; } set { reservas_oid = value;  }
}



private int instalacion_oid;
public int Instalacion_oid {
        get { return instalacion_oid; } set { instalacion_oid = value;  }
}

private double precio;
public double Precio {
        get { return precio; } set { precio = value;  }
}


private System.Collections.Generic.IList<int> valoraciones_oid;
public System.Collections.Generic.IList<int> Valoraciones_oid {
        get { return valoraciones_oid; } set { valoraciones_oid = value;  }
}
}
}
