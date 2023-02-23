
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Pista_existeEvento) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class PistaCP : GenericBasicCP
{
public bool ExisteEvento (int p_oid, Nullable<DateTime> p_fecha)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Pista_existeEvento) ENABLED START*/

        PistaCEN pistaCEN = null;
        DiaSemanaCEN diaSemanaCEN = null;
        EventoCEN eventoCEN = null;

        bool result = false;


        try
        {
                CPSession.SessionInitializeTransaction ();
                pistaCEN = new PistaCEN (unitRepo.pistarepository);
                diaSemanaCEN = new DiaSemanaCEN (unitRepo.diasemanarepository);
                eventoCEN = new EventoCEN (unitRepo.eventorepository);
                unitRepo.pistarepository.setSessionCP (CPSession);


                // Write here your custom transaction ...

                if (p_fecha == null)
                        result = true;
                else{
                        TimeSpan time = p_fecha.Value.TimeOfDay;
                        DateTime inicio = new DateTime ().AddTicks (time.Ticks);
                        DayOfWeek dia = p_fecha.Value.DayOfWeek;
                        DiaSemanaEN d = null;

                        switch (dia) {
                        case DayOfWeek.Sunday:
                                d = diaSemanaCEN.Obtener ("Domingo").FirstOrDefault ();
                                break;

                        case DayOfWeek.Monday:
                                d = diaSemanaCEN.Obtener ("Lunes").FirstOrDefault ();
                                break;

                        case DayOfWeek.Tuesday:
                                d = diaSemanaCEN.Obtener ("Martes").FirstOrDefault ();
                                break;

                        case DayOfWeek.Wednesday:
                                d = diaSemanaCEN.Obtener ("Miércoles").FirstOrDefault ();
                                break;

                        case DayOfWeek.Thursday:
                                d = diaSemanaCEN.Obtener ("Jueves").FirstOrDefault ();
                                break;

                        case DayOfWeek.Friday:
                                d = diaSemanaCEN.Obtener ("Viernes").FirstOrDefault ();
                                break;

                        case DayOfWeek.Saturday:
                                d = diaSemanaCEN.Obtener ("Sábado").FirstOrDefault ();
                                break;
                        }

                        var eventos = eventoCEN.Obtenereventospista (p_oid, inicio, d.Iddiasemana);

                        result = eventos != null && eventos.Count > 0;
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
