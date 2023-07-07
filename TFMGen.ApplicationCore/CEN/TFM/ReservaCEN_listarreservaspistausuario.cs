
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Reserva_listarreservaspistausuario) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ReservaCEN
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listarreservaspistausuario (int p_usuario)
{
            /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Reserva_listarreservaspistausuario) ENABLED START*/

            // Write here your custom code...

            return _IReservaRepository.Listarreservasusuario(p_usuario).Where(r => r.Pago != null && r.Tipo == Enumerated.TFM.TipoReservaEnum.reserva).OrderByDescending(r=>r.Horario.Inicio).ToList();

            /*PROTECTED REGION END*/
        }
}
}
