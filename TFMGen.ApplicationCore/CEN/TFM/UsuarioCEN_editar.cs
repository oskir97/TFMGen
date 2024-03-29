
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Usuario_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class UsuarioCEN
{
public void Editar (int p_Usuario_OID, string p_nombre, string p_email, string p_domicilio, string p_telefono, Nullable<DateTime> p_fechanacimiento, Nullable<DateTime> p_alta, string p_apellidos, String p_password, string p_codigopostal, string p_localidad, string p_provincia, int p_entidad)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Usuario_editar_customized) ENABLED START*/

        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Idusuario = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Email = p_email;
        usuarioEN.Domicilio = p_domicilio;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.Fechanacimiento = p_fechanacimiento;
        usuarioEN.Alta = p_alta;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        usuarioEN.Codigopostal = p_codigopostal;
        usuarioEN.Localidad = p_localidad;
        usuarioEN.Provincia = p_provincia;
        if (p_entidad != -1) {
                usuarioEN.Entidad = new EntidadEN ();
                usuarioEN.Entidad.Identidad = p_entidad;
        }
        else
                usuarioEN.Entidad = null;
        //Call to UsuarioRepository

        _IUsuarioRepository.Editar (usuarioEN);

        /*PROTECTED REGION END*/
}
}
}
