
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
 * Clase Reserva:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class ReservaRepository : BasicRepository, IReservaRepository
{
public ReservaRepository() : base ()
{
}


public ReservaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ReservaEN ReadOIDDefault (int idreserva
                                 )
{
        ReservaEN reservaEN = null;

        try
        {
                SessionInitializeTransaction ();
                reservaEN = (ReservaEN)session.Get (typeof(ReservaNH), idreserva);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaEN;
}

public System.Collections.Generic.IList<ReservaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReservaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReservaEN>();
                        else
                                result = session.CreateCriteria (typeof(ReservaNH)).List<ReservaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReservaEN reserva)
{
        try
        {
                SessionInitializeTransaction ();
                ReservaNH reservaNH = (ReservaNH)session.Load (typeof(ReservaNH), reserva.Idreserva);

                reservaNH.Nombre = reserva.Nombre;


                reservaNH.Apellidos = reserva.Apellidos;


                reservaNH.Email = reserva.Email;


                reservaNH.Telefono = reserva.Telefono;



                reservaNH.Cancelada = reserva.Cancelada;



                reservaNH.Maxparticipantes = reserva.Maxparticipantes;




                reservaNH.Fecha = reserva.Fecha;




                reservaNH.Tipo = reserva.Tipo;



                reservaNH.FechaCreacion = reserva.FechaCreacion;


                reservaNH.FechaCancelada = reserva.FechaCancelada;

                reservaNH.Nivelpartido = reserva.Nivelpartido;

                reservaNH.Descripcionpartido = reserva.Descripcionpartido;


                reservaNH.Imagen = reserva.Imagen;

                session.Update (reservaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (ReservaEN reserva)
{
        ReservaNH reservaNH = new ReservaNH (reserva);

        try
        {
                SessionInitializeTransaction ();
                if (reserva.Pista != null) {
                        // Argumento OID y no colección.
                        reservaNH
                        .Pista = (TFMGen.ApplicationCore.EN.TFM.PistaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.PistaEN), reserva.Pista.Idpista);

                        reservaNH.Pista.ReservasCreadas
                        .Add (reservaNH);
                }
                if (reserva.Horario != null) {
                        // Argumento OID y no colección.
                        reservaNH
                        .Horario = (TFMGen.ApplicationCore.EN.TFM.HorarioEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.HorarioEN), reserva.Horario.Idhorario);

                        reservaNH.Horario.Reserva
                        .Add (reservaNH);
                }
                if (reserva.Usuario != null) {
                        // Argumento OID y no colección.
                        reservaNH
                        .Usuario = (TFMGen.ApplicationCore.EN.TFM.UsuarioEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.UsuarioEN), reserva.Usuario.Idusuario);

                        reservaNH.Usuario.Reservas
                        .Add (reservaNH);
                }
                if (reserva.Deporte != null) {
                        // Argumento OID y no colección.
                        reservaNH
                        .Deporte = (TFMGen.ApplicationCore.EN.TFM.DeporteEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.DeporteEN), reserva.Deporte.Iddeporte);

                        reservaNH.Deporte.Reservas
                        .Add (reservaNH);
                }
                if (reserva.Evento != null) {
                        // Argumento OID y no colección.
                        reservaNH
                        .Evento = (TFMGen.ApplicationCore.EN.TFM.EventoEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.EventoEN), reserva.Evento.Idevento);

                        reservaNH.Evento.Reservas
                        .Add (reservaNH);
                }
                //if (reserva.Partido != null) {
                //        // Argumento OID y no colección.
                //        reservaNH
                //        .Partido = (TFMGen.ApplicationCore.EN.TFM.ReservaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.ReservaEN), reserva.Partido.Idreserva);

                //        reservaNH.Partido.Inscripciones
                //        .Add (reservaNH);
                //}

                session.Save (reservaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaNH.Idreserva;
}

public void Editar (ReservaEN reserva)
{
        try
        {
                SessionInitializeTransaction ();
                ReservaNH reservaNH = (ReservaNH)session.Load (typeof(ReservaNH), reserva.Idreserva);

                reservaNH.Nombre = reserva.Nombre;


                reservaNH.Apellidos = reserva.Apellidos;


                reservaNH.Email = reserva.Email;


                reservaNH.Telefono = reserva.Telefono;


                reservaNH.Cancelada = reserva.Cancelada;


                reservaNH.Maxparticipantes = reserva.Maxparticipantes;


                reservaNH.Fecha = reserva.Fecha;


                reservaNH.Tipo = reserva.Tipo;

                reservaNH.Nivelpartido = reserva.Nivelpartido;


                reservaNH.Descripcionpartido = reserva.Descripcionpartido;


                reservaNH.Imagen = reserva.Imagen;

                session.Update (reservaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idreserva
                      )
{
        try
        {
                SessionInitializeTransaction ();
                ReservaNH reservaNH = (ReservaNH)session.Load (typeof(ReservaNH), idreserva);
                session.Delete (reservaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: ReservaEN
public ReservaEN Obtener (int idreserva
                          )
{
        ReservaEN reservaEN = null;

        try
        {
                SessionInitializeTransaction ();
                reservaEN = (ReservaEN)session.Get (typeof(ReservaNH), idreserva);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listar (int p_identidad)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReservaNH self where SELECT r FROM ReservaNH as r INNER JOIN r.Pista as p INNER JOIN p.Entidad as e where e.Identidad = :p_identidad";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReservaNHlistarHQL");
                query.SetParameter ("p_identidad", p_identidad);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Inscribirsepartido (int p_Reserva_OID, System.Collections.Generic.IList<int> p_inscripciones_OIDs)
{
        TFMGen.ApplicationCore.EN.TFM.ReservaEN reservaEN = null;
        try
        {
                SessionInitializeTransaction ();
                reservaEN = (ReservaEN)session.Load (typeof(ReservaNH), p_Reserva_OID);
                TFMGen.ApplicationCore.EN.TFM.ReservaEN inscripcionesENAux = null;
                if (reservaEN.Inscripciones == null) {
                        reservaEN.Inscripciones = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                }

                foreach (int item in p_inscripciones_OIDs) {
                        inscripcionesENAux = new TFMGen.ApplicationCore.EN.TFM.ReservaEN ();
                        inscripcionesENAux = (TFMGen.ApplicationCore.EN.TFM.ReservaEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.ReservaNH), item);
                        inscripcionesENAux.Partido = reservaEN;

                        reservaEN.Inscripciones.Add (inscripcionesENAux);
                }


                session.Update (reservaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listarreservasusuario (int p_idusuario)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReservaNH self where SELECT r FROM ReservaNH as r INNER JOIN r.Usuario as u WHERE u.Idusuario = :p_idusuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReservaNHlistarreservasusuarioHQL");
                query.SetParameter ("p_idusuario", p_idusuario);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Obtenerinscripciones (int p_idReserva)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReservaNH self where SELECT r FROM ReservaNH as r INNER JOIN r.Partido as p where p.Idreserva = :p_idReserva";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReservaNHobtenerinscripcionesHQL");
                query.SetParameter ("p_idReserva", p_idReserva);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Obtenerreservaspista (int p_idPista, Nullable<DateTime> p_fecha)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReservaNH self where SELECT r FROM ReservaNH as r WHERE r.Fecha = :p_fecha AND not r.Cancelada AND r.Pista.Idpista = :p_idPista";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReservaNHobtenerreservaspistaHQL");
                query.SetParameter ("p_idPista", p_idPista);
                query.SetParameter ("p_fecha", p_fecha);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ReservaEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReservaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReservaEN>();
                else
                        result = session.CreateCriteria (typeof(ReservaNH)).List<ReservaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
