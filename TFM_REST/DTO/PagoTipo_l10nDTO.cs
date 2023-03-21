using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class PagoTipo_l10nDTO
{
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private int pagoTipo_oid;
public int PagoTipo_oid {
        get { return pagoTipo_oid; } set { pagoTipo_oid = value;  }
}



private int idioma_oid;
public int Idioma_oid {
        get { return idioma_oid; } set { idioma_oid = value;  }
}
}
}
