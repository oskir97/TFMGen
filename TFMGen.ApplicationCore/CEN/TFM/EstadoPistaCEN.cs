

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class EstadoPistaCEN
 *
 */
public partial class EstadoPistaCEN
{
private IEstadoPistaRepository _IEstadoPistaRepository;

public EstadoPistaCEN(IEstadoPistaRepository _IEstadoPistaRepository)
{
        this._IEstadoPistaRepository = _IEstadoPistaRepository;
}

public IEstadoPistaRepository get_IEstadoPistaRepository ()
{
        return this._IEstadoPistaRepository;
}

public int Crear (string p_nombre)
{
        EstadoPistaEN estadoPistaEN = null;
        int oid;

        //Initialized EstadoPistaEN
        estadoPistaEN = new EstadoPistaEN ();
        estadoPistaEN.Nombre = p_nombre;



        oid = _IEstadoPistaRepository.Crear (estadoPistaEN);
        return oid;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EstadoPistaEN> Listar (int p_idIdioma)
{
        return _IEstadoPistaRepository.Listar (p_idIdioma);
}
}
}
