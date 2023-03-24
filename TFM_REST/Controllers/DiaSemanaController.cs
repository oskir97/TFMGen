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


/*PROTECTED REGION ID(usingTFM_REST_DiaSemanaControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/DiaSemana")]
public class DiaSemanaController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/DiaSemana/Listar")]
public ActionResult<List<DiaSemanaDTOA> > Listar ()
{
        // CAD, CEN, EN, returnValue
        DiaSemanaRESTCAD diaSemanaRESTCAD = null;
        DiaSemanaCEN diaSemanaCEN = null;

        List<DiaSemanaEN> diaSemanaEN = null;
        List<DiaSemanaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                diaSemanaCEN = new DiaSemanaCEN (unitRepo.diasemanarepository);

                // Data
                // TODO: paginación

                diaSemanaEN = diaSemanaCEN.Listar (0, -1).ToList ();

                // Convert return
                if (diaSemanaEN != null) {
                        returnValue = new List<DiaSemanaDTOA>();
                        foreach (DiaSemanaEN entry in diaSemanaEN)
                                returnValue.Add (DiaSemanaAssembler.Convert (entry, unitRepo, session));
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












// No pasa el slEnables: obtener

[HttpGet]

[Route ("~/api/DiaSemana/Obtener")]

public ActionResult<System.Collections.Generic.List<DiaSemanaDTOA> > Obtener (string p_dia)
{
        // CAD, CEN, EN, returnValue

        DiaSemanaRESTCAD diaSemanaRESTCAD = null;
        DiaSemanaCEN diaSemanaCEN = null;


        System.Collections.Generic.List<DiaSemanaEN> en;

        System.Collections.Generic.List<DiaSemanaDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                diaSemanaRESTCAD = new DiaSemanaRESTCAD (session);
                diaSemanaCEN = new DiaSemanaCEN (unitRepo.diasemanarepository);

                // CEN return



                en = diaSemanaCEN.Obtener (p_dia).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<DiaSemanaDTOA>();
                        foreach (DiaSemanaEN entry in en)
                                returnValue.Add (DiaSemanaAssembler.Convert (entry, unitRepo, session));
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




















/*PROTECTED REGION ID(TFM_REST_DiaSemanaControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
