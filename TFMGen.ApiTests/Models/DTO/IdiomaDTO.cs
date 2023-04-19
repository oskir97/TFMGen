using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class IdiomaDTO
{
private int ididioma;
public int Ididioma {
        get { return ididioma; } set { ididioma = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private string cultura;
public string Cultura {
        get { return cultura; } set { cultura = value;  }
}


private System.Collections.Generic.IList<int> estadoPista_l10n_oid;
public System.Collections.Generic.IList<int> EstadoPista_l10n_oid {
        get { return estadoPista_l10n_oid; } set { estadoPista_l10n_oid = value;  }
}



private System.Collections.Generic.IList<int> deporte_l10n_oid;
public System.Collections.Generic.IList<int> Deporte_l10n_oid {
        get { return deporte_l10n_oid; } set { deporte_l10n_oid = value;  }
}



private System.Collections.Generic.IList<int> pagoTipo_l10n_oid;
public System.Collections.Generic.IList<int> PagoTipo_l10n_oid {
        get { return pagoTipo_l10n_oid; } set { pagoTipo_l10n_oid = value;  }
}



private System.Collections.Generic.IList<int> rol_l10n_oid;
public System.Collections.Generic.IList<int> Rol_l10n_oid {
        get { return rol_l10n_oid; } set { rol_l10n_oid = value;  }
}



private System.Collections.Generic.IList<int> diaSemana_l10n_oid;
public System.Collections.Generic.IList<int> DiaSemana_l10n_oid {
        get { return diaSemana_l10n_oid; } set { diaSemana_l10n_oid = value;  }
}
}
}
