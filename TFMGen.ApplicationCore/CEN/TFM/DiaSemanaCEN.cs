

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class DiaSemanaCEN
 *
 */
public partial class DiaSemanaCEN
{
private IDiaSemanaRepository _IDiaSemanaRepository;

public DiaSemanaCEN(IDiaSemanaRepository _IDiaSemanaRepository)
{
        this._IDiaSemanaRepository = _IDiaSemanaRepository;
}

public IDiaSemanaRepository get_IDiaSemanaRepository ()
{
        return this._IDiaSemanaRepository;
}

public int Crear (string p_nombre)
{
        DiaSemanaEN diaSemanaEN = null;
        int oid;

        //Initialized DiaSemanaEN
        diaSemanaEN = new DiaSemanaEN ();
        diaSemanaEN.Nombre = p_nombre;



        oid = _IDiaSemanaRepository.Crear (diaSemanaEN);
        return oid;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemanaEN> Obtener (string p_dia)
{
        return _IDiaSemanaRepository.Obtener (p_dia);
}
public System.Collections.Generic.IList<DiaSemanaEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<DiaSemanaEN> list = null;

        list = _IDiaSemanaRepository.Listar (first, size);
        return list;
}
}
}
