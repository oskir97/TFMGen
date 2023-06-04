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


/*PROTECTED REGION ID(usingTFM_REST_DeporteControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Deporte")]
public class DeporteController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Deporte/Listar")]
public ActionResult<List<DeporteDTOA> > Listar ()
{
        // CAD, CEN, EN, returnValue
        DeporteRESTCAD deporteRESTCAD = null;
        DeporteCEN deporteCEN = null;

        List<DeporteEN> deporteEN = null;
        List<DeporteDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                deporteCEN = new DeporteCEN (unitRepo.deporterepository);

                // Data
                // TODO: paginación

                deporteEN = deporteCEN.Listar (0, -1).ToList ();

                // Convert return
                if (deporteEN != null) {
                        returnValue = new List<DeporteDTOA>();
                        foreach (DeporteEN entry in deporteEN)
                                returnValue.Add (DeporteAssembler.Convert (entry, unitRepo, session));
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
































/*PROTECTED REGION ID(TFM_REST_DeporteControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
