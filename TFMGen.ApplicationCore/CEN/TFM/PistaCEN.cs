

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class PistaCEN
 *
 */
public partial class PistaCEN
{
private IPistaRepository _IPistaRepository;

public PistaCEN(IPistaRepository _IPistaRepository)
{
        this._IPistaRepository = _IPistaRepository;
}

public IPistaRepository get_IPistaRepository ()
{
        return this._IPistaRepository;
}

public void Eliminar (int idpista
                      )
{
        _IPistaRepository.Eliminar (idpista);
}

public PistaEN Obtener (int idpista
                        )
{
        PistaEN pistaEN = null;

        pistaEN = _IPistaRepository.Obtener (idpista);
        return pistaEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Listar (int p_idEntidad)
{
        return _IPistaRepository.Listar (p_idEntidad);
}
}
}