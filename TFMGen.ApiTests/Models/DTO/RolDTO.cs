using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class RolDTO
{
private int idrol;
public int Idrol {
        get { return idrol; } set { idrol = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}


private System.Collections.Generic.IList<int> usuarios_oid;
public System.Collections.Generic.IList<int> Usuarios_oid {
        get { return usuarios_oid; } set { usuarios_oid = value;  }
}

private System.Collections.Generic.IList<Rol_l10nDTO> rol_l10n;
public System.Collections.Generic.IList<Rol_l10nDTO> Rol_l10n {
        get { return rol_l10n; } set { rol_l10n = value;  }
}
}
}
