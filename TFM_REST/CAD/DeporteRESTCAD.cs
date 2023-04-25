
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
public class DeporteRESTCAD : DeporteRepository
{
public DeporteRESTCAD()
        : base ()
{
}

public DeporteRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<Deporte_l10nEN> TraduccionesDeporte (int iddeporte)
{
        IList<Deporte_l10nEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM Deporte_l10nNH self inner join self.Deporte as target with target.Iddeporte=:p_Iddeporte";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Iddeporte", iddeporte);




                result = query.List<Deporte_l10nEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DeporteRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
