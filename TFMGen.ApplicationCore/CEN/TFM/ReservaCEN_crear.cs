
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Reserva_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ReservaCEN
{
public int Crear (string p_nombre, string p_apellidos, string p_email, string p_telefono, bool p_cancelada, int p_pista, bool p_espartido, int p_maxparticipantes, Nullable<DateTime> p_fecha, Nullable<DateTime> p_fechapago)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Reserva_crear_customized) START*/

        ReservaEN reservaEN = null;

        int oid;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.Nombre = p_nombre;

        reservaEN.Apellidos = p_apellidos;

        reservaEN.Email = p_email;

        reservaEN.Telefono = p_telefono;

        reservaEN.Cancelada = p_cancelada;


        if (p_pista != -1) {
                reservaEN.Pista = new TFMGen.ApplicationCore.EN.TFM.PistaEN ();
                reservaEN.Pista.Idpista = p_pista;
        }

        reservaEN.Espartido = p_espartido;

        reservaEN.Maxparticipantes = p_maxparticipantes;

        reservaEN.Fecha = p_fecha;

        reservaEN.Fechapago = p_fechapago;

        //Call to ReservaRepository

        oid = _IReservaRepository.Crear (reservaEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
