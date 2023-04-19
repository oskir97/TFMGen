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


/*PROTECTED REGION ID(usingTFM_REST_AsitenciaControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Asitencia")]
public class AsitenciaController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Asitencia/Listartodos")]
public ActionResult<List<AsitenciaDTOA> > Listartodos ()
{
        // CAD, CEN, EN, returnValue
        AsitenciaRESTCAD asitenciaRESTCAD = null;
        AsitenciaCEN asitenciaCEN = null;

        List<AsitenciaEN> asitenciaEN = null;
        List<AsitenciaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                asitenciaCEN = new AsitenciaCEN (unitRepo.asitenciarepository);

                // Data
                // TODO: paginación

                asitenciaEN = asitenciaCEN.Listartodos (0, -1).ToList ();

                // Convert return
                if (asitenciaEN != null) {
                        returnValue = new List<AsitenciaDTOA>();
                        foreach (AsitenciaEN entry in asitenciaEN)
                                returnValue.Add (AsitenciaAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Asitencia/ObtenerAsistencias")]

public ActionResult<List<AsitenciaDTOA> > ObtenerAsistencias (int idUsuarioRegistrado)
{
        // CAD, EN
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioEN usuarioEN = null;

        // returnValue
        List<AsitenciaEN> en = null;
        List<AsitenciaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);


                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);

                // Exists UsuarioRegistrado
                usuarioEN = usuarioRegistradoRESTCAD.ReadOIDDefault (idUsuarioRegistrado);
                if (usuarioEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = usuarioRegistradoRESTCAD.ObtenerAsistencias (idUsuarioRegistrado).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<AsitenciaDTOA>();
                        foreach (AsitenciaEN entry in en)
                                returnValue.Add (AsitenciaAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Asitencia/ObtenerAsistenciasEvento")]

public ActionResult<List<AsitenciaDTOA> > ObtenerAsistenciasEvento (int idEvento)
{
        // CAD, EN
        EventoRESTCAD eventoRESTCAD = null;
        EventoEN eventoEN = null;

        // returnValue
        List<AsitenciaEN> en = null;
        List<AsitenciaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);


                eventoRESTCAD = new EventoRESTCAD (session);

                // Exists Evento
                eventoEN = eventoRESTCAD.ReadOIDDefault (idEvento);
                if (eventoEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = eventoRESTCAD.ObtenerAsistenciasEvento (idEvento).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<AsitenciaDTOA>();
                        foreach (AsitenciaEN entry in en)
                                returnValue.Add (AsitenciaAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idAsitencia}", Name="GetOIDAsitencia")]

[Route ("~/api/Asitencia/{idAsitencia}")]

public ActionResult<AsitenciaDTOA> Obtener (int idAsitencia)
{
        // CAD, CEN, EN, returnValue
        AsitenciaRESTCAD asitenciaRESTCAD = null;
        AsitenciaCEN asitenciaCEN = null;
        AsitenciaEN asitenciaEN = null;
        AsitenciaDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                asitenciaRESTCAD = new AsitenciaRESTCAD (session);
                asitenciaCEN = new AsitenciaCEN (unitRepo.asitenciarepository);

                // Data
                asitenciaEN = asitenciaCEN.Obtener (idAsitencia);

                // Convert return
                if (asitenciaEN != null) {
                        returnValue = AsitenciaAssembler.Convert (asitenciaEN, unitRepo, session);
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



// No pasa el slEnables: listar

[HttpGet]

[Route ("~/api/Asitencia/Listar")]

public ActionResult<System.Collections.Generic.List<AsitenciaDTOA> > Listar (int idusuario       )
{
        // CAD, CEN, EN, returnValue

        AsitenciaRESTCAD asitenciaRESTCAD = null;
        AsitenciaCEN asitenciaCEN = null;


        System.Collections.Generic.List<AsitenciaEN> en;

        System.Collections.Generic.List<AsitenciaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                asitenciaRESTCAD = new AsitenciaRESTCAD (session);
                asitenciaCEN = new AsitenciaCEN (unitRepo.asitenciarepository);

                // CEN return



                en = asitenciaCEN.Listar (idusuario).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<AsitenciaDTOA>();
                        foreach (AsitenciaEN entry in en)
                                returnValue.Add (AsitenciaAssembler.Convert (entry, unitRepo, session));
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





[HttpPost]

[Route ("~/api/Asitencia/Crear")]

public ActionResult<AsitenciaDTOA> Crear ( [FromBody] AsitenciaDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        AsitenciaRESTCAD asitenciaRESTCAD = null;
        AsitenciaCEN asitenciaCEN = null;
        AsitenciaDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                asitenciaRESTCAD = new AsitenciaRESTCAD (session);
                asitenciaCEN = new AsitenciaCEN (unitRepo.asitenciarepository);

                // Create
                returnOID = asitenciaCEN.Crear (

                        //Atributo OID: p_usuario
                        // attr.estaRelacionado: true
                        dto.Usuario_oid                 // association role

                        , dto.Fecha                                                                                                                                                      //Atributo Primitivo: p_fecha
                        , dto.Asiste                                                                                                                                                     //Atributo Primitivo: p_asiste
                        , dto.Notas                                                                                                                                                      //Atributo Primitivo: p_notas
                        );
                session.Commit ();

                // Convert return
                returnValue = AsitenciaAssembler.Convert (asitenciaRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Asitencia/Crear/" + returnOID, returnValue);
}





[HttpPut]

[Route ("~/api/Asitencia/Editar")]

public ActionResult<AsitenciaDTOA> Editar (int idAsitencia, [FromBody] AsitenciaDTO dto)
{
        // CAD, CEN, returnValue
        AsitenciaRESTCAD asitenciaRESTCAD = null;
        AsitenciaCEN asitenciaCEN = null;
        AsitenciaDTOA returnValue = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                asitenciaRESTCAD = new AsitenciaRESTCAD (session);
                asitenciaCEN = new AsitenciaCEN (unitRepo.asitenciarepository);

                // Modify
                asitenciaCEN.Editar (idAsitencia,
                        dto.Fecha
                        ,
                        dto.Asiste
                        ,
                        dto.Notas
                        );

                // Return modified object
                returnValue = AsitenciaAssembler.Convert (asitenciaRESTCAD.ReadOIDDefault (idAsitencia), unitRepo, session);

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

        // Return 404 - Not found
        if (returnValue == null)
                return StatusCode (404);
        // Return 200 - OK
        else return returnValue;
}




[HttpDelete]


[Route ("~/api/Asitencia/Eliminar")]

public ActionResult Eliminar (int p_asitencia_oid)
{
        // CAD, CEN
        AsitenciaRESTCAD asitenciaRESTCAD = null;
        AsitenciaCEN asitenciaCEN = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                asitenciaRESTCAD = new AsitenciaRESTCAD (session);
                asitenciaCEN = new AsitenciaCEN (unitRepo.asitenciarepository);

                asitenciaCEN.Eliminar (p_asitencia_oid);
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

        // Return 204 - No Content
        return StatusCode (204);
}









/*PROTECTED REGION ID(TFM_REST_AsitenciaControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
