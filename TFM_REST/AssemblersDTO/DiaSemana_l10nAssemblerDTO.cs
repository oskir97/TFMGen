using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class DiaSemana_l10nAssemblerDTO {
public static IList<DiaSemana_l10nEN> ConvertList (IList<DiaSemana_l10nDTO> lista)
{
        IList<DiaSemana_l10nEN> result = new List<DiaSemana_l10nEN>();
        foreach (DiaSemana_l10nDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static DiaSemana_l10nEN Convert (DiaSemana_l10nDTO dto)
{
        DiaSemana_l10nEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new DiaSemana_l10nEN ();



                        if (dto.DiaSemana_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDiaSemanaRepository diaSemanaCAD = new TFMGen.Infraestructure.Repository.TFM.DiaSemanaRepository ();

                                newinstance.DiaSemana = diaSemanaCAD.ReadOIDDefault (dto.DiaSemana_oid);
                        }
                        if (dto.Idioma_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IIdiomaRepository idiomaCAD = new TFMGen.Infraestructure.Repository.TFM.IdiomaRepository ();

                                newinstance.Idioma = idiomaCAD.ReadOIDDefault (dto.Idioma_oid);
                        }
                        newinstance.Iddiasemana = dto.Iddiasemana;
                        newinstance.Nombre = dto.Nombre;
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
