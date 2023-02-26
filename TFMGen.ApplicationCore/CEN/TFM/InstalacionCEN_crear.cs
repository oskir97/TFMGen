
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Instalacion_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class InstalacionCEN
{
public int Crear (string p_nombre, int p_entidad, string p_telefono, string p_domicilio, string p_ubicacion, string p_codigopostal, string p_localidad, string p_provincia, string p_telefonoalternativo, bool p_visible)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Instalacion_crear_customized) ENABLED START*/

        if (!string.IsNullOrEmpty (p_nombre)) {
                InstalacionEN instalacionEN = null;

                int oid;

                //Initialized InstalacionEN
                instalacionEN = new InstalacionEN ();
                instalacionEN.Nombre = p_nombre;


                if (p_entidad != -1) {
                        instalacionEN.Entidad = new TFMGen.ApplicationCore.EN.TFM.EntidadEN ();
                        instalacionEN.Entidad.Identidad = p_entidad;
                }

                instalacionEN.Telefono = p_telefono;

                instalacionEN.Domicilio = p_domicilio;

                instalacionEN.Ubicacion = p_ubicacion;

                instalacionEN.Codigopostal = p_codigopostal;

                instalacionEN.Localidad = p_localidad;

                instalacionEN.Provincia = p_provincia;

                instalacionEN.Telefonoalternativo = p_telefonoalternativo;

                instalacionEN.Visible = p_visible;

                //Call to InstalacionRepository

                oid = _IInstalacionRepository.Crear (instalacionEN);
                return oid;
        }
        else{
                return -1;
        }
        /*PROTECTED REGION END*/
}
}
}
