using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class Rol_l10nDTO
{
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private int rol_oid;
public int Rol_oid {
        get { return rol_oid; } set { rol_oid = value;  }
}



private int idioma_oid;
public int Idioma_oid {
        get { return idioma_oid; } set { idioma_oid = value;  }
}
}
}
