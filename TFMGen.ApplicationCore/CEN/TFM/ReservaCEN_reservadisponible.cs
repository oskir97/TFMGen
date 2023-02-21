
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Reserva_reservadisponible) ENABLED START*/
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ReservaCEN
{
public bool Reservadisponible (Nullable<DateTime> fecha, TFMGen.ApplicationCore.EN.TFM.ReservaEN p_partido, int p_pista)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Reserva_reservadisponible) ENABLED START*/

        // Write here your custom code...

        if (fecha == null)
                return false;

        if (p_partido != null) {
                return p_partido.Inscripciones !.Count + 1 < p_partido.Maxparticipantes;
        }
        else{
                return !_IReservaRepository.ReadAllDefault (0, -1).Any (r => r.Pista.Idpista == p_pista && !r.Cancelada && r.Fecha == fecha);
        }

        /*PROTECTED REGION END*/
}
}
}
