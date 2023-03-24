
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
public class PagoRESTCAD : PagoRepository
{
public PagoRESTCAD()
        : base ()
{
}

public PagoRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public PagoTipoEN ObtenerTipo (int idpago)
{
        PagoTipoEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Tipo FROM PagoNH self " +
                             "where self.Idpago = :p_Idpago";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idpago", idpago);




                result = query.UniqueResult<PagoTipoEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
