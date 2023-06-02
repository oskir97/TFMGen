
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Incidencia_modificar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class IncidenciaCEN
{
public void Modificar (int p_Incidencia_OID, string p_asunto, string p_descripcion, Nullable<DateTime> p_fechacancelada, Nullable<DateTime> p_fechareemplazada)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Incidencia_modificar_customized) START*/

        IncidenciaEN incidenciaEN = null;

        //Initialized IncidenciaEN
        incidenciaEN = new IncidenciaEN ();
        incidenciaEN.Idincidencia = p_Incidencia_OID;
        incidenciaEN.Asunto = p_asunto;
        incidenciaEN.Descripcion = p_descripcion;
        incidenciaEN.Fechacancelada = p_fechacancelada;
        incidenciaEN.Fechareemplazada = p_fechareemplazada;
        //Call to IncidenciaRepository

        _IIncidenciaRepository.Modificar (incidenciaEN);

        /*PROTECTED REGION END*/
}
}
}
