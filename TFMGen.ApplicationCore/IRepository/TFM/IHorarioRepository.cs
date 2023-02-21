
using System;
using TFMGen.ApplicationCore.EN.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IHorarioRepository
{
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



System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN> ListarDiasSemana (int p_idPista, int p_idIdioma);
}
}
