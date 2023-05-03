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


/*PROTECTED REGION ID(usingTFM_REST_EventoControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Evento")]
public class EventoController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Evento/Listartodos")]
public ActionResult<List<EventoDTOA> > Listartodos ()
{
        // CAD, CEN, EN, returnValue
        EventoRESTCAD eventoRESTCAD = null;
        EventoCEN eventoCEN = null;

        List<EventoEN> eventoEN = null;
        List<EventoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                eventoCEN = new EventoCEN (unitRepo.eventorepository);

                // Data
                // TODO: paginación

                eventoEN = eventoCEN.Listartodos (0, -1).ToList ();

                // Convert return
                if (eventoEN != null) {
                        returnValue = new List<EventoDTOA>();
                        foreach (EventoEN entry in eventoEN)
                                returnValue.Add (EventoAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Evento/ObtenerEventosImpartidos")]

public ActionResult<List<EventoDTOA> > ObtenerEventosImpartidos (int idUsuarioRegistrado)
{
        // CAD, EN
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioEN usuarioEN = null;

        // returnValue
        List<EventoEN> en = null;
        List<EventoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);

                // Exists UsuarioRegistrado
                usuarioEN = usuarioRegistradoRESTCAD.ReadOIDDefault (idUsuarioRegistrado);
                if (usuarioEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = usuarioRegistradoRESTCAD.ObtenerEventosImpartidos (idUsuarioRegistrado).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<EventoDTOA>();
                        foreach (EventoEN entry in en)
                                returnValue.Add (EventoAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Evento/ObtenerEventosInscrito")]

public ActionResult<List<EventoDTOA> > ObtenerEventosInscrito (int idUsuarioRegistrado)
{
        // CAD, EN
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioEN usuarioEN = null;

        // returnValue
        List<EventoEN> en = null;
        List<EventoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);

                // Exists UsuarioRegistrado
                usuarioEN = usuarioRegistradoRESTCAD.ReadOIDDefault (idUsuarioRegistrado);
                if (usuarioEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = usuarioRegistradoRESTCAD.ObtenerEventosInscrito (idUsuarioRegistrado).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<EventoDTOA>();
                        foreach (EventoEN entry in en)
                                returnValue.Add (EventoAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idEvento}", Name="GetOIDEvento")]

[Route ("~/api/Evento/{idEvento}")]

public ActionResult<EventoDTOA> Obtener (int idEvento)
{
        // CAD, CEN, EN, returnValue
        EventoRESTCAD eventoRESTCAD = null;
        EventoCEN eventoCEN = null;
        EventoEN eventoEN = null;
        EventoDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                eventoRESTCAD = new EventoRESTCAD (session);
                eventoCEN = new EventoCEN (unitRepo.eventorepository);

                // Data
                eventoEN = eventoCEN.Obtener (idEvento);

                // Convert return
                if (eventoEN != null) {
                        returnValue = EventoAssembler.Convert (eventoEN, unitRepo, session);
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

[Route ("~/api/Evento/Listar")]

public ActionResult<System.Collections.Generic.List<EventoDTOA> > Listar (int p_idusuario)
{
        // CAD, CEN, EN, returnValue

        EventoRESTCAD eventoRESTCAD = null;
        EventoCEN eventoCEN = null;


        System.Collections.Generic.List<EventoEN> en;

        System.Collections.Generic.List<EventoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                eventoRESTCAD = new EventoRESTCAD (session);
                eventoCEN = new EventoCEN (unitRepo.eventorepository);

                // CEN return



                en = eventoCEN.Listar (p_idusuario).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<EventoDTOA>();
                        foreach (EventoEN entry in en)
                                returnValue.Add (EventoAssembler.Convert (entry, unitRepo, session));
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


// No pasa el slEnables: listarentidad

[HttpGet]

[Route ("~/api/Evento/Listarentidad")]

public ActionResult<System.Collections.Generic.List<EventoDTOA> > Listarentidad (int p_identidad)
{
        // CAD, CEN, EN, returnValue

        EventoRESTCAD eventoRESTCAD = null;
        EventoCEN eventoCEN = null;


        System.Collections.Generic.List<EventoEN> en;

        System.Collections.Generic.List<EventoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                eventoRESTCAD = new EventoRESTCAD (session);
                eventoCEN = new EventoCEN (unitRepo.eventorepository);

                // CEN return



                en = eventoCEN.Listarentidad (p_identidad).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<EventoDTOA>();
                        foreach (EventoEN entry in en)
                                returnValue.Add (EventoAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Evento/Crear")]


public ActionResult<EventoDTOA> Crear ( [FromBody] EventoDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        EventoRESTCAD eventoRESTCAD = null;
        EventoCEN eventoCEN = null;
        EventoDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();


                eventoRESTCAD = new EventoRESTCAD (session);
                eventoCEN = new EventoCEN (unitRepo.eventorepository);

                // Create
                returnOID = eventoCEN.Crear (
                        dto.Nombre                                                                               //Atributo Primitivo: p_nombre
                        , dto.Descripcion                                                                                                                                                //Atributo Primitivo: p_descripcion
                        ,
                        //Atributo OID: p_entidad
                        // attr.estaRelacionado: true
                        dto.Entidad_oid                 // association role

                        ,
                        //Atributo OID: p_horarios
                        // attr.estaRelacionado: true
                        dto.Horarios_oid                 // association role

                        ,
                        //Atributo OID: p_diasSemana
                        // attr.estaRelacionado: true
                        dto.DiasSemana_oid                 // association role

                        , dto.Activo                                                                                                                                                     //Atributo Primitivo: p_activo
                        , dto.Plazas                                                                                                                                                     //Atributo Primitivo: p_plazas
                        );
                session.Commit ();

                // Convert return
                returnValue = EventoAssembler.Convert (eventoRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Evento/Crear/" + returnOID, returnValue);
}




[HttpDelete]


[Route ("~/api/Evento/Eliminar")]

public ActionResult Eliminar (int p_evento_oid)
{
        // CAD, CEN
        EventoRESTCAD eventoRESTCAD = null;
        EventoCEN eventoCEN = null;

        try
        {
                session.SessionInitializeTransaction ();


                eventoRESTCAD = new EventoRESTCAD (session);
                eventoCEN = new EventoCEN (unitRepo.eventorepository);

                eventoCEN.Eliminar (p_evento_oid);
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






/*PROTECTED REGION ID(TFM_REST_EventoControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs

[HttpPut]

[Route ("~/api/Evento/Editar")]

public ActionResult<EventoDTOA> Editar (int idEvento, [FromBody] EventoDTO dto)
{
        // CAD, CEN, returnValue
        EventoRESTCAD eventoRESTCAD = null;
        EventoCEN eventoCEN = null;
        EventoDTOA returnValue = null;
        UsuarioCEN usuarioCEN = null;
        HorarioCEN horarioCEN = null;

        try
        {
                session.SessionInitializeTransaction ();


                eventoRESTCAD = new EventoRESTCAD (session);
                eventoCEN = new EventoCEN (unitRepo.eventorepository);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);
                horarioCEN = new HorarioCEN (unitRepo.horariorepository);

                List<UsuarioEN> usuarios = new List<UsuarioEN>();
                List<UsuarioEN> tecnicos = new List<UsuarioEN>();
                List<HorarioEN> horarios = new List<HorarioEN>();

                if (dto.Usuarios_oid != null) {
                        foreach (var idusuario in dto.Usuarios_oid) {
                                usuarios.Add (usuarioCEN.Obtener (idusuario));
                        }
                }

                if (dto.Tecnicos_oid != null) {
                        foreach (var idtecnico in dto.Tecnicos_oid) {
                                tecnicos.Add (usuarioCEN.Obtener (idtecnico));
                        }
                }

                if (dto.Horarios_oid != null) {
                        foreach (var idhorario in dto.Horarios_oid) {
                                horarios.Add (horarioCEN.Obtener (idhorario));
                        }
                }

                // Modify
                eventoCEN.Editar (idEvento,
                        dto.Nombre
                        ,
                        dto.Descripcion
                        ,
                        usuarios
                        ,
                        tecnicos
                        ,
                        horarios
                        ,
                        dto.Activo
                        ,
                        dto.Plazas
                        );

                // Return modified object
                returnValue = EventoAssembler.Convert (eventoRESTCAD.ReadOIDDefault (idEvento), unitRepo, session);

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

[HttpPut]

[Route ("~/api/Evento/Asignarusuario")]

public ActionResult Asignarusuario (int p_evento_oid, System.Collections.Generic.IList<int> p_usuarios_oids)
{
        // CAD, CEN, returnValue
        EventoRESTCAD eventoRESTCAD = null;
        EventoCP eventoCP = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();


                eventoRESTCAD = new EventoRESTCAD (session);
                eventoCP = new EventoCP (session, unitRepo);

                // Relationer
                eventoCP.Asignarusuario (p_evento_oid, p_usuarios_oids);
                session.Commit ();
                result = StatusCode (200);
        }

        catch (Exception e)
        {
                session.RollBack ();

                result = StatusCode (500);
                if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) result = StatusCode (403);
                else if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) || e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.DataLayerException)) result = StatusCode (400);
        }
        finally
        {
                session.SessionClose ();
        }

        // Return 200 - OK
        return result;
}
/*PROTECTED REGION END*/
}
}
