
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
public class ValoracionRESTCAD : ValoracionRepository
{
public ValoracionRESTCAD()
        : base ()
{
}

public ValoracionRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public UsuarioEN ObtenerUsuarioCreadorValoracion (int idvaloracion)
{
        UsuarioEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Usuario FROM ValoracionNH self " +
                             "where self.Idvaloracion = :p_Idvaloracion";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idvaloracion", idvaloracion);




                result = query.UniqueResult<UsuarioEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
