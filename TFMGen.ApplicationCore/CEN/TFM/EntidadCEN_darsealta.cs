
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Entidad_darsealta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class EntidadCEN
{
public void Darsealta (int p_oid, Nullable<DateTime> p_alta)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Entidad_darsealta) ENABLED START*/

        // Write here your custom code...

        EntidadEN entidadEN = null;

        entidadEN = _IEntidadRepository.Obtener (p_oid);
        entidadEN.Alta = p_alta;

        _IEntidadRepository.Editar (entidadEN);

        /*PROTECTED REGION END*/
}
}
}
