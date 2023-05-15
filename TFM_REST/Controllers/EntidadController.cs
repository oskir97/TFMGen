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


/*PROTECTED REGION ID(usingTFM_REST_EntidadControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Entidad")]
public class EntidadController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Entidad/Listar")]
public ActionResult<List<EntidadDTOA> > Listar ()
{
        // CAD, CEN, EN, returnValue
        EntidadRESTCAD entidadRESTCAD = null;
        EntidadCEN entidadCEN = null;

        List<EntidadEN> entidadEN = null;
        List<EntidadDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                entidadCEN = new EntidadCEN (unitRepo.entidadrepository);

                // Data
                // TODO: paginación

                entidadEN = entidadCEN.Listar (0, -1).ToList ();

                // Convert return
                if (entidadEN != null) {
                        returnValue = new List<EntidadDTOA>();
                        foreach (EntidadEN entry in entidadEN)
                                returnValue.Add (EntidadAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idEntidad}", Name="GetOIDEntidad")]

[Route ("~/api/Entidad/{idEntidad}")]

public ActionResult<EntidadDTOA> Obtener (int idEntidad)
{
        // CAD, CEN, EN, returnValue
        EntidadRESTCAD entidadRESTCAD = null;
        EntidadCEN entidadCEN = null;
        EntidadEN entidadEN = null;
        EntidadDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                entidadRESTCAD = new EntidadRESTCAD (session);
                entidadCEN = new EntidadCEN (unitRepo.entidadrepository);

                // Data
                entidadEN = entidadCEN.Obtener (idEntidad);

                // Convert return
                if (entidadEN != null) {
                        returnValue = EntidadAssembler.Convert (entidadEN, unitRepo, session);
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










[HttpPut]

[Route ("~/api/Entidad/Editar")]

public ActionResult<EntidadDTOA> Editar (int idEntidad, [FromBody] EntidadDTO dto)
{
        // CAD, CEN, returnValue
        EntidadRESTCAD entidadRESTCAD = null;
        EntidadCEN entidadCEN = null;
        EntidadDTOA returnValue = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                entidadRESTCAD = new EntidadRESTCAD (session);
                entidadCEN = new EntidadCEN (unitRepo.entidadrepository);

                // Modify
                entidadCEN.Editar (idEntidad,
                        dto.Nombre
                        ,
                        dto.Email
                        ,
                        dto.Telefono
                        ,
                        dto.Domicilio
                        ,
                        dto.Alta
                        ,
                        dto.Codigopostal
                        ,
                        dto.Localidad
                        ,
                        dto.Provincia
                        ,
                        dto.Cifnif
                        ,
                        dto.Telefonoalternativo
                        ,
                        dto.Configuracion,
                        dto.Latitud,
                        dto.Longitud
                        );

                // Return modified object
                returnValue = EntidadAssembler.Convert (entidadRESTCAD.ReadOIDDefault (idEntidad), unitRepo, session);

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




/*PROTECTED REGION ID(TFM_REST_EntidadControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
[HttpPost]

[Route ("~/api/Entidad/Asignarimagen")]


public ActionResult Asignarimagen (int p_oid, string p_imagen)
{
        // CAD, CEN, returnValue
        EntidadRESTCAD entidadRESTCAD = null;
        EntidadCEN entidadCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                entidadRESTCAD = new EntidadRESTCAD (session);
                entidadCEN = new EntidadCEN (unitRepo.entidadrepository);


                // Operation
                entidadCEN.Asignarimagen (p_oid, p_imagen);
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



[HttpPost]

[Route ("~/api/Entidad/Darsebaja")]


public ActionResult Darsebaja (int p_oid, Nullable<DateTime> p_baja)
{
        // CAD, CEN, returnValue
        EntidadRESTCAD entidadRESTCAD = null;
        EntidadCEN entidadCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                entidadRESTCAD = new EntidadRESTCAD (session);
                entidadCEN = new EntidadCEN (unitRepo.entidadrepository);


                // Operation
                entidadCEN.Darsebaja (p_oid, p_baja);
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



[HttpPost]

[Route ("~/api/Entidad/Configurar")]


public ActionResult Configurar (int p_oid, string p_config)
{
        // CAD, CEN, returnValue
        EntidadRESTCAD entidadRESTCAD = null;
        EntidadCEN entidadCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                entidadRESTCAD = new EntidadRESTCAD (session);
                entidadCEN = new EntidadCEN (unitRepo.entidadrepository);


                // Operation
                entidadCEN.Configurar (p_oid, p_config);
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
