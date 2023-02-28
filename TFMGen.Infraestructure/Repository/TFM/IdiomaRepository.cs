
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
 * Clase Idioma:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class IdiomaRepository : BasicRepository, IIdiomaRepository
{
public IdiomaRepository() : base ()
{
}


public IdiomaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public IdiomaEN ReadOIDDefault (int ididioma
                                )
{
        IdiomaEN idiomaEN = null;

        try
        {
                SessionInitializeTransaction ();
                idiomaEN = (IdiomaEN)session.Get (typeof(IdiomaNH), ididioma);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IdiomaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return idiomaEN;
}

public System.Collections.Generic.IList<IdiomaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IdiomaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IdiomaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<IdiomaEN>();
                        else
                                result = session.CreateCriteria (typeof(IdiomaNH)).List<IdiomaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IdiomaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IdiomaEN idioma)
{
        try
        {
                SessionInitializeTransaction ();
                IdiomaNH idiomaNH = (IdiomaNH)session.Load (typeof(IdiomaNH), idioma.Ididioma);

                idiomaNH.Nombre = idioma.Nombre;


                idiomaNH.Cultura = idioma.Cultura;






                session.Update (idiomaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IdiomaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (IdiomaEN idioma)
{
        IdiomaNH idiomaNH = new IdiomaNH (idioma);

        try
        {
                SessionInitializeTransaction ();

                session.Save (idiomaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IdiomaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return idiomaNH.Ididioma;
}

public System.Collections.Generic.IList<IdiomaEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<IdiomaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IdiomaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<IdiomaEN>();
                else
                        result = session.CreateCriteria (typeof(IdiomaNH)).List<IdiomaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IdiomaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
