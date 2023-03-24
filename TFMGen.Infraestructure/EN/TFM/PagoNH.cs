
using System;
using TFMGen.ApplicationCore.EN.TFM;
namespace TFMGen.Infraestructure.EN.TFM
{
public partial class PagoNH : PagoEN {
public PagoNH ()
{
}

public PagoNH (PagoEN dto)
{
        this.Idpago = dto.Idpago;


        this.Subtotal = dto.Subtotal;


        this.Total = dto.Total;


        this.Iva = dto.Iva;


        this.Fecha = dto.Fecha;


        this.Token = dto.Token;
}
}
}
