using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class PistaEstadoDTO
{
private int idestado;
public int Idestado {
        get { return idestado; } set { idestado = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}


private System.Collections.Generic.IList<int> pistas_oid;
public System.Collections.Generic.IList<int> Pistas_oid {
        get { return pistas_oid; } set { pistas_oid = value;  }
}

private System.Collections.Generic.IList<PistaEstado_l10nDTO> estadoPista_l10n;
public System.Collections.Generic.IList<PistaEstado_l10nDTO> EstadoPista_l10n {
        get { return estadoPista_l10n; } set { estadoPista_l10n = value;  }
}
}
}
