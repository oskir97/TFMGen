using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class NotificacionDTO
{
private int receptor_oid;
public int Receptor_oid {
        get { return receptor_oid; } set { receptor_oid = value;  }
}

private int idnotificacion;
public int Idnotificacion {
        get { return idnotificacion; } set { idnotificacion = value;  }
}
private string asunto;
public string Asunto {
        get { return asunto; } set { asunto = value;  }
}
private string descripcion;
public string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}
private bool leida;
public bool Leida {
        get { return leida; } set { leida = value;  }
}


private int emisor_oid;
public int Emisor_oid {
        get { return emisor_oid; } set { emisor_oid = value;  }
}



private int entidad_oid;
public int Entidad_oid {
        get { return entidad_oid; } set { entidad_oid = value;  }
}

private TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum tipo;
public TFMGen.ApplicationCore.Enumerated.TFM.TipoNotificacionEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}


private int evento_oid;
public int Evento_oid {
        get { return evento_oid; } set { evento_oid = value;  }
}



private int reserva_oid;
public int Reserva_oid {
        get { return reserva_oid; } set { reserva_oid = value;  }
}
}
}
