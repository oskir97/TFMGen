
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Asitencia_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class AsitenciaCEN
{
public void Editar (int p_Asitencia_OID, Nullable<DateTime> p_fecha, bool p_asiste, string p_notas)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Asitencia_editar_customized) START*/

        AsitenciaEN asitenciaEN = null;

        //Initialized AsitenciaEN
        asitenciaEN = new AsitenciaEN ();
        asitenciaEN.Idasitencia = p_Asitencia_OID;
        asitenciaEN.Fecha = p_fecha;
        asitenciaEN.Asiste = p_asiste;
        asitenciaEN.Notas = p_notas;
        //Call to AsitenciaRepository

        _IAsitenciaRepository.Editar (asitenciaEN);

        /*PROTECTED REGION END*/
}
}
}
