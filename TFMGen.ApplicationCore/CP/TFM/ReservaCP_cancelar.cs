
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Reserva_cancelar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class ReservaCP : GenericBasicCP
{
public void Cancelar (int p_oid)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Reserva_cancelar) ENABLED START*/

        ReservaCEN reservaCEN = null;



        try
        {
                CPSession.SessionInitializeTransaction ();
                reservaCEN = new  ReservaCEN (unitRepo.reservarepository);
                unitRepo.reservarepository.setSessionCP (CPSession);


                // Write here your custom transaction ...

                ReservaEN reservaEN = null;

                reservaEN = unitRepo.reservarepository.Obtener (p_oid);
                DateTime inicio = reservaEN.Horario.Inicio.Value;

                DateTime fechaInicio = reservaEN.Fecha.Value.AddHours (inicio.Hour).AddMinutes (inicio.Minute).AddSeconds (inicio.Second);

                if (!reservaEN.Cancelada && DateTime.Now.AddHours (1) < fechaInicio) {
                        reservaEN.Cancelada = true;
                        reservaEN.FechaCancelada = DateTime.Now;
                        unitRepo.reservarepository.Editar (reservaEN);



                        CPSession.Commit ();
                }
                else{
                        throw new Exception ("No es posible cancelar la reserva, se va a efectura en 1 hora o menos o ya est� cancelada");
                }
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


        /*PROTECTED REGION END*/
}
}
}
