

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class EventoCEN
 *
 */
public partial class EventoCEN
{
private IEventoRepository _IEventoRepository;

public EventoCEN(IEventoRepository _IEventoRepository)
{
        this._IEventoRepository = _IEventoRepository;
}

public IEventoRepository get_IEventoRepository ()
{
        return this._IEventoRepository;
}

public void Eliminar (int idevento
                      )
{
        _IEventoRepository.Eliminar (idevento);
}

public EventoEN Obtener (int idevento
                         )
{
        EventoEN eventoEN = null;

        eventoEN = _IEventoRepository.Obtener (idevento);
        return eventoEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Listar (int p_idUsuario)
{
        return _IEventoRepository.Listar (p_idUsuario);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Listarentidad (int p_idEntidad)
{
        return _IEventoRepository.Listarentidad (p_idEntidad);
}
public System.Collections.Generic.IList<EventoEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> list = null;

        list = _IEventoRepository.Listartodos (first, size);
        return list;
}
public void Eliminarusuario (int p_Evento_OID, System.Collections.Generic.IList<int> p_usuarios_OIDs)
{
        //Call to EventoRepository

        _IEventoRepository.Eliminarusuario (p_Evento_OID, p_usuarios_OIDs);
}
public void Asignartecnico (int p_Evento_OID, System.Collections.Generic.IList<int> p_tecnicos_OIDs)
{
        //Call to EventoRepository

        _IEventoRepository.Asignartecnico (p_Evento_OID, p_tecnicos_OIDs);
}
public void Eliminartecnico (int p_Evento_OID, System.Collections.Generic.IList<int> p_tecnicos_OIDs)
{
        //Call to EventoRepository

        _IEventoRepository.Eliminartecnico (p_Evento_OID, p_tecnicos_OIDs);
}
public void Asignardiassemana (int p_Evento_OID, System.Collections.Generic.IList<int> p_diasSemana_OIDs)
{
        //Call to EventoRepository

        _IEventoRepository.Asignardiassemana (p_Evento_OID, p_diasSemana_OIDs);
}
public void Eliminardiassemana (int p_Evento_OID, System.Collections.Generic.IList<int> p_diasSemana_OIDs)
{
        //Call to EventoRepository

        _IEventoRepository.Eliminardiassemana (p_Evento_OID, p_diasSemana_OIDs);
}
public void Asignarhorarios (int p_Evento_OID, System.Collections.Generic.IList<int> p_horarios_OIDs)
{
        //Call to EventoRepository

        _IEventoRepository.Asignarhorarios (p_Evento_OID, p_horarios_OIDs);
}
public void Eliminarhorarios (int p_Evento_OID, System.Collections.Generic.IList<int> p_horarios_OIDs)
{
        //Call to EventoRepository

        _IEventoRepository.Eliminarhorarios (p_Evento_OID, p_horarios_OIDs);
}
}
}
