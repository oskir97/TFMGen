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


/*PROTECTED REGION ID(usingTFM_REST_HorarioControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Horario")]
public class HorarioController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Horario/Listartodos")]
public ActionResult<List<HorarioDTOA> > Listartodos ()
{
        // CAD, CEN, EN, returnValue
        HorarioRESTCAD horarioRESTCAD = null;
        HorarioCEN horarioCEN = null;

        List<HorarioEN> horarioEN = null;
        List<HorarioDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                horarioCEN = new HorarioCEN (unitRepo.horariorepository);

                // Data
                // TODO: paginación

                horarioEN = horarioCEN.Listartodos (0, -1).ToList ();

                // Convert return
                if (horarioEN != null) {
                        returnValue = new List<HorarioDTOA>();
                        foreach (HorarioEN entry in horarioEN)
                                returnValue.Add (HorarioAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idHorario}", Name="GetOIDHorario")]

[Route ("~/api/Horario/{idHorario}")]

public ActionResult<HorarioDTOA> Obtener (int idHorario)
{
        // CAD, CEN, EN, returnValue
        HorarioRESTCAD horarioRESTCAD = null;
        HorarioCEN horarioCEN = null;
        HorarioEN horarioEN = null;
        HorarioDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                horarioRESTCAD = new HorarioRESTCAD (session);
                horarioCEN = new HorarioCEN (unitRepo.horariorepository);

                // Data
                horarioEN = horarioCEN.Obtener (idHorario);

                // Convert return
                if (horarioEN != null) {
                        returnValue = HorarioAssembler.Convert (horarioEN, unitRepo, session);
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

[Route ("~/api/Horario/Listar")]

public ActionResult<System.Collections.Generic.List<HorarioDTOA> > Listar (int p_idpista)
{
        // CAD, CEN, EN, returnValue

        HorarioRESTCAD horarioRESTCAD = null;
        HorarioCEN horarioCEN = null;


        System.Collections.Generic.List<HorarioEN> en;

        System.Collections.Generic.List<HorarioDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                horarioRESTCAD = new HorarioRESTCAD (session);
                horarioCEN = new HorarioCEN (unitRepo.horariorepository);

                // CEN return



                en = horarioCEN.Listar (p_idpista).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<HorarioDTOA>();
                        foreach (HorarioEN entry in en)
                                returnValue.Add (HorarioAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Horario/Crear")]

public ActionResult<HorarioDTOA> Crear ( [FromBody] HorarioDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        HorarioRESTCAD horarioRESTCAD = null;
        HorarioCEN horarioCEN = null;
        HorarioDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                horarioRESTCAD = new HorarioRESTCAD (session);
                horarioCEN = new HorarioCEN (unitRepo.horariorepository);

                // Create
                returnOID = horarioCEN.Crear (
                        dto.Inicio                                                                               //Atributo Primitivo: p_inicio
                        , dto.Fin                                                                                                                                                //Atributo Primitivo: p_fin
                        ,
                        //Atributo OID: p_pista
                        // attr.estaRelacionado: true
                        dto.Pista_oid                 // association role

                        ,
                        //Atributo OID: p_diaSemana
                        // attr.estaRelacionado: true
                        dto.DiaSemana_oid                 // association role

                        );
                session.Commit ();

                // Convert return
                returnValue = HorarioAssembler.Convert (horarioRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Horario/Crear/" + returnOID, returnValue);
}





[HttpPut]

[Route ("~/api/Horario/Editar")]

public ActionResult<HorarioDTOA> Editar (int idHorario, [FromBody] HorarioDTO dto)
{
        // CAD, CEN, returnValue
        HorarioRESTCAD horarioRESTCAD = null;
        HorarioCEN horarioCEN = null;
        HorarioDTOA returnValue = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                horarioRESTCAD = new HorarioRESTCAD (session);
                horarioCEN = new HorarioCEN (unitRepo.horariorepository);

                // Modify
                horarioCEN.Editar (idHorario,
                        dto.Inicio
                        ,
                        dto.Fin,
                        dto.Pista_oid,
                        dto.DiaSemana_oid
                        );

                // Return modified object
                returnValue = HorarioAssembler.Convert (horarioRESTCAD.ReadOIDDefault (idHorario), unitRepo, session);

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


[Route ("~/api/Horario/Eliminar")]

public ActionResult Eliminar (int p_horario_oid)
{
        // CAD, CEN
        HorarioRESTCAD horarioRESTCAD = null;
        HorarioCEN horarioCEN = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                horarioRESTCAD = new HorarioRESTCAD (session);
                horarioCEN = new HorarioCEN (unitRepo.horariorepository);

                horarioCEN.Eliminar (p_horario_oid);
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









/*PROTECTED REGION ID(TFM_REST_HorarioControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
