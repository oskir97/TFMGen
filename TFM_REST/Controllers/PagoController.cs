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


/*PROTECTED REGION ID(usingTFM_REST_PagoControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/Pago")]
public class PagoController : BasicController
{
// Voy a generar el readAll



// ReadAll Generado a partir del NavigationalOperation
[HttpGet]

[Route ("~/api/Pago/Listartodos")]
public ActionResult<List<PagoDTOA> > Listartodos ()
{
        // CAD, CEN, EN, returnValue
        PagoRESTCAD pagoRESTCAD = null;
        PagoCEN pagoCEN = null;

        List<PagoEN> pagoEN = null;
        List<PagoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pagoCEN = new PagoCEN (unitRepo.pagorepository);

                // Data
                // TODO: paginación

                pagoEN = pagoCEN.Listartodos (0, -1).ToList ();

                // Convert return
                if (pagoEN != null) {
                        returnValue = new List<PagoDTOA>();
                        foreach (PagoEN entry in pagoEN)
                                returnValue.Add (PagoAssembler.Convert (entry, unitRepo, session));
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
// [Route("{idPago}", Name="GetOIDPago")]

[Route ("~/api/Pago/{idPago}")]

public ActionResult<PagoDTOA> Obtener (int idPago)
{
        // CAD, CEN, EN, returnValue
        PagoRESTCAD pagoRESTCAD = null;
        PagoCEN pagoCEN = null;
        PagoEN pagoEN = null;
        PagoDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                pagoRESTCAD = new PagoRESTCAD (session);
                pagoCEN = new PagoCEN (unitRepo.pagorepository);

                // Data
                pagoEN = pagoCEN.Obtener (idPago);

                // Convert return
                if (pagoEN != null) {
                        returnValue = PagoAssembler.Convert (pagoEN, unitRepo, session);
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

[Route ("~/api/Pago/Listar")]

public ActionResult<System.Collections.Generic.List<PagoDTOA> > Listar (int p_idreserva)
{
        // CAD, CEN, EN, returnValue

        PagoRESTCAD pagoRESTCAD = null;
        PagoCEN pagoCEN = null;


        System.Collections.Generic.List<PagoEN> en;

        System.Collections.Generic.List<PagoDTOA> returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);




                pagoRESTCAD = new PagoRESTCAD (session);
                pagoCEN = new PagoCEN (unitRepo.pagorepository);

                // CEN return



                en = pagoCEN.Listar (p_idreserva).ToList ();




                // Convert return
                if (en != null) {
                        returnValue = new System.Collections.Generic.List<PagoDTOA>();
                        foreach (PagoEN entry in en)
                                returnValue.Add (PagoAssembler.Convert (entry, unitRepo, session));
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

[Route ("~/api/Pago/Crear")]

public ActionResult<PagoDTOA> Crear ( [FromBody] PagoDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        PagoRESTCAD pagoRESTCAD = null;
        PagoCEN pagoCEN = null;
        PagoDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();
                string token = "";
                if (Request.Headers ["Authorization"].Count > 0)
                        token = Request.Headers ["Authorization"].ToString ();
                int id = new UsuarioCEN (unitRepo.usuariorepository).CheckToken (token);



                pagoRESTCAD = new PagoRESTCAD (session);
                pagoCEN = new PagoCEN (unitRepo.pagorepository);

                // Create
                returnOID = pagoCEN.Crear (
                        dto.Subtotal                                                                             //Atributo Primitivo: p_subtotal
                        , dto.Total                                                                                                                                                      //Atributo Primitivo: p_total
                        , dto.Iva                                                                                                                                                //Atributo Primitivo: p_iva
                        ,
                        //Atributo OID: p_tipo
                        // attr.estaRelacionado: true
                        dto.Tipo_oid                 // association role

                        , dto.Fecha                                                                                                                                                      //Atributo Primitivo: p_fecha
                        ,
                        //Atributo OID: p_reserva
                        // attr.estaRelacionado: true
                        dto.Reserva_oid                 // association role

                        , dto.Token                                                                                                                                                      //Atributo Primitivo: p_token
                        );
                session.Commit ();

                // Convert return
                returnValue = PagoAssembler.Convert (pagoRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/Pago/Crear/" + returnOID, returnValue);
}
















/*PROTECTED REGION ID(TFM_REST_PagoControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
