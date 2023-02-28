
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
 * Clase Pago:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class PagoRepository : BasicRepository, IPagoRepository
{
public PagoRepository() : base ()
{
}


public PagoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PagoEN ReadOIDDefault (int idpago
                              )
{
        PagoEN pagoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pagoEN = (PagoEN)session.Get (typeof(PagoNH), idpago);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagoEN;
}

public System.Collections.Generic.IList<PagoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PagoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PagoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PagoEN>();
                        else
                                result = session.CreateCriteria (typeof(PagoNH)).List<PagoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PagoEN pago)
{
        try
        {
                SessionInitializeTransaction ();
                PagoNH pagoNH = (PagoNH)session.Load (typeof(PagoNH), pago.Idpago);

                pagoNH.Subtotal = pago.Subtotal;


                pagoNH.Total = pago.Total;


                pagoNH.Iva = pago.Iva;



                pagoNH.Fecha = pago.Fecha;


                session.Update (pagoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (PagoEN pago)
{
        PagoNH pagoNH = new PagoNH (pago);

        try
        {
                SessionInitializeTransaction ();
                if (pago.Tipo != null) {
                        // Argumento OID y no colección.
                        pagoNH
                        .Tipo = (TFMGen.ApplicationCore.EN.TFM.PagoTipoEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.PagoTipoEN), pago.Tipo.Idtipo);

                        pagoNH.Tipo.Pagos
                        .Add (pagoNH);
                }
                if (pago.Reserva != null) {
                        // Argumento OID y no colección.
                        pagoNH
                        .Reserva = (TFMGen.ApplicationCore.EN.TFM.ReservaEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.ReservaEN), pago.Reserva.Idreserva);

                        pagoNH.Reserva.Pago
                                = pagoNH;
                }

                session.Save (pagoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagoNH.Idpago;
}

//Sin e: Obtener
//Con e: PagoEN
public PagoEN Obtener (int idpago
                       )
{
        PagoEN pagoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pagoEN = (PagoEN)session.Get (typeof(PagoNH), idpago);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagoEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> Listar (int p_idReserva)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PagoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PagoNH self where SELECT p FROM PagoNH as p WHERE p.Reserva.Idreserva = :p_idReserva";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PagoNHlistarHQL");
                query.SetParameter ("p_idReserva", p_idReserva);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.PagoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PagoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
