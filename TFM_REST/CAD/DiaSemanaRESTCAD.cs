
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
public class DiaSemanaRESTCAD : DiaSemanaRepository
{
public DiaSemanaRESTCAD()
        : base ()
{
}

public DiaSemanaRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<DiaSemana_l10nEN> ObtenerTraduccionesDiaSemana (int iddiasemana)
{
        IList<DiaSemana_l10nEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM DiaSemana_l10nNH self inner join self.DiaSemana as target with target.Iddiasemana=:p_Iddiasemana";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Iddiasemana", iddiasemana);




                result = query.List<DiaSemana_l10nEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemanaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
