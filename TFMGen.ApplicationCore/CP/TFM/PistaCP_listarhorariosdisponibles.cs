
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Pista_listarhorariosdisponibles) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class PistaCP : GenericBasicCP
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Listarhorariosdisponibles (int p_oid, Nullable<DateTime> p_fecha)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Pista_listarhorariosdisponibles) ENABLED START*/

        PistaCEN pistaCEN = null;
            HorarioCEN horarioCEN = null;
            DiaSemanaCEN diaSemanaCEN = null;

        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN>  result = null;


        try
        {
               
                if (p_fecha == null)
                    result = null;
                else
                {
                    CPSession.SessionInitializeTransaction();
                    pistaCEN = new PistaCEN(unitRepo.pistarepository);
                    horarioCEN = new HorarioCEN(unitRepo.horariorepository);
                    diaSemanaCEN = new DiaSemanaCEN(unitRepo.diasemanarepository);
                    unitRepo.pistarepository.setSessionCP(CPSession);
                    unitRepo.reservarepository.setSessionCP(CPSession);
                    unitRepo.diasemanarepository.setSessionCP(CPSession);

                    DayOfWeek dia = p_fecha.Value.DayOfWeek;
                    DiaSemanaEN iddiasemana = null;
                    DateTime fecha = p_fecha.Value.Date;

                    switch (dia)
                    {
                        case DayOfWeek.Sunday:
                            iddiasemana = diaSemanaCEN.Obtener("Domingo").FirstOrDefault();
                            break;

                        case DayOfWeek.Monday:
                            iddiasemana = diaSemanaCEN.Obtener("Lunes").FirstOrDefault();
                            break;

                        case DayOfWeek.Tuesday:
                            iddiasemana = diaSemanaCEN.Obtener("Martes").FirstOrDefault();
                            break;

                        case DayOfWeek.Wednesday:
                            iddiasemana = diaSemanaCEN.Obtener("Mi�rcoles").FirstOrDefault();
                            break;

                        case DayOfWeek.Thursday:
                            iddiasemana = diaSemanaCEN.Obtener("Jueves").FirstOrDefault();
                            break;

                        case DayOfWeek.Friday:
                            iddiasemana = diaSemanaCEN.Obtener("Viernes").FirstOrDefault();
                            break;

                        case DayOfWeek.Saturday:
                            iddiasemana = diaSemanaCEN.Obtener("S�bado").FirstOrDefault();
                            break;
                    }

                    result = horarioCEN.Listar(p_oid).Where(h => !h.Reserva.Any(r => r.Fecha == fecha) && !h.Eventos.Any(e => e.DiasSemana.Contains(iddiasemana))).ToList();





                CPSession.Commit();
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
        return result;


        /*PROTECTED REGION END*/
}
}
}
