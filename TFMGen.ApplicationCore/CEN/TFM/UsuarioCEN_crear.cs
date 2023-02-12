
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Usuario_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class UsuarioCEN
{
public int Crear (string p_nombre, string p_email, string p_domicilio, string p_telefono, Nullable<DateTime> p_fechanacimiento, Nullable<DateTime> p_alta, string p_apellidos, String p_password, int p_rol, string p_codigopostal, string p_localidad, string p_provincia, string p_telefonoalternativo)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Usuario_crear_customized) START*/

        UsuarioEN usuarioEN = null;

        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nombre = p_nombre;

        usuarioEN.Email = p_email;

        usuarioEN.Domicilio = p_domicilio;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.Fechanacimiento = p_fechanacimiento;

        usuarioEN.Alta = p_alta;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_password);


        if (p_rol != -1) {
                usuarioEN.Rol = new TFMGen.ApplicationCore.EN.TFM.RolEN ();
                usuarioEN.Rol.Idrol = p_rol;
        }

        usuarioEN.Codigopostal = p_codigopostal;

        usuarioEN.Localidad = p_localidad;

        usuarioEN.Provincia = p_provincia;

        usuarioEN.Telefonoalternativo = p_telefonoalternativo;

        //Call to UsuarioRepository

        oid = _IUsuarioRepository.Crear (usuarioEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
