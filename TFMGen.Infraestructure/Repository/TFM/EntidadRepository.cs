
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
 * Clase Entidad:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class EntidadRepository : BasicRepository, IEntidadRepository
{
public EntidadRepository() : base ()
{
}


public EntidadRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public EntidadEN ReadOIDDefault (int identidad
                                 )
{
        EntidadEN entidadEN = null;

        try
        {
                SessionInitializeTransaction ();
                entidadEN = (EntidadEN)session.Get (typeof(EntidadNH), identidad);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entidadEN;
}

public System.Collections.Generic.IList<EntidadEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EntidadEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EntidadNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<EntidadEN>();
                        else
                                result = session.CreateCriteria (typeof(EntidadNH)).List<EntidadEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EntidadEN entidad)
{
        try
        {
                SessionInitializeTransaction ();
                EntidadNH entidadNH = (EntidadNH)session.Load (typeof(EntidadNH), entidad.Identidad);

                entidadNH.Nombre = entidad.Nombre;


                entidadNH.Email = entidad.Email;


                entidadNH.Telefono = entidad.Telefono;


                entidadNH.Domicilio = entidad.Domicilio;


                entidadNH.Alta = entidad.Alta;


                entidadNH.Baja = entidad.Baja;


                entidadNH.Cifnif = entidad.Cifnif;


                entidadNH.Telefonoalternativo = entidad.Telefonoalternativo;






                entidadNH.Codigopostal = entidad.Codigopostal;


                entidadNH.Localidad = entidad.Localidad;


                entidadNH.Provincia = entidad.Provincia;


                entidadNH.Imagen = entidad.Imagen;


                entidadNH.Configuracion = entidad.Configuracion;


                session.Update (entidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (EntidadEN entidad)
{
        EntidadNH entidadNH = new EntidadNH (entidad);

        try
        {
                SessionInitializeTransaction ();

                session.Save (entidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entidadNH.Identidad;
}

public void Editar (EntidadEN entidad)
{
        try
        {
                SessionInitializeTransaction ();
                EntidadNH entidadNH = (EntidadNH)session.Load (typeof(EntidadNH), entidad.Identidad);

                entidadNH.Nombre = entidad.Nombre;


                entidadNH.Email = entidad.Email;


                entidadNH.Telefono = entidad.Telefono;


                entidadNH.Domicilio = entidad.Domicilio;


                entidadNH.Alta = entidad.Alta;


                entidadNH.Codigopostal = entidad.Codigopostal;


                entidadNH.Localidad = entidad.Localidad;


                entidadNH.Provincia = entidad.Provincia;


                entidadNH.Cifnif = entidad.Cifnif;


                entidadNH.Telefonoalternativo = entidad.Telefonoalternativo;


                entidadNH.Configuracion = entidad.Configuracion;

                session.Update (entidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int identidad
                      )
{
        try
        {
                SessionInitializeTransaction ();
                EntidadNH entidadNH = (EntidadNH)session.Load (typeof(EntidadNH), identidad);
                session.Delete (entidadNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: EntidadEN
public EntidadEN Obtener (int identidad
                          )
{
        EntidadEN entidadEN = null;

        try
        {
                SessionInitializeTransaction ();
                entidadEN = (EntidadEN)session.Get (typeof(EntidadNH), identidad);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entidadEN;
}

public System.Collections.Generic.IList<EntidadEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<EntidadEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EntidadNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<EntidadEN>();
                else
                        result = session.CreateCriteria (typeof(EntidadNH)).List<EntidadEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in EntidadRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
