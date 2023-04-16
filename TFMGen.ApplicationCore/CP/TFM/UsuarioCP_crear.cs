
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Usuario_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class UsuarioCP : GenericBasicCP
{
public TFMGen.ApplicationCore.EN.TFM.UsuarioEN Crear (string p_nombre, string p_email, string p_domicilio, string p_telefono, Nullable<DateTime> p_fechanacimiento, Nullable<DateTime> p_alta, string p_apellidos, String p_password, int p_rol, string p_codigopostal, string p_localidad, string p_provincia, string p_telefonoalternativo, int p_entidad)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Usuario_crear) ENABLED START*/

        UsuarioCEN usuarioCEN = null;

        TFMGen.ApplicationCore.EN.TFM.UsuarioEN result = null;


        try
        {
                CPSession.SessionInitializeTransaction ();
                usuarioCEN = new  UsuarioCEN (unitRepo.usuariorepository);

                if (usuarioCEN.Obtenerusuarioemail (p_email) != null)
                        throw new Exception ("El email ya existe");


                int oid;
                //Initialized UsuarioEN
                UsuarioEN usuarioEN;
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


                if (p_entidad != -1) {
                        usuarioEN.Entidad = new TFMGen.ApplicationCore.EN.TFM.EntidadEN ();
                        usuarioEN.Entidad.Identidad = p_entidad;
                }



                oid = usuarioCEN.get_IUsuarioRepository ().Crear (usuarioEN);

                result = usuarioCEN.get_IUsuarioRepository ().ReadOIDDefault (oid);



                CPSession.Commit ();
        }
        catch (Exception ex)
        {
                CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                CPSession.SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
