
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
public class UsuarioRESTCAD : UsuarioRepository
{
public UsuarioRESTCAD()
        : base ()
{
}

public UsuarioRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<AsitenciaEN> ObtenerAsistencias (int idusuario)
{
        IList<AsitenciaEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM AsitenciaNH self inner join self.Usuario as target with target.Idusuario=:p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.List<AsitenciaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<ReservaEN> ObtenerReservas (int idusuario)
{
        IList<ReservaEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ReservaNH self inner join self.Usuario as target with target.Idusuario=:p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.List<ReservaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<EventoEN> ObtenerEventosImpartidos (int idusuario)
{
        IList<EventoEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EventoNH self inner join self.Tecnicos as target with target.Idusuario=:p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.List<EventoEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<EventoEN> ObtenerEventosInscrito (int idusuario)
{
        IList<EventoEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EventoNH self inner join self.Usuarios as target with target.Idusuario=:p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.List<EventoEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<ValoracionEN> ObtenerValoracionesTecnicos (int idusuario)
{
        IList<ValoracionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ValoracionNH self inner join self.Tecnico as target with target.Idusuario=:p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.List<ValoracionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<ValoracionEN> ObtenerValoracionesRealizadas (int idusuario)
{
        IList<ValoracionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ValoracionNH self inner join self.Usuario as target with target.Idusuario=:p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.List<ValoracionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<NotificacionEN> ObtenerNotificacionesEnviadas (int idusuario)
{
        IList<NotificacionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM NotificacionNH self inner join self.Emisor as target with target.Idusuario=:p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.List<NotificacionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<NotificacionEN> ObtenerNotificacionesRecibidas (int idusuario)
{
        IList<NotificacionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM NotificacionNH self inner join self.Receptor as target with target.Idusuario=:p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.List<NotificacionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public RolEN ObtenerRol (int idusuario)
{
        RolEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Rol FROM UsuarioNH self " +
                             "where self.Idusuario = :p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.UniqueResult<RolEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
