
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
 * Clase Material:
 *
 */

namespace TFMGen.Infraestructure.Repository.TFM
{
public partial class MaterialRepository : BasicRepository, IMaterialRepository
{
public MaterialRepository() : base ()
{
}


public MaterialRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public MaterialEN ReadOIDDefault (int idmaterial
                                  )
{
        MaterialEN materialEN = null;

        try
        {
                SessionInitializeTransaction ();
                materialEN = (MaterialEN)session.Get (typeof(MaterialNH), idmaterial);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in MaterialRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return materialEN;
}

public System.Collections.Generic.IList<MaterialEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MaterialEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MaterialNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<MaterialEN>();
                        else
                                result = session.CreateCriteria (typeof(MaterialNH)).List<MaterialEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in MaterialRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MaterialEN material)
{
        try
        {
                SessionInitializeTransaction ();
                MaterialNH materialNH = (MaterialNH)session.Load (typeof(MaterialNH), material.Idmaterial);

                materialNH.Nombre = material.Nombre;


                materialNH.Descripcion = material.Descripcion;


                materialNH.Precio = material.Precio;


                materialNH.Proveedor = material.Proveedor;



                materialNH.Numexistencias = material.Numexistencias;

                session.Update (materialNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in MaterialRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (MaterialEN material)
{
        MaterialNH materialNH = new MaterialNH (material);

        try
        {
                SessionInitializeTransaction ();
                if (material.Instalacion != null) {
                        // Argumento OID y no colección.
                        materialNH
                        .Instalacion = (TFMGen.ApplicationCore.EN.TFM.InstalacionEN)session.Load (typeof(TFMGen.ApplicationCore.EN.TFM.InstalacionEN), material.Instalacion.Idinstalacion);

                        materialNH.Instalacion.Materiales
                        .Add (materialNH);
                }

                session.Save (materialNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in MaterialRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return materialNH.Idmaterial;
}

public void Editar (MaterialEN material)
{
        try
        {
                SessionInitializeTransaction ();
                MaterialNH materialNH = (MaterialNH)session.Load (typeof(MaterialNH), material.Idmaterial);

                materialNH.Nombre = material.Nombre;


                materialNH.Precio = material.Precio;


                materialNH.Proveedor = material.Proveedor;


                materialNH.Descripcion = material.Descripcion;


                materialNH.Numexistencias = material.Numexistencias;

                session.Update (materialNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in MaterialRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int idmaterial
                      )
{
        try
        {
                SessionInitializeTransaction ();
                MaterialNH materialNH = (MaterialNH)session.Load (typeof(MaterialNH), idmaterial);
                session.Delete (materialNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in MaterialRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: Obtener
//Con e: MaterialEN
public MaterialEN Obtener (int idmaterial
                           )
{
        MaterialEN materialEN = null;

        try
        {
                SessionInitializeTransaction ();
                materialEN = (MaterialEN)session.Get (typeof(MaterialNH), idmaterial);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in MaterialRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return materialEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.MaterialEN> Listar (int p_idInstalacion)
{
        System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.MaterialEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MaterialNH self where FROM MaterialNH as m WHERE m.Instalacion.Idinstalacion = :p_idInstalacion";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MaterialNHlistarHQL");
                query.SetParameter ("p_idInstalacion", p_idInstalacion);

                result = query.List<TFMGen.ApplicationCore.EN.TFM.MaterialEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TFMGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new TFMGen.ApplicationCore.Exceptions.DataLayerException ("Error in MaterialRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
