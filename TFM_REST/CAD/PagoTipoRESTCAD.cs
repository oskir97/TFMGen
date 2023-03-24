
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
public class PagoTipoRESTCAD : PagoTipoRepository
{
public PagoTipoRESTCAD()
        : base ()
{
}

public PagoTipoRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<PagoTipo_l10nEN> ObtenerTraduccionesTipos (int idtipo)
{
        IList<PagoTipo_l10nEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM PagoTipo_l10nNH self inner join self.PagoTipo as target with target.Idtipo=:p_Idtipo";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idtipo", idtipo);




                result = query.List<PagoTipo_l10nEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipoRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
