
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
public int Crear (string p_nombre, string p_apellidos, string p_email, string p_telefono, bool p_cancelada, int p_pista, int p_maxparticipantes, int p_horario, Nullable<DateTime> p_fecha, TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum p_tipo, int p_usuario, int p_deporte, int p_evento, TFMGen.ApplicationCore.Enumerated.TFM.NivelPartidoEnum? p_nivelpartido)
        {
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Reserva_crear_customized) ENABLED START*/

        ReservaEN reservaEN = null;

        int oid;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.Nombre = p_nombre;

        reservaEN.Apellidos = p_apellidos;

        reservaEN.Email = p_email;

        reservaEN.Telefono = p_telefono;

        reservaEN.Cancelada = p_cancelada;

        reservaEN.FechaCreacion = DateTime.Now;


        if (p_pista > 0) {
                reservaEN.Pista = new TFMGen.ApplicationCore.EN.TFM.PistaEN ();
                reservaEN.Pista.Idpista = p_pista;
        }

        if (p_evento > 0) {
                reservaEN.Evento = new TFMGen.ApplicationCore.EN.TFM.EventoEN ();
                reservaEN.Evento.Idevento = p_evento;
        }

        if (p_deporte > 0) {
                reservaEN.Deporte = new TFMGen.ApplicationCore.EN.TFM.DeporteEN ();
                reservaEN.Deporte.Iddeporte = p_deporte;
        }

        reservaEN.Maxparticipantes = p_maxparticipantes;


        if (p_horario > 0) {
                reservaEN.Horario = new TFMGen.ApplicationCore.EN.TFM.HorarioEN ();
                reservaEN.Horario.Idhorario = p_horario;
        }

        reservaEN.Fecha = p_fecha;

        reservaEN.Tipo = p_tipo;

            if (p_nivelpartido != null && p_nivelpartido > 0)
                reservaEN.Nivelpartido = p_nivelpartido.Value;


            if (p_usuario > 0) {
                reservaEN.Usuario = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN ();
                reservaEN.Usuario.Idusuario = p_usuario;
        }

        //Call to ReservaRepository

        oid = _IReservaRepository.Crear (reservaEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
