
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Evento_asignarusuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class EventoCEN
{
public void Asignarusuario (int p_oid, TFMGen.ApplicationCore.EN.TFM.UsuarioEN usuario, int numeroAlumnos)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Evento_asignarusuario) ENABLED START*/

        // Write here your custom code...

        EventoEN eventoEN = null;

        eventoEN = _IEventoRepository.Obtener (p_oid);

        if (numeroAlumnos == 0) {
                eventoEN.Usuarios = new List<UsuarioEN>() {
                        usuario
                };
        }
        else{
                if (!eventoEN.Usuarios.Contains (usuario)) {
                        eventoEN.Usuarios.Add (usuario);
                }
        }


        _IEventoRepository.Editar (eventoEN);

        /*PROTECTED REGION END*/
}
}
}
