

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class EntidadCEN
 *
 */
public partial class EntidadCEN
{
private IEntidadRepository _IEntidadRepository;

public EntidadCEN(IEntidadRepository _IEntidadRepository)
{
        this._IEntidadRepository = _IEntidadRepository;
}

public IEntidadRepository get_IEntidadRepository ()
{
        return this._IEntidadRepository;
}

public void Eliminar (int identidad
                      )
{
        _IEntidadRepository.Eliminar (identidad);
}

public EntidadEN Obtener (int identidad
                          )
{
        EntidadEN entidadEN = null;

        entidadEN = _IEntidadRepository.Obtener (identidad);
        return entidadEN;
}

public System.Collections.Generic.IList<EntidadEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<EntidadEN> list = null;

        list = _IEntidadRepository.Listar (first, size);
        return list;
}
}
}
