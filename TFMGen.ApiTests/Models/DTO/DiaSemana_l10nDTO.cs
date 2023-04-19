using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class DiaSemana_l10nDTO
{
private int diaSemana_oid;
public int DiaSemana_oid {
        get { return diaSemana_oid; } set { diaSemana_oid = value;  }
}



private int idioma_oid;
public int Idioma_oid {
        get { return idioma_oid; } set { idioma_oid = value;  }
}

private int iddiasemana;
public int Iddiasemana {
        get { return iddiasemana; } set { iddiasemana = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
}
}
