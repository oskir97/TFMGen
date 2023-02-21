
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Incidencia_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class IncidenciaCEN
{
public int Crear (int p_usuario, int p_evento, string p_asunto, string p_descripcion, Nullable<DateTime> p_fechacancelada, Nullable<DateTime> p_fechareemplazada)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Incidencia_crear_customized) START*/

        IncidenciaEN incidenciaEN = null;

        int oid;

        //Initialized IncidenciaEN
        incidenciaEN = new IncidenciaEN ();

        if (p_usuario != -1) {
                incidenciaEN.Usuario = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN ();
                incidenciaEN.Usuario.Idusuario = p_usuario;
        }


        if (p_evento != -1) {
                incidenciaEN.Evento = new TFMGen.ApplicationCore.EN.TFM.EventoEN ();
                incidenciaEN.Evento.Idevento = p_evento;
        }

        incidenciaEN.Asunto = p_asunto;

        incidenciaEN.Descripcion = p_descripcion;

        incidenciaEN.Fechacancelada = p_fechacancelada;

        incidenciaEN.Fechareemplazada = p_fechareemplazada;

        //Call to IncidenciaRepository

        oid = _IIncidenciaRepository.Crear (incidenciaEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
