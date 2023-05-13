
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Pista_editar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class PistaCEN
{
public void Editar (int p_Pista_OID, string p_nombre, int p_maxreservas, string p_ubicacion, bool p_visible, int p_estadosPista, System.Collections.Generic.IList<int> p_deporte, int p_instalacion, double p_precio)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Pista_editar_customized) ENABLED START*/

        PistaEN pistaEN = null;

        //Initialized PistaEN
        pistaEN = new PistaEN ();
        pistaEN.Idpista = p_Pista_OID;
        pistaEN.Nombre = p_nombre;
        pistaEN.Maxreservas = p_maxreservas;
        pistaEN.Ubicacion = p_ubicacion;
        pistaEN.Visible = p_visible;
        if (p_estadosPista != -1) {
                pistaEN.EstadosPista = new TFMGen.ApplicationCore.EN.TFM.PistaEstadoEN ();
                pistaEN.EstadosPista.Idestado = p_estadosPista;
        }

        if (p_deporte != null) {
                pistaEN.Deporte = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DeporteEN>();
                foreach (int item in p_deporte) {
                        TFMGen.ApplicationCore.EN.TFM.DeporteEN en = new TFMGen.ApplicationCore.EN.TFM.DeporteEN ();
                        en.Iddeporte = item;
                        pistaEN.Deporte.Add (en);
                }
        }

        else{
                pistaEN.Deporte = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DeporteEN>();
        }
        if (p_instalacion != -1) {
                pistaEN.Instalacion = new TFMGen.ApplicationCore.EN.TFM.InstalacionEN ();
                pistaEN.Instalacion.Idinstalacion = p_instalacion;
        }
        else{
                pistaEN.Instalacion = null;
        }
        pistaEN.Precio = p_precio;
        //Call to PistaRepository

        _IPistaRepository.Editar (pistaEN);

        /*PROTECTED REGION END*/
}
}
}
