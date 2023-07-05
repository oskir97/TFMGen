
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Reserva_inscribirsepartido) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class ReservaCP : GenericBasicCP
{
public void Inscribirsepartido (int p_Reserva_OID, System.Collections.Generic.IList<int> p_inscripciones_OIDs)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Reserva_inscribirsepartido) ENABLED START*/

        ReservaCEN reservaCEN = null;



        try
        {
                //CPSession.SessionInitializeTransaction ();
                unitRepo.reservarepository.setSessionCP (CPSession);
                reservaCEN = new  ReservaCEN (unitRepo.reservarepository);

                var p_partido = reservaCEN.Obtener (p_Reserva_OID);

                if ((reservaCEN.Obtenerinscripciones (p_Reserva_OID).Count (i=>!i.Cancelada) + p_inscripciones_OIDs.Count ()) <= p_partido.Maxparticipantes) {
                        reservaCEN.get_IReservaRepository ().Inscribirsepartido (p_Reserva_OID, p_inscripciones_OIDs);
                }
                else{
                        throw new Exception ("No se admiten m�s inscripciones");
                }

                //CPSession.Commit ();
        }
        catch (Exception ex)
        {
                //CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                //CPSession.SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
