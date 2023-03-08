
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
 * Clase Evento:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class EventoRepository : BasicRepository, IEventoRepository
{
public EventoRepository() : base ()
{
}


public EventoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public EventoEN ReadOIDDefault (int idevento
                                )
{
        EventoEN eventoEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Get (typeof(EventoNH), idevento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventoEN;
}

public System.Collections.Generic.IList<EventoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EventoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<EventoEN>();
                        else
                                result = session.CreateCriteria (typeof(EventoNH)).List<EventoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                EventoNH eventoNH = (EventoNH)session.Load (typeof(EventoNH), evento.Idevento);

                eventoNH.Nombre = evento.Nombre;


                eventoNH.Descripcion = evento.Descripcion;










                eventoNH.Activo = evento.Activo;


                eventoNH.Plazas = evento.Plazas;

                session.Update (eventoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (EventoEN evento)
{
        EventoNH eventoNH = new EventoNH (evento);

        try
        {
                SessionInitializeTransaction ();
                if (evento.Entidad != null) {
                        // Argumento OID y no colección.
                        eventoNH
                        .Entidad = (TFMGen.ApplicationCore.EN.TFM.EntidadEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.EntidadEN), evento.Entidad.Identidad);

                        eventoNH.Entidad.Eventos
                        .Add (eventoNH);
                }
                if (evento.Horarios != null) {
                        for (int i = 0; i < evento.Horarios.Count; i++) {
                                evento.Horarios [i] = (TFMGen.ApplicationCore.EN.TFM.HorarioEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.HorarioEN), evento.Horarios [i].Idhorario);
                                evento.Horarios [i].Eventos.Add (eventoNH);
                        }
                }
                if (evento.DiasSemana != null) {
                        for (int i = 0; i < evento.DiasSemana.Count; i++) {
                                evento.DiasSemana [i] = (TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN), evento.DiasSemana [i].Iddiasemana);
                                evento.DiasSemana [i].Eventos.Add (eventoNH);
                        }
                }

                session.Save (eventoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventoNH.Idevento;
}

public void Editar (EventoEN evento)
{
        try
        {
                SessionInitializeTransaction ();
                EventoNH eventoNH = (EventoNH)session.Load (typeof(EventoNH), evento.Idevento);

                eventoNH.Nombre = evento.Nombre;


                eventoNH.Descripcion = evento.Descripcion;


                eventoNH.Activo = evento.Activo;


                eventoNH.Plazas = evento.Plazas;

                session.Update (eventoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idevento
                      )
{
        try
        {
                SessionInitializeTransaction ();
                EventoNH eventoNH = (EventoNH)session.Load (typeof(EventoNH), idevento);
                session.Delete (eventoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: EventoEN
public EventoEN Obtener (int idevento
                         )
{
        EventoEN eventoEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Get (typeof(EventoNH), idevento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventoEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Listar (int p_idUsuario)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EventoNH self where SELECT e FROM EventoNH as e INNER JOIN e.Usuarios as u where u.Idusuario = :p_idUsuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EventoNHlistarHQL");
                query.SetParameter ("p_idUsuario", p_idUsuario);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Listarentidad (int p_idEntidad)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EventoNH self where FROM EventoNH as e WHERE e.Entidad.Identidad = :p_idEntidad";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EventoNHlistarentidadHQL");
                query.SetParameter ("p_idEntidad", p_idEntidad);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Asignarusuario (int p_Evento_OID, System.Collections.Generic.IList<int> p_usuarios_OIDs)
{
        TFMGen.ApplicationCore.EN.TFM.EventoEN eventoEN = null;
        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Load (typeof(EventoNH), p_Evento_OID);
                TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuariosENAux = null;
                if (eventoEN.Usuarios == null) {
                        eventoEN.Usuarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                }

                foreach (int item in p_usuarios_OIDs) {
                        usuariosENAux = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN ();
                        usuariosENAux = (TFMGen.ApplicationCore.EN.TFM.UsuarioEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.UsuarioNH), item);
                        usuariosENAux.Eventos.Add (eventoEN);

                        eventoEN.Usuarios.Add (usuariosENAux);
                }


                session.Update (eventoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Obtenereventospista (int p_idPista, Nullable<DateTime> p_fecha, int p_idDiaSemana)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EventoNH self where FROM EventoNH as e INNER JOIN e.Horarios as h INNER JOIN h.DiaSemana as d where e.Activo AND h.Pista.Idpista = :p_idPista AND h.Inicio = :p_fecha AND d.Iddiasemana = :p_idDiaSemana";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EventoNHobtenereventospistaHQL");
                query.SetParameter ("p_idPista", p_idPista);
                query.SetParameter ("p_fecha", p_fecha);
                query.SetParameter ("p_idDiaSemana", p_idDiaSemana);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EventoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
