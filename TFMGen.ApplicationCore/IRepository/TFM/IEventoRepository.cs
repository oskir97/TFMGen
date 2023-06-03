
using System;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFMGen.ApplicationCore.IRepository.TFM
{
public partial interface IEventoRepository
{
public void setSessionCP (GenericSessionCP session);

EventoEN ReadOIDDefault (int idevento
                         );

void ModifyDefault (EventoEN evento);

System.Collections.Generic.IList<EventoEN> ReadAllDefault (int first, int size);



int Crear (EventoEN evento);

void Editar (EventoEN evento);


void Eliminar (int idevento
               );


EventoEN Obtener (int idevento
                  );


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Listar (int p_idUsuario);


System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.EventoEN> Listarentidad (int p_idEntidad);


void Asignarusuario (int p_Evento_OID, System.Collections.Generic.IList<int> p_usuarios_OIDs);


System.Collections.Generic.IList<EventoEN> Listartodos (int first, int size);


void Eliminarusuario (int p_Evento_OID, System.Collections.Generic.IList<int> p_usuarios_OIDs);

void Asignartecnico (int p_Evento_OID, System.Collections.Generic.IList<int> p_tecnicos_OIDs);

void Eliminartecnico (int p_Evento_OID, System.Collections.Generic.IList<int> p_tecnicos_OIDs);

void Asignardiassemana (int p_Evento_OID, System.Collections.Generic.IList<int> p_diasSemana_OIDs);

void Eliminardiassemana (int p_Evento_OID, System.Collections.Generic.IList<int> p_diasSemana_OIDs);

void Asignarhorarios (int p_Evento_OID, System.Collections.Generic.IList<int> p_horarios_OIDs);

void Eliminarhorarios (int p_Evento_OID, System.Collections.Generic.IList<int> p_horarios_OIDs);
}
}
