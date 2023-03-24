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


/*PROTECTED REGION ID(usingTFM_REST_MaterialControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Material")]
public class MaterialController : BasicController
{
// Voy a generar el readAll












[HttpGet]
// [Route("{idMaterial}", Name="GetOIDMaterial")]

[Route ("~/api/Material/{idMaterial}")]

public ActionResult<MaterialDTOA> Obtener (int idMaterial)
{
        // CAD, CEN, EN, returnValue
        MaterialRESTCAD materialRESTCAD = null;
        MaterialCEN materialCEN = null;
        MaterialEN materialEN = null;
        MaterialDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                materialRESTCAD = new MaterialRESTCAD (session);
                materialCEN = new MaterialCEN (unitRepo.materialrepository);

                // Data
                materialEN = materialCEN.Obtener (idMaterial);

                // Convert return
                if (materialEN != null) {
                        returnValue = MaterialAssembler.Convert (materialEN, unitRepo, session);
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

[Route ("~/api/Material/Listar")]

public ActionResult<System.Collections.Generic.List<MaterialDTOA> > Listar (int p_idinstalacion)
{
        // CAD, CEN, EN, returnValue

        MaterialRESTCAD materialRESTCAD = null;
        MaterialCEN materialCEN = null;


        System.Collections.Generic.List<MaterialEN> en;

        System.Collections.Generic.List<MaterialDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                materialRESTCAD = new MaterialRESTCAD (session);
                materialCEN = new MaterialCEN (unitRepo.materialrepository);

                // CEN return



                en = materialCEN.Listar (p_idinstalacion).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<MaterialDTOA>();
                        foreach (MaterialEN entry in en)
                                returnValue.Add (MaterialAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Material/Crear")]

public ActionResult<MaterialDTOA> Crear ( [FromBody] MaterialDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        MaterialRESTCAD materialRESTCAD = null;
        MaterialCEN materialCEN = null;
        MaterialDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                materialRESTCAD = new MaterialRESTCAD (session);
                materialCEN = new MaterialCEN (unitRepo.materialrepository);

                // Create
                returnOID = materialCEN.Crear (
                        dto.Nombre                                                                               //Atributo Primitivo: p_nombre
                        , dto.Precio                                                                                                                                                     //Atributo Primitivo: p_precio
                        , dto.Proveedor                                                                                                                                                  //Atributo Primitivo: p_proveedor
                        ,
                        //Atributo OID: p_instalacion
                        // attr.estaRelacionado: true
                        dto.Instalacion_oid                 // association role

                        , dto.Descripcion                                                                                                                                                //Atributo Primitivo: p_descripcion
                        , dto.Numexistencias                                                                                                                                                     //Atributo Primitivo: p_numexistencias
                        , dto.Numeroproveedor                                                                                                                                                    //Atributo Primitivo: p_numeroproveedor
                        , dto.Numeroalternativoproveedor                                                                                                                                                 //Atributo Primitivo: p_numeroalternativoproveedor
                        , dto.Emailproveedor                                                                                                                                                     //Atributo Primitivo: p_emailproveedor
                        );
                session.Commit ();

                // Convert return
                returnValue = MaterialAssembler.Convert (materialRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Material/Crear/" + returnOID, returnValue);
}





[HttpPut]

[Route ("~/api/Material/Editar")]

public ActionResult<MaterialDTOA> Editar (int idMaterial, [FromBody] MaterialDTO dto)
{
        // CAD, CEN, returnValue
        MaterialRESTCAD materialRESTCAD = null;
        MaterialCEN materialCEN = null;
        MaterialDTOA returnValue = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                materialRESTCAD = new MaterialRESTCAD (session);
                materialCEN = new MaterialCEN (unitRepo.materialrepository);

                // Modify
                materialCEN.Editar (idMaterial,
                        dto.Nombre
                        ,
                        dto.Precio
                        ,
                        dto.Proveedor
                        ,
                        dto.Descripcion
                        ,
                        dto.Numexistencias
                        ,
                        dto.Numeroproveedor
                        ,
                        dto.Numeroalternativoproveedor
                        ,
                        dto.Emailproveedor
                        );

                // Return modified object
                returnValue = MaterialAssembler.Convert (materialRESTCAD.ReadOIDDefault (idMaterial), unitRepo, session);

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


[Route ("~/api/Material/Eliminar")]

public ActionResult Eliminar (int p_material_oid)
{
        // CAD, CEN
        MaterialRESTCAD materialRESTCAD = null;
        MaterialCEN materialCEN = null;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                materialRESTCAD = new MaterialRESTCAD (session);
                materialCEN = new MaterialCEN (unitRepo.materialrepository);

                materialCEN.Eliminar (p_material_oid);
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









/*PROTECTED REGION ID(TFM_REST_MaterialControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
