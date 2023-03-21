using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class IncidenciaDTO
{
private int idincidencia;
public int Idincidencia {
        get { return idincidencia; } set { idincidencia = value;  }
}


private int usuario_oid;
public int Usuario_oid {
        get { return usuario_oid; } set { usuario_oid = value;  }
}



private int evento_oid;
public int Evento_oid {
        get { return evento_oid; } set { evento_oid = value;  }
}

private string asunto;
public string Asunto {
        get { return asunto; } set { asunto = value;  }
}
private string descripcion;
public string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}
private Nullable<DateTime> fechacancelada;
public Nullable<DateTime> Fechacancelada {
        get { return fechacancelada; } set { fechacancelada = value;  }
}
private Nullable<DateTime> fechareemplazada;
public Nullable<DateTime> Fechareemplazada {
        get { return fechareemplazada; } set { fechareemplazada = value;  }
}
}
}
