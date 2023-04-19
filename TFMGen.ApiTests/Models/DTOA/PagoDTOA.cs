using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class PagoDTOA
{
private int idpago;
public int Idpago
{
        get { return idpago; }
        set { idpago = value; }
}

private double subtotal;
public double Subtotal
{
        get { return subtotal; }
        set { subtotal = value; }
}

private double total;
public double Total
{
        get { return total; }
        set { total = value; }
}

private double iva;
public double Iva
{
        get { return iva; }
        set { iva = value; }
}

private Nullable<DateTime> fecha;
public Nullable<DateTime> Fecha
{
        get { return fecha; }
        set { fecha = value; }
}


/* Rol: Pago o--> PagoTipo */
private PagoTipoDTOA obtenerTipo;
public PagoTipoDTOA ObtenerTipo
{
        get { return obtenerTipo; }
        set { obtenerTipo = value; }
}
}
}
