
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Asitencia_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class AsitenciaCEN
{
public int Crear (int p_usuario, Nullable<DateTime> p_fecha, bool p_asiste, string p_notas)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Asitencia_crear_customized) ENABLED START*/

        AsitenciaEN asitenciaEN = null;

        int oid;

        //Initialized AsitenciaEN
        asitenciaEN = new AsitenciaEN ();

        if (p_usuario != -1) {
                asitenciaEN.Usuario = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN ();
                asitenciaEN.Usuario.Idusuario = p_usuario;
        }

        asitenciaEN.Fecha = p_fecha;

        asitenciaEN.Asiste = p_asiste;

        asitenciaEN.Notas = p_notas;

        //Call to AsitenciaRepository

        oid = _IAsitenciaRepository.Crear (asitenciaEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
