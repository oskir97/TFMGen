using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class HorarioDTO
{
private int idhorario;
public int Idhorario {
        get { return idhorario; } set { idhorario = value;  }
}
private Nullable<DateTime> inicio;
public Nullable<DateTime> Inicio {
        get { return inicio; } set { inicio = value;  }
}
private Nullable<DateTime> fin;
public Nullable<DateTime> Fin {
        get { return fin; } set { fin = value;  }
}


private int pista_oid;
public int Pista_oid {
        get { return pista_oid; } set { pista_oid = value;  }
}



private System.Collections.Generic.IList<int> reserva_oid;
public System.Collections.Generic.IList<int> Reserva_oid {
        get { return reserva_oid; } set { reserva_oid = value;  }
}



private System.Collections.Generic.IList<int> diaSemana_oid;
public System.Collections.Generic.IList<int> DiaSemana_oid {
        get { return diaSemana_oid; } set { diaSemana_oid = value;  }
}



private System.Collections.Generic.IList<int> eventos_oid;
public System.Collections.Generic.IList<int> Eventos_oid {
        get { return eventos_oid; } set { eventos_oid = value;  }
}
}
}
