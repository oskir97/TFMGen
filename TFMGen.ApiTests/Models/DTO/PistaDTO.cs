using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApiTests.Models.DTO
{
public partial class PistaDTO
{
private int idpista;
public int Idpista {
        get { return idpista; } set { idpista = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private string ubicacion;
public string Ubicacion {
        get { return ubicacion; } set { ubicacion = value;  }
}
private string imagen;
public string Imagen {
        get { return imagen; } set { imagen = value;  }
}
private int maxreservas;
public int Maxreservas {
        get { return maxreservas; } set { maxreservas = value;  }
}


private System.Collections.Generic.IList<int> reservasCreadas_oid;
public System.Collections.Generic.IList<int> ReservasCreadas_oid {
        get { return reservasCreadas_oid; } set { reservasCreadas_oid = value;  }
}



private int entidad_oid;
public int Entidad_oid {
        get { return entidad_oid; } set { entidad_oid = value;  }
}



private int instalacion_oid;
public int Instalacion_oid {
        get { return instalacion_oid; } set { instalacion_oid = value;  }
}



private int estadosPista_oid;
public int EstadosPista_oid {
        get { return estadosPista_oid; } set { estadosPista_oid = value;  }
}



private System.Collections.Generic.IList<int> valoracionesAPistas_oid;
public System.Collections.Generic.IList<int> ValoracionesAPistas_oid {
        get { return valoracionesAPistas_oid; } set { valoracionesAPistas_oid = value;  }
}

private System.Collections.Generic.IList<HorarioDTO> horarios;
public System.Collections.Generic.IList<HorarioDTO> Horarios {
        get { return horarios; } set { horarios = value;  }
}


private System.Collections.Generic.IList<int> deporte_oid;
public System.Collections.Generic.IList<int> Deporte_oid {
        get { return deporte_oid; } set { deporte_oid = value;  }
}

private bool visible;
public bool Visible {
        get { return visible; } set { visible = value;  }
}
        private decimal precio;
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
