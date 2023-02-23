

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

public void Editar (int p_Reserva_OID, string p_nombre, string p_apellidos, string p_email, string p_telefono, bool p_cancelada, int p_maxparticipantes, Nullable<DateTime> p_fecha, TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum p_tipo)
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
        reservaEN.Maxparticipantes = p_maxparticipantes;
        reservaEN.Fecha = p_fecha;
        reservaEN.Tipo = p_tipo;
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

public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Listar (int p_identidad)
{
        return _IReservaRepository.Listar (p_identidad);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Obtenerinscripciones (int p_idReserva)
{
        return _IReservaRepository.Obtenerinscripciones (p_idReserva);
}
public System.Collections.Generic.IList<TFMGen.ApplicationCore.EN.TFM.ReservaEN> Obtenerreservaspista (int p_idPista, Nullable<DateTime> p_fecha)
{
        return _IReservaRepository.Obtenerreservaspista (p_idPista, p_fecha);
}
}
}
