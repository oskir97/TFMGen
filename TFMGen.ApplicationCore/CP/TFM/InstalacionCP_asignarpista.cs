
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Instalacion_asignarpista) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class InstalacionCP : GenericBasicCP
{
public void Asignarpista (int p_Instalacion_OID, System.Collections.Generic.IList<int> p_pistas_OIDs)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Instalacion_asignarpista) ENABLED START*/

        InstalacionCEN instalacionCEN = null;



        try
        {
                CPSession.SessionInitializeTransaction ();
                instalacionCEN = new  InstalacionCEN (unitRepo.instalacionrepository);







                instalacionCEN.get_IInstalacionRepository ().Asignarpista (p_Instalacion_OID, p_pistas_OIDs);



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


        /*PROTECTED REGION END*/
}
}
}
