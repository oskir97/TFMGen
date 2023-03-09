
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Usuario_cambiarrol) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class UsuarioCP : GenericBasicCP
{
public void Cambiarrol (int p_Usuario_OID, int p_rol_OID)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Usuario_cambiarrol) ENABLED START*/

        UsuarioCEN usuarioCEN = null;



        try
        {
                CPSession.SessionInitializeTransaction ();
                unitRepo.usuariorepository.setSessionCP (CPSession);
                usuarioCEN = new  UsuarioCEN (unitRepo.usuariorepository);







                usuarioCEN.get_IUsuarioRepository ().Cambiarrol (p_Usuario_OID, p_rol_OID);



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
