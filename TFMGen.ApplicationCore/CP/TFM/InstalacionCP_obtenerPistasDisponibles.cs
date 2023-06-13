
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Instalacion_obtenerPistasDisponibles) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class InstalacionCP : GenericBasicCP
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> ObtenerPistasDisponibles (int p_oid, Nullable<DateTime> p_fecha, bool notClose)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Instalacion_obtenerPistasDisponibles) ENABLED START*/

        InstalacionCEN instalacionCEN = null;
        PistaCP pistaCP = null;

        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN>  result = null;


        try
        {
                if (!notClose)
                        CPSession.SessionInitializeTransaction ();

                instalacionCEN = new  InstalacionCEN (unitRepo.instalacionrepository);
                pistaCP = new PistaCP (CPSession, unitRepo);
                unitRepo.instalacionrepository.setSessionCP (CPSession);
                unitRepo.pistarepository.setSessionCP (CPSession);



                var pistas = instalacionCEN.Obtener (p_oid).Pistas.ToList ();

                foreach (var pista in pistas) {
                        var horariosDisponibles = pistaCP.Listarhorariosdisponibles (pista.Idpista, p_fecha, true);

                        if (horariosDisponibles != null && horariosDisponibles.Count () > 0) {
                                result.Add (pista);
                        }
                }

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
