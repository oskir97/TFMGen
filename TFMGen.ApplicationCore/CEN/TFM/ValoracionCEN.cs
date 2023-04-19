

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class ValoracionCEN
 *
 */
public partial class ValoracionCEN
{
private IValoracionRepository _IValoracionRepository;

public ValoracionCEN(IValoracionRepository _IValoracionRepository)
{
        this._IValoracionRepository = _IValoracionRepository;
}

public IValoracionRepository get_IValoracionRepository ()
{
        return this._IValoracionRepository;
}

public int Crear (int p_estrellas, string p_comentario, int p_usuario)
{
        ValoracionEN valoracionEN = null;
        int oid;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Estrellas = p_estrellas;

        valoracionEN.Comentario = p_comentario;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids idvaloracion
                valoracionEN.Usuario = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN ();
                valoracionEN.Usuario.Idusuario = p_usuario;
        }



        oid = _IValoracionRepository.Crear (valoracionEN);
        return oid;
}

public void Editar (int p_Valoracion_OID, int p_estrellas, string p_comentario)
{
        ValoracionEN valoracionEN = null;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Idvaloracion = p_Valoracion_OID;
        valoracionEN.Estrellas = p_estrellas;
        valoracionEN.Comentario = p_comentario;
        //Call to ValoracionRepository

        _IValoracionRepository.Editar (valoracionEN);
}

public void Eliminar (int idvaloracion
                      )
{
        _IValoracionRepository.Eliminar (idvaloracion);
}

public ValoracionEN Obtener (int idvaloracion
                             )
{
        ValoracionEN valoracionEN = null;

        valoracionEN = _IValoracionRepository.Obtener (idvaloracion);
        return valoracionEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listar (int p_idUsuario)
{
        return _IValoracionRepository.Listar (p_idUsuario);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listartecnico (int p_idUsuario)
{
        return _IValoracionRepository.Listartecnico (p_idUsuario);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarentidad (int p_idEntidad)
{
        return _IValoracionRepository.Listarentidad (p_idEntidad);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarpista (int p_idPista)
{
        return _IValoracionRepository.Listarpista (p_idPista);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarinstalacion (int p_idInstalacion)
{
        return _IValoracionRepository.Listarinstalacion (p_idInstalacion);
}
public System.Collections.Generic.IList<ValoracionEN> Listartodas (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> list = null;

        list = _IValoracionRepository.Listartodas (first, size);
        return list;
}
}
}
