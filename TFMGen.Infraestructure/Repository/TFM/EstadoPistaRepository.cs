
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
 * Clase EstadoPista:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class EstadoPistaRepository : BasicRepository, IEstadoPistaRepository
{
public EstadoPistaRepository() : base ()
{
}


public EstadoPistaRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public EstadoPistaEN ReadOIDDefault (int idestado
                                     )
{
        EstadoPistaEN estadoPistaEN = null;

        try
        {
                SessionInitializeTransaction ();
                estadoPistaEN = (EstadoPistaEN)session.Get (typeof(EstadoPistaNH), idestado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EstadoPistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return estadoPistaEN;
}

public System.Collections.Generic.IList<EstadoPistaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EstadoPistaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EstadoPistaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<EstadoPistaEN>();
                        else
                                result = session.CreateCriteria (typeof(EstadoPistaNH)).List<EstadoPistaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EstadoPistaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EstadoPistaEN estadoPista)
{
        try
        {
                SessionInitializeTransaction ();
                EstadoPistaNH estadoPistaNH = (EstadoPistaNH)session.Load (typeof(EstadoPistaNH), estadoPista.Idestado);

                estadoPistaNH.Nombre = estadoPista.Nombre;



                session.Update (estadoPistaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EstadoPistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (EstadoPistaEN estadoPista)
{
        EstadoPistaNH estadoPistaNH = new EstadoPistaNH (estadoPista);

        try
        {
                SessionInitializeTransaction ();

                session.Save (estadoPistaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EstadoPistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return estadoPistaNH.Idestado;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN> Listar (int p_idIdioma)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EstadoPistaNH self where FROM EstadoPistaEN as e WHERE e.Idioma.IDIdioma = p_idIdioma";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EstadoPistaNHlistarHQL");
                query.SetParameter ("p_idIdioma", p_idIdioma);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EstadoPistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
