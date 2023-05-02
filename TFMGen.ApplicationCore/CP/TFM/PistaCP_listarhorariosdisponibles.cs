
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
        public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Listarhorariosdisponibles(int p_oid, Nullable<DateTime> p_fecha)
        {
            /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Pista_listarhorariosdisponibles) ENABLED START*/

            PistaCEN pistaCEN = null;
            ReservaCEN reservaCEN = null;
            DiaSemanaCEN diaSemanaCEN = null;
            EventoCEN eventoCEN = null;
            PistaCP pistaCP = null;

            List<HorarioEN> horariosDisponibles = null;

            if (p_fecha.HasValue)
            {
                try
                {
                    CPSession.SessionInitializeTransaction();
                    pistaCEN = new PistaCEN(unitRepo.pistarepository);
                    unitRepo.pistarepository.setSessionCP(CPSession);
                    reservaCEN = new ReservaCEN(unitRepo.reservarepository);
                    unitRepo.reservarepository.setSessionCP(CPSession);
                    diaSemanaCEN = new DiaSemanaCEN(unitRepo.diasemanarepository);
                    unitRepo.diasemanarepository.setSessionCP(CPSession);
                    eventoCEN = new EventoCEN(unitRepo.eventorepository);
                    unitRepo.eventorepository.setSessionCP(CPSession);

                    // Write here your custom transaction ...

                    p_fecha = p_fecha < DateTime.Now ? DateTime.Now : p_fecha;

                    horariosDisponibles = new List<HorarioEN>();
                    PistaEN pista = pistaCEN.Obtener(p_oid);

                    if (pista != null)
                    {
                        TimeSpan time = p_fecha.Value.TimeOfDay;
                        DateTime inicio = new DateTime().AddTicks(time.Ticks);

                        foreach (var horario in pista.Horarios.Where(h => h.Inicio >= inicio))
                        {
                            if (!ExisteReserva(p_oid, horario.Inicio, reservaCEN) && !ExisteEvento(p_oid, horario.Inicio,diaSemanaCEN, eventoCEN))
                            {
                                horariosDisponibles.Add(horario);
                            }
                        }
                    }

                    CPSession.Commit();
                }
                catch (Exception ex)
                {
                    CPSession.RollBack();
                    throw ex;
                }
                finally
                {
                    CPSession.SessionClose();
                }
            }

            return horariosDisponibles;
            /*PROTECTED REGION END*/
        }
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Pista_listarhorariosdisponibles) ENABLED START*/
        private bool ExisteReserva(int p_oid, Nullable<DateTime> p_fecha, ReservaCEN reservaCEN)
        {
            bool result;
            if (p_fecha == null)
                result = true;
            else
            {
                var reservas = reservaCEN.Obtenerreservaspista(p_oid, p_fecha);

                result = reservas != null && reservas.Count > 0;
            }

            return result;
        }

        public bool ExisteEvento(int p_oid, Nullable<DateTime> p_fecha, DiaSemanaCEN diaSemanaCEN, EventoCEN eventoCEN)
        {
            bool result;
            if (p_fecha == null)
                result = true;
            else
            {
                TimeSpan time = p_fecha.Value.TimeOfDay;
                DayOfWeek dia = p_fecha.Value.DayOfWeek;
                DiaSemanaEN d = null;

                switch (dia)
                {
                    case DayOfWeek.Sunday:
                        d = diaSemanaCEN.Obtener("Domingo").FirstOrDefault();
                        break;

                    case DayOfWeek.Monday:
                        d = diaSemanaCEN.Obtener("Lunes").FirstOrDefault();
                        break;

                    case DayOfWeek.Tuesday:
                        d = diaSemanaCEN.Obtener("Martes").FirstOrDefault();
                        break;

                    case DayOfWeek.Wednesday:
                        d = diaSemanaCEN.Obtener("Miércoles").FirstOrDefault();
                        break;

                    case DayOfWeek.Thursday:
                        d = diaSemanaCEN.Obtener("Jueves").FirstOrDefault();
                        break;

                    case DayOfWeek.Friday:
                        d = diaSemanaCEN.Obtener("Viernes").FirstOrDefault();
                        break;

                    case DayOfWeek.Saturday:
                        d = diaSemanaCEN.Obtener("Sábado").FirstOrDefault();
                        break;
                }

                var eventos = eventoCEN.Obtenereventospista(p_oid, p_fecha, d.Iddiasemana);

                result = eventos != null && eventos.Count > 0;
            }

            return result;
        }

        /*PROTECTED REGION END*/
    }
}
