
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
public class DiaSemana_l10nRESTCAD : DiaSemana_l10nRepository
{
public DiaSemana_l10nRESTCAD()
        : base ()
{
}

public DiaSemana_l10nRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IdiomaEN GetIdiomaDiaSemana (int iddiasemana)
{
        IdiomaEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Idioma FROM DiaSemana_l10nNH self " +
                             "where self.Iddiasemana = :p_Iddiasemana";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Iddiasemana", iddiasemana);




                result = query.UniqueResult<IdiomaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemana_l10nRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
