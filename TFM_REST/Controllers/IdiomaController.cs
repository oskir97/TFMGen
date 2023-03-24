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


/*PROTECTED REGION ID(usingTFM_REST_IdiomaControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Idioma")]
public class IdiomaController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Idioma/Listar")]
public ActionResult<List<IdiomaDTOA> > Listar ()
{
        // CAD, CEN, EN, returnValue
        IdiomaRESTCAD idiomaRESTCAD = null;
        IdiomaCEN idiomaCEN = null;

        List<IdiomaEN> idiomaEN = null;
        List<IdiomaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                idiomaCEN = new IdiomaCEN (unitRepo.idiomarepository);

                // Data
                // TODO: paginación

                idiomaEN = idiomaCEN.Listar (0, -1).ToList ();

                // Convert return
                if (idiomaEN != null) {
                        returnValue = new List<IdiomaDTOA>();
                        foreach (IdiomaEN entry in idiomaEN)
                                returnValue.Add (IdiomaAssembler.Convert (entry, unitRepo, session));
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





























/*PROTECTED REGION ID(TFM_REST_IdiomaControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
