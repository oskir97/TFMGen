
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
 * Clase PagoTipo_l10n:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class PagoTipo_l10nRepository : BasicRepository, IPagoTipo_l10nRepository
{
public PagoTipo_l10nRepository() : base ()
{
}


public PagoTipo_l10nRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PagoTipo_l10nEN ReadOIDDefault (int id
                                       )
{
        PagoTipo_l10nEN pagoTipo_l10nEN = null;

        try
        {
                SessionInitializeTransaction ();
                pagoTipo_l10nEN = (PagoTipo_l10nEN)session.Get (typeof(PagoTipo_l10nNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipo_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagoTipo_l10nEN;
}

public System.Collections.Generic.IList<PagoTipo_l10nEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PagoTipo_l10nEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PagoTipo_l10nNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PagoTipo_l10nEN>();
                        else
                                result = session.CreateCriteria (typeof(PagoTipo_l10nNH)).List<PagoTipo_l10nEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipo_l10nRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PagoTipo_l10nEN pagoTipo_l10n)
{
        try
        {
                SessionInitializeTransaction ();
                PagoTipo_l10nNH pagoTipo_l10nNH = (PagoTipo_l10nNH)session.Load (typeof(PagoTipo_l10nNH), pagoTipo_l10n.Id);

                pagoTipo_l10nNH.Nombre = pagoTipo_l10n.Nombre;



                session.Update (pagoTipo_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipo_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (PagoTipo_l10nEN pagoTipo_l10n)
{
        PagoTipo_l10nNH pagoTipo_l10nNH = new PagoTipo_l10nNH (pagoTipo_l10n);

        try
        {
                SessionInitializeTransaction ();
                if (pagoTipo_l10n.PagoTipo != null) {
                        // Argumento OID y no colección.
                        pagoTipo_l10nNH
                        .PagoTipo = (TFMGen.ApplicationCore.EN.TFM.PagoTipoEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.PagoTipoEN), pagoTipo_l10n.PagoTipo.Idtipo);

                        pagoTipo_l10nNH.PagoTipo.PagoTipo_l10n
                        .Add (pagoTipo_l10nNH);
                }
                if (pagoTipo_l10n.Idioma != null) {
                        // Argumento OID y no colección.
                        pagoTipo_l10nNH
                        .Idioma = (TFMGen.ApplicationCore.EN.TFM.IdiomaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.IdiomaEN), pagoTipo_l10n.Idioma.Ididioma);

                        pagoTipo_l10nNH.Idioma.PagoTipo_l10n
                        .Add (pagoTipo_l10nNH);
                }

                session.Save (pagoTipo_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipo_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagoTipo_l10nNH.Id;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> Listar (int p_idIdioma)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PagoTipo_l10nNH self where SELECT t FROM PagoTipo_l10nNH as t WHERE t.Idioma.Ididioma = :p_idIdioma";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PagoTipo_l10nNHlistarHQL");
                query.SetParameter ("p_idIdioma", p_idIdioma);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipo_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PagoTipo_l10nEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<PagoTipo_l10nEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PagoTipo_l10nNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<PagoTipo_l10nEN>();
                else
                        result = session.CreateCriteria (typeof(PagoTipo_l10nNH)).List<PagoTipo_l10nEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipo_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
