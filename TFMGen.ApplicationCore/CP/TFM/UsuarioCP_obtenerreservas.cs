
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Usuario_obtenerreservas) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class UsuarioCP : GenericBasicCP
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Obtenerreservas (int p_oid, bool notClose)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Usuario_obtenerreservas) ENABLED START*/

        UsuarioCEN usuarioCEN = null;
        ReservaCEN reservaCEN = null;

        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN>  result = null;


        try
        {
                if (!notClose)
                        CPSession.SessionInitializeTransaction ();
                reservaCEN = new  ReservaCEN (unitRepo.reservarepository);

                var reservas = reservaCEN.Listarreservasusuario (p_oid);

                foreach (var reserva in reservas.Where (r => r.Pago == null && r.FechaCreacion.HasValue && r.FechaCreacion.Value.AddDays (1) > DateTime.Now && r.Partido == null).ToList ()) {
                        reservaCEN.Eliminar (reserva.Idreserva);
                }

                result = reservas.Where (r => r.Pago != null).ToList ();


                if (!notClose)
                        CPSession.Commit ();
        }
        catch (Exception ex)
        {
                if (!notClose)
                        CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                if (!notClose)
                        CPSession.SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
