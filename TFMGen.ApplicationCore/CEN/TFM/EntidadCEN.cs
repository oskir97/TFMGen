

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class EntidadCEN
 *
 */
public partial class EntidadCEN
{
private IEntidadRepository _IEntidadRepository;

public EntidadCEN(IEntidadRepository _IEntidadRepository)
{
        this._IEntidadRepository = _IEntidadRepository;
}

public IEntidadRepository get_IEntidadRepository ()
{
        return this._IEntidadRepository;
}

public int Crear (string p_nombre, string p_email, string p_telefono, string p_domicilio, Nullable<DateTime> p_alta, int p_codigoPostal)
{
        EntidadEN entidadEN = null;
        int oid;

        //Initialized EntidadEN
        entidadEN = new EntidadEN ();
        entidadEN.Nombre = p_nombre;

        entidadEN.Email = p_email;

        entidadEN.Telefono = p_telefono;

        entidadEN.Domicilio = p_domicilio;

        entidadEN.Alta = p_alta;


        if (p_codigoPostal != -1) {
                // El argumento p_codigoPostal -> Property codigoPostal es oid = false
                // Lista de oids identidad
                entidadEN.CodigoPostal = new TFMGen.ApplicationCore.EN.TFM.CodigoPostalEN ();
                entidadEN.CodigoPostal.Idcodigopostal = p_codigoPostal;
        }



        oid = _IEntidadRepository.Crear (entidadEN);
        return oid;
}

public void Editar (int p_Entidad_OID, string p_nombre, string p_email, string p_telefono, string p_domicilio, Nullable<DateTime> p_alta)
{
        EntidadEN entidadEN = null;

        //Initialized EntidadEN
        entidadEN = new EntidadEN ();
        entidadEN.Identidad = p_Entidad_OID;
        entidadEN.Nombre = p_nombre;
        entidadEN.Email = p_email;
        entidadEN.Telefono = p_telefono;
        entidadEN.Domicilio = p_domicilio;
        entidadEN.Alta = p_alta;
        //Call to EntidadRepository

        _IEntidadRepository.Editar (entidadEN);
}

public void Eliminar (int identidad
                      )
{
        _IEntidadRepository.Eliminar (identidad);
}

public EntidadEN Obtener (int identidad
                          )
{
        EntidadEN entidadEN = null;

        entidadEN = _IEntidadRepository.Obtener (identidad);
        return entidadEN;
}

public System.Collections.Generic.IList<EntidadEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EntidadEN> list = null;

        list = _IEntidadRepository.ReadAll (first, size);
        return list;
}
}
}
