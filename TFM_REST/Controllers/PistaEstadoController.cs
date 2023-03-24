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


/*PROTECTED REGION ID(usingTFM_REST_PistaEstadoControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/PistaEstado")]
public class PistaEstadoController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/PistaEstado/Listar")]
public ActionResult<List<PistaEstadoDTOA> > Listar ()
{
        // CAD, CEN, EN, returnValue
        PistaEstadoRESTCAD pistaEstadoRESTCAD = null;
        PistaEstadoCEN pistaEstadoCEN = null;

        List<PistaEstadoEN> pistaEstadoEN = null;
        List<PistaEstadoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                pistaEstadoCEN = new PistaEstadoCEN (unitRepo.pistaestadorepository);

                // Data
                // TODO: paginación

                pistaEstadoEN = pistaEstadoCEN.Listar (0, -1).ToList ();

                // Convert return
                if (pistaEstadoEN != null) {
                        returnValue = new List<PistaEstadoDTOA>();
                        foreach (PistaEstadoEN entry in pistaEstadoEN)
                                returnValue.Add (PistaEstadoAssembler.Convert (entry, unitRepo, session));
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






























/*PROTECTED REGION ID(TFM_REST_PistaEstadoControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
