using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class InstalacionDTO
{
private int idinstalacion;
public int Idinstalacion {
        get { return idinstalacion; } set { idinstalacion = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private string telefono;
public string Telefono {
        get { return telefono; } set { telefono = value;  }
}
private string domicilio;
public string Domicilio {
        get { return domicilio; } set { domicilio = value;  }
}
private string ubicacion;
public string Ubicacion {
        get { return ubicacion; } set { ubicacion = value;  }
}
private string imagen;
public string Imagen {
        get { return imagen; } set { imagen = value;  }
}


private System.Collections.Generic.IList<int> pistas_oid;
public System.Collections.Generic.IList<int> Pistas_oid {
        get { return pistas_oid; } set { pistas_oid = value;  }
}

private System.Collections.Generic.IList<MaterialDTO> materiales;
public System.Collections.Generic.IList<MaterialDTO> Materiales {
        get { return materiales; } set { materiales = value;  }
}


private int entidad_oid;
public int Entidad_oid {
        get { return entidad_oid; } set { entidad_oid = value;  }
}



private System.Collections.Generic.IList<int> valoracionesAInstalaciones_oid;
public System.Collections.Generic.IList<int> ValoracionesAInstalaciones_oid {
        get { return valoracionesAInstalaciones_oid; } set { valoracionesAInstalaciones_oid = value;  }
}

private string codigopostal;
public string Codigopostal {
        get { return codigopostal; } set { codigopostal = value;  }
}
private string localidad;
public string Localidad {
        get { return localidad; } set { localidad = value;  }
}
private string provincia;
public string Provincia {
        get { return provincia; } set { provincia = value;  }
}
private string telefonoalternativo;
public string Telefonoalternativo {
        get { return telefonoalternativo; } set { telefonoalternativo = value;  }
}
private bool visible;
public bool Visible {
        get { return visible; } set { visible = value;  }
}
private double latitud;
public double Latitud {
        get { return latitud; } set { latitud = value;  }
}
private double longitud;
public double Longitud {
        get { return longitud; } set { longitud = value;  }
}


private System.Collections.Generic.IList<int> eventos_oid;
public System.Collections.Generic.IList<int> Eventos_oid {
        get { return eventos_oid; } set { eventos_oid = value;  }
}



private System.Collections.Generic.IList<int> usuario_oid;
public System.Collections.Generic.IList<int> Usuario_oid {
        get { return usuario_oid; } set { usuario_oid = value;  }
}
}
}
