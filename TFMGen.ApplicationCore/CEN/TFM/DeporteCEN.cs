

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class DeporteCEN
 *
 */
public partial class DeporteCEN
{
private IDeporteRepository _IDeporteRepository;

public DeporteCEN(IDeporteRepository _IDeporteRepository)
{
        this._IDeporteRepository = _IDeporteRepository;
}

public IDeporteRepository get_IDeporteRepository ()
{
        return this._IDeporteRepository;
}

public int Crear (string p_nombre)
{
        DeporteEN deporteEN = null;
        int oid;

        //Initialized DeporteEN
        deporteEN = new DeporteEN ();
        deporteEN.Nombre = p_nombre;



        oid = _IDeporteRepository.Crear (deporteEN);
        return oid;
}

public void Editar (int p_Deporte_OID, string p_nombre)
{
        DeporteEN deporteEN = null;

        //Initialized DeporteEN
        deporteEN = new DeporteEN ();
        deporteEN.Iddeporte = p_Deporte_OID;
        deporteEN.Nombre = p_nombre;
        //Call to DeporteRepository

        _IDeporteRepository.Editar (deporteEN);
}

public void Eliminar (int iddeporte
                      )
{
        _IDeporteRepository.Eliminar (iddeporte);
}

public DeporteEN Obtener (int iddeporte
                          )
{
        DeporteEN deporteEN = null;

        deporteEN = _IDeporteRepository.Obtener (iddeporte);
        return deporteEN;
}

public System.Collections.Generic.IList<DeporteEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<DeporteEN> list = null;

        list = _IDeporteRepository.Listar (first, size);
        return list;
}
}
}
