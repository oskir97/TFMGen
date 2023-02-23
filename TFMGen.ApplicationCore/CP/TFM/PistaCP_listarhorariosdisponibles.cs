
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

        List<HorarioEN> horariosDisponibles = null;

        if (p_fecha.HasValue) {
                try
                {
                        CPSession.SessionInitializeTransaction ();
                        pistaCEN = new PistaCEN (unitRepo.pistarepository);
                        unitRepo.pistarepository.setSessionCP (CPSession);


                        // Write here your custom transaction ...

                        p_fecha = p_fecha < DateTime.Now ? DateTime.Now : p_fecha;

                        horariosDisponibles = new List<HorarioEN>();
                        PistaEN pista = pistaCEN.Obtener (p_oid);

                        if (pista != null) {
                                TimeSpan time = p_fecha.Value.TimeOfDay;
                                DateTime inicio = new DateTime ().AddTicks (time.Ticks);

                                foreach (var horario in pista.Horarios.Where (h => h.Inicio >= inicio)) {
                                        if (!this.ExisteReserva (p_oid, horario.Inicio) && !this.ExisteEvento (p_oid, horario.Inicio)) {
                                                horariosDisponibles.Add (horario);
                                        }
                                }
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
        }

        return horariosDisponibles;
        /*PROTECTED REGION END*/
}
}
}
