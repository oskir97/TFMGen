
using System;
using System.Text;
using TFMGen.ApplicationCore.CEN.TFM;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CP.TFM;
using TFMGen.Infraestructure.EN.TFM;


/*
 * Clase DiaSemana:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class DiaSemanaRepository : BasicRepository, IDiaSemanaRepository
{
public DiaSemanaRepository() : base ()
{
}


public DiaSemanaRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public DiaSemanaEN ReadOIDDefault (int iddiasemana
                                   )
{
        DiaSemanaEN diaSemanaEN = null;

        try
        {
                SessionInitializeTransaction ();
                diaSemanaEN = (DiaSemanaEN)session.Get (typeof(DiaSemanaNH), iddiasemana);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemanaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diaSemanaEN;
}

public System.Collections.Generic.IList<DiaSemanaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DiaSemanaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DiaSemanaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<DiaSemanaEN>();
                        else
                                result = session.CreateCriteria (typeof(DiaSemanaNH)).List<DiaSemanaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemanaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DiaSemanaEN diaSemana)
{
        try
        {
                SessionInitializeTransaction ();
                DiaSemanaNH diaSemanaNH = (DiaSemanaNH)session.Load (typeof(DiaSemanaNH), diaSemana.Iddiasemana);

                diaSemanaNH.Nombre = diaSemana.Nombre;




                session.Update (diaSemanaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemanaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (DiaSemanaEN diaSemana)
{
        DiaSemanaNH diaSemanaNH = new DiaSemanaNH (diaSemana);

        try
        {
                SessionInitializeTransaction ();

                session.Save (diaSemanaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemanaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diaSemanaNH.Iddiasemana;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> Obtener (string p_dia)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM DiaSemanaNH self where FROM DiaSemanaNH as d where d.Nombre = :p_dia";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("DiaSemanaNHobtenerHQL");
                query.SetParameter ("p_dia", p_dia);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemanaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<DiaSemanaEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<DiaSemanaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DiaSemanaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<DiaSemanaEN>();
                else
                        result = session.CreateCriteria (typeof(DiaSemanaNH)).List<DiaSemanaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemanaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
