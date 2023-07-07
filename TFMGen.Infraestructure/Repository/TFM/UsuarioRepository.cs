
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
 * Clase Usuario:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class UsuarioRepository : BasicRepository, IUsuarioRepository
{
public UsuarioRepository() : base ()
{
}


public UsuarioRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public UsuarioEN ReadOIDDefault (int idusuario
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioNH), idusuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioNH)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioNH usuarioNH = (UsuarioNH)session.Load (typeof(UsuarioNH), usuario.Idusuario);

                usuarioNH.Nombre = usuario.Nombre;


                usuarioNH.Email = usuario.Email;


                usuarioNH.Domicilio = usuario.Domicilio;


                usuarioNH.Telefono = usuario.Telefono;


                usuarioNH.Telefonoalternativo = usuario.Telefonoalternativo;


                usuarioNH.Fechanacimiento = usuario.Fechanacimiento;


                usuarioNH.Alta = usuario.Alta;


                usuarioNH.Baja = usuario.Baja;


                usuarioNH.Ubicacionactual = usuario.Ubicacionactual;


                usuarioNH.Apellidos = usuario.Apellidos;


                usuarioNH.Password = usuario.Password;









                usuarioNH.Codigopostal = usuario.Codigopostal;


                usuarioNH.Localidad = usuario.Localidad;


                usuarioNH.Provincia = usuario.Provincia;






                usuarioNH.Numero = usuario.Numero;



                usuarioNH.Imagen = usuario.Imagen;


                session.Update (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public void Editar (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioNH usuarioNH = (UsuarioNH)session.Load (typeof(UsuarioNH), usuario.Idusuario);

                usuarioNH.Nombre = usuario.Nombre;


                usuarioNH.Email = usuario.Email;


                usuarioNH.Domicilio = usuario.Domicilio;


                usuarioNH.Telefono = usuario.Telefono;


                usuarioNH.Fechanacimiento = usuario.Fechanacimiento;


                usuarioNH.Alta = usuario.Alta;


                usuarioNH.Apellidos = usuario.Apellidos;


                usuarioNH.Password = usuario.Password;


                usuarioNH.Codigopostal = usuario.Codigopostal;


                usuarioNH.Localidad = usuario.Localidad;


                usuarioNH.Provincia = usuario.Provincia;


                usuarioNH.Numero = usuario.Numero;


                usuarioNH.Imagen = usuario.Imagen;

                session.Update (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idusuario
                      )
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioNH usuarioNH = (UsuarioNH)session.Load (typeof(UsuarioNH), idusuario);
                session.Delete (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: UsuarioEN
public UsuarioEN Obtener (int idusuario
                          )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioNH), idusuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioNH)).List<UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public int Crear (UsuarioEN usuario)
{
        UsuarioNH usuarioNH = new UsuarioNH (usuario);

        try
        {
                SessionInitializeTransaction ();
                if (usuario.Rol != null) {
                        // Argumento OID y no colección.
                        usuarioNH
                        .Rol = (TFMGen.ApplicationCore.EN.TFM.RolEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.RolEN), usuario.Rol.Idrol);

                        usuarioNH.Rol.Usuarios
                        .Add (usuarioNH);
                }
                if (usuario.Entidad != null) {
                        // Argumento OID y no colección.
                        usuarioNH
                        .Entidad = (TFMGen.ApplicationCore.EN.TFM.EntidadEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.EntidadEN), usuario.Entidad.Identidad);

                        usuarioNH.Entidad.Usuarios
                        .Add (usuarioNH);
                }

                session.Save (usuarioNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioNH.Idusuario;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Listaralumnosevento (int p_idEvento)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioNH self where SELECT u FROM UsuarioNH as u INNER JOIN u.Eventos as e where e.Idevento = :p_idEvento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioNHlistaralumnoseventoHQL");
                query.SetParameter ("p_idEvento", p_idEvento);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Listartecnicosevento (int p_idEvento)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioNH self where SELECT u FROM UsuarioNH as u INNER JOIN u.EventosImpartidos as e where e.Idevento = :p_idEvento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioNHlistartecnicoseventoHQL");
                query.SetParameter ("p_idEvento", p_idEvento);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Listarusuariospartido (int p_Idreserva)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioNH self where SELECT u FROM UsuarioNH as u INNER JOIN u.Reservas as r where r.Idreserva = :p_Idreserva OR r.Partido.Idreserva = :p_Idreserva";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioNHlistarusuariospartidoHQL");
                query.SetParameter ("p_Idreserva", p_Idreserva);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Cambiarrol (int p_Usuario_OID, int p_rol_OID)
{
        TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioNH), p_Usuario_OID);
                usuarioEN.Rol = (TFMGen.ApplicationCore.EN.TFM.RolEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.RolNH), p_rol_OID);

                usuarioEN.Rol.Usuarios.Add (usuarioEN);



                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public TFMGen.ApplicationCore.EN.TFM.UsuarioEN ObtenerEmailPass (string p_email, string p_pass)
{
        TFMGen.ApplicationCore.EN.TFM.UsuarioEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioNH self where SELECT u FROM UsuarioNH as u where u.Email = :p_email AND u.Password = :p_pass";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioNHobtenerEmailPassHQL");
                query.SetParameter ("p_email", p_email);
                query.SetParameter ("p_pass", p_pass);


                result = query.UniqueResult<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public TFMGen.ApplicationCore.EN.TFM.UsuarioEN Obtenerusuarioemail (string p_email)
{
        TFMGen.ApplicationCore.EN.TFM.UsuarioEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioNH self where SELECT u FROM UsuarioNH as u where u.Email = :p_email";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioNHobtenerusuarioemailHQL");
                query.SetParameter ("p_email", p_email);


                result = query.UniqueResult<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public TFMGen.ApplicationCore.EN.TFM.UsuarioEN Obtenerusuario (int p_idusuario)
{
        TFMGen.ApplicationCore.EN.TFM.UsuarioEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioNH self where FROM UsuarioNH as u where u.Idusuario = :p_idusuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioNHobtenerusuarioHQL");
                query.SetParameter ("p_idusuario", p_idusuario);


                result = query.UniqueResult<TFMGen.ApplicationCore.EN.TFM.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Asignarinstalacionfavoritos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_instalacion_OIDs)
{
        TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioNH), p_Usuario_OID);
                TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacionENAux = null;
                if (usuarioEN.Instalacion == null) {
                        usuarioEN.Instalacion = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.InstalacionEN>();
                }

                foreach (int item in p_instalacion_OIDs) {
                        instalacionENAux = new TFMGen.ApplicationCore.EN.TFM.InstalacionEN ();
                        instalacionENAux = (TFMGen.ApplicationCore.EN.TFM.InstalacionEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.InstalacionNH), item);
                        instalacionENAux.Usuario.Add (usuarioEN);

                        usuarioEN.Instalacion.Add (instalacionENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Eliminarinstalacionfavoritos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_instalacion_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuarioEN = null;
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioNH), p_Usuario_OID);

                TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacionENAux = null;
                if (usuarioEN.Instalacion != null) {
                        foreach (int item in p_instalacion_OIDs) {
                                instalacionENAux = (TFMGen.ApplicationCore.EN.TFM.InstalacionEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.InstalacionNH), item);
                                if (usuarioEN.Instalacion.Contains (instalacionENAux) == true) {
                                        usuarioEN.Instalacion.Remove (instalacionENAux);
                                        instalacionENAux.Usuario.Remove (usuarioEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_instalacion_OIDs you are trying to unrelationer, doesn't exist in UsuarioEN");
                        }
                }

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in UsuarioRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
