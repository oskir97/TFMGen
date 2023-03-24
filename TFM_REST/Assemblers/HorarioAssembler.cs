using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using TFM_REST.DTOA;
using TFM_REST.CAD;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.CEN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFM_REST.Assemblers
{
public static class HorarioAssembler
{
public static HorarioDTOA Convert (HorarioEN en, GenericUnitOfWorkRepository unitRepo, GenericSessionCP session = null)
{
        HorarioDTOA dto = null;
        HorarioRESTCAD horarioRESTCAD = null;
        HorarioCEN horarioCEN = null;
        HorarioCP horarioCP = null;

        if (en != null) {
                dto = new HorarioDTOA ();
                horarioRESTCAD = new HorarioRESTCAD (session);
                horarioCEN = new HorarioCEN (horarioRESTCAD);
                horarioCP = new HorarioCP (session, unitRepo);





                //
                // Attributes

                dto.Idhorario = en.Idhorario;

                dto.Inicio = en.Inicio;


                dto.Fin = en.Fin;


                //
                // TravesalLink

                /* Rol: Horario o--> DiaSemana */
                dto.ObtenerDiasSemana = null;
                List<DiaSemanaEN> ObtenerDiasSemana = horarioRESTCAD.ObtenerDiasSemana (en.Idhorario).ToList ();
                if (ObtenerDiasSemana != null) {
                        dto.ObtenerDiasSemana = new List<DiaSemanaDTOA>();
                        foreach (DiaSemanaEN entry in ObtenerDiasSemana)
                                dto.ObtenerDiasSemana.Add (DiaSemanaAssembler.Convert (entry, unitRepo, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
