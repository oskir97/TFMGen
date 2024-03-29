using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
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
}
}
