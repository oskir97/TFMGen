
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
 * Clase Asitencia:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class AsitenciaRepository : BasicRepository, IAsitenciaRepository
{
public AsitenciaRepository() : base ()
{
}


public AsitenciaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public AsitenciaEN ReadOIDDefault (int idasitencia
                                   )
{
        AsitenciaEN asitenciaEN = null;

        try
        {
                SessionInitializeTransaction ();
                asitenciaEN = (AsitenciaEN)session.Get (typeof(AsitenciaNH), idasitencia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in AsitenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return asitenciaEN;
}

public System.Collections.Generic.IList<AsitenciaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AsitenciaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AsitenciaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<AsitenciaEN>();
                        else
                                result = session.CreateCriteria (typeof(AsitenciaNH)).List<AsitenciaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in AsitenciaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AsitenciaEN asitencia)
{
        try
        {
                SessionInitializeTransaction ();
                AsitenciaNH asitenciaNH = (AsitenciaNH)session.Load (typeof(AsitenciaNH), asitencia.Idasitencia);


                asitenciaNH.Fecha = asitencia.Fecha;


                asitenciaNH.Asiste = asitencia.Asiste;


                asitenciaNH.Notas = asitencia.Notas;


                session.Update (asitenciaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in AsitenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (AsitenciaEN asitencia)
{
        AsitenciaNH asitenciaNH = new AsitenciaNH (asitencia);

        try
        {
                SessionInitializeTransaction ();
                if (asitencia.Usuario != null) {
                        // Argumento OID y no colección.
                        asitenciaNH
                        .Usuario = (TFMGen.ApplicationCore.EN.TFM.UsuarioEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.UsuarioEN), asitencia.Usuario.Idusuario);

                        asitenciaNH.Usuario.Asitencias
                        .Add (asitenciaNH);
                }

                session.Save (asitenciaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in AsitenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return asitenciaNH.Idasitencia;
}

public void Editar (AsitenciaEN asitencia)
{
        try
        {
                SessionInitializeTransaction ();
                AsitenciaNH asitenciaNH = (AsitenciaNH)session.Load (typeof(AsitenciaNH), asitencia.Idasitencia);

                asitenciaNH.Fecha = asitencia.Fecha;


                asitenciaNH.Asiste = asitencia.Asiste;


                asitenciaNH.Notas = asitencia.Notas;

                session.Update (asitenciaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in AsitenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idasitencia
                      )
{
        try
        {
                SessionInitializeTransaction ();
                AsitenciaNH asitenciaNH = (AsitenciaNH)session.Load (typeof(AsitenciaNH), idasitencia);
                session.Delete (asitenciaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in AsitenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: AsitenciaEN
public AsitenciaEN Obtener (int idasitencia
                            )
{
        AsitenciaEN asitenciaEN = null;

        try
        {
                SessionInitializeTransaction ();
                asitenciaEN = (AsitenciaEN)session.Get (typeof(AsitenciaNH), idasitencia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in AsitenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return asitenciaEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> Listar (int p_idUsuario)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AsitenciaNH self where FROM AsitenciaNH as a WHERE a.Usuario.Idusuario = :p_idUsuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AsitenciaNHlistarHQL");
                query.SetParameter ("p_idUsuario", p_idUsuario);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in AsitenciaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
