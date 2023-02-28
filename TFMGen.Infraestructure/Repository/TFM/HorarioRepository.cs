
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
 * Clase Horario:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class HorarioRepository : BasicRepository, IHorarioRepository
{
public HorarioRepository() : base ()
{
}


public HorarioRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public HorarioEN ReadOIDDefault (int idhorario
                                 )
{
        HorarioEN horarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                horarioEN = (HorarioEN)session.Get (typeof(HorarioNH), idhorario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return horarioEN;
}

public System.Collections.Generic.IList<HorarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<HorarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(HorarioNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<HorarioEN>();
                        else
                                result = session.CreateCriteria (typeof(HorarioNH)).List<HorarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (HorarioEN horario)
{
        try
        {
                SessionInitializeTransaction ();
                HorarioNH horarioNH = (HorarioNH)session.Load (typeof(HorarioNH), horario.Idhorario);

                horarioNH.Inicio = horario.Inicio;


                horarioNH.Fin = horario.Fin;





                session.Update (horarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (HorarioEN horario)
{
        HorarioNH horarioNH = new HorarioNH (horario);

        try
        {
                SessionInitializeTransaction ();
                if (horario.Pista != null) {
                        // Argumento OID y no colección.
                        horarioNH
                        .Pista = (TFMGen.ApplicationCore.EN.TFM.PistaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.PistaEN), horario.Pista.Idpista);

                        horarioNH.Pista.Horarios
                        .Add (horarioNH);
                }
                if (horario.DiaSemana != null) {
                        for (int i = 0; i < horario.DiaSemana.Count; i++) {
                                horario.DiaSemana [i] = (TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN), horario.DiaSemana [i].Iddiasemana);
                                horario.DiaSemana [i].Horario.Add (horarioNH);
                        }
                }

                session.Save (horarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return horarioNH.Idhorario;
}

public void Editar (HorarioEN horario)
{
        try
        {
                SessionInitializeTransaction ();
                HorarioNH horarioNH = (HorarioNH)session.Load (typeof(HorarioNH), horario.Idhorario);

                horarioNH.Inicio = horario.Inicio;


                horarioNH.Fin = horario.Fin;

                session.Update (horarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idhorario
                      )
{
        try
        {
                SessionInitializeTransaction ();
                HorarioNH horarioNH = (HorarioNH)session.Load (typeof(HorarioNH), idhorario);
                session.Delete (horarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: HorarioEN
public HorarioEN Obtener (int idhorario
                          )
{
        HorarioEN horarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                horarioEN = (HorarioEN)session.Get (typeof(HorarioNH), idhorario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return horarioEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Listar (int p_idPista)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM HorarioNH self where SELECT h FROM HorarioNH as h INNER JOIN h.Pista as p WHERE p.Idpista = :p_idPista";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("HorarioNHlistarHQL");
                query.SetParameter ("p_idPista", p_idPista);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> ListarDiasSemana (int p_idPista, int p_idIdioma)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM HorarioNH self where SELECT h FROM HorarioNH as h INNER JOIN h.DiaSemana as d INNER JOIN d.DiaSemana_l10n as dl10n where h.Pista.Idpista = :p_idPista AND dl10n = :p_idIdioma";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("HorarioNHlistarDiasSemanaHQL");
                query.SetParameter ("p_idPista", p_idPista);
                query.SetParameter ("p_idIdioma", p_idIdioma);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in HorarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
