

using System;
using System.Text;
using System.Collections.Generic;

using TFMGen.ApplicationCore.Exceptions;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;


namespace TFMGen.ApplicationCore.CEN.TFM
{
/*
 *      Definition of the class ReservaCEN
 *
 */
public partial class ReservaCEN
{
private IReservaRepository _IReservaRepository;

public ReservaCEN(IReservaRepository _IReservaRepository)
{
        this._IReservaRepository = _IReservaRepository;
}

public IReservaRepository get_IReservaRepository ()
{
        return this._IReservaRepository;
}

public int Crear (string p_nombre, string p_apellidos, string p_email, string p_telefono, bool p_cancelada, int p_pista, bool p_espartido, int p_maxparticipantes)
{
        ReservaEN reservaEN = null;
        int oid;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.Nombre = p_nombre;

        reservaEN.Apellidos = p_apellidos;

        reservaEN.Email = p_email;

        reservaEN.Telefono = p_telefono;

        reservaEN.Cancelada = p_cancelada;


        if (p_pista != -1) {
                // El argumento p_pista -> Property pista es oid = false
                // Lista de oids idreserva
                reservaEN.Pista = new TFMGen.ApplicationCore.EN.TFM.PistaEN ();
                reservaEN.Pista.Idpista = p_pista;
        }

        reservaEN.Espartido = p_espartido;

        reservaEN.Maxparticipantes = p_maxparticipantes;



        oid = _IReservaRepository.Crear (reservaEN);
        return oid;
}

public void Editar (int p_Reserva_OID, string p_nombre, string p_apellidos, string p_email, string p_telefono, bool p_cancelada, bool p_espartido, int p_maxparticipantes)
{
        ReservaEN reservaEN = null;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.Idreserva = p_Reserva_OID;
        reservaEN.Nombre = p_nombre;
        reservaEN.Apellidos = p_apellidos;
        reservaEN.Email = p_email;
        reservaEN.Telefono = p_telefono;
        reservaEN.Cancelada = p_cancelada;
        reservaEN.Espartido = p_espartido;
        reservaEN.Maxparticipantes = p_maxparticipantes;
        //Call to ReservaRepository

        _IReservaRepository.Editar (reservaEN);
}

public void Eliminar (int idreserva
                      )
{
        _IReservaRepository.Eliminar (idreserva);
}

public ReservaEN Obtener (int idreserva
                          )
{
        ReservaEN reservaEN = null;

        reservaEN = _IReservaRepository.Obtener (idreserva);
        return reservaEN;
}

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listar (int p_idUsuario)
{
        return _IReservaRepository.Listar (p_idUsuario);
}
}
}
