
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
 * Clase PistaEstado_l10n:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class PistaEstado_l10nRepository : BasicRepository, IPistaEstado_l10nRepository
{
public PistaEstado_l10nRepository() : base ()
{
}


public PistaEstado_l10nRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PistaEstado_l10nEN ReadOIDDefault (int id
                                          )
{
        PistaEstado_l10nEN pistaEstado_l10nEN = null;

        try
        {
                SessionInitializeTransaction ();
                pistaEstado_l10nEN = (PistaEstado_l10nEN)session.Get (typeof(PistaEstado_l10nNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstado_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pistaEstado_l10nEN;
}

public System.Collections.Generic.IList<PistaEstado_l10nEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PistaEstado_l10nEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PistaEstado_l10nNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PistaEstado_l10nEN>();
                        else
                                result = session.CreateCriteria (typeof(PistaEstado_l10nNH)).List<PistaEstado_l10nEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstado_l10nRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PistaEstado_l10nEN pistaEstado_l10n)
{
        try
        {
                SessionInitializeTransaction ();
                PistaEstado_l10nNH pistaEstado_l10nNH = (PistaEstado_l10nNH)session.Load (typeof(PistaEstado_l10nNH), pistaEstado_l10n.Id);

                pistaEstado_l10nNH.Nombre = pistaEstado_l10n.Nombre;



                session.Update (pistaEstado_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstado_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (PistaEstado_l10nEN pistaEstado_l10n)
{
        PistaEstado_l10nNH pistaEstado_l10nNH = new PistaEstado_l10nNH (pistaEstado_l10n);

        try
        {
                SessionInitializeTransaction ();
                if (pistaEstado_l10n.Idioma != null) {
                        // Argumento OID y no colección.
                        pistaEstado_l10nNH
                        .Idioma = (TFMGen.ApplicationCore.EN.TFM.IdiomaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.IdiomaEN), pistaEstado_l10n.Idioma.Ididioma);

                        pistaEstado_l10nNH.Idioma.EstadoPista_l10n
                        .Add (pistaEstado_l10nNH);
                }
                if (pistaEstado_l10n.EstadoPista != null) {
                        // Argumento OID y no colección.
                        pistaEstado_l10nNH
                        .EstadoPista = (TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN), pistaEstado_l10n.EstadoPista.Idestado);

                        pistaEstado_l10nNH.EstadoPista.EstadoPista_l10n
                        .Add (pistaEstado_l10nNH);
                }

                session.Save (pistaEstado_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstado_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pistaEstado_l10nNH.Id;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> Listar (int p_idIdioma)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PistaEstado_l10nNH self where SELECT p FROM PistaEstado_l10nNH as p WHERE p.Idioma.Ididioma = :p_idIdioma";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PistaEstado_l10nNHlistarHQL");
                query.SetParameter ("p_idIdioma", p_idIdioma);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstado_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PistaEstado_l10nEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<PistaEstado_l10nEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PistaEstado_l10nNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<PistaEstado_l10nEN>();
                else
                        result = session.CreateCriteria (typeof(PistaEstado_l10nNH)).List<PistaEstado_l10nEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstado_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
