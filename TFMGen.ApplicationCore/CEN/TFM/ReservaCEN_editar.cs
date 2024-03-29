
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Reserva_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ReservaCEN
{
public void Editar (int p_Reserva_OID, string p_nombre, string p_apellidos, string p_email, string p_telefono, bool p_cancelada, int p_maxparticipantes, Nullable<DateTime> p_fecha, TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum p_tipo, TFMGen.ApplicationCore.Enumerated.TFM.NivelPartidoEnum p_nivelpartido, int p_partido, string p_descripcion, string p_imagen)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Reserva_editar_customized) START*/

        ReservaEN reservaEN = null;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.Idreserva = p_Reserva_OID;
        reservaEN.Nombre = p_nombre;
        reservaEN.Apellidos = p_apellidos;
        reservaEN.Email = p_email;
        reservaEN.Telefono = p_telefono;
        reservaEN.Cancelada = p_cancelada;
        reservaEN.Maxparticipantes = p_maxparticipantes;
        reservaEN.Fecha = p_fecha;
        reservaEN.Tipo = p_tipo;
        reservaEN.Nivelpartido = p_nivelpartido;
        reservaEN.Idreserva = p_partido;
        reservaEN.Descripcionpartido = p_descripcion;
        reservaEN.Imagen = p_imagen;
        //Call to ReservaRepository

        _IReservaRepository.Editar (reservaEN);

        /*PROTECTED REGION END*/
}
}
}
