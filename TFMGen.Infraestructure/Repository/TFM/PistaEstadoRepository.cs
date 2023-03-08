
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
 * Clase PistaEstado:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class PistaEstadoRepository : BasicRepository, IPistaEstadoRepository
{
public PistaEstadoRepository() : base ()
{
}


public PistaEstadoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PistaEstadoEN ReadOIDDefault (int idestado
                                     )
{
        PistaEstadoEN pistaEstadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pistaEstadoEN = (PistaEstadoEN)session.Get (typeof(PistaEstadoNH), idestado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstadoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pistaEstadoEN;
}

public System.Collections.Generic.IList<PistaEstadoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PistaEstadoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PistaEstadoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PistaEstadoEN>();
                        else
                                result = session.CreateCriteria (typeof(PistaEstadoNH)).List<PistaEstadoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstadoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PistaEstadoEN pistaEstado)
{
        try
        {
                SessionInitializeTransaction ();
                PistaEstadoNH pistaEstadoNH = (PistaEstadoNH)session.Load (typeof(PistaEstadoNH), pistaEstado.Idestado);

                pistaEstadoNH.Nombre = pistaEstado.Nombre;



                session.Update (pistaEstadoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstadoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (PistaEstadoEN pistaEstado)
{
        PistaEstadoNH pistaEstadoNH = new PistaEstadoNH (pistaEstado);

        try
        {
                SessionInitializeTransaction ();

                session.Save (pistaEstadoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstadoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pistaEstadoNH.Idestado;
}

public System.Collections.Generic.IList<PistaEstadoEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<PistaEstadoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PistaEstadoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<PistaEstadoEN>();
                else
                        result = session.CreateCriteria (typeof(PistaEstadoNH)).List<PistaEstadoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaEstadoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
