
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
public class Deporte_l10nRESTCAD : Deporte_l10nRepository
{
public Deporte_l10nRESTCAD()
        : base ()
{
}

public Deporte_l10nRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IdiomaEN GetIdiomaDeporte (int id)
{
        IdiomaEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Idioma FROM Deporte_l10nNH self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<IdiomaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Deporte_l10nRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
