using System;
using System.Runtime.Serialization;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFM_REST.DTO
{
public partial class PagoDTO
{
private int idpago;
public int Idpago {
        get { return idpago; } set { idpago = value;  }
}
private double subtotal;
public double Subtotal {
        get { return subtotal; } set { subtotal = value;  }
}
private double total;
public double Total {
        get { return total; } set { total = value;  }
}
private double iva;
public double Iva {
        get { return iva; } set { iva = value;  }
}


private int tipo_oid;
public int Tipo_oid {
        get { return tipo_oid; } set { tipo_oid = value;  }
}

private Nullable<DateTime> fecha;
public Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


private int reserva_oid;
public int Reserva_oid {
        get { return reserva_oid; } set { reserva_oid = value;  }
}
}
}
