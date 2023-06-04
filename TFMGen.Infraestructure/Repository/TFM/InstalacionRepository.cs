
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
 * Clase Instalacion:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class InstalacionRepository : BasicRepository, IInstalacionRepository
{
public InstalacionRepository() : base ()
{
}


public InstalacionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public InstalacionEN ReadOIDDefault (int idinstalacion
                                     )
{
        InstalacionEN instalacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                instalacionEN = (InstalacionEN)session.Get (typeof(InstalacionNH), idinstalacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return instalacionEN;
}

public System.Collections.Generic.IList<InstalacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<InstalacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(InstalacionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<InstalacionEN>();
                        else
                                result = session.CreateCriteria (typeof(InstalacionNH)).List<InstalacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (InstalacionEN instalacion)
{
        try
        {
                SessionInitializeTransaction ();
                InstalacionNH instalacionNH = (InstalacionNH)session.Load (typeof(InstalacionNH), instalacion.Idinstalacion);

                instalacionNH.Nombre = instalacion.Nombre;


                instalacionNH.Telefono = instalacion.Telefono;


                instalacionNH.Domicilio = instalacion.Domicilio;


                instalacionNH.Ubicacion = instalacion.Ubicacion;


                instalacionNH.Imagen = instalacion.Imagen;






                instalacionNH.Codigopostal = instalacion.Codigopostal;


                instalacionNH.Localidad = instalacion.Localidad;


                instalacionNH.Provincia = instalacion.Provincia;


                instalacionNH.Telefonoalternativo = instalacion.Telefonoalternativo;


                instalacionNH.Visible = instalacion.Visible;


                instalacionNH.Latitud = instalacion.Latitud;


                instalacionNH.Longitud = instalacion.Longitud;


                session.Update (instalacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (InstalacionEN instalacion)
{
        InstalacionNH instalacionNH = new InstalacionNH (instalacion);

        try
        {
                SessionInitializeTransaction ();
                if (instalacion.Entidad != null) {
                        // Argumento OID y no colección.
                        instalacionNH
                        .Entidad = (TFMGen.ApplicationCore.EN.TFM.EntidadEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.EntidadEN), instalacion.Entidad.Identidad);

                        instalacionNH.Entidad.Instalaciones
                        .Add (instalacionNH);
                }

                session.Save (instalacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return instalacionNH.Idinstalacion;
}

public void Editar (InstalacionEN instalacion)
{
        try
        {
                SessionInitializeTransaction ();
                InstalacionNH instalacionNH = (InstalacionNH)session.Load (typeof(InstalacionNH), instalacion.Idinstalacion);

                instalacionNH.Nombre = instalacion.Nombre;


                instalacionNH.Telefono = instalacion.Telefono;


                instalacionNH.Domicilio = instalacion.Domicilio;


                instalacionNH.Ubicacion = instalacion.Ubicacion;


                instalacionNH.Codigopostal = instalacion.Codigopostal;


                instalacionNH.Localidad = instalacion.Localidad;


                instalacionNH.Provincia = instalacion.Provincia;


                instalacionNH.Telefonoalternativo = instalacion.Telefonoalternativo;


                instalacionNH.Latitud = instalacion.Latitud;


                instalacionNH.Longitud = instalacion.Longitud;

                session.Update (instalacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idinstalacion
                      )
{
        try
        {
                SessionInitializeTransaction ();
                InstalacionNH instalacionNH = (InstalacionNH)session.Load (typeof(InstalacionNH), idinstalacion);
                session.Delete (instalacionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: InstalacionEN
public InstalacionEN Obtener (int idinstalacion
                              )
{
        InstalacionEN instalacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                instalacionEN = (InstalacionEN)session.Get (typeof(InstalacionNH), idinstalacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return instalacionEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> Listar (int p_idEntidad)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.InstalacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM InstalacionNH self where SELECT i FROM InstalacionNH as i WHERE i.Entidad.Identidad = :p_idEntidad";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("InstalacionNHlistarHQL");
                query.SetParameter ("p_idEntidad", p_idEntidad);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.InstalacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Asignarpista (int p_Instalacion_OID, System.Collections.Generic.IList<int> p_pistas_OIDs)
{
        TFMGen.ApplicationCore.EN.TFM.InstalacionEN instalacionEN = null;
        try
        {
                SessionInitializeTransaction ();
                instalacionEN = (InstalacionEN)session.Load (typeof(InstalacionNH), p_Instalacion_OID);
                TFMGen.ApplicationCore.EN.TFM.PistaEN pistasENAux = null;
                if (instalacionEN.Pistas == null) {
                        instalacionEN.Pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                }

                foreach (int item in p_pistas_OIDs) {
                        pistasENAux = new TFMGen.ApplicationCore.EN.TFM.PistaEN ();
                        pistasENAux = (TFMGen.ApplicationCore.EN.TFM.PistaEN)session.Load (typeof(TFMGen.Infraestructure.EN.TFM.PistaNH), item);
                        pistasENAux.Instalacion = instalacionEN;

                        instalacionEN.Pistas.Add (pistasENAux);
                }


                session.Update (instalacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<InstalacionEN> Listartodos (int first, int size)
{
        System.Collections.Generic.IList<InstalacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(InstalacionNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<InstalacionEN>();
                else
                        result = session.CreateCriteria (typeof(InstalacionNH)).List<InstalacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in InstalacionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
