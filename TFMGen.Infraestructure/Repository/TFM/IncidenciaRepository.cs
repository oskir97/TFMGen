
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
 * Clase Incidencia:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class IncidenciaRepository : BasicRepository, IIncidenciaRepository
{
public IncidenciaRepository() : base ()
{
}


public IncidenciaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public IncidenciaEN ReadOIDDefault (int idincidencia
                                    )
{
        IncidenciaEN incidenciaEN = null;

        try
        {
                SessionInitializeTransaction ();
                incidenciaEN = (IncidenciaEN)session.Get (typeof(IncidenciaNH), idincidencia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IncidenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return incidenciaEN;
}

public System.Collections.Generic.IList<IncidenciaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IncidenciaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IncidenciaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<IncidenciaEN>();
                        else
                                result = session.CreateCriteria (typeof(IncidenciaNH)).List<IncidenciaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IncidenciaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IncidenciaEN incidencia)
{
        try
        {
                SessionInitializeTransaction ();
                IncidenciaNH incidenciaNH = (IncidenciaNH)session.Load (typeof(IncidenciaNH), incidencia.Idincidencia);



                incidenciaNH.Asunto = incidencia.Asunto;


                incidenciaNH.Descripcion = incidencia.Descripcion;


                incidenciaNH.Fechacancelada = incidencia.Fechacancelada;


                incidenciaNH.Fechareemplazada = incidencia.Fechareemplazada;

                session.Update (incidenciaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IncidenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (IncidenciaEN incidencia)
{
        IncidenciaNH incidenciaNH = new IncidenciaNH (incidencia);

        try
        {
                SessionInitializeTransaction ();
                if (incidencia.Usuario != null) {
                        // Argumento OID y no colección.
                        incidenciaNH
                        .Usuario = (TFMGen.ApplicationCore.EN.TFM.UsuarioEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.UsuarioEN), incidencia.Usuario.Idusuario);

                        incidenciaNH.Usuario.Incidencia
                        .Add (incidenciaNH);
                }
                if (incidencia.Evento != null) {
                        // Argumento OID y no colección.
                        incidenciaNH
                        .Evento = (TFMGen.ApplicationCore.EN.TFM.EventoEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.EventoEN), incidencia.Evento.Idevento);

                        incidenciaNH.Evento.Incidencia
                        .Add (incidenciaNH);
                }

                session.Save (incidenciaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IncidenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return incidenciaNH.Idincidencia;
}

public void Modificar (IncidenciaEN incidencia)
{
        try
        {
                SessionInitializeTransaction ();
                IncidenciaNH incidenciaNH = (IncidenciaNH)session.Load (typeof(IncidenciaNH), incidencia.Idincidencia);

                incidenciaNH.Asunto = incidencia.Asunto;


                incidenciaNH.Descripcion = incidencia.Descripcion;


                incidenciaNH.Fechacancelada = incidencia.Fechacancelada;

                session.Update (incidenciaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IncidenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idincidencia
                      )
{
        try
        {
                SessionInitializeTransaction ();
                IncidenciaNH incidenciaNH = (IncidenciaNH)session.Load (typeof(IncidenciaNH), idincidencia);
                session.Delete (incidenciaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IncidenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: IncidenciaEN
public IncidenciaEN Obtener (int idincidencia
                             )
{
        IncidenciaEN incidenciaEN = null;

        try
        {
                SessionInitializeTransaction ();
                incidenciaEN = (IncidenciaEN)session.Get (typeof(IncidenciaNH), idincidencia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IncidenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return incidenciaEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> Listar (int p_idEvento)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM IncidenciaNH self where FROM IncidenciaNH as i WHERE i.Evento.Idevento = :p_idEvento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("IncidenciaNHlistarHQL");
                query.SetParameter ("p_idEvento", p_idEvento);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.IncidenciaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in IncidenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
