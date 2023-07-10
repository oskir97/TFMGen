
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
public class PistaRESTCAD : PistaRepository
{
public PistaRESTCAD()
        : base ()
{
}

public PistaRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<HorarioEN> ObtenerHorarios (int idpista)
{
        IList<HorarioEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM HorarioNH self inner join self.Pistas as target with target.Idpista=:p_Idpista";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idpista", idpista);




                result = query.List<HorarioEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public InstalacionEN ObtenerInstalaciones (int idpista)
{
        InstalacionEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Instalacion FROM PistaNH self " +
                             "where self.Idpista = :p_Idpista";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idpista", idpista);




                result = query.UniqueResult<InstalacionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public EntidadEN ObtenerEntidadPista (int idpista)
{
        EntidadEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Entidad FROM PistaNH self " +
                             "where self.Idpista = :p_Idpista";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idpista", idpista);




                result = query.UniqueResult<EntidadEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<ValoracionEN> ObtenerValoracionesPista (int idpista)
{
        IList<ValoracionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ValoracionNH self inner join self.Pista as target with target.Idpista=:p_Idpista";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idpista", idpista);




                result = query.List<ValoracionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public PistaEstadoEN ObtenerEstado (int idpista)
{
        PistaEstadoEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.EstadosPista FROM PistaNH self " +
                             "where self.Idpista = :p_Idpista";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idpista", idpista);




                result = query.UniqueResult<PistaEstadoEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<DeporteEN> ObtenerDeporte (int idpista)
{
        IList<DeporteEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM DeporteNH self inner join self.Pistas as target with target.Idpista=:p_Idpista";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idpista", idpista);




                result = query.List<DeporteEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
