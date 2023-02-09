

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class AsitenciaCEN
 *
 */
public partial class AsitenciaCEN
{
private IAsitenciaRepository _IAsitenciaRepository;

public AsitenciaCEN(IAsitenciaRepository _IAsitenciaRepository)
{
        this._IAsitenciaRepository = _IAsitenciaRepository;
}

public IAsitenciaRepository get_IAsitenciaRepository ()
{
        return this._IAsitenciaRepository;
}

public int Crear (int p_usuario, Nullable<DateTime> p_fecha, bool p_asiste)
{
        AsitenciaEN asitenciaEN = null;
        int oid;

        //Initialized AsitenciaEN
        asitenciaEN = new AsitenciaEN ();

        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids idasitencia
                asitenciaEN.Usuario = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN ();
                asitenciaEN.Usuario.Idusuario = p_usuario;
        }

        asitenciaEN.Fecha = p_fecha;

        asitenciaEN.Asiste = p_asiste;



        oid = _IAsitenciaRepository.Crear (asitenciaEN);
        return oid;
}

public void Editar (int p_Asitencia_OID, Nullable<DateTime> p_fecha, bool p_asiste)
{
        AsitenciaEN asitenciaEN = null;

        //Initialized AsitenciaEN
        asitenciaEN = new AsitenciaEN ();
        asitenciaEN.Idasitencia = p_Asitencia_OID;
        asitenciaEN.Fecha = p_fecha;
        asitenciaEN.Asiste = p_asiste;
        //Call to AsitenciaRepository

        _IAsitenciaRepository.Editar (asitenciaEN);
}

public void Eliminar (int idasitencia
                      )
{
        _IAsitenciaRepository.Eliminar (idasitencia);
}

public AsitenciaEN Obtener (int idasitencia
                            )
{
        AsitenciaEN asitenciaEN = null;

        asitenciaEN = _IAsitenciaRepository.Obtener (idasitencia);
        return asitenciaEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.AsitenciaEN> Listar (int p_idUsuario)
{
        return _IAsitenciaRepository.Listar (p_idUsuario);
}
}
}
