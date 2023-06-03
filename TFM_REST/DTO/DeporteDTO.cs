using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class DeporteDTO
{
private int iddeporte;
public int Iddeporte {
        get { return iddeporte; } set { iddeporte = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private string descripcion;
public string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


private System.Collections.Generic.IList<int> pistas_oid;
public System.Collections.Generic.IList<int> Pistas_oid {
        get { return pistas_oid; } set { pistas_oid = value;  }
}

private System.Collections.Generic.IList<Deporte_l10nDTO> deporte_l10n;
public System.Collections.Generic.IList<Deporte_l10nDTO> Deporte_l10n {
        get { return deporte_l10n; } set { deporte_l10n = value;  }
}
private string icono;
public string Icono {
        get { return icono; } set { icono = value;  }
}


private System.Collections.Generic.IList<int> eventos_oid;
public System.Collections.Generic.IList<int> Eventos_oid {
        get { return eventos_oid; } set { eventos_oid = value;  }
}
}
}
