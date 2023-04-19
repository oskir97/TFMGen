using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class Deporte_l10nDTO
{
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private int idioma_oid;
public int Idioma_oid {
        get { return idioma_oid; } set { idioma_oid = value;  }
}



private int deporte_oid;
public int Deporte_oid {
        get { return deporte_oid; } set { deporte_oid = value;  }
}
}
}
