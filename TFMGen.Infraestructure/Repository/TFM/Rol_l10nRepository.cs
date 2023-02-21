
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
 * Clase Rol_l10n:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class Rol_l10nRepository : BasicRepository, IRol_l10nRepository
{
public Rol_l10nRepository() : base ()
{
}


public Rol_l10nRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public Rol_l10nEN ReadOIDDefault (int id
                                  )
{
        Rol_l10nEN rol_l10nEN = null;

        try
        {
                SessionInitializeTransaction ();
                rol_l10nEN = (Rol_l10nEN)session.Get (typeof(Rol_l10nNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Rol_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rol_l10nEN;
}

public System.Collections.Generic.IList<Rol_l10nEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<Rol_l10nEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(Rol_l10nNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<Rol_l10nEN>();
                        else
                                result = session.CreateCriteria (typeof(Rol_l10nNH)).List<Rol_l10nEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Rol_l10nRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (Rol_l10nEN rol_l10n)
{
        try
        {
                SessionInitializeTransaction ();
                Rol_l10nNH rol_l10nNH = (Rol_l10nNH)session.Load (typeof(Rol_l10nNH), rol_l10n.Id);

                rol_l10nNH.Nombre = rol_l10n.Nombre;



                session.Update (rol_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Rol_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (Rol_l10nEN rol_l10n)
{
        Rol_l10nNH rol_l10nNH = new Rol_l10nNH (rol_l10n);

        try
        {
                SessionInitializeTransaction ();
                if (rol_l10n.Rol != null) {
                        // Argumento OID y no colección.
                        rol_l10nNH
                        .Rol = (TFMGen.ApplicationCore.EN.TFM.RolEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.RolEN), rol_l10n.Rol.Idrol);

                        rol_l10nNH.Rol.Rol_l10n
                        .Add (rol_l10nNH);
                }
                if (rol_l10n.Idioma != null) {
                        // Argumento OID y no colección.
                        rol_l10nNH
                        .Idioma = (TFMGen.ApplicationCore.EN.TFM.IdiomaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.IdiomaEN), rol_l10n.Idioma.Ididioma);

                        rol_l10nNH.Idioma.Rol_l10n
                        .Add (rol_l10nNH);
                }

                session.Save (rol_l10nNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Rol_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rol_l10nNH.Id;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> Listar (int p_idIdioma)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM Rol_l10nNH self where FROM Rol_l10nNH as p WHERE p.Idioma.Ididioma = :p_idIdioma";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("Rol_l10nNHlistarHQL");
                query.SetParameter ("p_idIdioma", p_idIdioma);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.Rol_l10nEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in Rol_l10nRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
