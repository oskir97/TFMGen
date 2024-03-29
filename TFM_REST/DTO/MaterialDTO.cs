using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class MaterialDTO
{
private int idmaterial;
public int Idmaterial {
        get { return idmaterial; } set { idmaterial = value;  }
}
private string nombre;
public string Nombre {
        get { return nombre; } set { nombre = value;  }
}
private string descripcion;
public string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}
private double precio;
public double Precio {
        get { return precio; } set { precio = value;  }
}
private string proveedor;
public string Proveedor {
        get { return proveedor; } set { proveedor = value;  }
}


private int instalacion_oid;
public int Instalacion_oid {
        get { return instalacion_oid; } set { instalacion_oid = value;  }
}

private int numexistencias;
public int Numexistencias {
        get { return numexistencias; } set { numexistencias = value;  }
}
private string urlventa;
public string Urlventa {
        get { return urlventa; } set { urlventa = value;  }
}
private string numeroproveedor;
public string Numeroproveedor {
        get { return numeroproveedor; } set { numeroproveedor = value;  }
}
private string numeroalternativoproveedor;
public string Numeroalternativoproveedor {
        get { return numeroalternativoproveedor; } set { numeroalternativoproveedor = value;  }
}
private string emailproveedor;
public string Emailproveedor {
        get { return emailproveedor; } set { emailproveedor = value;  }
}
}
}
