
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Pista_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class PistaCEN
{
public int Crear (string p_nombre, int p_maxreservas, int p_entidad, int p_estadosPista, System.Collections.Generic.IList<int> p_deporte, string p_ubicacion, bool p_visible, int p_instalacion, double p_precio, double p_latitud, double p_longitud)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Pista_crear_customized) ENABLED START*/

        PistaEN pistaEN = null;

        int oid;

        //Initialized PistaEN
        pistaEN = new PistaEN ();
        pistaEN.Nombre = p_nombre;

        pistaEN.Maxreservas = p_maxreservas;


        if (p_entidad != -1) {
                pistaEN.Entidad = new TFMGen.ApplicationCore.EN.TFM.EntidadEN ();
                pistaEN.Entidad.Identidad = p_entidad;
        }


        if (p_estadosPista != -1) {
                pistaEN.EstadosPista = new TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN ();
                pistaEN.EstadosPista.Idestado = p_estadosPista;
        }


        pistaEN.Deporte = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DeporteEN>();
        if (p_deporte != null) {
                foreach (int item in p_deporte) {
                        TFMGen.ApplicationCore.EN.TFM.DeporteEN en = new TFMGen.ApplicationCore.EN.TFM.DeporteEN ();
                        en.Iddeporte = item;
                        pistaEN.Deporte.Add (en);
                }
        }

        else{
                pistaEN.Deporte = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DeporteEN>();
        }

        pistaEN.Ubicacion = p_ubicacion;
        pistaEN.Visible = p_visible;

        if (p_instalacion != -1) {
                pistaEN.Instalacion = new TFMGen.ApplicationCore.EN.TFM.InstalacionEN ();
                pistaEN.Instalacion.Idinstalacion = p_instalacion;
        }
        else{
                pistaEN.Instalacion = null;
        }

        pistaEN.Precio = p_precio;

        pistaEN.Latitud = p_latitud;
        pistaEN.Longitud = p_longitud;

        //Call to PistaRepository

        oid = _IPistaRepository.Crear (pistaEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
