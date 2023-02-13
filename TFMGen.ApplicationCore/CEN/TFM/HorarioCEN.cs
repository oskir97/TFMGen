

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

public void Editar (int p_Horario_OID, TimeSpan p_inicio, TimeSpan p_fin)
{
        HorarioEN horarioEN = null;

        //Initialized HorarioEN
        horarioEN = new HorarioEN ();
        horarioEN.Idhorario = p_Horario_OID;
        horarioEN.Inicio = p_inicio;
        horarioEN.Fin = p_fin;
        //Call to HorarioRepository

        _IHorarioRepository.Editar (horarioEN);
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
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Listardisponibles ()
{
        return _IHorarioRepository.Listardisponibles ();
}
}
}
