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


/*PROTECTED REGION ID(usingTFM_REST_UsuarioRegistradoControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/UsuarioRegistrado")]
public class UsuarioRegistradoController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/UsuarioRegistrado/Listar")]
public ActionResult<List<UsuarioRegistradoDTOA> > Listar ()
{
        // CAD, CEN, EN, returnValue
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;

        List<UsuarioEN> usuarioEN = null;
        List<UsuarioRegistradoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);

                // Data
                // TODO: paginación

                usuarioEN = usuarioCEN.Listar (0, -1).ToList ();

                // Convert return
                if (usuarioEN != null) {
                        returnValue = new List<UsuarioRegistradoDTOA>();
                        foreach (UsuarioEN entry in usuarioEN)
                                returnValue.Add (UsuarioRegistradoAssembler.Convert (entry, unitRepo, session));
                }
        }

        catch (Exception e)
        {
                StatusCodeResult result = StatusCode (500);
                if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) result = StatusCode (403);
                else if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) || e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.DataLayerException)) result = StatusCode (400);
                return result;
        }
        finally
        {
                session.SessionClose ();
        }

        // Return 204 - Empty
        if (returnValue == null || returnValue.Count == 0)
                return StatusCode (204);
        // Return 200 - OK
        else return returnValue;
}









[HttpGet]
// [Route("{idUsuarioRegistrado}", Name="GetOIDUsuarioRegistrado")]

[Route ("~/api/UsuarioRegistrado/{idUsuarioRegistrado}")]

public ActionResult<UsuarioRegistradoDTOA> Obtener (int idUsuarioRegistrado)
{
        // CAD, CEN, EN, returnValue
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;
        UsuarioEN usuarioEN = null;
        UsuarioRegistradoDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);

                // Data
                usuarioEN = usuarioCEN.Obtener (idUsuarioRegistrado);

                // Convert return
                if (usuarioEN != null) {
                        returnValue = UsuarioRegistradoAssembler.Convert (usuarioEN, unitRepo, session);
                }
        }

        catch (Exception e)
        {
                StatusCodeResult result = StatusCode (500);
                if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) result = StatusCode (403);
                else if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) || e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.DataLayerException)) result = StatusCode (400);
                return result;
        }
        finally
        {
                session.SessionClose ();
        }

        // Return 204 - Empty
        if (returnValue == null)
                return StatusCode (204);
        // Return 200 - OK
        else return returnValue;
}





















/*PROTECTED REGION ID(TFM_REST_UsuarioRegistradoControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
