using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class DiaSemanaDTO
{
private int iddiasemana;
public int Iddiasemana {
        get { return iddiasemana; } set { iddiasemana = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private System.Collections.Generic.IList<DiaSemana_l10nDTO> diaSemana_l10n;
public System.Collections.Generic.IList<DiaSemana_l10nDTO> DiaSemana_l10n {
        get { return diaSemana_l10n; } set { diaSemana_l10n = value;  }
}


private System.Collections.Generic.IList<int> horario_oid;
public System.Collections.Generic.IList<int> Horario_oid {
        get { return horario_oid; } set { horario_oid = value;  }
}



private System.Collections.Generic.IList<int> eventos_oid;
public System.Collections.Generic.IList<int> Eventos_oid {
        get { return eventos_oid; } set { eventos_oid = value;  }
}
}
}
