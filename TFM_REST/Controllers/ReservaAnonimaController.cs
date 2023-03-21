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


/*PROTECTED REGION ID(usingTFM_REST_ReservaAnonimaControllerAzure) ENABLED START*/
// Meter las referencias para las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/



namespace TFM_REST.Controllers
{
[ApiController]
[Route ("~/api/ReservaAnonima")]
public class ReservaAnonimaController : BasicController
{
// Voy a generar el readAll











[HttpGet]
// [Route("{idReservaAnonima}", Name="GetOIDReservaAnonima")]

[Route ("~/api/ReservaAnonima/{idReservaAnonima}")]

public ActionResult<ReservaAnonimaDTOA> Obtener (int idReservaAnonima)
{
        // CAD, CEN, EN, returnValue
        ReservaAnonimaRESTCAD reservaAnonimaRESTCAD = null;
        ReservaCEN reservaCEN = null;
        ReservaEN reservaEN = null;
        ReservaAnonimaDTOA returnValue = null;

        try
        {
                session.SessionInitializeWithoutTransaction ();


                reservaAnonimaRESTCAD = new ReservaAnonimaRESTCAD (session);
                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // Data
                reservaEN = reservaCEN.Obtener (idReservaAnonima);

                // Convert return
                if (reservaEN != null) {
                        returnValue = ReservaAnonimaAssembler.Convert (reservaEN, unitRepo, session);
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






[HttpPost]

[Route ("~/api/ReservaAnonima/Crear")]

public ActionResult<ReservaAnonimaDTOA> Crear ( [FromBody] ReservaDTO dto)
{
        // CAD, CEN, returnValue, returnOID
        ReservaAnonimaRESTCAD reservaAnonimaRESTCAD = null;
        ReservaCEN reservaCEN = null;
        ReservaAnonimaDTOA returnValue = null;
        int returnOID = -1;

        try
        {
                session.SessionInitializeTransaction ();


                reservaAnonimaRESTCAD = new ReservaAnonimaRESTCAD (session);
                reservaCEN = new ReservaCEN (unitRepo.reservarepository);

                // Create
                returnOID = reservaCEN.Crear (
                        dto.Nombre                                                                               //Atributo Primitivo: p_nombre
                        , dto.Apellidos                                                                                                                                                  //Atributo Primitivo: p_apellidos
                        , dto.Email                                                                                                                                                      //Atributo Primitivo: p_email
                        , dto.Telefono                                                                                                                                                   //Atributo Primitivo: p_telefono
                        , dto.Cancelada                                                                                                                                                  //Atributo Primitivo: p_cancelada
                        ,
                        //Atributo OID: p_pista
                        // attr.estaRelacionado: true
                        dto.Pista_oid                 // association role

                        , dto.Maxparticipantes                                                                                                                                                   //Atributo Primitivo: p_maxparticipantes
                        ,
                        //Atributo OID: p_horario
                        // attr.estaRelacionado: true
                        dto.Horario_oid                 // association role

                        , dto.Fecha                                                                                                                                                      //Atributo Primitivo: p_fecha
                        , dto.Tipo                                                                                                                                                       //Atributo Primitivo: p_tipo
                        ,
                        //Atributo OID: p_usuario
                        // attr.estaRelacionado: true
                        dto.Usuario_oid                 // association role

                        );
                session.Commit ();

                // Convert return
                returnValue = ReservaAnonimaAssembler.Convert (reservaAnonimaRESTCAD.ReadOIDDefault (returnOID), unitRepo, session);
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


        return Created ("~/api/ReservaAnonima/Crear/" + returnOID, returnValue);
}
















/*PROTECTED REGION ID(TFM_REST_ReservaAnonimaControllerAzure) ENABLED START*/
// Meter las operaciones que invoquen a las CPs
/*PROTECTED REGION END*/
}
}
