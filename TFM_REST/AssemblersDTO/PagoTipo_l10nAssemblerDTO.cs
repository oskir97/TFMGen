using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class PagoTipo_l10nAssemblerDTO {
public static IList<PagoTipo_l10nEN> ConvertList (IList<PagoTipo_l10nDTO> lista)
{
        IList<PagoTipo_l10nEN> result = new List<PagoTipo_l10nEN>();
        foreach (PagoTipo_l10nDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PagoTipo_l10nEN Convert (PagoTipo_l10nDTO dto)
{
        PagoTipo_l10nEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PagoTipo_l10nEN ();



                        newinstance.Nombre = dto.Nombre;
                        newinstance.Id = dto.Id;
                        if (dto.PagoTipo_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPagoTipoRepository pagoTipoCAD = new TFMGen.Infraestructure.Repository.TFM.PagoTipoRepository ();

                                newinstance.PagoTipo = pagoTipoCAD.ReadOIDDefault (dto.PagoTipo_oid);
                        }
                        if (dto.Idioma_oid != -1) {
                                TFMGen.ApplicationCore.IRepository.TFM.IIdiomaRepository idiomaCAD = new TFMGen.Infraestructure.Repository.TFM.IdiomaRepository ();

                                newinstance.Idioma = idiomaCAD.ReadOIDDefault (dto.Idioma_oid);
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
