

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using Newtonsoft.Json;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioRepository _IUsuarioRepository;

public UsuarioCEN(IUsuarioRepository _IUsuarioRepository)
{
        this._IUsuarioRepository = _IUsuarioRepository;
}

public IUsuarioRepository get_IUsuarioRepository ()
{
        return this._IUsuarioRepository;
}

public void Eliminar (int idusuario
                      )
{
        _IUsuarioRepository.Eliminar (idusuario);
}

public UsuarioEN Obtener (int idusuario
                          )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioRepository.Obtener (idusuario);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> Listar (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioRepository.Listar (first, size);
        return list;
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Listaralumnosevento (int p_idEvento)
{
        return _IUsuarioRepository.Listaralumnosevento (p_idEvento);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Listartecnicosevento (int p_idEvento)
{
        return _IUsuarioRepository.Listartecnicosevento (p_idEvento);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Listarusuariospartido (int p_Idreserva)
{
        return _IUsuarioRepository.Listarusuariospartido (p_Idreserva);
}
public TFMGen.ApplicationCore.EN.TFM.UsuarioEN ObtenerEmailPass (string p_email, string p_pass)
{
        return _IUsuarioRepository.ObtenerEmailPass (p_email, p_pass);
}
public TFMGen.ApplicationCore.EN.TFM.UsuarioEN Obtenerusuarioemail (string p_email)
{
        return _IUsuarioRepository.Obtenerusuarioemail (p_email);
}
public TFMGen.ApplicationCore.EN.TFM.UsuarioEN Obtenerusuario (int p_idusuario)
{
        return _IUsuarioRepository.Obtenerusuario (p_idusuario);
}
public void Asignarinstalacionfavoritos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_instalacion_OIDs)
{
        //Call to UsuarioRepository

        _IUsuarioRepository.Asignarinstalacionfavoritos (p_Usuario_OID, p_instalacion_OIDs);
}



private string Encode (int idusuario)
{
        var payload = new Dictionary<string, object>(){
                { "idusuario", idusuario }
        };
        string token = Jose.JWT.Encode (payload, Utils.Util.getKey (), Jose.JwsAlgorithm.HS256);

        return token;
}

public string GetToken (int idusuario)
{
        UsuarioEN en = _IUsuarioRepository.ReadOIDDefault (idusuario);
        string token = Encode (en.Idusuario);

        return token;
}
public int CheckToken (string token)
{
        int result = -1;

        try
        {
                string decodedToken = Utils.Util.Decode (token);



                int id = (int)ObtenerIDUSUARIO (decodedToken);

                UsuarioEN en = _IUsuarioRepository.ReadOIDDefault (id);

                if (en != null && ((long)en.Idusuario).Equals (ObtenerIDUSUARIO (decodedToken))
                    ) {
                        result = id;
                }
                else throw new ModelException ("El token es incorrecto");
        } catch (Exception e)
        {
                throw new ModelException ("El token es incorrecto");
        }

        return result;
}


public long ObtenerIDUSUARIO (string decodedToken)
{
        try
        {
                Dictionary<string, object> results = JsonConvert.DeserializeObject<Dictionary<string, object> >(decodedToken);
                long idusuario = (long)results ["idusuario"];
                return idusuario;
        }
        catch
        {
                throw new Exception ("El token enviado no es correcto");
        }
}
}
}
