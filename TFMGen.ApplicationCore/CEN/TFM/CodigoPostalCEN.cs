

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class CodigoPostalCEN
 *
 */
public partial class CodigoPostalCEN
{
private ICodigoPostalRepository _ICodigoPostalRepository;

public CodigoPostalCEN(ICodigoPostalRepository _ICodigoPostalRepository)
{
        this._ICodigoPostalRepository = _ICodigoPostalRepository;
}

public ICodigoPostalRepository get_ICodigoPostalRepository ()
{
        return this._ICodigoPostalRepository;
}

public int Crear (string p_codigo, string p_localidad, string p_comunidad, string p_provincia, string p_latitud, string p_longitud, string p_precision)
{
        CodigoPostalEN codigoPostalEN = null;
        int oid;

        //Initialized CodigoPostalEN
        codigoPostalEN = new CodigoPostalEN ();
        codigoPostalEN.Codigo = p_codigo;

        codigoPostalEN.Localidad = p_localidad;

        codigoPostalEN.Comunidad = p_comunidad;

        codigoPostalEN.Provincia = p_provincia;

        codigoPostalEN.Latitud = p_latitud;

        codigoPostalEN.Longitud = p_longitud;

        codigoPostalEN.Precision = p_precision;



        oid = _ICodigoPostalRepository.Crear (codigoPostalEN);
        return oid;
}
}
}
