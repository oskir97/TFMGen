

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class InstalacionCEN
 *
 */
public partial class InstalacionCEN
{
private IInstalacionRepository _IInstalacionRepository;

public InstalacionCEN(IInstalacionRepository _IInstalacionRepository)
{
        this._IInstalacionRepository = _IInstalacionRepository;
}

public IInstalacionRepository get_IInstalacionRepository ()
{
        return this._IInstalacionRepository;
}

public void Eliminar (int idinstalacion
                      )
{
        _IInstalacionRepository.Eliminar (idinstalacion);
}

public InstalacionEN Obtener (int idinstalacion
                              )
{
        InstalacionEN instalacionEN = null;

        instalacionEN = _IInstalacionRepository.Obtener (idinstalacion);
        return instalacionEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> Listar (int p_idEntidad)
{
        return _IInstalacionRepository.Listar (p_idEntidad);
}
}
}
