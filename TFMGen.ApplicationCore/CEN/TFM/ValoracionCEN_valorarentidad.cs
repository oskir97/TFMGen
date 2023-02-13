
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Valoracion_valorarentidad) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ValoracionCEN
{
public void Valorarentidad (TFMGen.ApplicationCore.EN.TFM.ValoracionEN p_valoracion, TFMGen.ApplicationCore.EN.TFM.EntidadEN p_entidad)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Valoracion_valorarentidad) ENABLED START*/

        p_valoracion.Entidad = p_entidad;

        _IValoracionRepository.Editar (p_valoracion);

        /*PROTECTED REGION END*/
}
}
}
