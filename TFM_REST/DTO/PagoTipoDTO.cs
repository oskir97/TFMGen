using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class PagoTipoDTO
{
private int idtipo;
public int Idtipo {
        get { return idtipo; } set { idtipo = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}


private System.Collections.Generic.IList<int> pagos_oid;
public System.Collections.Generic.IList<int> Pagos_oid {
        get { return pagos_oid; } set { pagos_oid = value;  }
}

private System.Collections.Generic.IList<PagoTipo_l10nDTO> pagoTipo_l10n;
public System.Collections.Generic.IList<PagoTipo_l10nDTO> PagoTipo_l10n {
        get { return pagoTipo_l10n; } set { pagoTipo_l10n = value;  }
}
}
}
