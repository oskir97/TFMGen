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


/*PROTECTED REGION ID(usingTFM_REST_PistaControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Pista")]
public class PistaController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Pista/Listartodas")]
public ActionResult<List<PistaDTOA> > Listartodas ()
{
        // CAD, CEN, EN, returnValue
        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;

        List<PistaEN> pistaEN = null;
        List<PistaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pistaCEN = new PistaCEN (unitRepo.pistarepository);

                // Data
                // TODO: paginación

                pistaEN = pistaCEN.Listartodas (0, -1).ToList ();

                // Convert return
                if (pistaEN != null) {
                        returnValue = new List<PistaDTOA>();
                        foreach (PistaEN entry in pistaEN)
                                returnValue.Add (PistaAssembler.Convert (entry, unitRepo, session));
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





[Route ("~/api/Pista/ObtenerPistaHorario")]

public ActionResult<PistaDTOA> ObtenerPistaHorario (int idHorario)
{
        // CAD, EN
        HorarioRESTCAD horarioRESTCAD = null;
        HorarioEN horarioEN = null;

        // returnValue
        PistaEN en = null;
        PistaDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);


                horarioRESTCAD = new HorarioRESTCAD (session);

                // Exists Horario
                horarioEN = horarioRESTCAD.ReadOIDDefault (idHorario);
                if (horarioEN == null) return NotFound ();

                // Rol
                // TODO: paginación


                en = horarioRESTCAD.ObtenerPistaHorario (idHorario);



                // Convert return
                if (en != null) {
                        returnValue = PistaAssembler.Convert (en, unitRepo, session);
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







[HttpGet]
// [Route("{idPista}", Name="GetOIDPista")]

[Route ("~/api/Pista/{idPista}")]

public ActionResult<PistaDTOA> Obtener (int idPista)
{
        // CAD, CEN, EN, returnValue
        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;
        PistaEN pistaEN = null;
        PistaDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);

                // Data
                pistaEN = pistaCEN.Obtener (idPista);

                // Convert return
                if (pistaEN != null) {
                        returnValue = PistaAssembler.Convert (pistaEN, unitRepo, session);
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



// No pasa el slEnables: listarEntidad

[HttpGet]

[Route ("~/api/Pista/ListarEntidad")]

public ActionResult<System.Collections.Generic.List<PistaDTOA> > ListarEntidad (int p_identidad)
{
        // CAD, CEN, EN, returnValue

        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;


        System.Collections.Generic.List<PistaEN> en;

        System.Collections.Generic.List<PistaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);

                // CEN return



                en = pistaCEN.ListarEntidad (p_identidad).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<PistaDTOA>();
                        foreach (PistaEN entry in en)
                                returnValue.Add (PistaAssembler.Convert (entry, unitRepo, session));
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

// No pasa el slEnables: listar

[HttpGet]

[Route ("~/api/Pista/Listar")]

public ActionResult<System.Collections.Generic.List<PistaDTOA> > Listar (           )
{
        // CAD, CEN, EN, returnValue

        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;


        System.Collections.Generic.List<PistaEN> en;

        System.Collections.Generic.List<PistaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);

                // CEN return



                en = pistaCEN.Listar (   ).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<PistaDTOA>();
                        foreach (PistaEN entry in en)
                                returnValue.Add (PistaAssembler.Convert (entry, unitRepo, session));
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


// No pasa el slEnables: obtenerpistasinstalacion

[HttpGet]

[Route ("~/api/Pista/Obtenerpistasinstalacion")]

public ActionResult<System.Collections.Generic.List<PistaDTOA> > Obtenerpistasinstalacion (int p_idinstalacion)
{
        // CAD, CEN, EN, returnValue

        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;


        System.Collections.Generic.List<PistaEN> en;

        System.Collections.Generic.List<PistaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);

                // CEN return



                en = pistaCEN.Obtenerpistasinstalacion (p_idinstalacion).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<PistaDTOA>();
                        foreach (PistaEN entry in en)
                                returnValue.Add (PistaAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Pista/Crear")]

public ActionResult<PistaDTOA> Crear ( [FromBody] PistaDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;
        PistaDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);

                // Create
                returnOID = pistaCEN.Crear (
                        dto.Nombre                                                                               //Atributo Primitivo: p_nombre
                        , dto.Maxreservas                                                                                                                                                //Atributo Primitivo: p_maxreservas
                        ,
                        //Atributo OID: p_entidad
                        // attr.estaRelacionado: true
                        dto.Entidad_oid                 // association role

                        ,
                        //Atributo OID: p_estadosPista
                        // attr.estaRelacionado: true
                        dto.EstadosPista_oid                 // association role

                        ,
                        //Atributo OID: p_deporte
                        // attr.estaRelacionado: true
                        dto.Deporte_oid                 // association role

                        , dto.Ubicacion                                                                                                                                                  //Atributo Primitivo: p_ubicacion
                        , dto.Visible                                                                                                                                                    //Atributo Primitivo: p_visible
                        ,
                        //Atributo OID: p_instalacion
                        // attr.estaRelacionado: true
                        dto.Instalacion_oid                 // association role

                        , dto.Precio                                                                                                                                                     //Atributo Primitivo: p_precio
                        , dto.Latitud                                                                                                                                                    //Atributo Primitivo: p_latitud
                        , dto.Longitud                                                                                                                                                   //Atributo Primitivo: p_longitud
                        );
                session.Commit ();

                // Convert return
                returnValue = PistaAssembler.Convert (pistaRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Pista/Crear/" + returnOID, returnValue);
}



[HttpDelete]


[Route ("~/api/Pista/Eliminar")]

public ActionResult Eliminar (int p_pista_oid)
{
        // CAD, CEN
        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);

                pistaCEN.Eliminar (p_pista_oid);
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




[HttpPost]

[Route ("~/api/Pista/ExisteReserva")]

public ActionResult<bool>

ExisteReserva (int p_oid, [FromBody]Nullable<DateTime> p_fecha)
{
        // CP, returnValue
        PistaCP pistaCP = null;

        bool returnValue;

        try
        {
                session.SessionInitializeTransaction ();

                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pistaCP = new PistaCP (session, unitRepo);

                // Operation
                returnValue = pistaCP.ExisteReserva (p_oid, p_fecha);
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
        return returnValue;
}



[HttpPost]

[Route ("~/api/Pista/ExisteEvento")]

public ActionResult<bool>

ExisteEvento (int p_oid, Nullable<DateTime> p_fecha)
{
        // CP, returnValue
        PistaCP pistaCP = null;

        bool returnValue;

        try
        {
                session.SessionInitializeTransaction ();

                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pistaCP = new PistaCP (session, unitRepo);

                // Operation
                returnValue = pistaCP.ExisteEvento (p_oid, p_fecha);
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
        return returnValue;
}





/*PROTECTED REGION ID(TFM_REST_PistaControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs

[HttpPut]

[Route ("~/api/Pista/Editar")]

public ActionResult<PistaDTOA> Editar (int idPista, [FromBody] PistaDTO dto)
{
        // CAD, CEN, returnValue
        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;
        PistaDTOA returnValue = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);

                // Modify
                pistaCEN.Editar (idPista,
                        dto.Nombre
                        ,
                        dto.Maxreservas
                        ,
                        dto.Ubicacion
                        ,
                        dto.Visible,
                        dto.EstadosPista_oid,
                        dto.Deporte_oid,
                        dto.Instalacion_oid,
                        dto.Precio,
                        dto.Latitud,
                        dto.Longitud
                        );

                // Return modified object
                returnValue = PistaAssembler.Convert (pistaRESTCAD.ReadOIDDefault (idPista), unitRepo, session);

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

// No pasa el slEnables: buscar

[HttpGet]

[Route ("~/api/Pista/Buscar")]

public ActionResult<System.Collections.Generic.List<PistaDTOA> > Buscar (string p_busqueda)
{
        // CAD, CEN, EN, returnValue

        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;


        System.Collections.Generic.List<PistaEN> en;

        System.Collections.Generic.List<PistaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);

                // CEN return



                en = pistaCEN.Buscar ("%" + p_busqueda + "%").ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<PistaDTOA>();
                        foreach (PistaEN entry in en)
                                returnValue.Add (PistaAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Pista/Listarhorariosdisponibles")]

public ActionResult<System.Collections.Generic.List<HorarioDTOA> > Listarhorariosdisponibles (int p_oid, [FromBody]Nullable<DateTime> p_fecha)
{
        // CP, returnValue
        PistaCP pistaCP = null;

        System.Collections.Generic.List<HorarioDTOA> returnValue = null;
        System.Collections.Generic.List<HorarioEN> en;

        try
        {
                session.SessionInitializeTransaction ();

                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pistaCP = new PistaCP (session, unitRepo);

                // Operation
                en = pistaCP.Listarhorariosdisponibles (p_oid, p_fecha, true).ToList ();
                session.Commit ();

                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<HorarioDTOA>();
                        foreach (HorarioEN entry in en)
                                returnValue.Add (HorarioAssembler.Convert (entry, unitRepo, session));
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

[HttpPost]

[Route ("~/api/Pista/Asignarimagen")]


public ActionResult Asignarimagen (int p_oid, string p_imagen)
{
        // CAD, CEN, returnValue
        PistaRESTCAD pistaRESTCAD = null;
        PistaCEN pistaCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                pistaRESTCAD = new PistaRESTCAD (session);
                pistaCEN = new PistaCEN (unitRepo.pistarepository);


                // Operation
                pistaCEN.Asignarimagen (p_oid, p_imagen);
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
