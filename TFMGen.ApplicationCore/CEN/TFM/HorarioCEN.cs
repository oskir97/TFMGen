

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class HorarioCEN
 *
 */
public partial class HorarioCEN
{
private IHorarioRepository _IHorarioRepository;

public HorarioCEN(IHorarioRepository _IHorarioRepository)
{
        this._IHorarioRepository = _IHorarioRepository;
}

public IHorarioRepository get_IHorarioRepository ()
{
        return this._IHorarioRepository;
}

public void Eliminar (int idhorario
                      )
{
        _IHorarioRepository.Eliminar (idhorario);
}

public HorarioEN Obtener (int idhorario
                          )
{
        HorarioEN horarioEN = null;

        horarioEN = _IHorarioRepository.Obtener (idhorario);
        return horarioEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Listar (int p_idPista)
{
        return _IHorarioRepository.Listar (p_idPista);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> ListarDiasSemana (int p_idHorario, int p_idIdioma)
{
        return _IHorarioRepository.ListarDiasSemana (p_idHorario, p_idIdioma);
}
public System.Collections.Generic.IList<HorarioEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<HorarioEN> list = null;

        list = _IHorarioRepository.Listartodos (first, size);
        return list;
}
public void Asignarpistas (int p_Horario_OID, System.Collections.Generic.IList<int> p_pistas_OIDs)
{
        //Call to HorarioRepository

        _IHorarioRepository.Asignarpistas (p_Horario_OID, p_pistas_OIDs);
}
public void Elimininarpistas (int p_Horario_OID, System.Collections.Generic.IList<int> p_pistas_OIDs)
{
        //Call to HorarioRepository

        _IHorarioRepository.Elimininarpistas (p_Horario_OID, p_pistas_OIDs);
}
}
}
