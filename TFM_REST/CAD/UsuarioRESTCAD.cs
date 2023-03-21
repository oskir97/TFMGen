
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
public class UsuarioRESTCAD : UsuarioRepository
{
public UsuarioRESTCAD()
        : base ()
{
}

public UsuarioRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<ReservaEN> ObtenerReservas (int idusuario)
{
        IList<ReservaEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ReservaNH self inner join self.Usuario as target with target.Idusuario=:p_Idusuario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idusuario", idusuario);




                result = query.List<ReservaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
