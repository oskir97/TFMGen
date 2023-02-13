
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Reserva_listarreservasusuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ReservaCEN
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listarreservasusuario (int p_idusuario)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Reserva_listarreservasusuario_customized) START*/

        return _IReservaRepository.Listarreservasusuario (p_idusuario);
        /*PROTECTED REGION END*/
}
}
}
