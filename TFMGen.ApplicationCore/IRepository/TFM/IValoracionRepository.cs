
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IValoracionRepository
{
public void setSessionCP (GenericSessionCP session);

ValoracionEN ReadOIDDefault (int idvaloracion
                             );

void ModifyDefault (ValoracionEN valoracion);

System.Collections.Generic.IList<ValoracionEN> ReadAllDefault (int first, int size);



int Crear (ValoracionEN valoracion);

void Editar (ValoracionEN valoracion);


void Eliminar (int idvaloracion
               );


ValoracionEN Obtener (int idvaloracion
                      );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listar (int p_idUsuario);


void Valorarpista (int p_Valoracion_OID, int p_pista_OID);

void Valorarentidad (int p_Valoracion_OID, int p_entidad_OID);

void Valorarinstalacion (int p_Valoracion_OID, int p_instalacion_OID);

void Valorartecnico (int p_Valoracion_OID, int p_tecnico_OID);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listartecnico (int p_idUsuario);


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarentidad (int p_idEntidad);


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarpista (int p_idPista);


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarinstalacion (int p_idInstalacion);


System.Collections.Generic.IList<ValoracionEN> Listartodas (int first, int size);


void Valorarevento (int p_Valoracion_OID, int p_evento_OID);

System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ValoracionEN> Listarevento (int p_idEvento);


void ValorarUsuarioPartido (int p_Valoracion_OID, int p_usuariopartido_OID);
}
}
