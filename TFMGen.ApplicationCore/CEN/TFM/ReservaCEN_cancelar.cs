
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Reserva_cancelar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ReservaCEN
{
public void Cancelar (int p_oid)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Reserva_cancelar) ENABLED START*/

        // Write here your custom code...

        ReservaEN reservaEN = null;

        reservaEN = _IReservaRepository.Obtener (p_oid);
        reservaEN.Cancelada = true;

        _IReservaRepository.Editar (reservaEN);

        /*PROTECTED REGION END*/
}
}
}
