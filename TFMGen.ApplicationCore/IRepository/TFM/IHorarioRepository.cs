
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IHorarioRepository
{
public void setSessionCP (GenericSessionCP session);

HorarioEN ReadOIDDefault (int idhorario
                          );

void ModifyDefault (HorarioEN horario);

System.Collections.Generic.IList<HorarioEN> ReadAllDefault (int first, int size);



int Crear (HorarioEN horario);

void Editar (HorarioEN horario);


void Eliminar (int idhorario
               );


HorarioEN Obtener (int idhorario
                   );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> Listar (int p_idPista);


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> ListarDiasSemana (int p_idHorario, int p_idIdioma);


System.Collections.Generic.IList<HorarioEN> Listartodos (int first, int size);


void Asignarpistas (int p_Horario_OID, System.Collections.Generic.IList<int> p_pistas_OIDs);

void Elimininarpistas (int p_Horario_OID, System.Collections.Generic.IList<int> p_pistas_OIDs);
}
}
