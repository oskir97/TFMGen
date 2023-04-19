

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class AsitenciaCEN
 *
 */
public partial class AsitenciaCEN
{
private IAsitenciaRepository _IAsitenciaRepository;

public AsitenciaCEN(IAsitenciaRepository _IAsitenciaRepository)
{
        this._IAsitenciaRepository = _IAsitenciaRepository;
}

public IAsitenciaRepository get_IAsitenciaRepository ()
{
        return this._IAsitenciaRepository;
}

public void Eliminar (int idasitencia
                      )
{
        _IAsitenciaRepository.Eliminar (idasitencia);
}

public AsitenciaEN Obtener (int idasitencia
                            )
{
        AsitenciaEN asitenciaEN = null;

        asitenciaEN = _IAsitenciaRepository.Obtener (idasitencia);
        return asitenciaEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> Listar (int p_idUsuario)
{
        return _IAsitenciaRepository.Listar (p_idUsuario);
}
public System.Collections.Generic.IList<AsitenciaEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<AsitenciaEN> list = null;

        list = _IAsitenciaRepository.Listartodos (first, size);
        return list;
}
}
}
