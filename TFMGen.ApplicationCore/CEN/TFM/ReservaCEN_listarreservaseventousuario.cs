
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Reserva_listarreservaseventousuario) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ReservaCEN
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listarreservaseventousuario (int p_usuario)
{
            /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Reserva_listarreservaseventousuario) ENABLED START*/

            // Write here your custom code...
            var reservas = _IReservaRepository.Listarreservasusuario(p_usuario).Where(r => r.Pago != null && r.Tipo == Enumerated.TFM.TipoReservaEnum.inscripcion && r.Evento != null).OrderByDescending(r => r.Evento.Inicio).ToList();
            
            //foreach(var reserva in reservas)
            //{
            //    reserva.Pista = reserva.Evento.Horarios[0].Pista;
            //}
            return reservas;

        /*PROTECTED REGION END*/
}
}
}
