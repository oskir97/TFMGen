
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
public class RolRESTCAD : RolRepository
{
public RolRESTCAD()
        : base ()
{
}

public RolRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<Rol_l10nEN> ObtenerTraduccionesRol (int idrol)
{
        IList<Rol_l10nEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM Rol_l10nNH self inner join self.Rol as target with target.Idrol=:p_Idrol";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idrol", idrol);




                result = query.List<Rol_l10nEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in RolRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
