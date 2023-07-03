
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Pago_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class PagoCEN
{
public int Crear (double p_subtotal, double p_total, double p_iva, int p_tipo, Nullable<DateTime> p_fecha, int p_reserva, string p_token)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Pago_crear_customized) START*/

        PagoEN pagoEN = null;

        int oid;

        //Initialized PagoEN
        pagoEN = new PagoEN ();
        pagoEN.Subtotal = p_subtotal;

        pagoEN.Total = p_total;

        pagoEN.Iva = p_iva;


        if (p_tipo != -1) {
                pagoEN.Tipo = new TFMGen.ApplicationCore.EN.TFM.PagoTipoEN ();
                pagoEN.Tipo.Idtipo = p_tipo;
        }

        pagoEN.Fecha = DateTime.Now;


        if (p_reserva != -1) {
                pagoEN.Reserva = new TFMGen.ApplicationCore.EN.TFM.ReservaEN ();
                pagoEN.Reserva.Idreserva = p_reserva;
        }

        pagoEN.Token = p_token;

        //Call to PagoRepository

        oid = _IPagoRepository.Crear (pagoEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
