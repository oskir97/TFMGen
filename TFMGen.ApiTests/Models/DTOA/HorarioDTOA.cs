using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace TFMGen.ApiTests.Models.DTOA
{
public class HorarioDTOA
{
private int idhorario;
public int Idhorario
{
        get { return idhorario; }
        set { idhorario = value; }
}

private Nullable<DateTime> inicio;
public Nullable<DateTime> Inicio
{
        get { return inicio; }
        set { inicio = value; }
}

private Nullable<DateTime> fin;
public Nullable<DateTime> Fin
{
        get { return fin; }
        set { fin = value; }
}


/* Rol: Horario o--> DiaSemana */
private IList<DiaSemanaDTOA> obtenerDiasSemana;
public IList<DiaSemanaDTOA> ObtenerDiasSemana
{
        get { return obtenerDiasSemana; }
        set { obtenerDiasSemana = value; }
}

/* Rol: Horario o--> Pista */
private PistaDTOA obtenerPistaHorario;
public PistaDTOA ObtenerPistaHorario
{
        get { return obtenerPistaHorario; }
        set { obtenerPistaHorario = value; }
}
}
}
