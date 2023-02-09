

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class RolCEN
 *
 */
public partial class RolCEN
{
private IRolRepository _IRolRepository;

public RolCEN(IRolRepository _IRolRepository)
{
        this._IRolRepository = _IRolRepository;
}

public IRolRepository get_IRolRepository ()
{
        return this._IRolRepository;
}

public int Crear (string p_nombre)
{
        RolEN rolEN = null;
        int oid;

        //Initialized RolEN
        rolEN = new RolEN ();
        rolEN.Nombre = p_nombre;



        oid = _IRolRepository.Crear (rolEN);
        return oid;
}
}
}
