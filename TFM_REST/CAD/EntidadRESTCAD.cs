
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
public class EntidadRESTCAD : EntidadRepository
{
public EntidadRESTCAD()
        : base ()
{
}

public EntidadRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<ValoracionEN> ObtenerValoracionesEntidad (int identidad)
{
        IList<ValoracionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ValoracionNH self inner join self.Entidad as target with target.Identidad=:p_Identidad";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Identidad", identidad);




                result = query.List<ValoracionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<NotificacionEN> ObtenerNotificacionesEntidad (int identidad)
{
        IList<NotificacionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM NotificacionNH self inner join self.Entidad as target with target.Identidad=:p_Identidad";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Identidad", identidad);




                result = query.List<NotificacionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<UsuarioEN> ObtenerUsuarios (int identidad)
{
        IList<UsuarioEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM UsuarioNH self inner join self.Entidad as target with target.Identidad=:p_Identidad";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Identidad", identidad);




                result = query.List<UsuarioEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
