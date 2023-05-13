
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
 * Clase Pista:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class PistaRepository : BasicRepository, IPistaRepository
{
public PistaRepository() : base ()
{
}


public PistaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PistaEN ReadOIDDefault (int idpista
                               )
{
        PistaEN pistaEN = null;

        try
        {
                SessionInitializeTransaction ();
                pistaEN = (PistaEN)session.Get (typeof(PistaNH), idpista);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pistaEN;
}

public System.Collections.Generic.IList<PistaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PistaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PistaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PistaEN>();
                        else
                                result = session.CreateCriteria (typeof(PistaNH)).List<PistaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PistaEN pista)
{
        try
        {
                SessionInitializeTransaction ();
                PistaNH pistaNH = (PistaNH)session.Load (typeof(PistaNH), pista.Idpista);

                pistaNH.Nombre = pista.Nombre;


                pistaNH.Ubicacion = pista.Ubicacion;


                pistaNH.Imagen = pista.Imagen;


                pistaNH.Maxreservas = pista.Maxreservas;









                pistaNH.Visible = pista.Visible;


                pistaNH.Precio = pista.Precio;

                session.Update (pistaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (PistaEN pista)
{
        PistaNH pistaNH = new PistaNH (pista);

        try
        {
                SessionInitializeTransaction ();
                if (pista.Entidad != null) {
                        // Argumento OID y no colección.
                        pistaNH
                        .Entidad = (TFMGen.ApplicationCore.EN.TFM.EntidadEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.EntidadEN), pista.Entidad.Identidad);

                        pistaNH.Entidad.Pistas
                        .Add (pistaNH);
                }
                if (pista.EstadosPista != null) {
                        // Argumento OID y no colección.
                        pistaNH
                        .EstadosPista = (TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN), pista.EstadosPista.Idestado);

                        pistaNH.EstadosPista.Pistas
                        .Add (pistaNH);
                }
                if (pista.Deporte != null) {
                        for (int i = 0; i < pista.Deporte.Count; i++) {
                                pista.Deporte [i] = (TFMGen.ApplicationCore.EN.TFM.DeporteEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.DeporteEN), pista.Deporte [i].Iddeporte);
                                pista.Deporte [i].Pistas.Add (pistaNH);
                        }
                }
                if (pista.Instalacion != null)
                {
                    // Argumento OID y no colección.
                    pistaNH
                    .Instalacion = (TFMGen.ApplicationCore.EN.TFM.InstalacionEN)session.Load(typeof(TFMGen.ApplicationCore.EN.TFM.InstalacionEN), pista.Instalacion.Idinstalacion);

                    pistaNH.Instalacion.Pistas
                    .Add(pistaNH);
                }

                session.Save (pistaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pistaNH.Idpista;
}

public void Editar (PistaEN pista)
{
        try
        {
                SessionInitializeTransaction ();
                PistaNH pistaNH = (PistaNH)session.Load (typeof(PistaNH), pista.Idpista);

                pistaNH.Nombre = pista.Nombre;


                pistaNH.Maxreservas = pista.Maxreservas;


                pistaNH.Ubicacion = pista.Ubicacion;


                pistaNH.Visible = pista.Visible;
                if (pista.EstadosPista != null)
                {
                    // Argumento OID y no colección.
                    pistaNH
                    .EstadosPista = (TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN)session.Load(typeof(TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN), pista.EstadosPista.Idestado);

                    pistaNH.EstadosPista.Pistas
                    .Add(pistaNH);
                }
                if (pista.Deporte != null)
                {

                    foreach (var deporte in pistaNH.Deporte)
                    {
                        deporte.Pistas.Remove(pistaNH);
                    }

                    pistaNH.Deporte.Clear();

                    for (int i = 0; i < pista.Deporte.Count; i++)
                    {
                        pistaNH.Deporte.Add((TFMGen.ApplicationCore.EN.TFM.DeporteEN)session.Load(typeof(TFMGen.ApplicationCore.EN.TFM.DeporteEN), pista.Deporte[i].Iddeporte));
                        pistaNH.Deporte[i].Pistas.Add(pistaNH);
                    }
                }
                if (pista.Instalacion != null)
                {
                    // Argumento OID y no colección.
                    pistaNH
                    .Instalacion = (TFMGen.ApplicationCore.EN.TFM.InstalacionEN)session.Load(typeof(TFMGen.ApplicationCore.EN.TFM.InstalacionEN), pista.Instalacion.Idinstalacion);

                    pistaNH.Instalacion.Pistas
                    .Add(pistaNH);
                }

                pistaNH.Precio = pista.Precio;

                session.Update (pistaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idpista
                      )
{
        try
        {
                SessionInitializeTransaction ();
                PistaNH pistaNH = (PistaNH)session.Load (typeof(PistaNH), idpista);
                foreach (var deporte in pistaNH.Deporte)
                    deporte.Pistas.Remove(pistaNH);
                session.Delete (pistaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: PistaEN
public PistaEN Obtener (int idpista
                        )
{
        PistaEN pistaEN = null;

        try
        {
                SessionInitializeTransaction ();
                pistaEN = (PistaEN)session.Get (typeof(PistaNH), idpista);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pistaEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> ListarEntidad (int p_idEntidad)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PistaNH self where SELECT p FROM PistaNH as p INNER JOIN p.Entidad as e WHERE e.Identidad = :p_idEntidad";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PistaNHlistarEntidadHQL");
                query.SetParameter ("p_idEntidad", p_idEntidad);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Buscar (string p_busqueda)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PistaNH self where SELECT p FROM PistaNH as p LEFT JOIN p.Deporte as d LEFT JOIN p.Instalacion as i WHERE p.Visible = true AND (:p_busqueda is null OR (p.Nombre LIKE :p_busqueda OR p.Ubicacion LIKE :p_busqueda OR (i is not null AND (i.Nombre LIKE :p_busqueda OR i.Localidad LIKE :p_busqueda OR i.Provincia LIKE :p_busqueda OR i.Telefono LIKE :p_busqueda OR i.Codigopostal LIKE :p_busqueda OR i.Domicilio LIKE :p_busqueda) AND i.Visible) OR ((p.Entidad.Nombre LIKE :p_busqueda OR p.Entidad.Localidad LIKE :p_busqueda OR p.Entidad.Provincia LIKE :p_busqueda OR p.Entidad.Telefono LIKE :p_busqueda OR p.Entidad.Codigopostal LIKE :p_busqueda OR p.Entidad.Domicilio LIKE :p_busqueda) AND p.Entidad.Baja is null) OR d.Nombre LIKE :p_busqueda))";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PistaNHbuscarHQL");
                query.SetParameter ("p_busqueda", p_busqueda);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Listar ()
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PistaNH self where SELECT p FROM PistaNH  as p WHERE p.Visible = true";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PistaNHlistarHQL");

                result = query.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> Obtenerpistasinstalacion (int p_idinstalacion)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.PistaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PistaNH self where SELECT p FROM PistaNH  as p WHERE p.Instalacion.Idinstalacion = :p_idinstalacion";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PistaNHobtenerpistasinstalacionHQL");
                query.SetParameter ("p_idinstalacion", p_idinstalacion);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PistaEN> Listartodas (int first, int size)
{
        System.Collections.Generic.IList<PistaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PistaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<PistaEN>();
                else
                        result = session.CreateCriteria (typeof(PistaNH)).List<PistaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in PistaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
