using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
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


private System.Collections.Generic.IList<int> pistas_oid;
public System.Collections.Generic.IList<int> Pistas_oid {
        get { return pistas_oid; } set { pistas_oid = value;  }
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



private int entidad_oid;
public int Entidad_oid {
        get { return entidad_oid; } set { entidad_oid = value;  }
}
}
}
