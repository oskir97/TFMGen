
using System;
// Definición clase PagoEN
namespace TFMGen.ApplicationCore.EN.TFM
{
public partial class PagoEN
{
/**
 *	Atributo idpago
 */
private int idpago;



/**
 *	Atributo subtotal
 */
private double subtotal;



/**
 *	Atributo total
 */
private double total;



/**
 *	Atributo iva
 */
private double iva;



/**
 *	Atributo tipo
 */
private TFMGen.ApplicationCore.EN.TFM.PagoTipoEN tipo;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo reserva
 */
private TFMGen.ApplicationCore.EN.TFM.ReservaEN reserva;






public virtual int Idpago {
        get { return idpago; } set { idpago = value;  }
}



public virtual double Subtotal {
        get { return subtotal; } set { subtotal = value;  }
}



public virtual double Total {
        get { return total; } set { total = value;  }
}



public virtual double Iva {
        get { return iva; } set { iva = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.PagoTipoEN Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.ReservaEN Reserva {
        get { return reserva; } set { reserva = value;  }
}





public PagoEN()
{
}



public PagoEN(int idpago, double subtotal, double total, double iva, TFMGen.ApplicationCore.EN.TFM.PagoTipoEN tipo, Nullable<DateTime> fecha, TFMGen.ApplicationCore.EN.TFM.ReservaEN reserva
              )
{
        this.init (Idpago, subtotal, total, iva, tipo, fecha, reserva);
}


public PagoEN(PagoEN pago)
{
        this.init (Idpago, pago.Subtotal, pago.Total, pago.Iva, pago.Tipo, pago.Fecha, pago.Reserva);
}

private void init (int idpago
                   , double subtotal, double total, double iva, TFMGen.ApplicationCore.EN.TFM.PagoTipoEN tipo, Nullable<DateTime> fecha, TFMGen.ApplicationCore.EN.TFM.ReservaEN reserva)
{
        this.Idpago = idpago;


        this.Subtotal = subtotal;

        this.Total = total;

        this.Iva = iva;

        this.Tipo = tipo;

        this.Fecha = fecha;

        this.Reserva = reserva;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PagoEN t = obj as PagoEN;
        if (t == null)
                return false;
        if (Idpago.Equals (t.Idpago))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Idpago.GetHashCode ();
        return hash;
}
}
}
