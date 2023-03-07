
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
 * Clase Rol:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class RolRepository : BasicRepository, IRolRepository
{
public RolRepository() : base ()
{
}


public RolRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public RolEN ReadOIDDefault (int idrol
                             )
{
        RolEN rolEN = null;

        try
        {
                SessionInitializeTransaction ();
                rolEN = (RolEN)session.Get (typeof(RolNH), idrol);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in RolRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rolEN;
}

public System.Collections.Generic.IList<RolEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RolEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RolNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<RolEN>();
                        else
                                result = session.CreateCriteria (typeof(RolNH)).List<RolEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in RolRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RolEN rol)
{
        try
        {
                SessionInitializeTransaction ();
                RolNH rolNH = (RolNH)session.Load (typeof(RolNH), rol.Idrol);

                rolNH.Nombre = rol.Nombre;



                session.Update (rolNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in RolRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (RolEN rol)
{
        RolNH rolNH = new RolNH (rol);

        try
        {
                SessionInitializeTransaction ();

                session.Save (rolNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in RolRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rolNH.Idrol;
}
}
}
