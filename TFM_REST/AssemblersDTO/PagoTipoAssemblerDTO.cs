using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class PagoTipoAssemblerDTO {
public static IList<PagoTipoEN> ConvertList (IList<PagoTipoDTO> lista)
{
        IList<PagoTipoEN> result = new List<PagoTipoEN>();
        foreach (PagoTipoDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PagoTipoEN Convert (PagoTipoDTO dto)
{
        PagoTipoEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PagoTipoEN ();



                        newinstance.Idtipo = dto.Idtipo;
                        newinstance.Nombre = dto.Nombre;
                        if (dto.Pagos_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPagoRepository pagoCAD = new TFMGen.Infraestructure.Repository.TFM.PagoRepository ();

                                newinstance.Pagos = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PagoEN>();
                                foreach (int entry in dto.Pagos_oid) {
                                        newinstance.Pagos.Add (pagoCAD.ReadOIDDefault (entry));
                                }
                        }

                        if (dto.PagoTipo_l10n != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPagoTipo_l10nRepository pagoTipo_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.PagoTipo_l10nRepository ();

                                newinstance.PagoTipo_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PagoTipo_l10nEN>();
                                foreach (PagoTipo_l10nDTO entry in dto.PagoTipo_l10n) {
                                        newinstance.PagoTipo_l10n.Add (PagoTipo_l10nAssemblerDTO.Convert (entry));
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
