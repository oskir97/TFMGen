

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class IncidenciaCEN
 *
 */
public partial class IncidenciaCEN
{
private IIncidenciaRepository _IIncidenciaRepository;

public IncidenciaCEN(IIncidenciaRepository _IIncidenciaRepository)
{
        this._IIncidenciaRepository = _IIncidenciaRepository;
}

public IIncidenciaRepository get_IIncidenciaRepository ()
{
        return this._IIncidenciaRepository;
}

public void Modificar (int p_Incidencia_OID, string p_asunto, string p_descripcion, Nullable<DateTime> p_fechacancelada)
{
        IncidenciaEN incidenciaEN = null;

        //Initialized IncidenciaEN
        incidenciaEN = new IncidenciaEN ();
        incidenciaEN.Idincidencia = p_Incidencia_OID;
        incidenciaEN.Asunto = p_asunto;
        incidenciaEN.Descripcion = p_descripcion;
        incidenciaEN.Fechacancelada = p_fechacancelada;
        //Call to IncidenciaRepository

        _IIncidenciaRepository.Modificar (incidenciaEN);
}

public void Eliminar (int idincidencia
                      )
{
        _IIncidenciaRepository.Eliminar (idincidencia);
}

public IncidenciaEN Obtener (int idincidencia
                             )
{
        IncidenciaEN incidenciaEN = null;

        incidenciaEN = _IIncidenciaRepository.Obtener (idincidencia);
        return incidenciaEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> Listar (int p_idEvento)
{
        return _IIncidenciaRepository.Listar (p_idEvento);
}
public System.Collections.Generic.IList<IncidenciaEN> Listartodas (int first, int size)
{
        System.Collections.Generic.IList<IncidenciaEN> list = null;

        list = _IIncidenciaRepository.Listartodas (first, size);
        return list;
}
}
}
