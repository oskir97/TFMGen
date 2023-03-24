
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
public class AsitenciaRESTCAD : AsitenciaRepository
{
public AsitenciaRESTCAD()
        : base ()
{
}

public AsitenciaRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public EventoEN ObtenerEvento (int idasitencia)
{
        EventoEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Evento FROM AsitenciaNH self " +
                             "where self.Idasitencia = :p_Idasitencia";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idasitencia", idasitencia);




                result = query.UniqueResult<EventoEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in AsitenciaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
