
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Evento_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class EventoCEN
{
public int Crear (string p_nombre, string p_descripcion, int p_entidad, bool p_activo, int p_plazas, int p_deporte, Nullable<DateTime> p_inicio, Nullable<DateTime> p_fin, int p_instalacion, double p_precio, string p_imagen)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Evento_crear_customized) START*/

        EventoEN eventoEN = null;

        int oid;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Nombre = p_nombre;

        eventoEN.Descripcion = p_descripcion;


        if (p_entidad != -1) {
                eventoEN.Entidad = new TFMGen.ApplicationCore.EN.TFM.EntidadEN ();
                eventoEN.Entidad.Identidad = p_entidad;
        }

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

        eventoEN.Imagen = p_imagen;

        //Call to EventoRepository

        oid = _IEventoRepository.Crear (eventoEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
