
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
 * Clase Notificacion:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class NotificacionRepository : BasicRepository, INotificacionRepository
{
public NotificacionRepository() : base ()
{
}


public NotificacionRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public NotificacionEN ReadOIDDefault (int idnotificacion
                                      )
{
        NotificacionEN notificacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                notificacionEN = (NotificacionEN)session.Get (typeof(NotificacionNH), idnotificacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in NotificacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notificacionEN;
}

public System.Collections.Generic.IList<NotificacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<NotificacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(NotificacionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<NotificacionEN>();
                        else
                                result = session.CreateCriteria (typeof(NotificacionNH)).List<NotificacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in NotificacionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (NotificacionEN notificacion)
{
        try
        {
                SessionInitializeTransaction ();
                NotificacionNH notificacionNH = (NotificacionNH)session.Load (typeof(NotificacionNH), notificacion.Idnotificacion);


                notificacionNH.Asunto = notificacion.Asunto;


                notificacionNH.Descripcion = notificacion.Descripcion;


                notificacionNH.Leida = notificacion.Leida;




                notificacionNH.Tipo = notificacion.Tipo;

                session.Update (notificacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in NotificacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (NotificacionEN notificacion)
{
        NotificacionNH notificacionNH = new NotificacionNH (notificacion);

        try
        {
                SessionInitializeTransaction ();

                session.Save (notificacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in NotificacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notificacionNH.Idnotificacion;
}

public void Editar (NotificacionEN notificacion)
{
        try
        {
                SessionInitializeTransaction ();
                NotificacionNH notificacionNH = (NotificacionNH)session.Load (typeof(NotificacionNH), notificacion.Idnotificacion);

                notificacionNH.Asunto = notificacion.Asunto;


                notificacionNH.Descripcion = notificacion.Descripcion;


                notificacionNH.Leida = notificacion.Leida;


                notificacionNH.Tipo = notificacion.Tipo;

                session.Update (notificacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in NotificacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idnotificacion
                      )
{
        try
        {
                SessionInitializeTransaction ();
                NotificacionNH notificacionNH = (NotificacionNH)session.Load (typeof(NotificacionNH), idnotificacion);
                session.Delete (notificacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in NotificacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: NotificacionEN
public NotificacionEN Obtener (int idnotificacion
                               )
{
        NotificacionEN notificacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                notificacionEN = (NotificacionEN)session.Get (typeof(NotificacionNH), idnotificacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in NotificacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notificacionEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> Listar (int p_idUsuario)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.NotificacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM NotificacionNH self where FROM NotificacionEN as n WHERE n.Usuario.IDUsuario = p_idUsuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("NotificacionNHlistarHQL");
                query.SetParameter ("p_idUsuario", p_idUsuario);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.NotificacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in NotificacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
