

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

public int Crear (string p_nombre, string p_descripcion, int p_entidad, System.Collections.Generic.IList<int> p_horarios, System.Collections.Generic.IList<int> p_diasSemana, bool p_activo, int p_plazas)
{
        EventoEN eventoEN = null;
        int oid;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Nombre = p_nombre;

        eventoEN.Descripcion = p_descripcion;


        if (p_entidad != -1) {
                // El argumento p_entidad -> Property entidad es oid = false
                // Lista de oids idevento
                eventoEN.Entidad = new TFMGen.ApplicationCore.EN.TFM.EntidadEN ();
                eventoEN.Entidad.Identidad = p_entidad;
        }


        eventoEN.Horarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
        if (p_horarios != null) {
                foreach (int item in p_horarios) {
                        TFMGen.ApplicationCore.EN.TFM.HorarioEN en = new TFMGen.ApplicationCore.EN.TFM.HorarioEN ();
                        en.Idhorario = item;
                        eventoEN.Horarios.Add (en);
                }
        }

        else{
                eventoEN.Horarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
        }


        eventoEN.DiasSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
        if (p_diasSemana != null) {
                foreach (int item in p_diasSemana) {
                        TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN en = new TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN ();
                        en.Iddiasemana = item;
                        eventoEN.DiasSemana.Add (en);
                }
        }

        else{
                eventoEN.DiasSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
        }

        eventoEN.Activo = p_activo;

        eventoEN.Plazas = p_plazas;



        oid = _IEventoRepository.Crear (eventoEN);
        return oid;
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
}
}
