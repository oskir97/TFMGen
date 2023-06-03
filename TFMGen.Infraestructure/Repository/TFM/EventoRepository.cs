
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
                if (evento.Deporte != null) {
                        // Argumento OID y no colección.
                        eventoNH
                        .Deporte = (TFMGen.ApplicationCore.EN.TFM.DeporteEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.DeporteEN), evento.Deporte.Iddeporte);

                        eventoNH.Deporte.Eventos
                        .Add (eventoNH);
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

public System.Collections.Generic.IList<EventoEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EventoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<EventoEN>();
                else
                        result = session.CreateCriteria (typeof(EventoNH)).List<EventoEN>();
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

public void Eliminarusuario (int p_Evento_OID, System.Collections.Generic.IList<int> p_usuarios_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                TFMGen.ApplicationCore.EN.TFM.EventoEN eventoEN = null;
                eventoEN = (EventoEN)session.Load (typeof(EventoNH), p_Evento_OID);

                TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuariosENAux = null;
                if (eventoEN.Usuarios != null) {
                        foreach (int item in p_usuarios_OIDs) {
                                usuariosENAux = (TFMGen.ApplicationCore.EN.TFM.UsuarioEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.UsuarioNH), item);
                                if (eventoEN.Usuarios.Contains (usuariosENAux) == true) {
                                        eventoEN.Usuarios.Remove (usuariosENAux);
                                        usuariosENAux.Eventos.Remove (eventoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_usuarios_OIDs you are trying to unrelationer, doesn't exist in EventoEN");
                        }
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
public void Asignartecnico (int p_Evento_OID, System.Collections.Generic.IList<int> p_tecnicos_OIDs)
{
        TFMGen.ApplicationCore.EN.TFM.EventoEN eventoEN = null;
        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Load (typeof(EventoNH), p_Evento_OID);
                TFMGen.ApplicationCore.EN.TFM.UsuarioEN tecnicosENAux = null;
                if (eventoEN.Tecnicos == null) {
                        eventoEN.Tecnicos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                }

                foreach (int item in p_tecnicos_OIDs) {
                        tecnicosENAux = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN ();
                        tecnicosENAux = (TFMGen.ApplicationCore.EN.TFM.UsuarioEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.UsuarioNH), item);
                        tecnicosENAux.EventosImpartidos.Add (eventoEN);

                        eventoEN.Tecnicos.Add (tecnicosENAux);
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

public void Eliminartecnico (int p_Evento_OID, System.Collections.Generic.IList<int> p_tecnicos_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                TFMGen.ApplicationCore.EN.TFM.EventoEN eventoEN = null;
                eventoEN = (EventoEN)session.Load (typeof(EventoNH), p_Evento_OID);

                TFMGen.ApplicationCore.EN.TFM.UsuarioEN tecnicosENAux = null;
                if (eventoEN.Tecnicos != null) {
                        foreach (int item in p_tecnicos_OIDs) {
                                tecnicosENAux = (TFMGen.ApplicationCore.EN.TFM.UsuarioEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.UsuarioNH), item);
                                if (eventoEN.Tecnicos.Contains (tecnicosENAux) == true) {
                                        eventoEN.Tecnicos.Remove (tecnicosENAux);
                                        tecnicosENAux.EventosImpartidos.Remove (eventoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_tecnicos_OIDs you are trying to unrelationer, doesn't exist in EventoEN");
                        }
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
public void Asignardiassemana (int p_Evento_OID, System.Collections.Generic.IList<int> p_diasSemana_OIDs)
{
        TFMGen.ApplicationCore.EN.TFM.EventoEN eventoEN = null;
        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Load (typeof(EventoNH), p_Evento_OID);
                TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN diasSemanaENAux = null;
                if (eventoEN.DiasSemana == null) {
                        eventoEN.DiasSemana = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN>();
                }

                foreach (int item in p_diasSemana_OIDs) {
                        diasSemanaENAux = new TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN ();
                        diasSemanaENAux = (TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.DiaSemanaNH), item);
                        diasSemanaENAux.Eventos.Add (eventoEN);

                        eventoEN.DiasSemana.Add (diasSemanaENAux);
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

public void Eliminardiassemana (int p_Evento_OID, System.Collections.Generic.IList<int> p_diasSemana_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                TFMGen.ApplicationCore.EN.TFM.EventoEN eventoEN = null;
                eventoEN = (EventoEN)session.Load (typeof(EventoNH), p_Evento_OID);

                TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN diasSemanaENAux = null;
                if (eventoEN.DiasSemana != null) {
                        foreach (int item in p_diasSemana_OIDs) {
                                diasSemanaENAux = (TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.DiaSemanaNH), item);
                                if (eventoEN.DiasSemana.Contains (diasSemanaENAux) == true) {
                                        eventoEN.DiasSemana.Remove (diasSemanaENAux);
                                        diasSemanaENAux.Eventos.Remove (eventoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_diasSemana_OIDs you are trying to unrelationer, doesn't exist in EventoEN");
                        }
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
public void Asignarhorarios (int p_Evento_OID, System.Collections.Generic.IList<int> p_horarios_OIDs)
{
        TFMGen.ApplicationCore.EN.TFM.EventoEN eventoEN = null;
        try
        {
                SessionInitializeTransaction ();
                eventoEN = (EventoEN)session.Load (typeof(EventoNH), p_Evento_OID);
                TFMGen.ApplicationCore.EN.TFM.HorarioEN horariosENAux = null;
                if (eventoEN.Horarios == null) {
                        eventoEN.Horarios = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
                }

                foreach (int item in p_horarios_OIDs) {
                        horariosENAux = new TFMGen.ApplicationCore.EN.TFM.HorarioEN ();
                        horariosENAux = (TFMGen.ApplicationCore.EN.TFM.HorarioEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.HorarioNH), item);
                        horariosENAux.Eventos.Add (eventoEN);

                        eventoEN.Horarios.Add (horariosENAux);
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

public void Eliminarhorarios (int p_Evento_OID, System.Collections.Generic.IList<int> p_horarios_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                TFMGen.ApplicationCore.EN.TFM.EventoEN eventoEN = null;
                eventoEN = (EventoEN)session.Load (typeof(EventoNH), p_Evento_OID);

                TFMGen.ApplicationCore.EN.TFM.HorarioEN horariosENAux = null;
                if (eventoEN.Horarios != null) {
                        foreach (int item in p_horarios_OIDs) {
                                horariosENAux = (TFMGen.ApplicationCore.EN.TFM.HorarioEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.HorarioNH), item);
                                if (eventoEN.Horarios.Contains (horariosENAux) == true) {
                                        eventoEN.Horarios.Remove (horariosENAux);
                                        horariosENAux.Eventos.Remove (eventoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_horarios_OIDs you are trying to unrelationer, doesn't exist in EventoEN");
                        }
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
}
}
