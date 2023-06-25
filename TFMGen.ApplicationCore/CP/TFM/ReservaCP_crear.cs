
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Reserva_crear) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
    public partial class ReservaCP : GenericBasicCP
    {
        public TFMGen.ApplicationCore.EN.TFM.ReservaEN Crear(string p_nombre, string p_apellidos, string p_email, string p_telefono, bool p_cancelada, int p_pista, int p_maxparticipantes, int p_horario, Nullable<DateTime> p_fecha, TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum p_tipo, int p_usuario, int p_deporte, int p_evento)
        {
            /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Reserva_crear) ENABLED START*/

            ReservaCEN reservaCEN = null;

            TFMGen.ApplicationCore.EN.TFM.ReservaEN result = null;


            try
            {
                CPSession.SessionInitializeTransaction();
                reservaCEN = new ReservaCEN(unitRepo.reservarepository);

                var reservas = reservaCEN.Listarreservasusuario(p_usuario);
                if (reservas != null && reservas.Count > 0 && reservas.Any(r => r.Pago == null && r.Usuario.Idusuario == p_usuario && r.FechaCreacion < DateTime.Now.AddMinutes(-10)))
                {
                    foreach (var idreserva in reservas.Where(r => r.Pago == null && r.Usuario.Idusuario == p_usuario && r.FechaCreacion < DateTime.Now.AddMinutes(-10)).Select(r => r.Idreserva).ToList())
                    {
                        reservaCEN.Eliminar(idreserva);
                    }
                }

                int oid;
                //Initialized ReservaEN
                ReservaEN reservaEN;
                reservaEN = new ReservaEN();
                reservaEN.Nombre = p_nombre;

                reservaEN.Apellidos = p_apellidos;

                reservaEN.Email = p_email;

                reservaEN.Telefono = p_telefono;

                reservaEN.Cancelada = p_cancelada;

                reservaEN.FechaCreacion = DateTime.Now;


                if (p_pista != -1)
                {
                    reservaEN.Pista = new TFMGen.ApplicationCore.EN.TFM.PistaEN();
                    reservaEN.Pista.Idpista = p_pista;
                }

                reservaEN.Maxparticipantes = p_maxparticipantes;


                if (p_horario != -1)
                {
                    reservaEN.Horario = new TFMGen.ApplicationCore.EN.TFM.HorarioEN();
                    reservaEN.Horario.Idhorario = p_horario;
                }

                reservaEN.Fecha = p_fecha;

                reservaEN.Tipo = p_tipo;


                if (p_usuario != -1)
                {
                    reservaEN.Usuario = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN();
                    reservaEN.Usuario.Idusuario = p_usuario;
                }


                if (p_deporte != -1)
                {
                    reservaEN.Deporte = new TFMGen.ApplicationCore.EN.TFM.DeporteEN();
                    reservaEN.Deporte.Iddeporte = p_deporte;
                }


                if (p_evento != -1)
                {
                    reservaEN.Evento = new TFMGen.ApplicationCore.EN.TFM.EventoEN();
                    reservaEN.Evento.Idevento = p_evento;
                }



                oid = reservaCEN.get_IReservaRepository().Crear(reservaEN);

                result = reservaCEN.get_IReservaRepository().ReadOIDDefault(oid);



                CPSession.Commit();
            }
            catch (Exception ex)
            {
                CPSession.RollBack();
                throw ex;
            }
            finally
            {
                CPSession.SessionClose();
            }
            return result;


            /*PROTECTED REGION END*/
        }
    }
}
