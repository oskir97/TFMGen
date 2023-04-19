using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class ValoracionDTO
{
private int idvaloracion;
public int Idvaloracion {
        get { return idvaloracion; } set { idvaloracion = value;  }
}
private int estrellas;
public int Estrellas {
        get { return estrellas; } set { estrellas = value;  }
}
private string comentario;
public string Comentario {
        get { return comentario; } set { comentario = value;  }
}


private int usuario_oid;
public int Usuario_oid {
        get { return usuario_oid; } set { usuario_oid = value;  }
}



private int entidad_oid;
public int Entidad_oid {
        get { return entidad_oid; } set { entidad_oid = value;  }
}



private int instalacion_oid;
public int Instalacion_oid {
        get { return instalacion_oid; } set { instalacion_oid = value;  }
}



private int pista_oid;
public int Pista_oid {
        get { return pista_oid; } set { pista_oid = value;  }
}



private int tecnico_oid;
public int Tecnico_oid {
        get { return tecnico_oid; } set { tecnico_oid = value;  }
}
}
}
