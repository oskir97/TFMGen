
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Instalacion_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class InstalacionCEN
{
public void Editar (int p_Instalacion_OID, string p_nombre, string p_telefono, string p_domicilio, string p_ubicacion, string p_codigopostal, string p_localidad, string p_provincia, string p_telefonoalternativo, double p_latitud, double p_longitud, string p_email, string p_imagen)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Instalacion_editar_customized) START*/

        InstalacionEN instalacionEN = null;

        //Initialized InstalacionEN
        instalacionEN = new InstalacionEN ();
        instalacionEN.Idinstalacion = p_Instalacion_OID;
        instalacionEN.Nombre = p_nombre;
        instalacionEN.Telefono = p_telefono;
        instalacionEN.Domicilio = p_domicilio;
        instalacionEN.Ubicacion = p_ubicacion;
        instalacionEN.Codigopostal = p_codigopostal;
        instalacionEN.Localidad = p_localidad;
        instalacionEN.Provincia = p_provincia;
        instalacionEN.Telefonoalternativo = p_telefonoalternativo;
        instalacionEN.Latitud = p_latitud;
        instalacionEN.Longitud = p_longitud;
        instalacionEN.Email = p_email;
            instalacionEN.Imagen = p_imagen;
        //Call to InstalacionRepository

        _IInstalacionRepository.Editar (instalacionEN);

        /*PROTECTED REGION END*/
}
}
}
