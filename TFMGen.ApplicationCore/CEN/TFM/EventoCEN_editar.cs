
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
public void Editar (int p_Evento_OID, string p_nombre, string p_descripcion, bool p_activo, int p_plazas, int p_deporte, Nullable<DateTime> p_inicio, Nullable<DateTime> p_fin, int p_instalacion, double p_precio)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Evento_editar_customized) ENABLED START*/

        EventoEN eventoEN = null;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Idevento = p_Evento_OID;
        eventoEN.Nombre = p_nombre;
        eventoEN.Descripcion = p_descripcion;
        eventoEN.Activo = p_activo;
        eventoEN.Plazas = p_plazas;
        if (p_deporte != -1) {
                eventoEN.Deporte = new TFMGen.ApplicationCore.EN.TFM.DeporteEN ();
                eventoEN.Deporte.Iddeporte = p_deporte;
        }
        eventoEN.Inicio = p_inicio;
        eventoEN.Fin = p_fin;
        if (p_instalacion != -1) {
                eventoEN.Instalacion = new TFMGen.ApplicationCore.EN.TFM.InstalacionEN ();
                eventoEN.Instalacion.Idinstalacion = p_instalacion;
        }
        eventoEN.Precio = p_precio;
        //Call to EventoRepository

        _IEventoRepository.Editar (eventoEN);

        /*PROTECTED REGION END*/
}
}
}
