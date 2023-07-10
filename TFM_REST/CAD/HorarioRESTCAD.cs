
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
public class HorarioRESTCAD : HorarioRepository
{
public HorarioRESTCAD()
        : base ()
{
}

public HorarioRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}



public IList<DiaSemanaEN> ObtenerDiasSemana (int idhorario)
{
        IList<DiaSemanaEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM DiaSemanaNH self inner join self.Horario as target with target.Idhorario=:p_Idhorario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idhorario", idhorario);




                result = query.List<DiaSemanaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<PistaEN> ObtenerPistaHorario (int idhorario)
{
        IList<PistaEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM PistaNH self inner join self.Horarios as target with target.Idhorario=:p_Idhorario";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Idhorario", idhorario);




                result = query.List<PistaEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException) throw;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
