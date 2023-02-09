
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
private decimal subtotal;



/**
 *	Atributo total
 */
private decimal total;



/**
 *	Atributo iva
 */
private decimal iva;



/**
 *	Atributo tipo
 */
private TFMGen.ApplicationCore.EN.TFM.TipoEN tipo;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo reservas
 */
private System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservas;






public virtual int Idpago {
        get { return idpago; } set { idpago = value;  }
}



public virtual decimal Subtotal {
        get { return subtotal; } set { subtotal = value;  }
}



public virtual decimal Total {
        get { return total; } set { total = value;  }
}



public virtual decimal Iva {
        get { return iva; } set { iva = value;  }
}



public virtual TFMGen.ApplicationCore.EN.TFM.TipoEN Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Reservas {
        get { return reservas; } set { reservas = value;  }
}





public PagoEN()
{
        reservas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
}



public PagoEN(int idpago, decimal subtotal, decimal total, decimal iva, TFMGen.ApplicationCore.EN.TFM.TipoEN tipo, Nullable<DateTime> fecha, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservas
              )
{
        this.init (Idpago, subtotal, total, iva, tipo, fecha, reservas);
}


public PagoEN(PagoEN pago)
{
        this.init (Idpago, pago.Subtotal, pago.Total, pago.Iva, pago.Tipo, pago.Fecha, pago.Reservas);
}

private void init (int idpago
                   , decimal subtotal, decimal total, decimal iva, TFMGen.ApplicationCore.EN.TFM.TipoEN tipo, Nullable<DateTime> fecha, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> reservas)
{
        this.Idpago = idpago;


        this.Subtotal = subtotal;

        this.Total = total;

        this.Iva = iva;

        this.Tipo = tipo;

        this.Fecha = fecha;

        this.Reservas = reservas;
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
