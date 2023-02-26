
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
 * Clase Deporte_l10n:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class Deporte_l10nRepository : BasicRepository, IDeporte_l10nRepository
{
public Deporte_l10nRepository() : base ()
{
}


public Deporte_l10nRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public Deporte_l10nEN ReadOIDDefault (int id
                                      )
{
        Deporte_l10nEN deporte_l10nEN = null;

        try
        {
                SessionInitializeTransaction ();
                deporte_l10nEN = (Deporte_l10nEN)session.Get (typeof(Deporte_l10nNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Deporte_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deporte_l10nEN;
}

public System.Collections.Generic.IList<Deporte_l10nEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<Deporte_l10nEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(Deporte_l10nNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<Deporte_l10nEN>();
                        else
                                result = session.CreateCriteria (typeof(Deporte_l10nNH)).List<Deporte_l10nEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Deporte_l10nRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (Deporte_l10nEN deporte_l10n)
{
        try
        {
                SessionInitializeTransaction ();
                Deporte_l10nNH deporte_l10nNH = (Deporte_l10nNH)session.Load (typeof(Deporte_l10nNH), deporte_l10n.Id);

                deporte_l10nNH.Nombre = deporte_l10n.Nombre;



                session.Update (deporte_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Deporte_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (Deporte_l10nEN deporte_l10n)
{
        Deporte_l10nNH deporte_l10nNH = new Deporte_l10nNH (deporte_l10n);

        try
        {
                SessionInitializeTransaction ();
                if (deporte_l10n.Idioma != null) {
                        // Argumento OID y no colección.
                        deporte_l10nNH
                        .Idioma = (TFMGen.ApplicationCore.EN.TFM.IdiomaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.IdiomaEN), deporte_l10n.Idioma.Ididioma);

                        deporte_l10nNH.Idioma.Deporte_l10n
                        .Add (deporte_l10nNH);
                }
                if (deporte_l10n.Deporte != null) {
                        // Argumento OID y no colección.
                        deporte_l10nNH
                        .Deporte = (TFMGen.ApplicationCore.EN.TFM.DeporteEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.DeporteEN), deporte_l10n.Deporte.Iddeporte);

                        deporte_l10nNH.Deporte.Deporte_l10n
                        .Add (deporte_l10nNH);
                }

                session.Save (deporte_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Deporte_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deporte_l10nNH.Id;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> Listar (int p_idIdioma)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM Deporte_l10nNH self where SELECT d FROM Deporte_l10nNH as d WHERE d.Idioma.Ididioma = :p_idIdioma";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("Deporte_l10nNHlistarHQL");
                query.SetParameter ("p_idIdioma", p_idIdioma);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Deporte_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
