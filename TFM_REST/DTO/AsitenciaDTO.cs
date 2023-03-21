using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class AsitenciaDTO
{
private int idasitencia;
public int Idasitencia {
        get { return idasitencia; } set { idasitencia = value;  }
}


private int usuario_oid;
public int Usuario_oid {
        get { return usuario_oid; } set { usuario_oid = value;  }
}

private Nullable<DateTime> fecha;
public Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}
private bool asiste;
public bool Asiste {
        get { return asiste; } set { asiste = value;  }
}
private string notas;
public string Notas {
        get { return notas; } set { notas = value;  }
}


private int evento_oid;
public int Evento_oid {
        get { return evento_oid; } set { evento_oid = value;  }
}
}
}
