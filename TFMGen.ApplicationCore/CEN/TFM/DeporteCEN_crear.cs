
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Deporte_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class DeporteCEN
{
public int Crear (string p_nombre, string p_descripcion, string p_icono)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Deporte_crear_customized) START*/

        DeporteEN deporteEN = null;

        int oid;

        //Initialized DeporteEN
        deporteEN = new DeporteEN ();
        deporteEN.Nombre = p_nombre;

        deporteEN.Descripcion = p_descripcion;

        deporteEN.Icono = p_icono;

        //Call to DeporteRepository

        oid = _IDeporteRepository.Crear (deporteEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
