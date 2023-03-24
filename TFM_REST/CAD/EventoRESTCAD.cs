
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
public class EventoRESTCAD : EventoRepository
{
public EventoRESTCAD()
        : base ()
{
}

public EventoRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<AsitenciaEN> ObtenerAsistenciasEvento (int idevento)
{
        IList<AsitenciaEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM AsitenciaNH self inner join self.Evento as target with target.Idevento=:p_Idevento";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idevento", idevento);




                result = query.List<AsitenciaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<UsuarioEN> ObtenerInstructores (int idevento)
{
        IList<UsuarioEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM UsuarioNH self inner join self.EventosImpartidos as target with target.Idevento=:p_Idevento";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idevento", idevento);




                result = query.List<UsuarioEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<UsuarioEN> ObtenerAlumnos (int idevento)
{
        IList<UsuarioEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM UsuarioNH self inner join self.Eventos as target with target.Idevento=:p_Idevento";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idevento", idevento);




                result = query.List<UsuarioEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IncidenciaEN> ObtenerIncidencias (int idevento)
{
        IList<IncidenciaEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM IncidenciaNH self inner join self.Evento as target with target.Idevento=:p_Idevento";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idevento", idevento);




                result = query.List<IncidenciaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
