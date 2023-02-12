

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class IdiomaCEN
 *
 */
public partial class IdiomaCEN
{
private IIdiomaRepository _IIdiomaRepository;

public IdiomaCEN(IIdiomaRepository _IIdiomaRepository)
{
        this._IIdiomaRepository = _IIdiomaRepository;
}

public IIdiomaRepository get_IIdiomaRepository ()
{
        return this._IIdiomaRepository;
}

public int Crear (string p_nombre, string p_cultura)
{
        IdiomaEN idiomaEN = null;
        int oid;

        //Initialized IdiomaEN
        idiomaEN = new IdiomaEN ();
        idiomaEN.Nombre = p_nombre;

        idiomaEN.Cultura = p_cultura;



        oid = _IIdiomaRepository.Crear (idiomaEN);
        return oid;
}
}
}
