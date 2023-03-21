using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class PistaEstado_l10nAssemblerDTO {
public static IList<PistaEstado_l10nEN> ConvertList (IList<PistaEstado_l10nDTO> lista)
{
        IList<PistaEstado_l10nEN> result = new List<PistaEstado_l10nEN>();
        foreach (PistaEstado_l10nDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PistaEstado_l10nEN Convert (PistaEstado_l10nDTO dto)
{
        PistaEstado_l10nEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PistaEstado_l10nEN ();



                        newinstance.Nombre = dto.Nombre;
                        if (dto.Idioma_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IIdiomaRepository idiomaCAD = new TFMGen.Infraestructure.Repository.TFM.IdiomaRepository ();

                                newinstance.Idioma = idiomaCAD.ReadOIDDefault (dto.Idioma_oid);
                        }
                        if (dto.EstadoPista_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaEstadoRepository pistaEstadoCAD = new TFMGen.Infraestructure.Repository.TFM.PistaEstadoRepository ();

                                newinstance.EstadoPista = pistaEstadoCAD.ReadOIDDefault (dto.EstadoPista_oid);
                        }
                        newinstance.Id = dto.Id;
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
