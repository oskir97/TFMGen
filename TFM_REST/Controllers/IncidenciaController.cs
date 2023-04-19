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


/*PROTECTED REGION ID(usingTFM_REST_IncidenciaControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Incidencia")]
public class IncidenciaController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Incidencia/Listartodas")]
public ActionResult<List<IncidenciaDTOA> > Listartodas ()
{
        // CAD, CEN, EN, returnValue
        IncidenciaRESTCAD incidenciaRESTCAD = null;
        IncidenciaCEN incidenciaCEN = null;

        List<IncidenciaEN> incidenciaEN = null;
        List<IncidenciaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                incidenciaCEN = new IncidenciaCEN (unitRepo.incidenciarepository);

                // Data
                // TODO: paginación

                incidenciaEN = incidenciaCEN.Listartodas (0, -1).ToList ();

                // Convert return
                if (incidenciaEN != null) {
                        returnValue = new List<IncidenciaDTOA>();
                        foreach (IncidenciaEN entry in incidenciaEN)
                                returnValue.Add (IncidenciaAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Incidencia/ObtenerIncidencias")]

public ActionResult<List<IncidenciaDTOA> > ObtenerIncidencias (int idEvento)
{
        // CAD, EN
        EventoRESTCAD eventoRESTCAD = null;
        EventoEN eventoEN = null;

        // returnValue
        List<IncidenciaEN> en = null;
        List<IncidenciaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                eventoRESTCAD = new EventoRESTCAD (session);

                // Exists Evento
                eventoEN = eventoRESTCAD.ReadOIDDefault (idEvento);
                if (eventoEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = eventoRESTCAD.ObtenerIncidencias (idEvento).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<IncidenciaDTOA>();
                        foreach (IncidenciaEN entry in en)
                                returnValue.Add (IncidenciaAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idIncidencia}", Name="GetOIDIncidencia")]

[Route ("~/api/Incidencia/{idIncidencia}")]

public ActionResult<IncidenciaDTOA> Obtener (int idIncidencia)
{
        // CAD, CEN, EN, returnValue
        IncidenciaRESTCAD incidenciaRESTCAD = null;
        IncidenciaCEN incidenciaCEN = null;
        IncidenciaEN incidenciaEN = null;
        IncidenciaDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                incidenciaRESTCAD = new IncidenciaRESTCAD (session);
                incidenciaCEN = new IncidenciaCEN (unitRepo.incidenciarepository);

                // Data
                incidenciaEN = incidenciaCEN.Obtener (idIncidencia);

                // Convert return
                if (incidenciaEN != null) {
                        returnValue = IncidenciaAssembler.Convert (incidenciaEN, unitRepo, session);
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

[Route ("~/api/Incidencia/Listar")]

public ActionResult<System.Collections.Generic.List<IncidenciaDTOA> > Listar (int p_idevento)
{
        // CAD, CEN, EN, returnValue

        IncidenciaRESTCAD incidenciaRESTCAD = null;
        IncidenciaCEN incidenciaCEN = null;


        System.Collections.Generic.List<IncidenciaEN> en;

        System.Collections.Generic.List<IncidenciaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                incidenciaRESTCAD = new IncidenciaRESTCAD (session);
                incidenciaCEN = new IncidenciaCEN (unitRepo.incidenciarepository);

                // CEN return



                en = incidenciaCEN.Listar (p_idevento).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<IncidenciaDTOA>();
                        foreach (IncidenciaEN entry in en)
                                returnValue.Add (IncidenciaAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Incidencia/Crear")]

public ActionResult<IncidenciaDTOA> Crear ( [FromBody] IncidenciaDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        IncidenciaRESTCAD incidenciaRESTCAD = null;
        IncidenciaCEN incidenciaCEN = null;
        IncidenciaDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();


                incidenciaRESTCAD = new IncidenciaRESTCAD (session);
                incidenciaCEN = new IncidenciaCEN (unitRepo.incidenciarepository);

                // Create
                returnOID = incidenciaCEN.Crear (

                        //Atributo OID: p_usuario
                        // attr.estaRelacionado: true
                        dto.Usuario_oid                 // association role

                        ,
                        //Atributo OID: p_evento
                        // attr.estaRelacionado: true
                        dto.Evento_oid                 // association role

                        , dto.Asunto                                                                                                                                                     //Atributo Primitivo: p_asunto
                        , dto.Descripcion                                                                                                                                                //Atributo Primitivo: p_descripcion
                        , dto.Fechacancelada                                                                                                                                                     //Atributo Primitivo: p_fechacancelada
                        , dto.Fechareemplazada                                                                                                                                                   //Atributo Primitivo: p_fechareemplazada
                        );
                session.Commit ();

                // Convert return
                returnValue = IncidenciaAssembler.Convert (incidenciaRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Incidencia/Crear/" + returnOID, returnValue);
}




[HttpPut]

[Route ("~/api/Incidencia/Modificar")]

public ActionResult<IncidenciaDTOA> Modificar (int idIncidencia, [FromBody] IncidenciaDTO dto)
{
        // CAD, CEN, returnValue
        IncidenciaRESTCAD incidenciaRESTCAD = null;
        IncidenciaCEN incidenciaCEN = null;
        IncidenciaDTOA returnValue = null;

        try
        {
                session.SessionInitializeTransaction ();


                incidenciaRESTCAD = new IncidenciaRESTCAD (session);
                incidenciaCEN = new IncidenciaCEN (unitRepo.incidenciarepository);

                // Modify
                incidenciaCEN.Modificar (idIncidencia,
                        dto.Asunto
                        ,
                        dto.Descripcion
                        ,
                        dto.Fechacancelada
                        );

                // Return modified object
                returnValue = IncidenciaAssembler.Convert (incidenciaRESTCAD.ReadOIDDefault (idIncidencia), unitRepo, session);

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


[Route ("~/api/Incidencia/Eliminar")]

public ActionResult Eliminar (int p_incidencia_oid)
{
        // CAD, CEN
        IncidenciaRESTCAD incidenciaRESTCAD = null;
        IncidenciaCEN incidenciaCEN = null;

        try
        {
                session.SessionInitializeTransaction ();


                incidenciaRESTCAD = new IncidenciaRESTCAD (session);
                incidenciaCEN = new IncidenciaCEN (unitRepo.incidenciarepository);

                incidenciaCEN.Eliminar (p_incidencia_oid);
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









/*PROTECTED REGION ID(TFM_REST_IncidenciaControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
