using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class DiaSemanaAssemblerDTO {
public static IList<DiaSemanaEN> ConvertList (IList<DiaSemanaDTO> lista)
{
        IList<DiaSemanaEN> result = new List<DiaSemanaEN>();
        foreach (DiaSemanaDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static DiaSemanaEN Convert (DiaSemanaDTO dto)
{
        DiaSemanaEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new DiaSemanaEN ();



                        newinstance.Iddiasemana = dto.Iddiasemana;
                        newinstance.Nombre = dto.Nombre;

                        if (dto.DiaSemana_l10n != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDiaSemana_l10nRepository diaSemana_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.DiaSemana_l10nRepository ();

                                newinstance.DiaSemana_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.DiaSemana_l10nEN>();
                                foreach (DiaSemana_l10nDTO entry in dto.DiaSemana_l10n) {
                                        newinstance.DiaSemana_l10n.Add (DiaSemana_l10nAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.Horario_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IHorarioRepository horarioCAD = new TFMGen.Infraestructure.Repository.TFM.HorarioRepository ();

                                newinstance.Horario = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.HorarioEN>();
                                foreach (int entry in dto.Horario_oid) {
                                        newinstance.Horario.Add (horarioCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Eventos_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IEventoRepository eventoCAD = new TFMGen.Infraestructure.Repository.TFM.EventoRepository ();

                                newinstance.Eventos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.EventoEN>();
                                foreach (int entry in dto.Eventos_oid) {
                                        newinstance.Eventos.Add (eventoCAD.ReadOIDDefault (entry));
                                }
                        }
                }
        }
        catch (Exception)
        {
                throw;
        }
        return newinstance;
}
}
}
