
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Deporte_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class DeporteCEN
{
public void Editar (int p_Deporte_OID, string p_nombre, string p_descripcion, string p_icono)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Deporte_editar_customized) START*/

        DeporteEN deporteEN = null;

        //Initialized DeporteEN
        deporteEN = new DeporteEN ();
        deporteEN.Iddeporte = p_Deporte_OID;
        deporteEN.Nombre = p_nombre;
        deporteEN.Descripcion = p_descripcion;
        deporteEN.Icono = p_icono;
        //Call to DeporteRepository

        _IDeporteRepository.Editar (deporteEN);

        /*PROTECTED REGION END*/
}
}
}
