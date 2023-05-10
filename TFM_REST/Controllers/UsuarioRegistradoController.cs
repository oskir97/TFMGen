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





/*PROTECTED REGION ID(TFM_REST_UsuarioRegistradoControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs


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
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




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





[Route ("~/api/UsuarioRegistrado/ObtenerAlumnos")]

public ActionResult<List<UsuarioRegistradoDTOA> > ObtenerAlumnos (int idEvento)
{
        // CAD, EN
        EventoRESTCAD eventoRESTCAD = null;
        EventoEN eventoEN = null;

        // returnValue
        List<UsuarioEN> en = null;
        List<UsuarioRegistradoDTOA> returnValue = null;

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


                en = eventoRESTCAD.ObtenerAlumnos (idEvento).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<UsuarioRegistradoDTOA>();
                        foreach (UsuarioEN entry in en)
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





[Route ("~/api/UsuarioRegistrado/ObtenerUsuarios")]

public ActionResult<List<UsuarioRegistradoDTOA> > ObtenerUsuarios (int idEntidad)
{
        // CAD, EN
        EntidadRESTCAD entidadRESTCAD = null;
        EntidadEN entidadEN = null;

        // returnValue
        List<UsuarioEN> en = null;
        List<UsuarioRegistradoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);


                entidadRESTCAD = new EntidadRESTCAD (session);

                // Exists Entidad
                entidadEN = entidadRESTCAD.ReadOIDDefault (idEntidad);
                if (entidadEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = entidadRESTCAD.ObtenerUsuarios (idEntidad).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<UsuarioRegistradoDTOA>();
                        foreach (UsuarioEN entry in en)
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

[Route ("~/api/UsuarioRegistrado")]

public ActionResult<UsuarioRegistradoDTOA> Obtener ()
{
        // CAD, CEN, EN, returnValue
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;
        UsuarioEN usuarioEN = null;
        UsuarioRegistradoDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);

                // Data
                usuarioEN = usuarioCEN.Obtener (id);

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



// No pasa el slEnables: listaralumnosevento

[HttpGet]

[Route ("~/api/UsuarioRegistrado/Listaralumnosevento")]

public ActionResult<System.Collections.Generic.List<UsuarioRegistradoDTOA> > Listaralumnosevento (int p_idevento)
{
        // CAD, CEN, EN, returnValue

        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;


        System.Collections.Generic.List<UsuarioEN> en;

        System.Collections.Generic.List<UsuarioRegistradoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);

                // CEN return



                en = usuarioCEN.Listaralumnosevento (p_idevento).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<UsuarioRegistradoDTOA>();
                        foreach (UsuarioEN entry in en)
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


// No pasa el slEnables: listartecnicosevento

[HttpGet]

[Route ("~/api/UsuarioRegistrado/Listartecnicosevento")]

public ActionResult<System.Collections.Generic.List<UsuarioRegistradoDTOA> > Listartecnicosevento (int p_idevento)
{
        // CAD, CEN, EN, returnValue

        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;


        System.Collections.Generic.List<UsuarioEN> en;

        System.Collections.Generic.List<UsuarioRegistradoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);

                // CEN return



                en = usuarioCEN.Listartecnicosevento (p_idevento).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<UsuarioRegistradoDTOA>();
                        foreach (UsuarioEN entry in en)
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


// No pasa el slEnables: listarusuariospartido

[HttpGet]

[Route ("~/api/UsuarioRegistrado/Listarusuariospartido")]

public ActionResult<System.Collections.Generic.List<UsuarioRegistradoDTOA> > Listarusuariospartido (int p_idreserva)
{
        // CAD, CEN, EN, returnValue

        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;


        System.Collections.Generic.List<UsuarioEN> en;

        System.Collections.Generic.List<UsuarioRegistradoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);

                // CEN return



                en = usuarioCEN.Listarusuariospartido (p_idreserva).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<UsuarioRegistradoDTOA>();
                        foreach (UsuarioEN entry in en)
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

// No pasa el slEnables: obtenerusuario

[HttpGet]

[Route ("~/api/UsuarioRegistrado/Obtenerusuario")]

public ActionResult<UsuarioRegistradoDTOA> Obtenerusuario (int idusuario)
{
        // CAD, CEN, EN, returnValue

        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;


        UsuarioEN en;

        UsuarioRegistradoDTOA returnValue;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);

                // CEN return



                en = usuarioCEN.Obtenerusuario (idusuario);




                // Convert return
                returnValue = UsuarioRegistradoAssembler.Convert (en, unitRepo, session);
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

[HttpPost]


[Route ("~/api/UsuarioRegistrado/Crear")]



public ActionResult<UsuarioRegistradoDTOA> Crear ( [FromBody] UsuarioDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        UsuarioCP usuarioCP = null;
        UsuarioRegistradoDTOA returnValue = null;
        UsuarioEN returnOID = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                usuarioCP = new UsuarioCP (session, unitRepo);

                // Create
                returnOID = usuarioCP.Crear (
                        dto.Nombre
                        , dto.Email
                        , dto.Domicilio
                        , dto.Telefono
                        , dto.Fechanacimiento
                        , DateTime.Now
                        , dto.Apellidos
                        , dto.Password,
                        dto.Rol_oid
                        , dto.Codigopostal
                        , dto.Localidad
                        , dto.Provincia
                        , dto.Telefonoalternativo
                        , dto.Entidad_oid
                        );
                session.Commit ();

                // Convert return
                returnValue = UsuarioRegistradoAssembler.Convert (returnOID, unitRepo, session);
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



        return Created ("~/api/UsuarioRegistrado/Crear/" + returnOID, returnValue);
}

[HttpPut]

[Route ("~/api/UsuarioRegistrado/Cambiarrol")]

public ActionResult
Cambiarrol (int p_rol_oid, int idusuario)
{
        // CAD, CEN, returnValue
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCP usuarioCP = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCP = new UsuarioCP (session, unitRepo);

                // Relationer
                usuarioCP.Cambiarrol (idusuario, p_rol_oid);
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

[Route ("~/api/UsuarioRegistrado/Darsebaja")]


public ActionResult Darsebaja (Nullable<DateTime> p_baja, int idusuario)
{
        // CAD, CEN, returnValue
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);


                // Operation
                usuarioCEN.Darsebaja (idusuario, p_baja);
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

[Route ("~/api/UsuarioRegistrado/Darsealta")]


public ActionResult Darsealta (Nullable<DateTime> p_alta, int idusuario)
{
        // CAD, CEN, returnValue
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);


                // Operation
                usuarioCEN.Darsealta (idusuario, p_alta);
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

[HttpPut]

[Route ("~/api/UsuarioRegistrado/Editar")]

public ActionResult<UsuarioRegistradoDTOA> Editar (int idUsuario, [FromBody] UsuarioDTO dto)
{
        // CAD, CEN, returnValue
        UsuarioCP usuarioCP = null;
        UsuarioCEN usuarioCEN = null;
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioRegistradoDTOA returnValue = null;


        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);
                int id = usuarioCEN.CheckToken (token);

                usuarioCP = new UsuarioCP (session, unitRepo);
                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);

                // Modify
                usuarioCP.Editar (idUsuario,
                        dto.Nombre
                        ,
                        dto.Email
                        ,
                        dto.Domicilio
                        ,
                        dto.Telefono
                        ,
                        dto.Fechanacimiento
                        ,
                        dto.Alta
                        ,
                        dto.Apellidos
                        ,
                        dto.Password
                        ,
                        dto.Codigopostal
                        ,
                        dto.Localidad
                        ,
                        dto.Provincia,
                        dto.Entidad_oid
                        );
                // Return modified object

                unitRepo.usuariorepository.setSessionCP (session);

                returnValue = UsuarioRegistradoAssembler.Convert (usuarioCEN.Obtener (dto.Idusuario), unitRepo, session);

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


[Route ("~/api/UsuarioRegistrado/Eliminar")]

public ActionResult Eliminar (int p_oid)
{
        // CAD, CEN
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioCEN usuarioCEN = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD (session);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);

                usuarioCEN.Eliminar (p_oid);
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

/*PROTECTED REGION END*/
}
}
