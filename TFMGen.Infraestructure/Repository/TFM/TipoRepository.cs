
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
 * Clase Tipo:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class TipoRepository : BasicRepository, ITipoRepository
{
public TipoRepository() : base ()
{
}


public TipoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public TipoEN ReadOIDDefault (int idtipo
                              )
{
        TipoEN tipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                tipoEN = (TipoEN)session.Get (typeof(TipoNH), idtipo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tipoEN;
}

public System.Collections.Generic.IList<TipoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TipoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TipoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<TipoEN>();
                        else
                                result = session.CreateCriteria (typeof(TipoNH)).List<TipoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TipoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TipoEN tipo)
{
        try
        {
                SessionInitializeTransaction ();
                TipoNH tipoNH = (TipoNH)session.Load (typeof(TipoNH), tipo.Idtipo);

                tipoNH.Nombre = tipo.Nombre;



                session.Update (tipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (TipoEN tipo)
{
        TipoNH tipoNH = new TipoNH (tipo);

        try
        {
                SessionInitializeTransaction ();

                session.Save (tipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tipoNH.Idtipo;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.TipoEN> Listar (int p_idIdioma)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.TipoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TipoNH self where FROM TipoEN as t WHERE t.Idioma.IDIdioma = p_idIdioma";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TipoNHlistarHQL");
                query.SetParameter ("p_idIdioma", p_idIdioma);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.TipoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in TipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
