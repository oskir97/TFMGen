
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Pista_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class PistaCEN
{
public void Editar (int p_Pista_OID, string p_nombre, int p_maxreservas, string p_ubicacion)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Pista_editar_customized) START*/

        PistaEN pistaEN = null;

        //Initialized PistaEN
        pistaEN = new PistaEN ();
        pistaEN.Idpista = p_Pista_OID;
        pistaEN.Nombre = p_nombre;
        pistaEN.Maxreservas = p_maxreservas;
        pistaEN.Ubicacion = p_ubicacion;
        //Call to PistaRepository

        _IPistaRepository.Editar (pistaEN);

        /*PROTECTED REGION END*/
}
}
}
