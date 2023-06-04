
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Valoracion_valorarevento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ValoracionCEN
{
public void Valorarevento (TFMGen.ApplicationCore.EN.TFM.ValoracionEN p_valoracion, TFMGen.ApplicationCore.EN.TFM.EventoEN p_evento)
{
            /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Valoracion_valorarevento) ENABLED START*/

            // Write here your custom code...

            p_valoracion.Evento = p_evento;

            _IValoracionRepository.Editar(p_valoracion);

            /*PROTECTED REGION END*/
        }
}
}
