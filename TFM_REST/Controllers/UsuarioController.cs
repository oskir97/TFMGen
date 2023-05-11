using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TFM_REST.DTO;
using TFM_REST.DTOA;
using TFM_REST.CAD;
using TFM_REST.Assemblers;
using TFM_REST.AssemblersDTO;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.CP.TFM;


/*PROTECTED REGION ID(usingTFM_REST_UsuarioControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Usuario")]
public class UsuarioController : BasicController
{
// Voy a generar el readAll









/*PROTECTED REGION ID(TFM_REST_UsuarioControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs


[HttpPost]


[Route ("~/api/Usuario/Crear")]



public ActionResult<UsuarioDTOA> Crear ( [FromBody] UsuarioDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        UsuarioCP usuarioCP = null;
        RolCEN rolCEN = null;
        UsuarioDTOA returnValue = null;
        UsuarioEN returnOID = null;

        try
        {
                session.SessionInitializeTransaction ();


                usuarioCP = new UsuarioCP (session, unitRepo);
                rolCEN = new RolCEN (unitRepo.rolrepository);

                // Create
                returnOID = usuarioCP.Crear (
                        dto.Nombre
                        , dto.Email
                        , dto.Domicilio
                        , dto.Telefono
                        , dto.Fechanacimiento
                        , DateTime.Now
                        , dto.Apellidos
                        , dto.Password
                        , rolCEN.Listar (0, -1).Where (r => r.Nombre == "Usuario").Select (r => r.Idrol).FirstOrDefault ()
                        , dto.Codigopostal
                        , dto.Localidad
                        , dto.Provincia
                        , dto.Telefonoalternativo
                        , dto.Idusuario
                        );
                session.Commit ();

                // Convert return
                returnValue = UsuarioAssembler.Convert (returnOID, unitRepo, session);
        }

        catch (Exception e)
        {
                session.RollBack ();

                StatusCodeResult result = StatusCode (500);
                if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) result = StatusCode (403);
                else if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) || e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.DataLayerException)) result = StatusCode (400);
                return result;
        }
        finally
        {
                session.SessionClose ();
        }



        return Created ("~/api/Usuario/Crear/" + returnOID, returnValue);
}


[HttpPost]

[Route ("~/api/Usuario/Login")]


public ActionResult<string> Login ( [FromBody] UsuarioDTO dto)
{
        // CAD, CEN, returnValue
        UsuarioRESTCAD usuarioRESTCAD = null;
        UsuarioCEN usuarioCEN = null;
        string token = null;

        try
        {
                session.SessionInitializeTransaction ();
                usuarioRESTCAD = new UsuarioRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);


                // Operation
                token = usuarioCEN.Login (
                        dto.Email
                        , dto.Password
                        );

                session.Commit ();
        }

        catch (Exception e)
        {
                session.RollBack ();

                StatusCodeResult result = StatusCode (500);
                if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) result = StatusCode (403);
                else if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) || e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.DataLayerException)) result = StatusCode (400);
                return result;
        }
        finally
        {
                session.SessionClose ();
        }

        // Return 200 - OK
        if (token != null)
                return token;
        else
                return StatusCode (403);
}
/*PROTECTED REGION END*/
}
}
