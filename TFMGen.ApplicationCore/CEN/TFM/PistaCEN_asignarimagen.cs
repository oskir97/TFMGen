
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Pista_asignarimagen) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class PistaCEN
{
public void Asignarimagen (int p_oid, string p_imagen)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Pista_asignarimagen) ENABLED START*/

        // Write here your custom code...

        PistaEN pistaEN = null;

        pistaEN = _IPistaRepository.Obtener (p_oid);
        pistaEN.Imagen = p_imagen;

        _IPistaRepository.Editar (pistaEN);

        /*PROTECTED REGION END*/
}
}
}
