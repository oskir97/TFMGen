
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
 * Clase CodigoPostal:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class CodigoPostalRepository : BasicRepository, ICodigoPostalRepository
{
public CodigoPostalRepository() : base ()
{
}


public CodigoPostalRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public CodigoPostalEN ReadOIDDefault (int idcodigopostal
                                      )
{
        CodigoPostalEN codigoPostalEN = null;

        try
        {
                SessionInitializeTransaction ();
                codigoPostalEN = (CodigoPostalEN)session.Get (typeof(CodigoPostalNH), idcodigopostal);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CodigoPostalRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return codigoPostalEN;
}

public System.Collections.Generic.IList<CodigoPostalEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CodigoPostalEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CodigoPostalNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<CodigoPostalEN>();
                        else
                                result = session.CreateCriteria (typeof(CodigoPostalNH)).List<CodigoPostalEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CodigoPostalRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CodigoPostalEN codigoPostal)
{
        try
        {
                SessionInitializeTransaction ();
                CodigoPostalNH codigoPostalNH = (CodigoPostalNH)session.Load (typeof(CodigoPostalNH), codigoPostal.Idcodigopostal);

                codigoPostalNH.Codigo = codigoPostal.Codigo;


                codigoPostalNH.Localidad = codigoPostal.Localidad;


                codigoPostalNH.Comunidad = codigoPostal.Comunidad;


                codigoPostalNH.Provincia = codigoPostal.Provincia;


                codigoPostalNH.Latitud = codigoPostal.Latitud;


                codigoPostalNH.Longitud = codigoPostal.Longitud;


                codigoPostalNH.Precision = codigoPostal.Precision;



                session.Update (codigoPostalNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CodigoPostalRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (CodigoPostalEN codigoPostal)
{
        CodigoPostalNH codigoPostalNH = new CodigoPostalNH (codigoPostal);

        try
        {
                SessionInitializeTransaction ();

                session.Save (codigoPostalNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in CodigoPostalRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return codigoPostalNH.Idcodigopostal;
}
}
}
