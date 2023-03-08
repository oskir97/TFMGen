
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
 * Clase DiaSemana_l10n:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class DiaSemana_l10nRepository : BasicRepository, IDiaSemana_l10nRepository
{
public DiaSemana_l10nRepository() : base ()
{
}


public DiaSemana_l10nRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public DiaSemana_l10nEN ReadOIDDefault (int id
                                        )
{
        DiaSemana_l10nEN diaSemana_l10nEN = null;

        try
        {
                SessionInitializeTransaction ();
                diaSemana_l10nEN = (DiaSemana_l10nEN)session.Get (typeof(DiaSemana_l10nNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemana_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diaSemana_l10nEN;
}

public System.Collections.Generic.IList<DiaSemana_l10nEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DiaSemana_l10nEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DiaSemana_l10nNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<DiaSemana_l10nEN>();
                        else
                                result = session.CreateCriteria (typeof(DiaSemana_l10nNH)).List<DiaSemana_l10nEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemana_l10nRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DiaSemana_l10nEN diaSemana_l10n)
{
        try
        {
                SessionInitializeTransaction ();
                DiaSemana_l10nNH diaSemana_l10nNH = (DiaSemana_l10nNH)session.Load (typeof(DiaSemana_l10nNH), diaSemana_l10n.Id);



                diaSemana_l10nNH.Nombre = diaSemana_l10n.Nombre;

                session.Update (diaSemana_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemana_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (DiaSemana_l10nEN diaSemana_l10n)
{
        DiaSemana_l10nNH diaSemana_l10nNH = new DiaSemana_l10nNH (diaSemana_l10n);

        try
        {
                SessionInitializeTransaction ();
                if (diaSemana_l10n.DiaSemana != null) {
                        // Argumento OID y no colección.
                        diaSemana_l10nNH
                        .DiaSemana = (TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN), diaSemana_l10n.DiaSemana.Id);

                        diaSemana_l10nNH.DiaSemana.DiaSemana_l10n
                        .Add (diaSemana_l10nNH);
                }
                if (diaSemana_l10n.Idioma != null) {
                        // Argumento OID y no colección.
                        diaSemana_l10nNH
                        .Idioma = (TFMGen.ApplicationCore.EN.TFM.IdiomaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.IdiomaEN), diaSemana_l10n.Idioma.Ididioma);

                        diaSemana_l10nNH.Idioma.DiaSemana_l10n
                        .Add (diaSemana_l10nNH);
                }

                session.Save (diaSemana_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemana_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return diaSemana_l10nNH.Id;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> Listar (int p_idIdioma)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM DiaSemana_l10nNH self where FROM DiaSemana_l10nNH as d WHERE d.Idioma.Ididioma = :p_idIdioma";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("DiaSemana_l10nNHlistarHQL");
                query.SetParameter ("p_idIdioma", p_idIdioma);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DiaSemana_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
