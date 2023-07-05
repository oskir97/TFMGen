
using System;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using System.Collections.Generic;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.Infraestructure.Repository.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFM_REST.CAD
{
public class ReservaRESTCAD : ReservaRepository
{
public ReservaRESTCAD()
        : base ()
{
}

public ReservaRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public PistaEN ObtenerPista (int idreserva)
{
        PistaEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Pista FROM ReservaNH self " +
                             "where self.Idreserva = :p_Idreserva";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idreserva", idreserva);




                result = query.UniqueResult<PistaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public PagoEN GetPagoOfReserva (int idreserva)
{
        PagoEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Pago FROM ReservaNH self " +
                             "where self.Idreserva = :p_Idreserva";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idreserva", idreserva);




                result = query.UniqueResult<PagoEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public UsuarioEN ObtenerUsuarioCreador (int idreserva)
{
        UsuarioEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Usuario FROM ReservaNH self " +
                             "where self.Idreserva = :p_Idreserva";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idreserva", idreserva);




                result = query.UniqueResult<UsuarioEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<NotificacionEN> ObtenerNotificacionesReserva (int idreserva)
{
        IList<NotificacionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM NotificacionNH self inner join self.Reserva as target with target.Idreserva=:p_Idreserva";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idreserva", idreserva);




                result = query.List<NotificacionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public HorarioEN ObtenerHorarioReserva (int idreserva)
{
        HorarioEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Horario FROM ReservaNH self " +
                             "where self.Idreserva = :p_Idreserva";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idreserva", idreserva);




                result = query.UniqueResult<HorarioEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public DeporteEN ObtenerDeporteReserva (int idreserva)
{
        DeporteEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Deporte FROM ReservaNH self " +
                             "where self.Idreserva = :p_Idreserva";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idreserva", idreserva);




                result = query.UniqueResult<DeporteEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public EventoEN ObtenerEventoReserva (int idreserva)
{
        EventoEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Evento FROM ReservaNH self " +
                             "where self.Idreserva = :p_Idreserva";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idreserva", idreserva);




                result = query.UniqueResult<EventoEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public ReservaEN ObtenerPartidoReserva (int idreserva)
{
        ReservaEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Partido FROM ReservaNH self " +
                             "where self.Idreserva = :p_Idreserva";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idreserva", idreserva);




                result = query.UniqueResult<ReservaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
