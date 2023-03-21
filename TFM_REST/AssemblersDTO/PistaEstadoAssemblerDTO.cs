using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class PistaEstadoAssemblerDTO {
public static IList<PistaEstadoEN> ConvertList (IList<PistaEstadoDTO> lista)
{
        IList<PistaEstadoEN> result = new List<PistaEstadoEN>();
        foreach (PistaEstadoDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PistaEstadoEN Convert (PistaEstadoDTO dto)
{
        PistaEstadoEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PistaEstadoEN ();



                        newinstance.Idestado = dto.Idestado;
                        newinstance.Nombre = dto.Nombre;
                        if (dto.Pistas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaRepository pistaCAD = new TFMGen.Infraestructure.Repository.TFM.PistaRepository ();

                                newinstance.Pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                                foreach (int entry in dto.Pistas_oid) {
                                        newinstance.Pistas.Add (pistaCAD.ReadOIDDefault (entry));
                                }
                        }

                        if (dto.EstadoPista_l10n != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaEstado_l10nRepository pistaEstado_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.PistaEstado_l10nRepository ();

                                newinstance.EstadoPista_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEstado_l10nEN>();
                                foreach (PistaEstado_l10nDTO entry in dto.EstadoPista_l10n) {
                                        newinstance.EstadoPista_l10n.Add (PistaEstado_l10nAssemblerDTO.Convert (entry));
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
