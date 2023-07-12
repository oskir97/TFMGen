
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Usuario_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class UsuarioCP : GenericBasicCP
{
public void Editar (int p_Usuario_OID, string p_nombre, string p_email, string p_domicilio, string p_telefono, Nullable<DateTime> p_fechanacimiento, Nullable<DateTime> p_alta, string p_apellidos, String p_password, string p_codigopostal, string p_localidad, string p_provincia, int p_entidad, string p_numero, string p_imagen, string p_telefonoAlternativo)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Usuario_editar) ENABLED START*/

        UsuarioCEN usuarioCEN = null;



        try
        {
                CPSession.SessionInitializeTransaction ();
                usuarioCEN = new  UsuarioCEN (unitRepo.usuariorepository);

                var usuarioEmail = usuarioCEN.Obtenerusuarioemail (p_email);
                if (usuarioCEN.Obtenerusuarioemail (p_email) != null && usuarioEmail.Idusuario != p_Usuario_OID)
                        throw new Exception ("El email ya existe");

                UsuarioEN usuarioEN = usuarioCEN.Obtenerusuario (p_Usuario_OID);
                if (usuarioEN == null)
                        throw new Exception ("El usuario no existe");


                //Initialized UsuarioEN
                usuarioEN.Idusuario = p_Usuario_OID;
                usuarioEN.Nombre = p_nombre;
                usuarioEN.Email = p_email;
                usuarioEN.Domicilio = p_domicilio;
                usuarioEN.Telefono = p_telefono;
                usuarioEN.Telefonoalternativo = p_telefonoAlternativo;
                usuarioEN.Fechanacimiento = p_fechanacimiento;

                if(p_alta.HasValue)
                    usuarioEN.Alta = p_alta;

                usuarioEN.Apellidos = p_apellidos;
                usuarioEN.Numero = p_numero;

                if (!string.IsNullOrEmpty (p_password)) {
                        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_password);
                }
                usuarioEN.Imagen = p_imagen;
                usuarioEN.Codigopostal = p_codigopostal;
                usuarioEN.Localidad = p_localidad;
                usuarioEN.Provincia = p_provincia;
                if (p_entidad != -1) {
                        usuarioEN.Entidad = new EntidadEN ();
                        usuarioEN.Entidad.Identidad = p_entidad;
                }
                else
                        usuarioEN.Entidad = null;
                usuarioCEN.get_IUsuarioRepository ().Editar (usuarioEN);


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


        /*PROTECTED REGION END*/
}
}
}
