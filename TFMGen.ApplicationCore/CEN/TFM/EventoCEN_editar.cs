
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Evento_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class EventoCEN
{
public void Editar (int p_Evento_OID, string p_nombre, string p_descripcion, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> p_alumnos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.UsuarioEN> p_tecnicos, System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.HorarioEN> p_horarios, bool p_activo, int p_plazas)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Evento_editar_customized) ENABLED START*/

        EventoEN eventoEN = null;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Idevento = p_Evento_OID;
        eventoEN.Nombre = p_nombre;
        eventoEN.Descripcion = p_descripcion;
        eventoEN.Usuarios = p_alumnos;
        eventoEN.Tecnicos = p_tecnicos;
        eventoEN.Horarios = p_horarios;
        eventoEN.Activo = p_activo;
        eventoEN.Plazas = p_plazas;
        //Call to EventoRepository

        _IEventoRepository.Editar (eventoEN);

        /*PROTECTED REGION END*/
}
}
}
