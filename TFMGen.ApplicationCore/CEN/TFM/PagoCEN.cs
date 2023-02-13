

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class PagoCEN
 *
 */
public partial class PagoCEN
{
private IPagoRepository _IPagoRepository;

public PagoCEN(IPagoRepository _IPagoRepository)
{
        this._IPagoRepository = _IPagoRepository;
}

public IPagoRepository get_IPagoRepository ()
{
        return this._IPagoRepository;
}

public int Crear (double p_subtotal, double p_total, double p_iva, int p_tipo, Nullable<DateTime> p_fecha, int p_reserva)
{
        PagoEN pagoEN = null;
        int oid;

        //Initialized PagoEN
        pagoEN = new PagoEN ();
        pagoEN.Subtotal = p_subtotal;

        pagoEN.Total = p_total;

        pagoEN.Iva = p_iva;


        if (p_tipo != -1) {
                // El argumento p_tipo -> Property tipo es oid = false
                // Lista de oids idpago
                pagoEN.Tipo = new TFMGen.ApplicationCore.EN.TFM.PagoTipoEN ();
                pagoEN.Tipo.Idtipo = p_tipo;
        }

        pagoEN.Fecha = p_fecha;


        if (p_reserva != -1) {
                // El argumento p_reserva -> Property reserva es oid = false
                // Lista de oids idpago
                pagoEN.Reserva = new TFMGen.ApplicationCore.EN.TFM.ReservaEN ();
                pagoEN.Reserva.Idreserva = p_reserva;
        }



        oid = _IPagoRepository.Crear (pagoEN);
        return oid;
}

public PagoEN Obtener (int idpago
                       )
{
        PagoEN pagoEN = null;

        pagoEN = _IPagoRepository.Obtener (idpago);
        return pagoEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> Listar (int p_idReserva)
{
        return _IPagoRepository.Listar (p_idReserva);
}
}
}
