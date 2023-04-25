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


/*PROTECTED REGION ID(usingTFM_REST_NotificacionControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Notificacion")]
public class NotificacionController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Notificacion/Listartodas")]
public ActionResult<List<NotificacionDTOA> > Listartodas ()
{
        // CAD, CEN, EN, returnValue
        NotificacionRESTCAD notificacionRESTCAD = null;
        NotificacionCEN notificacionCEN = null;

        List<NotificacionEN> notificacionEN = null;
        List<NotificacionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                notificacionCEN = new NotificacionCEN (unitRepo.notificacionrepository);

                // Data
                // TODO: paginación

                notificacionEN = notificacionCEN.Listartodas (0, -1).ToList ();

                // Convert return
                if (notificacionEN != null) {
                        returnValue = new List<NotificacionDTOA>();
                        foreach (NotificacionEN entry in notificacionEN)
                                returnValue.Add (NotificacionAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Notificacion/ObtenerNotificacionesEnviadas")]

public ActionResult<List<NotificacionDTOA> > ObtenerNotificacionesEnviadas (int idUsuarioRegistrado)
{
        // CAD, EN
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioEN usuarioEN = null;

        // returnValue
        List<NotificacionEN> en = null;
        List<NotificacionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);

                // Exists UsuarioRegistrado
                usuarioEN = usuarioRegistradoRESTCAD.ReadOIDDefault (idUsuarioRegistrado);
                if (usuarioEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = usuarioRegistradoRESTCAD.ObtenerNotificacionesEnviadas (idUsuarioRegistrado).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<NotificacionDTOA>();
                        foreach (NotificacionEN entry in en)
                                returnValue.Add (NotificacionAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Notificacion/ObtenerNotificacionesRecibidas")]

public ActionResult<List<NotificacionDTOA> > ObtenerNotificacionesRecibidas (int idUsuarioRegistrado)
{
        // CAD, EN
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioEN usuarioEN = null;

        // returnValue
        List<NotificacionEN> en = null;
        List<NotificacionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);

                // Exists UsuarioRegistrado
                usuarioEN = usuarioRegistradoRESTCAD.ReadOIDDefault (idUsuarioRegistrado);
                if (usuarioEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = usuarioRegistradoRESTCAD.ObtenerNotificacionesRecibidas (idUsuarioRegistrado).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<NotificacionDTOA>();
                        foreach (NotificacionEN entry in en)
                                returnValue.Add (NotificacionAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Notificacion/ObtenerNotificacionesEntidad")]

public ActionResult<List<NotificacionDTOA> > ObtenerNotificacionesEntidad (int idEntidad)
{
        // CAD, EN
        EntidadRESTCAD entidadRESTCAD = null;
        EntidadEN entidadEN = null;

        // returnValue
        List<NotificacionEN> en = null;
        List<NotificacionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                entidadRESTCAD = new EntidadRESTCAD (session);

                // Exists Entidad
                entidadEN = entidadRESTCAD.ReadOIDDefault (idEntidad);
                if (entidadEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = entidadRESTCAD.ObtenerNotificacionesEntidad (idEntidad).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<NotificacionDTOA>();
                        foreach (NotificacionEN entry in en)
                                returnValue.Add (NotificacionAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Notificacion/ObtenerNotificacionesReserva")]

public ActionResult<List<NotificacionDTOA> > ObtenerNotificacionesReserva (int idReserva)
{
        // CAD, EN
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaEN reservaEN = null;

        // returnValue
        List<NotificacionEN> en = null;
        List<NotificacionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                reservaRESTCAD = new ReservaRESTCAD (session);

                // Exists Reserva
                reservaEN = reservaRESTCAD.ReadOIDDefault (idReserva);
                if (reservaEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = reservaRESTCAD.ObtenerNotificacionesReserva (idReserva).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<NotificacionDTOA>();
                        foreach (NotificacionEN entry in en)
                                returnValue.Add (NotificacionAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idNotificacion}", Name="GetOIDNotificacion")]

[Route ("~/api/Notificacion/{idNotificacion}")]

public ActionResult<NotificacionDTOA> Obtener (int idNotificacion)
{
        // CAD, CEN, EN, returnValue
        NotificacionRESTCAD notificacionRESTCAD = null;
        NotificacionCEN notificacionCEN = null;
        NotificacionEN notificacionEN = null;
        NotificacionDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                notificacionRESTCAD = new NotificacionRESTCAD (session);
                notificacionCEN = new NotificacionCEN (unitRepo.notificacionrepository);

                // Data
                notificacionEN = notificacionCEN.Obtener (idNotificacion);

                // Convert return
                if (notificacionEN != null) {
                        returnValue = NotificacionAssembler.Convert (notificacionEN, unitRepo, session);
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

[Route ("~/api/Notificacion/Listar")]

public ActionResult<System.Collections.Generic.List<NotificacionDTOA> > Listar (int p_idusuario)
{
        // CAD, CEN, EN, returnValue

        NotificacionRESTCAD notificacionRESTCAD = null;
        NotificacionCEN notificacionCEN = null;


        System.Collections.Generic.List<NotificacionEN> en;

        System.Collections.Generic.List<NotificacionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                notificacionRESTCAD = new NotificacionRESTCAD (session);
                notificacionCEN = new NotificacionCEN (unitRepo.notificacionrepository);

                // CEN return



                en = notificacionCEN.Listar (p_idusuario).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<NotificacionDTOA>();
                        foreach (NotificacionEN entry in en)
                                returnValue.Add (NotificacionAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Notificacion/CrearNotifEvento")]

public ActionResult<NotificacionDTOA> CrearNotifEvento ( [FromBody] NotificacionDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        NotificacionRESTCAD notificacionRESTCAD = null;
        NotificacionCEN notificacionCEN = null;
        NotificacionDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();


                notificacionRESTCAD = new NotificacionRESTCAD (session);
                notificacionCEN = new NotificacionCEN (unitRepo.notificacionrepository);

                // Create
                returnOID = notificacionCEN.CrearNotifEvento (
                        dto.Asunto                                                                               //Atributo Primitivo: p_asunto
                        , dto.Descripcion                                                                                                                                                //Atributo Primitivo: p_descripcion
                        , dto.Leida                                                                                                                                                      //Atributo Primitivo: p_leida
                        , dto.Tipo                                                                                                                                                       //Atributo Primitivo: p_tipo
                        ,
                        //Atributo OID: p_evento
                        // attr.estaRelacionado: true
                        dto.Evento_oid                 // association role

                        );
                session.Commit ();

                // Convert return
                returnValue = NotificacionAssembler.Convert (notificacionRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Notificacion/CrearNotifEvento/" + returnOID, returnValue);
}

[HttpPost]

[Route ("~/api/Notificacion/CrearNotifReserva")]

public ActionResult<NotificacionDTOA> CrearNotifReserva ( [FromBody] NotificacionDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        NotificacionRESTCAD notificacionRESTCAD = null;
        NotificacionCEN notificacionCEN = null;
        NotificacionDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();


                notificacionRESTCAD = new NotificacionRESTCAD (session);
                notificacionCEN = new NotificacionCEN (unitRepo.notificacionrepository);

                // Create
                returnOID = notificacionCEN.CrearNotifReserva (
                        dto.Asunto                                                                               //Atributo Primitivo: p_asunto
                        , dto.Descripcion                                                                                                                                                //Atributo Primitivo: p_descripcion
                        , dto.Leida                                                                                                                                                      //Atributo Primitivo: p_leida
                        , dto.Tipo                                                                                                                                                       //Atributo Primitivo: p_tipo
                        ,
                        //Atributo OID: p_reserva
                        // attr.estaRelacionado: true
                        dto.Reserva_oid                 // association role

                        );
                session.Commit ();

                // Convert return
                returnValue = NotificacionAssembler.Convert (notificacionRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Notificacion/CrearNotifReserva/" + returnOID, returnValue);
}

[HttpDelete]


[Route ("~/api/Notificacion/Eliminar")]

public ActionResult Eliminar (int p_notificacion_oid)
{
        // CAD, CEN
        NotificacionRESTCAD notificacionRESTCAD = null;
        NotificacionCEN notificacionCEN = null;

        try
        {
                session.SessionInitializeTransaction ();


                notificacionRESTCAD = new NotificacionRESTCAD (session);
                notificacionCEN = new NotificacionCEN (unitRepo.notificacionrepository);

                notificacionCEN.Eliminar (p_notificacion_oid);
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






/*PROTECTED REGION ID(TFM_REST_NotificacionControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs

[HttpPut]

[Route ("~/api/Notificacion/Editar")]

public ActionResult<NotificacionDTOA> Editar (int idNotificacion, [FromBody] NotificacionDTO dto)
{
        // CAD, CEN, returnValue
        NotificacionRESTCAD notificacionRESTCAD = null;
        EventoRESTCAD eventoRESTCAD = null;
        NotificacionCEN notificacionCEN = null;
        ReservaRESTCAD reservaRESTCAD = null;
        NotificacionDTOA returnValue = null;

        try
        {
                session.SessionInitializeTransaction ();


                notificacionRESTCAD = new NotificacionRESTCAD (session);
                eventoRESTCAD = new EventoRESTCAD (session);
                reservaRESTCAD = new ReservaRESTCAD (session);
                notificacionCEN = new NotificacionCEN (unitRepo.notificacionrepository);

                // Modify
                notificacionCEN.Editar (idNotificacion,
                        dto.Asunto
                        ,
                        dto.Descripcion
                        ,
                        dto.Leida
                        ,
                        dto.Tipo
                        ,
                        eventoRESTCAD.ReadOIDDefault (dto.Evento_oid)
                        ,
                        reservaRESTCAD.ReadOIDDefault (dto.Reserva_oid)
                        );

                // Return modified object
                returnValue = NotificacionAssembler.Convert (notificacionRESTCAD.ReadOIDDefault (idNotificacion), unitRepo, session);

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

[HttpPost]

[Route ("~/api/Notificacion/EnviarAEntidad")]


public ActionResult EnviarAEntidad (int p_notificacion, int p_entidad, int p_emisor)
{
        // CAD, CEN, returnValue
        NotificacionRESTCAD notificacionRESTCAD = null;
        NotificacionCEN notificacionCEN = null;
        EntidadCEN entidadCEN = null;
        UsuarioCEN usuarioCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();


                notificacionRESTCAD = new NotificacionRESTCAD (session);
                notificacionCEN = new NotificacionCEN (unitRepo.notificacionrepository);
                entidadCEN = new EntidadCEN (unitRepo.entidadrepository);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);


                // Operation
                notificacionCEN.EnviarAEntidad (notificacionCEN.Obtener (p_notificacion), entidadCEN.Obtener (p_entidad), usuarioCEN.Obtener (p_emisor));
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



[HttpPost]

[Route ("~/api/Notificacion/EnviarAUsuario")]


public ActionResult EnviarAUsuario (int p_notificacion, int p_receptor, int p_emisorusuario, int p_emisorentidad)
{
        // CAD, CEN, returnValue
        NotificacionRESTCAD notificacionRESTCAD = null;
        NotificacionCEN notificacionCEN = null;
        EntidadCEN entidadCEN = null;
        UsuarioCEN usuarioCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();


                notificacionRESTCAD = new NotificacionRESTCAD (session);
                notificacionCEN = new NotificacionCEN (unitRepo.notificacionrepository);
                entidadCEN = new EntidadCEN (unitRepo.entidadrepository);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);



                // Operation
                notificacionCEN.EnviarAUsuario (notificacionCEN.Obtener (p_notificacion), usuarioCEN.Obtener (p_receptor), usuarioCEN.Obtener (p_emisorusuario), entidadCEN.Obtener (p_emisorentidad));
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
