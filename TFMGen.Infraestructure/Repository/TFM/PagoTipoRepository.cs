
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
 * Clase PagoTipo:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class PagoTipoRepository : BasicRepository, IPagoTipoRepository
{
public PagoTipoRepository() : base ()
{
}


public PagoTipoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PagoTipoEN ReadOIDDefault (int idtipo
                                  )
{
        PagoTipoEN pagoTipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pagoTipoEN = (PagoTipoEN)session.Get (typeof(PagoTipoNH), idtipo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagoTipoEN;
}

public System.Collections.Generic.IList<PagoTipoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PagoTipoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PagoTipoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PagoTipoEN>();
                        else
                                result = session.CreateCriteria (typeof(PagoTipoNH)).List<PagoTipoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PagoTipoEN pagoTipo)
{
        try
        {
                SessionInitializeTransaction ();
                PagoTipoNH pagoTipoNH = (PagoTipoNH)session.Load (typeof(PagoTipoNH), pagoTipo.Idtipo);

                pagoTipoNH.Nombre = pagoTipo.Nombre;



                session.Update (pagoTipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (PagoTipoEN pagoTipo)
{
        PagoTipoNH pagoTipoNH = new PagoTipoNH (pagoTipo);

        try
        {
                SessionInitializeTransaction ();

                session.Save (pagoTipoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagoTipoNH.Idtipo;
}

public System.Collections.Generic.IList<PagoTipoEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<PagoTipoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PagoTipoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<PagoTipoEN>();
                else
                        result = session.CreateCriteria (typeof(PagoTipoNH)).List<PagoTipoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoTipoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
