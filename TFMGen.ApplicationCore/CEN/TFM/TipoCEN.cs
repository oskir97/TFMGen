

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class TipoCEN
 *
 */
public partial class TipoCEN
{
private ITipoRepository _ITipoRepository;

public TipoCEN(ITipoRepository _ITipoRepository)
{
        this._ITipoRepository = _ITipoRepository;
}

public ITipoRepository get_ITipoRepository ()
{
        return this._ITipoRepository;
}

public int Crear (string p_nombre)
{
        TipoEN tipoEN = null;
        int oid;

        //Initialized TipoEN
        tipoEN = new TipoEN ();
        tipoEN.Nombre = p_nombre;



        oid = _ITipoRepository.Crear (tipoEN);
        return oid;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.TipoEN> Listar (int p_idIdioma)
{
        return _ITipoRepository.Listar (p_idIdioma);
}
}
}
