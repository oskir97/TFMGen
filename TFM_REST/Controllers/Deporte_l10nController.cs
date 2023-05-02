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


/*PROTECTED REGION ID(usingTFM_REST_Deporte_l10nControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Deporte_l10n")]
public class Deporte_l10nController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Deporte_l10n/Listartodos")]
public ActionResult<List<Deporte_l10nDTOA> > Listartodos ()
{
        // CAD, CEN, EN, returnValue
        Deporte_l10nRESTCAD deporte_l10nRESTCAD = null;
        Deporte_l10nCEN deporte_l10nCEN = null;

        List<Deporte_l10nEN> deporte_l10nEN = null;
        List<Deporte_l10nDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                deporte_l10nCEN = new Deporte_l10nCEN (unitRepo.deporte_l10nrepository);

                // Data
                // TODO: paginación

                deporte_l10nEN = deporte_l10nCEN.Listartodos (0, -1).ToList ();

                // Convert return
                if (deporte_l10nEN != null) {
                        returnValue = new List<Deporte_l10nDTOA>();
                        foreach (Deporte_l10nEN entry in deporte_l10nEN)
                                returnValue.Add (Deporte_l10nAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Deporte_l10n/Listar")]

public ActionResult<System.Collections.Generic.List<Deporte_l10nDTOA> > Listar (int p_ididioma)
{
        // CAD, CEN, EN, returnValue

        Deporte_l10nRESTCAD deporte_l10nRESTCAD = null;
        Deporte_l10nCEN deporte_l10nCEN = null;


        System.Collections.Generic.List<Deporte_l10nEN> en;

        System.Collections.Generic.List<Deporte_l10nDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();



                deporte_l10nRESTCAD = new Deporte_l10nRESTCAD (session);
                deporte_l10nCEN = new Deporte_l10nCEN (unitRepo.deporte_l10nrepository);

                // CEN return



                en = deporte_l10nCEN.Listar (p_ididioma).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<Deporte_l10nDTOA>();
                        foreach (Deporte_l10nEN entry in en)
                                returnValue.Add (Deporte_l10nAssembler.Convert (entry, unitRepo, session));
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




















/*PROTECTED REGION ID(TFM_REST_Deporte_l10nControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
