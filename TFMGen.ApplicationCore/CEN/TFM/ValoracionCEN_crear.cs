
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Valoracion_crear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ValoracionCEN
{
public int Crear (int p_estrellas, string p_comentario, int p_usuario, Nullable<DateTime> p_fecha, int p_instalacion, int p_evento, int p_usuarioPartido)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Valoracion_crear_customized) START*/

        ValoracionEN valoracionEN = null;

        int oid;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Estrellas = p_estrellas;

        valoracionEN.Comentario = p_comentario;


        if (p_usuario != -1) {
                valoracionEN.Usuario = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN ();
                valoracionEN.Usuario.Idusuario = p_usuario;
        }

        valoracionEN.Fecha = p_fecha;


        if (p_instalacion != -1) {
                valoracionEN.Instalacion = new TFMGen.ApplicationCore.EN.TFM.InstalacionEN ();
                valoracionEN.Instalacion.Idinstalacion = p_instalacion;
        }


        if (p_evento != -1) {
                valoracionEN.Evento = new TFMGen.ApplicationCore.EN.TFM.EventoEN ();
                valoracionEN.Evento.Idevento = p_evento;
        }


        if (p_usuarioPartido != -1) {
                valoracionEN.Usuariopartido = new TFMGen.ApplicationCore.EN.TFM.UsuarioEN ();
                valoracionEN.Usuariopartido.Idusuario = p_usuarioPartido;
        }

        //Call to ValoracionRepository

        oid = _IValoracionRepository.Crear (valoracionEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
