
using System;
using System.Text;

using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CP.TFM_Reserva_partidoDisponible) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CP.TFM
{
    public partial class ReservaCP : GenericBasicCP
    {
        public bool PartidoDisponible(int p_oid, int p_idusuario)
        {
            /*PROTECTED REGION ID(TFMGen.ApplicationCore.CP.TFM_Evento_eventodisponible) ENABLED START*/

            ReservaCEN reservaCEN = null;

            bool result = false;


            try
            {
                CPSession.SessionInitializeTransaction();
                reservaCEN = new ReservaCEN(unitRepo.reservarepository);
                unitRepo.reservarepository.setSessionCP(CPSession);

                var reserva = reservaCEN.Obtener(p_oid);

                if (reserva.Maxparticipantes == reserva.Inscripciones.Where(r => r.Pago != null).Count())
                    result = false;
                else
                {
                    var reservas = reserva.Inscripciones.ToList();

                    if (reservas != null && reservas.Count > 0 && reservas.Any(r => r.Pago == null && r.Usuario.Idusuario == p_idusuario && r.FechaCreacion < DateTime.Now.AddMinutes(-10)))
                    {
                        reservaCEN.Eliminar(reservas.Where(r => r.Pago == null && r.Usuario.Idusuario == p_idusuario && r.FechaCreacion < DateTime.Now.AddMinutes(-10)).Select(r => r.Idreserva).FirstOrDefault());
                        result = false;
                    }
                    if (reserva.Maxparticipantes == reserva.Inscripciones.Where(r => r.Pago != null).Count() + 1)
                        result = !(reservas != null && reservas.Count > 0 && ((reservas.Any(r => r.Pago != null && !r.Cancelada) || reservas.Any(r => r.Usuario.Idusuario != p_idusuario && r.Pago == null && r.FechaCreacion > DateTime.Now.AddMinutes(-10)))));
                    else
                        result = true;
                }




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
