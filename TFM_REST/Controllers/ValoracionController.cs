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


/*PROTECTED REGION ID(usingTFM_REST_ValoracionControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Valoracion")]
public class ValoracionController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Valoracion/Listartodas")]
public ActionResult<List<ValoracionDTOA> > Listartodas ()
{
        // CAD, CEN, EN, returnValue
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;

        List<ValoracionEN> valoracionEN = null;
        List<ValoracionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                // Data
                // TODO: paginación

                valoracionEN = valoracionCEN.Listartodas (0, -1).ToList ();

                // Convert return
                if (valoracionEN != null) {
                        returnValue = new List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in valoracionEN)
                                returnValue.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Valoracion/ObtenerValoracionesRealizadas")]

public ActionResult<List<ValoracionDTOA> > ObtenerValoracionesRealizadas (int idUsuarioRegistrado)
{
        // CAD, EN
        UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
        UsuarioEN usuarioEN = null;

        // returnValue
        List<ValoracionEN> en = null;
        List<ValoracionDTOA> returnValue = null;

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


                en = usuarioRegistradoRESTCAD.ObtenerValoracionesRealizadas (idUsuarioRegistrado).ToList ();



                // Convert return
                if (en != null) {
                        returnValue = new List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in en)
                                returnValue.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idValoracion}", Name="GetOIDValoracion")]

[Route ("~/api/Valoracion/{idValoracion}")]

public ActionResult<ValoracionDTOA> Obtener (int idValoracion)
{
        // CAD, CEN, EN, returnValue
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;
        ValoracionEN valoracionEN = null;
        ValoracionDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                // Data
                valoracionEN = valoracionCEN.Obtener (idValoracion);

                // Convert return
                if (valoracionEN != null) {
                        returnValue = ValoracionAssembler.Convert (valoracionEN, unitRepo, session);
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

[Route ("~/api/Valoracion/Listar")]

public ActionResult<System.Collections.Generic.List<ValoracionDTOA> > Listar (int p_idusuario)
{
        // CAD, CEN, EN, returnValue

        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;


        System.Collections.Generic.List<ValoracionEN> en;

        System.Collections.Generic.List<ValoracionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                // CEN return



                en = valoracionCEN.Listar (p_idusuario).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in en)
                                returnValue.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
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


// No pasa el slEnables: listartecnico

[HttpGet]

[Route ("~/api/Valoracion/Listartecnico")]

public ActionResult<System.Collections.Generic.List<ValoracionDTOA> > Listartecnico (int p_idusuario)
{
        // CAD, CEN, EN, returnValue

        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;


        System.Collections.Generic.List<ValoracionEN> en;

        System.Collections.Generic.List<ValoracionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                // CEN return



                en = valoracionCEN.Listartecnico (p_idusuario).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in en)
                                returnValue.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Valoracion/Listarentidad")]

public ActionResult<System.Collections.Generic.List<ValoracionDTOA> > Listarentidad (int p_identidad)
{
        // CAD, CEN, EN, returnValue

        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;


        System.Collections.Generic.List<ValoracionEN> en;

        System.Collections.Generic.List<ValoracionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                // CEN return



                en = valoracionCEN.Listarentidad (p_identidad).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in en)
                                returnValue.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
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


// No pasa el slEnables: listarpista

[HttpGet]

[Route ("~/api/Valoracion/Listarpista")]

public ActionResult<System.Collections.Generic.List<ValoracionDTOA> > Listarpista (int p_idpista)
{
        // CAD, CEN, EN, returnValue

        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;


        System.Collections.Generic.List<ValoracionEN> en;

        System.Collections.Generic.List<ValoracionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                // CEN return



                en = valoracionCEN.Listarpista (p_idpista).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in en)
                                returnValue.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
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


// No pasa el slEnables: listarinstalacion

[HttpGet]

[Route ("~/api/Valoracion/Listarinstalacion")]

public ActionResult<System.Collections.Generic.List<ValoracionDTOA> > Listarinstalacion (int p_idinstalacion)
{
        // CAD, CEN, EN, returnValue

        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;


        System.Collections.Generic.List<ValoracionEN> en;

        System.Collections.Generic.List<ValoracionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                // CEN return



                en = valoracionCEN.Listarinstalacion (p_idinstalacion).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<ValoracionDTOA>();
                        foreach (ValoracionEN entry in en)
                                returnValue.Add (ValoracionAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Valoracion/Crear")]


public ActionResult<ValoracionDTOA> Crear ( [FromBody] ValoracionDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;
        ValoracionDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                // Create
                returnOID = valoracionCEN.Crear (
                        dto.Estrellas                                                                            //Atributo Primitivo: p_estrellas
                        , dto.Comentario                                                                                                                                                 //Atributo Primitivo: p_comentario
                        ,
                        //Atributo OID: p_usuario
                        // attr.estaRelacionado: true
                        dto.Usuario_oid                 // association role

                        );
                session.Commit ();

                // Convert return
                returnValue = ValoracionAssembler.Convert (valoracionRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Valoracion/Crear/" + returnOID, returnValue);
}






[HttpPut]

[Route ("~/api/Valoracion/Editar")]

public ActionResult<ValoracionDTOA> Editar (int idValoracion, [FromBody] ValoracionDTO dto)
{
        // CAD, CEN, returnValue
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;
        ValoracionDTOA returnValue = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                // Modify
                valoracionCEN.Editar (idValoracion,
                        dto.Estrellas
                        ,
                        dto.Comentario
                        );

                // Return modified object
                returnValue = ValoracionAssembler.Convert (valoracionRESTCAD.ReadOIDDefault (idValoracion), unitRepo, session);

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


[Route ("~/api/Valoracion/Eliminar")]

public ActionResult Eliminar (int p_valoracion_oid)
{
        // CAD, CEN
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);

                valoracionCEN.Eliminar (p_valoracion_oid);
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





/*PROTECTED REGION ID(TFM_REST_ValoracionControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
[HttpPost]

[Route ("~/api/Valoracion/Valorarpista")]


public ActionResult Valorarpista (int p_valoracion, int p_pista)
{
        // CAD, CEN, returnValue
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;
        PistaCEN pistaCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers["Authorization"].Count > 0)
                    token = Request.Headers["Authorization"].ToString();
                int id = new UsuarioCEN(unitRepo.usuariorepository).CheckToken(token);



                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);


                // Operation
                valoracionCEN.Valorarpista (valoracionCEN.Obtener (p_valoracion), pistaCEN.Obtener (p_pista));
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

[Route ("~/api/Valoracion/Valorarentidad")]


public ActionResult Valorarentidad (int p_valoracion, int p_entidad)
{
        // CAD, CEN, returnValue
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;
        EntidadCEN entidadCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers["Authorization"].Count > 0)
                    token = Request.Headers["Authorization"].ToString();
                int id = new UsuarioCEN(unitRepo.usuariorepository).CheckToken(token);



                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);
                entidadCEN = new EntidadCEN (unitRepo.entidadrepository);


                // Operation
                valoracionCEN.Valorarentidad (valoracionCEN.Obtener (p_valoracion), entidadCEN.Obtener (p_entidad));
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

[Route ("~/api/Valoracion/Valorarinstalacion")]


public ActionResult Valorarinstalacion (int p_valoracion, int p_instalacion)
{
        // CAD, CEN, returnValue
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;
        InstalacionCEN instalacionCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers["Authorization"].Count > 0)
                    token = Request.Headers["Authorization"].ToString();
                int id = new UsuarioCEN(unitRepo.usuariorepository).CheckToken(token);



                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);
                instalacionCEN = new InstalacionCEN (unitRepo.instalacionrepository);


                // Operation
                valoracionCEN.Valorarinstalacion (valoracionCEN.Obtener (p_valoracion), instalacionCEN.Obtener (p_instalacion));
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

[Route ("~/api/Valoracion/Valorartecnico")]


public ActionResult Valorartecnico (int p_valoracion, int p_tecnico)
{
        // CAD, CEN, returnValue
        ValoracionRESTCAD valoracionRESTCAD = null;
        ValoracionCEN valoracionCEN = null;
        UsuarioCEN usuarioCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers["Authorization"].Count > 0)
                    token = Request.Headers["Authorization"].ToString();
                int id = new UsuarioCEN(unitRepo.usuariorepository).CheckToken(token);



                valoracionRESTCAD = new ValoracionRESTCAD (session);
                valoracionCEN = new ValoracionCEN (unitRepo.valoracionrepository);
                usuarioCEN = new UsuarioCEN (unitRepo.usuariorepository);


                // Operation
                valoracionCEN.Valorartecnico (valoracionCEN.Obtener (p_valoracion), usuarioCEN.Obtener (p_tecnico));
                session.Commit ();

                result = StatusCode (200);
        }

        catch (Exception e)
        {
                session.RollBack ();

                result = StatusCode (500);
                if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) && e.Message.Equals ("El token es incorrecto")) result = StatusCode (403);
                else if (e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) || e.GetType () == typeof(TFMGen.ApplicationCore.Exceptions.DataLayerException)) result = StatusCode (400);
                return result;
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
