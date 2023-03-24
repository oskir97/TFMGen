
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
public class InstalacionRESTCAD : InstalacionRepository
{
public InstalacionRESTCAD()
        : base ()
{
}

public InstalacionRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public EntidadEN ObtenerEntidadInstalacion (int idinstalacion)
{
        EntidadEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Entidad FROM InstalacionNH self " +
                             "where self.Idinstalacion = :p_Idinstalacion";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idinstalacion", idinstalacion);




                result = query.UniqueResult<EntidadEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<MaterialEN> ObtenerMateriales (int idinstalacion)
{
        IList<MaterialEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM MaterialNH self inner join self.Instalacion as target with target.Idinstalacion=:p_Idinstalacion";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idinstalacion", idinstalacion);




                result = query.List<MaterialEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<ValoracionEN> ObtenerValoracionesInstalacion (int idinstalacion)
{
        IList<ValoracionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ValoracionNH self inner join self.Instalacion as target with target.Idinstalacion=:p_Idinstalacion";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idinstalacion", idinstalacion);




                result = query.List<ValoracionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
