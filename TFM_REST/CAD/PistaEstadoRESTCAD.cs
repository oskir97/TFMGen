
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
public class PistaEstadoRESTCAD : PistaEstadoRepository
{
public PistaEstadoRESTCAD()
        : base ()
{
}

public PistaEstadoRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<PistaEstado_l10nEN> ObtenerTraduccionesEstado (int idestado)
{
        IList<PistaEstado_l10nEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM PistaEstado_l10nNH self inner join self.EstadoPista as target with target.Idestado=:p_Idestado";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idestado", idestado);




                result = query.List<PistaEstado_l10nEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstadoRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
