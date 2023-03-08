

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class PagoTipoCEN
 *
 */
public partial class PagoTipoCEN
{
private IPagoTipoRepository _IPagoTipoRepository;

public PagoTipoCEN(IPagoTipoRepository _IPagoTipoRepository)
{
        this._IPagoTipoRepository = _IPagoTipoRepository;
}

public IPagoTipoRepository get_IPagoTipoRepository ()
{
        return this._IPagoTipoRepository;
}

public int Crear (string p_nombre)
{
        PagoTipoEN pagoTipoEN = null;
        int oid;

        //Initialized PagoTipoEN
        pagoTipoEN = new PagoTipoEN ();
        pagoTipoEN.Nombre = p_nombre;



        oid = _IPagoTipoRepository.Crear (pagoTipoEN);
        return oid;
}

public System.Collections.Generic.IList<PagoTipoEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<PagoTipoEN> list = null;

        list = _IPagoTipoRepository.Listar (first, size);
        return list;
}
}
}
