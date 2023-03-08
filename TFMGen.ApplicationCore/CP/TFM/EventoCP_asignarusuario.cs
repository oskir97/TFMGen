
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Evento_asignarusuario) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class EventoCP : GenericBasicCP
{
public void Asignarusuario (int p_Evento_OID, System.Collections.Generic.IList<int> p_usuarios_OIDs)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Evento_asignarusuario) ENABLED START*/

        EventoCEN eventoCEN = null;



        try
        {
                // Write here your custom transaction ...

                CPSession.SessionInitializeTransaction ();
                eventoCEN = new  EventoCEN (unitRepo.eventorepository);

                EventoEN eventoEN = eventoCEN.Obtener (p_oid);

                eventoCEN.get_IEventoRepository ().Asignarusuario (p_Evento_OID, p_usuarios_OIDs);


                        eventoCEN.Editar (eventoEN.Idevento, eventoEN.Nombre, eventoEN.Descripcion, eventoEN.Usuarios, eventoEN.Tecnicos, eventoEN.Horarios, eventoEN.Activo, eventoEN.Plazas);
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


        /*PROTECTED REGION END*/
}
}
}
