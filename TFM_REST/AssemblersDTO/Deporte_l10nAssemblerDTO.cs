using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class Deporte_l10nAssemblerDTO {
public static IList<Deporte_l10nEN> ConvertList (IList<Deporte_l10nDTO> lista)
{
        IList<Deporte_l10nEN> result = new List<Deporte_l10nEN>();
        foreach (Deporte_l10nDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static Deporte_l10nEN Convert (Deporte_l10nDTO dto)
{
        Deporte_l10nEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new Deporte_l10nEN ();



                        newinstance.Nombre = dto.Nombre;
                        newinstance.Id = dto.Id;
                        if (dto.Idioma_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IIdiomaRepository idiomaCAD = new TFMGen.Infraestructure.Repository.TFM.IdiomaRepository ();

                                newinstance.Idioma = idiomaCAD.ReadOIDDefault (dto.Idioma_oid);
                        }
                        if (dto.Deporte_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDeporteRepository deporteCAD = new TFMGen.Infraestructure.Repository.TFM.DeporteRepository ();

                                newinstance.Deporte = deporteCAD.ReadOIDDefault (dto.Deporte_oid);
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
