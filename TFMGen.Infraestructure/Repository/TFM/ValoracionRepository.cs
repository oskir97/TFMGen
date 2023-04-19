
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
 * Clase Valoracion:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class ValoracionRepository : BasicRepository, IValoracionRepository
{
public ValoracionRepository() : base ()
{
}


public ValoracionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ValoracionEN ReadOIDDefault (int idvaloracion
                                    )
{
        ValoracionEN valoracionEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionEN = (ValoracionEN)session.Get (typeof(ValoracionNH), idvaloracion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionEN;
}

public System.Collections.Generic.IList<ValoracionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ValoracionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ValoracionEN>();
                        else
                                result = session.CreateCriteria (typeof(ValoracionNH)).List<ValoracionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ValoracionEN valoracion)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionNH valoracionNH = (ValoracionNH)session.Load (typeof(ValoracionNH), valoracion.Idvaloracion);

                valoracionNH.Estrellas = valoracion.Estrellas;


                valoracionNH.Comentario = valoracion.Comentario;






                session.Update (valoracionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (ValoracionEN valoracion)
{
        ValoracionNH valoracionNH = new ValoracionNH (valoracion);

        try
        {
                SessionInitializeTransaction ();
                if (valoracion.Usuario != null) {
                        // Argumento OID y no colección.
                        valoracionNH
                        .Usuario = (TFMGen.ApplicationCore.EN.TFM.UsuarioEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.UsuarioEN), valoracion.Usuario.Idusuario);

                        valoracionNH.Usuario.ValoracionesUsuario
                        .Add (valoracionNH);
                }

                session.Save (valoracionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionNH.Idvaloracion;
}

public void Editar (ValoracionEN valoracion)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionNH valoracionNH = (ValoracionNH)session.Load (typeof(ValoracionNH), valoracion.Idvaloracion);

                valoracionNH.Estrellas = valoracion.Estrellas;


                valoracionNH.Comentario = valoracion.Comentario;

                session.Update (valoracionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idvaloracion
                      )
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionNH valoracionNH = (ValoracionNH)session.Load (typeof(ValoracionNH), idvaloracion);
                session.Delete (valoracionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: ValoracionEN
public ValoracionEN Obtener (int idvaloracion
                             )
{
        ValoracionEN valoracionEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionEN = (ValoracionEN)session.Get (typeof(ValoracionNH), idvaloracion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listar (int p_idUsuario)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ValoracionNH self where SELECT v FROM ValoracionNH as v WHERE v.Usuario.Idusuario = :p_idUsuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ValoracionNHlistarHQL");
                query.SetParameter ("p_idUsuario", p_idUsuario);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listartecnico (int p_idUsuario)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ValoracionNH self where SELECT v FROM ValoracionNH as v WHERE v.Tecnico.Idusuario = :p_idUsuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ValoracionNHlistartecnicoHQL");
                query.SetParameter ("p_idUsuario", p_idUsuario);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarentidad (int p_idEntidad)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ValoracionNH self where SELECT v FROM ValoracionNH as v WHERE v.Entidad.Identidad = :p_idEntidad";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ValoracionNHlistarentidadHQL");
                query.SetParameter ("p_idEntidad", p_idEntidad);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarpista (int p_idPista)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ValoracionNH self where SELECT v FROM ValoracionNH as v WHERE v.Pista.Idpista = :p_idPista";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ValoracionNHlistarpistaHQL");
                query.SetParameter ("p_idPista", p_idPista);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarinstalacion (int p_idInstalacion)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ValoracionNH self where SELECT v FROM ValoracionNH as v WHERE v.Instalacion.Idinstalacion = :p_idInstalacion";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ValoracionNHlistarinstalacionHQL");
                query.SetParameter ("p_idInstalacion", p_idInstalacion);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.ValoracionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<ValoracionEN> Listartodas (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ValoracionNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ValoracionEN>();
                else
                        result = session.CreateCriteria (typeof(ValoracionNH)).List<ValoracionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in ValoracionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
