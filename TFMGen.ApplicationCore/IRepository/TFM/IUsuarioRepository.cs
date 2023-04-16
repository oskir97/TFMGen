
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IUsuarioRepository
{
public void setSessionCP (GenericSessionCP session);

UsuarioEN ReadOIDDefault (int idusuario
                          );

void ModifyDefault (UsuarioEN usuario);

System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size);



void Editar (UsuarioEN usuario);


void Eliminar (int idusuario
               );


UsuarioEN Obtener (int idusuario
                   );


System.Collections.Generic.IList<UsuarioEN> Listar (int first, int size);



int Crear (UsuarioEN usuario);




System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Listaralumnosevento (int p_idEvento);


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Listartecnicosevento (int p_idEvento);



System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> Listarusuariospartido (int p_Idreserva);


void Cambiarrol (int p_Usuario_OID, int p_rol_OID);

TFMGen.ApplicationCore.EN.TFM.UsuarioEN ObtenerEmailPass (string p_email, string p_pass);


TFMGen.ApplicationCore.EN.TFM.UsuarioEN Obtenerusuarioemail (string p_email);
}
}
