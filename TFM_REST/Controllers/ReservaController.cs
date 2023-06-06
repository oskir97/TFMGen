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


/*PROTECTED REGION ID(usingTFM_REST_ReservaControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Reserva")]
public class ReservaController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Reserva/Listartodos")]
public ActionResult<List<ReservaDTOA> > Listartodos ()
{
        // CAD, CEN, EN, returnValue
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;

        List<ReservaEN> reservaEN = null;
        List<ReservaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // Data
                // TODO: paginación

                reservaEN = reservaCEN.Listartodos (0, -1).ToList ();

                // Convert return
                if (reservaEN != null) {
                        returnValue = new List<ReservaDTOA>();
                        foreach (ReservaEN entry in reservaEN)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Reserva/ObtenerReservas")]

public ActionResult<List<ReservaDTOA> > ObtenerReservas (int idUsuarioRegistrado)
{
        // CAD, EN
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioEN usuarioEN = null;

        // returnValue
        List<ReservaEN> en = null;
        List<ReservaDTOA> returnValue = null;

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


                en = usuarioRegistradoRESTCAD.ObtenerReservas (idUsuarioRegistrado).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<ReservaDTOA>();
                        foreach (ReservaEN entry in en)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Reserva/ObtenerReservasEvento")]

public ActionResult<List<ReservaDTOA> > ObtenerReservasEvento (int idEvento)
{
        // CAD, EN
        EventoRESTCAD eventoRESTCAD = null;
        EventoEN eventoEN = null;

        // returnValue
        List<ReservaEN> en = null;
        List<ReservaDTOA> returnValue = null;

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


                en = eventoRESTCAD.ObtenerReservasEvento (idEvento).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<ReservaDTOA>();
                        foreach (ReservaEN entry in en)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idReserva}", Name="GetOIDReserva")]

[Route ("~/api/Reserva/{idReserva}")]

public ActionResult<ReservaDTOA> Obtener (int idReserva)
{
        // CAD, CEN, EN, returnValue
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;
        ReservaEN reservaEN = null;
        ReservaDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                reservaRESTCAD = new ReservaRESTCAD (session);
                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // Data
                reservaEN = reservaCEN.Obtener (idReserva);

                // Convert return
                if (reservaEN != null) {
                        returnValue = ReservaAssembler.Convert (reservaEN, unitRepo, session);
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



// No pasa el slEnables: listarreservasusuario

[HttpGet]

[Route ("~/api/Reserva/Listarreservasusuario")]

public ActionResult<System.Collections.Generic.List<ReservaDTOA> > Listarreservasusuario (          )
{
        // CAD, CEN, EN, returnValue

        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;


        System.Collections.Generic.List<ReservaEN> en;

        System.Collections.Generic.List<ReservaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                reservaRESTCAD = new ReservaRESTCAD (session);
                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // CEN return



                en = reservaCEN.Listarreservasusuario (id).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<ReservaDTOA>();
                        foreach (ReservaEN entry in en)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
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

// Pasa el slEnables


//Pasa el serviceLinkValid

// ReadFilter Generado a partir del serviceLink

[HttpGet]

[Route ("~/api/Reserva/Reserva_obtenerinscripciones")]

public ActionResult<List<ReservaDTOA> > Reserva_obtenerinscripciones (int p_idreserva)
{
        // CAD, CEN, EN, returnValue

        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;

        System.Collections.Generic.List<ReservaEN> en;
        List<ReservaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                reservaRESTCAD = new ReservaRESTCAD (session);
                reservaCEN = new ReservaCEN (unitRepo.reservarepository);


                // CEN return


                // paginación

                en = reservaCEN.Obtenerinscripciones (p_idreserva).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<ReservaDTOA>();
                        foreach (ReservaEN entry in en)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
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





// No pasa el slEnables: obtenerreservaspista

[HttpGet]

[Route ("~/api/Reserva/Obtenerreservaspista")]

public ActionResult<System.Collections.Generic.List<ReservaDTOA> > Obtenerreservaspista (int p_idpista, Nullable<DateTime> p_fecha)
{
        // CAD, CEN, EN, returnValue

        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;


        System.Collections.Generic.List<ReservaEN> en;

        System.Collections.Generic.List<ReservaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                reservaRESTCAD = new ReservaRESTCAD (session);
                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // CEN return



                en = reservaCEN.Obtenerreservaspista (p_idpista, p_fecha).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<ReservaDTOA>();
                        foreach (ReservaEN entry in en)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Reserva/Crear")]

public ActionResult<ReservaDTOA> Crear ( [FromBody] ReservaDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;
        ReservaDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                reservaRESTCAD = new ReservaRESTCAD (session);
                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // Create
                returnOID = reservaCEN.Crear (
                        dto.Nombre                                                                               //Atributo Primitivo: p_nombre
                        , dto.Apellidos                                                                                                                                                  //Atributo Primitivo: p_apellidos
                        , dto.Email                                                                                                                                                      //Atributo Primitivo: p_email
                        , dto.Telefono                                                                                                                                                   //Atributo Primitivo: p_telefono
                        , dto.Cancelada                                                                                                                                                  //Atributo Primitivo: p_cancelada
                        ,
                        //Atributo OID: p_pista
                        // attr.estaRelacionado: true
                        dto.Pista_oid                 // association role

                        , dto.Maxparticipantes                                                                                                                                                   //Atributo Primitivo: p_maxparticipantes
                        ,
                        //Atributo OID: p_horario
                        // attr.estaRelacionado: true
                        dto.Horario_oid                 // association role

                        , dto.Fecha                                                                                                                                                      //Atributo Primitivo: p_fecha
                        , dto.Tipo                                                                                                                                                       //Atributo Primitivo: p_tipo
                        ,
                        //Atributo OID: p_usuario
                        // attr.estaRelacionado: true
                        dto.Usuario_oid                 // association role

                        ,
                        //Atributo OID: p_deporte
                        // attr.estaRelacionado: true
                        dto.Deporte_oid                 // association role

                        ,
                        //Atributo OID: p_evento
                        // attr.estaRelacionado: true
                        dto.Evento_oid                 // association role

                        );
                session.Commit ();

                // Convert return
                returnValue = ReservaAssembler.Convert (reservaRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Reserva/Crear/" + returnOID, returnValue);
}




/*PROTECTED REGION ID(TFM_REST_ReservaControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
[HttpPut]

[Route ("~/api/Reserva/Inscribirsepartido")]

public ActionResult Inscribirsepartido (int p_reserva_oid, System.Collections.Generic.IList<int> p_inscripciones_oids)
{
        // CAD, CEN, returnValue
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCP reservaCP = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                reservaRESTCAD = new ReservaRESTCAD (session);
                reservaCP = new ReservaCP (session, unitRepo);

                // Relationer
                reservaCP.Inscribirsepartido (p_reserva_oid, p_inscripciones_oids);
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

[Route ("~/api/Reserva/Cancelar")]


public ActionResult Cancelar (int p_oid)
{
        // CAD, CEN, returnValue
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCP reservaCP = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                reservaRESTCAD = new ReservaRESTCAD (session);
                reservaCP = new ReservaCP (session, unitRepo);


                // Operation
                reservaCP.Cancelar (p_oid);
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

[HttpGet]

[Route ("~/api/Reserva/ListarPartidos")]
public ActionResult<List<ReservaDTOA> > ListarPartidos ()
{
        // CAD, CEN, EN, returnValue
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;

        List<ReservaEN> reservaEN = null;
        List<ReservaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // Data
                // TODO: paginación

                reservaEN = reservaCEN.Listartodos (0, -1).Where (r => r.Tipo == TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum.partido).ToList ();

                // Convert return
                if (reservaEN != null) {
                        returnValue = new List<ReservaDTOA>();
                        foreach (ReservaEN entry in reservaEN)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Reserva/ListarReservas")]
public ActionResult<List<ReservaDTOA> > ListarReservas ()
{
        // CAD, CEN, EN, returnValue
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;

        List<ReservaEN> reservaEN = null;
        List<ReservaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // Data
                // TODO: paginación

                reservaEN = reservaCEN.Listartodos (0, -1).Where (r => r.Tipo == TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum.reserva).ToList ();

                // Convert return
                if (reservaEN != null) {
                        returnValue = new List<ReservaDTOA>();
                        foreach (ReservaEN entry in reservaEN)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Reserva/ListarInscripciones")]
public ActionResult<List<ReservaDTOA> > ListarInscripciones ()
{
        // CAD, CEN, EN, returnValue
        ReservaRESTCAD reservaRESTCAD = null;
        ReservaCEN reservaCEN = null;

        List<ReservaEN> reservaEN = null;
        List<ReservaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // Data
                // TODO: paginación

                reservaEN = reservaCEN.Listartodos (0, -1).Where (r => r.Tipo == TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum.inscripcion).ToList ();

                // Convert return
                if (reservaEN != null) {
                        returnValue = new List<ReservaDTOA>();
                        foreach (ReservaEN entry in reservaEN)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Reserva/Listarfiltros")]

public ActionResult<System.Collections.Generic.List<ReservaDTOA> > Listarfiltros ([FromBody] FilterReservaDTO filtro)
{
        // CP, returnValue
        ReservaCP reservaCP = null;

        System.Collections.Generic.List<ReservaDTOA> returnValue = null;
        System.Collections.Generic.List<ReservaEN> en;

        try
        {
                session.SessionInitializeTransaction ();

                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                reservaCP = new ReservaCP (session, unitRepo);

                // Operation
                en = reservaCP.Listarfiltros (filtro.Filtro, filtro.Localidad, filtro.Latitud, filtro.Longitud, filtro.Fecha, filtro.Deporte, filtro.Orden).ToList ();
                session.Commit ();

                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<ReservaDTOA>();
                        foreach (ReservaEN entry in en)
                                returnValue.Add (ReservaAssembler.Convert (entry, unitRepo, session));
                }
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
        return returnValue;
}


/*PROTECTED REGION END*/
}
}
