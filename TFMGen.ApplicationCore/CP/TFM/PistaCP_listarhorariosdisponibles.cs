
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Pista_listarhorariosdisponibles) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class PistaCP : GenericBasicCP
{
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Listarhorariosdisponibles (int p_oid, Nullable<DateTime> p_fecha)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Pista_listarhorariosdisponibles) ENABLED START*/

        PistaCEN pistaCEN = null;

        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN>  result = null;


        try
        {
                CPSession.SessionInitializeTransaction ();
                pistaCEN = new  PistaCEN (unitRepo.pistarepository);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method Listarhorariosdisponibles() not yet implemented.");



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
