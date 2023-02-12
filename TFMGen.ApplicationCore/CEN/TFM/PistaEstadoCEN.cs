

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class PistaEstadoCEN
 *
 */
public partial class PistaEstadoCEN
{
private IPistaEstadoRepository _IPistaEstadoRepository;

public PistaEstadoCEN(IPistaEstadoRepository _IPistaEstadoRepository)
{
        this._IPistaEstadoRepository = _IPistaEstadoRepository;
}

public IPistaEstadoRepository get_IPistaEstadoRepository ()
{
        return this._IPistaEstadoRepository;
}

public int Crear (string p_nombre)
{
        PistaEstadoEN pistaEstadoEN = null;
        int oid;

        //Initialized PistaEstadoEN
        pistaEstadoEN = new PistaEstadoEN ();
        pistaEstadoEN.Nombre = p_nombre;



        oid = _IPistaEstadoRepository.Crear (pistaEstadoEN);
        return oid;
}
}
}
