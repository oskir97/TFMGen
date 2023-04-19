

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
public TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN ObtenerTipo (int p_idPago, int p_idIdioma)
{
        return _IPagoRepository.ObtenerTipo (p_idPago, p_idIdioma);
}
public System.Collections.Generic.IList<PagoEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<PagoEN> list = null;

        list = _IPagoRepository.Listartodos (first, size);
        return list;
}
}
}
