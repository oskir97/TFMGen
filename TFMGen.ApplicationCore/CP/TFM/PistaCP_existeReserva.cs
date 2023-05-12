
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Pista_existeReserva) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class PistaCP : GenericBasicCP
{
public bool ExisteReserva (int p_oid, Nullable<DateTime> p_fecha)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Pista_existeReserva) ENABLED START*/

        PistaCEN pistaCEN = null;
        DiaSemanaCEN diaSemanaCEN = null;
        ReservaCEN reservaCEN = null;

        bool result = false;


        try
        {
                CPSession.SessionInitializeTransaction ();
                pistaCEN = new  PistaCEN (unitRepo.pistarepository);
                diaSemanaCEN = new DiaSemanaCEN (unitRepo.diasemanarepository);
                reservaCEN = new ReservaCEN (unitRepo.reservarepository);
                unitRepo.pistarepository.setSessionCP (CPSession);
                unitRepo.diasemanarepository.setSessionCP(CPSession);
                unitRepo.reservarepository.setSessionCP(CPSession);
                unitRepo.eventorepository.setSessionCP(CPSession);


                // Write here your custom transaction ...

                if (p_fecha == null)
                        result = true;
                else{
                        var reservas = reservaCEN.Obtenerreservaspista (p_oid, p_fecha);
                    reservas = reservas.Where(r => r.Horario.Inicio.Value.TimeOfDay == p_fecha.Value.TimeOfDay).ToList();

                        return (reservas != null && reservas.Count > 0 && ((reservas.Any (r => r.Pago != null) || reservas.Any (r => r.Pago == null && r.FechaCreacion > DateTime.Now.AddMinutes (-5))))) || ExisteEvento (p_oid, p_fecha);
                }



                CPSession.Commit ();
        }
        catch (Exception ex)
        {
                CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                CPSession.SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
