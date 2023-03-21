using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFM_REST.DTOA
{
public class ReservaDTOA
{
private int idreserva;
public int Idreserva
{
        get { return idreserva; }
        set { idreserva = value; }
}

private bool cancelada;
public bool Cancelada
{
        get { return cancelada; }
        set { cancelada = value; }
}

private int maxparticipantes;
public int Maxparticipantes
{
        get { return maxparticipantes; }
        set { maxparticipantes = value; }
}

private Nullable<DateTime> fecha;
public Nullable<DateTime> Fecha
{
        get { return fecha; }
        set { fecha = value; }
}

private TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum tipo;
public TFMGen.ApplicationCore.Enumerated.TFM.TipoReservaEnum Tipo
{
        get { return tipo; }
        set { tipo = value; }
}
}
}
