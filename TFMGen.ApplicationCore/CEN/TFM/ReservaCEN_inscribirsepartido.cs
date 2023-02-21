
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


/*PROTECTED REGION ID(usingTFMGen.ApplicationCore.CEN.TFM_Reserva_inscribirsepartido) ENABLED START*/
//  references to other libraries
using System.Linq;
/*PROTECTED REGION END*/

namespace TFMGen.ApplicationCore.CEN.TFM
{
public partial class ReservaCEN
{
public int Inscribirsepartido (TFMGen.ApplicationCore.EN.TFM.ReservaEN p_partido, TFMGen.ApplicationCore.EN.TFM.UsuarioEN p_usuario)
{
        /*PROTECTED REGION ID(TFMGen.ApplicationCore.CEN.TFM_Reserva_inscribirsepartido) ENABLED START*/

        // Write here your custom code...
        int oid = 0;

        if (_IReservaRepository.Obtenerinscripciones (p_partido.Idreserva).Count () < p_partido.Maxparticipantes - 1) { // se le resta 1 por la reserva del creador del partido
                ReservaEN inscripcion = new ReservaEN ();
                inscripcion.Nombre = p_usuario.Nombre;
                inscripcion.Apellidos = p_usuario.Apellidos;
                inscripcion.Email = p_usuario.Email;
                inscripcion.Telefono = p_usuario.Telefono;
                inscripcion.Cancelada = false;
                inscripcion.Maxparticipantes = 1;
                inscripcion.Fecha = p_partido.Fecha;
                inscripcion.Pista = p_partido.Pista;
                inscripcion.Horario = p_partido.Horario;
                inscripcion.Tipo = Enumerated.TFM.TipoReservaEnum.inscripcion;

                inscripcion.Partido = p_partido;
                inscripcion.Usuario = p_usuario;

                oid = _IReservaRepository.Crear (inscripcion);
        }

        return oid;

        /*PROTECTED REGION END*/
}
}
}
