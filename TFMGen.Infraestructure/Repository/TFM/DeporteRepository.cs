
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
 * Clase Deporte:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class DeporteRepository : BasicRepository, IDeporteRepository
{
public DeporteRepository() : base ()
{
}


public DeporteRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public DeporteEN ReadOIDDefault (int iddeporte
                                 )
{
        DeporteEN deporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                deporteEN = (DeporteEN)session.Get (typeof(DeporteNH), iddeporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DeporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deporteEN;
}

public System.Collections.Generic.IList<DeporteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DeporteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DeporteNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<DeporteEN>();
                        else
                                result = session.CreateCriteria (typeof(DeporteNH)).List<DeporteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DeporteRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DeporteEN deporte)
{
        try
        {
                SessionInitializeTransaction ();
                DeporteNH deporteNH = (DeporteNH)session.Load (typeof(DeporteNH), deporte.Iddeporte);

                deporteNH.Nombre = deporte.Nombre;


                deporteNH.Descripcion = deporte.Descripcion;




                deporteNH.Icono = deporte.Icono;


                session.Update (deporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DeporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (DeporteEN deporte)
{
        DeporteNH deporteNH = new DeporteNH (deporte);

        try
        {
                SessionInitializeTransaction ();

                session.Save (deporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DeporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deporteNH.Iddeporte;
}

public void Editar (DeporteEN deporte)
{
        try
        {
                SessionInitializeTransaction ();
                DeporteNH deporteNH = (DeporteNH)session.Load (typeof(DeporteNH), deporte.Iddeporte);

                deporteNH.Nombre = deporte.Nombre;


                deporteNH.Descripcion = deporte.Descripcion;


                deporteNH.Icono = deporte.Icono;

                session.Update (deporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DeporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int iddeporte
                      )
{
        try
        {
                SessionInitializeTransaction ();
                DeporteNH deporteNH = (DeporteNH)session.Load (typeof(DeporteNH), iddeporte);
                session.Delete (deporteNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DeporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: DeporteEN
public DeporteEN Obtener (int iddeporte
                          )
{
        DeporteEN deporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                deporteEN = (DeporteEN)session.Get (typeof(DeporteNH), iddeporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DeporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deporteEN;
}

public System.Collections.Generic.IList<DeporteEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<DeporteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DeporteNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<DeporteEN>();
                else
                        result = session.CreateCriteria (typeof(DeporteNH)).List<DeporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in DeporteRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
