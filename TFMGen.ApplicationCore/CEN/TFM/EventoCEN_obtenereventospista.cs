
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Evento_obtenereventospista) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class EventoCEN
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Obtenereventospista (int p_idPista, Nullable<DateTime> p_fecha, int p_idDiaSemana)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Evento_obtenereventospista) ENABLED START*/

        // Write here your custom code...
        var eventos = _IEventoRepository.Listartodos (0, -1);

        return eventos.Where (e => e.Activo && e.Horarios.Any (h => h.Pistas.Any(p=>p.Idpista == p_idPista) && h.Inicio.Value.TimeOfDay == p_fecha.Value.TimeOfDay) && e.DiasSemana.Any (d => d.Iddiasemana == p_idDiaSemana)).ToList ();

        /*PROTECTED REGION END*/
}
}
}
