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


/*PROTECTED REGION ID(usingTFM_REST_InstalacionControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Instalacion")]
public class InstalacionController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Instalacion/Listartodos")]
public ActionResult<List<InstalacionDTOA> > Listartodos ()
{
        // CAD, CEN, EN, returnValue
        InstalacionRESTCAD instalacionRESTCAD = null;
        InstalacionCEN instalacionCEN = null;

        List<InstalacionEN> instalacionEN = null;
        List<InstalacionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                instalacionCEN = new InstalacionCEN (unitRepo.instalacionrepository);

                // Data
                // TODO: paginación

                instalacionEN = instalacionCEN.Listartodos (0, -1).ToList ();

                // Convert return
                if (instalacionEN != null) {
                        returnValue = new List<InstalacionDTOA>();
                        foreach (InstalacionEN entry in instalacionEN)
                                returnValue.Add (InstalacionAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idInstalacion}", Name="GetOIDInstalacion")]

[Route ("~/api/Instalacion/{idInstalacion}")]

public ActionResult<InstalacionDTOA> Obtener (int idInstalacion)
{
        // CAD, CEN, EN, returnValue
        InstalacionRESTCAD instalacionRESTCAD = null;
        InstalacionCEN instalacionCEN = null;
        InstalacionEN instalacionEN = null;
        InstalacionDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                instalacionRESTCAD = new InstalacionRESTCAD (session);
                instalacionCEN = new InstalacionCEN (unitRepo.instalacionrepository);

                // Data
                instalacionEN = instalacionCEN.Obtener (idInstalacion);

                // Convert return
                if (instalacionEN != null) {
                        returnValue = InstalacionAssembler.Convert (instalacionEN, unitRepo, session);
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

[Route ("~/api/Instalacion/Listar")]

public ActionResult<System.Collections.Generic.List<InstalacionDTOA> > Listar (int p_identidad)
{
        // CAD, CEN, EN, returnValue

        InstalacionRESTCAD instalacionRESTCAD = null;
        InstalacionCEN instalacionCEN = null;


        System.Collections.Generic.List<InstalacionEN> en;

        System.Collections.Generic.List<InstalacionDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                instalacionRESTCAD = new InstalacionRESTCAD (session);
                instalacionCEN = new InstalacionCEN (unitRepo.instalacionrepository);

                // CEN return



                en = instalacionCEN.Listar (p_identidad).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<InstalacionDTOA>();
                        foreach (InstalacionEN entry in en)
                                returnValue.Add (InstalacionAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Instalacion/Crear")]

public ActionResult<InstalacionDTOA> Crear ( [FromBody] InstalacionDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        InstalacionRESTCAD instalacionRESTCAD = null;
        InstalacionCEN instalacionCEN = null;
        InstalacionDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                instalacionRESTCAD = new InstalacionRESTCAD (session);
                instalacionCEN = new InstalacionCEN (unitRepo.instalacionrepository);

                // Create
                returnOID = instalacionCEN.Crear (
                        dto.Nombre                                                                               //Atributo Primitivo: p_nombre
                        ,
                        //Atributo OID: p_entidad
                        // attr.estaRelacionado: true
                        dto.Entidad_oid                 // association role

                        , dto.Visible                                                                                                                                                    //Atributo Primitivo: p_visible
                        , dto.Latitud                                                                                                                                                    //Atributo Primitivo: p_latitud
                        , dto.Longitud                                                                                                                                                   //Atributo Primitivo: p_longitud
                        , dto.Telefono                                                                                                                                                   //Atributo Primitivo: p_telefono
                        , dto.Domicilio                                                                                                                                                  //Atributo Primitivo: p_domicilio
                        , dto.Ubicacion                                                                                                                                                  //Atributo Primitivo: p_ubicacion
                        , dto.Codigopostal                                                                                                                                                       //Atributo Primitivo: p_codigopostal
                        , dto.Localidad                                                                                                                                                  //Atributo Primitivo: p_localidad
                        , dto.Provincia                                                                                                                                                  //Atributo Primitivo: p_provincia
                        , dto.Telefonoalternativo,
                        dto.Email//Atributo Primitivo: p_telefonoalternativo
                        );
                session.Commit ();

                // Convert return
                returnValue = InstalacionAssembler.Convert (instalacionRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Instalacion/Crear/" + returnOID, returnValue);
}





[HttpPut]

[Route ("~/api/Instalacion/Editar")]

public ActionResult<InstalacionDTOA> Editar (int idInstalacion, [FromBody] InstalacionDTO dto)
{
        // CAD, CEN, returnValue
        InstalacionRESTCAD instalacionRESTCAD = null;
        InstalacionCEN instalacionCEN = null;
        InstalacionDTOA returnValue = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                instalacionRESTCAD = new InstalacionRESTCAD (session);
                instalacionCEN = new InstalacionCEN (unitRepo.instalacionrepository);

                // Modify
                instalacionCEN.Editar (idInstalacion,
                        dto.Nombre
                        ,
                        dto.Telefono
                        ,
                        dto.Domicilio
                        ,
                        dto.Ubicacion
                        ,
                        dto.Codigopostal
                        ,
                        dto.Localidad
                        ,
                        dto.Provincia
                        ,
                        dto.Telefonoalternativo
                        ,
                        dto.Latitud
                        ,
                        dto.Longitud,
                        dto.Email
                        );

                // Return modified object
                returnValue = InstalacionAssembler.Convert (instalacionRESTCAD.ReadOIDDefault (idInstalacion), unitRepo, session);

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


[Route ("~/api/Instalacion/Eliminar")]

public ActionResult Eliminar (int p_instalacion_oid)
{
        // CAD, CEN
        InstalacionRESTCAD instalacionRESTCAD = null;
        InstalacionCEN instalacionCEN = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                instalacionRESTCAD = new InstalacionRESTCAD (session);
                instalacionCEN = new InstalacionCEN (unitRepo.instalacionrepository);

                instalacionCEN.Eliminar (p_instalacion_oid);
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

/*PROTECTED REGION ID(TFM_REST_InstalacionControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
[HttpPut]

[Route ("~/api/Instalacion/Asignarpista")]

public ActionResult Asignarpista (int p_instalacion_oid, System.Collections.Generic.IList<int> p_pistas_oids)
{
        // CAD, CEN, returnValue
        InstalacionRESTCAD instalacionRESTCAD = null;
        InstalacionCP instalacionCP = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                instalacionRESTCAD = new InstalacionRESTCAD (session);
                instalacionCP = new InstalacionCP (session, unitRepo);

                // Relationer
                instalacionCP.Asignarpista (p_instalacion_oid, p_pistas_oids);
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

[Route ("~/api/Instalacion/Asignarimagen")]


public ActionResult Asignarimagen (int p_oid, string p_imagen)
{
        // CAD, CEN, returnValue
        InstalacionRESTCAD instalacionRESTCAD = null;
        InstalacionCEN instalacionCEN = null;
        StatusCodeResult result;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                instalacionRESTCAD = new InstalacionRESTCAD (session);
                instalacionCEN = new InstalacionCEN (unitRepo.instalacionrepository);


                // Operation
                instalacionCEN.Asignarimagen (p_oid, p_imagen);
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

[Route ("~/api/Instalacion/Listarfiltros")]

public ActionResult<System.Collections.Generic.List<InstalacionDTOA> > Listarfiltros ([FromBody] FilterReservaDTO filtro)
{
        // CP, returnValue
        InstalacionCP instalacionCP = null;

        System.Collections.Generic.List<InstalacionDTOA> returnValue = null;
        System.Collections.Generic.List<InstalacionEN> en;

        try
        {
                session.SessionInitializeTransaction ();

                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                instalacionCP = new InstalacionCP (session, unitRepo);

                // Operation
                en = instalacionCP.Listarfiltros (filtro.Filtro, filtro.Localidad, filtro.Latitud, filtro.Longitud, filtro.Fecha, filtro.Deporte, filtro.Orden, true, id).ToList ();
                session.Commit ();

                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<InstalacionDTOA>();
                        foreach (InstalacionEN entry in en)
                                returnValue.Add (InstalacionAssembler.Convert (entry, unitRepo, session));
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

        [HttpGet]





        [Route("~/api/Instalacion/ObtenerInstalacionesFavoritas")]

        public ActionResult<List<InstalacionDTOA>> ObtenerInstalacionesFavoritas(int idUsuarioRegistrado)
        {
            // CAD, EN
            UsuarioRegistradoRESTCAD usuarioRegistradoRESTCAD = null;
            UsuarioEN usuarioEN = null;

            // returnValue
            List<InstalacionEN> en = null;
            List<InstalacionDTOA> returnValue = null;

            try
            {
                session.SessionInitializeWithoutTransaction();
                string token = "";
                if (Request.Headers["Authorization"].Count > 0)
                    token = Request.Headers["Authorization"].ToString();
                new UsuarioCEN(unitRepo.usuariorepository).CheckToken(token);


                usuarioRegistradoRESTCAD = new UsuarioRegistradoRESTCAD(session);

                // Exists UsuarioRegistrado
                usuarioEN = usuarioRegistradoRESTCAD.ReadOIDDefault(idUsuarioRegistrado);
                if (usuarioEN == null) return NotFound();

                // Rol
                // TODO: paginación


                en = usuarioRegistradoRESTCAD.ObtenerInstalacionesFavoritas(idUsuarioRegistrado).ToList();



                // Convert return
                if (en != null)
                {
                    returnValue = new List<InstalacionDTOA>();
                    foreach (InstalacionEN entry in en)
                        returnValue.Add(InstalacionAssembler.Convert(entry, unitRepo, session));
                }
            }

            catch (Exception e)
            {
                StatusCodeResult result = StatusCode(500);
                if (e.GetType() == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) && e.Message.Equals("El token es incorrecto")) result = StatusCode(403);
                else if (e.GetType() == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) || e.GetType() == typeof(TFMGen.ApplicationCore.Exceptions.DataLayerException)) result = StatusCode(400);
                return result;
            }
            finally
            {
                session.SessionClose();
            }

            // Return 204 - Empty
            if (returnValue == null || returnValue.Count == 0)
                return StatusCode(204);
            // Return 200 - OK
            else return returnValue;
        }

        [HttpPost]

        [Route("~/api/Instalacion/ObtenerPistasDisponibles")]

        public ActionResult<System.Collections.Generic.List<PistaDTOA>> ObtenerPistasDisponibles(int p_oid, [FromBody]Nullable<DateTime> p_fecha)
        {
            // CP, returnValue
            InstalacionCP instalacionCP = null;

            System.Collections.Generic.List<PistaDTOA> returnValue = null;
            System.Collections.Generic.List<PistaEN> en;

            try
            {
                session.SessionInitializeTransaction();

                string token = "";
                if (Request.Headers["Authorization"].Count > 0)
                    token = Request.Headers["Authorization"].ToString();
                int id = new UsuarioCEN(unitRepo.usuariorepository).CheckToken(token);




                instalacionCP = new InstalacionCP(session, unitRepo);

                // Operation
                en = instalacionCP.ObtenerPistasDisponibles(p_oid, p_fecha, true).ToList();
                session.Commit();

                // Convert return
                if (en != null)
                {
                    returnValue = new System.Collections.Generic.List<PistaDTOA>();
                    foreach (PistaEN entry in en)
                        returnValue.Add(PistaAssembler.Convert(entry, unitRepo, session));
                }
            }

            catch (Exception e)
            {
                session.RollBack();

                StatusCodeResult result = StatusCode(500);
                if (e.GetType() == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) && e.Message.Equals("El token es incorrecto")) result = StatusCode(403);
                else if (e.GetType() == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) || e.GetType() == typeof(TFMGen.ApplicationCore.Exceptions.DataLayerException)) result = StatusCode(400);
                return result;
            }
            finally
            {
                session.SessionClose();
            }

            // Return 200 - OK
            return returnValue;
        }


        [HttpGet]

        [Route("~/api/Instalacion/Esfavorita")]


        public ActionResult<bool>

Esfavorita(int p_oid)
        {
            // CAD, CEN, returnValue
            InstalacionRESTCAD instalacionRESTCAD = null;
            InstalacionCEN instalacionCEN = null;
            bool returnValue;

            try
            {
                session.SessionInitializeTransaction();
                string token = "";
                if (Request.Headers["Authorization"].Count > 0)
                    token = Request.Headers["Authorization"].ToString();
                int id = new UsuarioCEN(unitRepo.usuariorepository).CheckToken(token);



                instalacionRESTCAD = new InstalacionRESTCAD(session);
                instalacionCEN = new InstalacionCEN(unitRepo.instalacionrepository);


                // Operation
                returnValue = instalacionCEN.Esfavorita(p_oid, id);
                session.Commit();
            }

            catch (Exception e)
            {
                session.RollBack();

                StatusCodeResult result = StatusCode(500);
                if (e.GetType() == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) && e.Message.Equals("El token es incorrecto")) result = StatusCode(403);
                else if (e.GetType() == typeof(TFMGen.ApplicationCore.Exceptions.ModelException) || e.GetType() == typeof(TFMGen.ApplicationCore.Exceptions.DataLayerException)) result = StatusCode(400);
                return result;
            }
            finally
            {
                session.SessionClose();
            }

            // Return 200 - OK
            return returnValue;
        }



        /*PROTECTED REGION END*/
    }
}
