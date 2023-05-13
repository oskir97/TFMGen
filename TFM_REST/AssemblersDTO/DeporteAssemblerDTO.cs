using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.EN.TFM;
using TFM_REST.DTO;
using TFMGen.Infraestructure.Repository.TFM;

namespace TFM_REST.AssemblersDTO
{
public class DeporteAssemblerDTO {
public static IList<DeporteEN> ConvertList (IList<DeporteDTO> lista)
{
        IList<DeporteEN> result = new List<DeporteEN>();
        foreach (DeporteDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static DeporteEN Convert (DeporteDTO dto)
{
        DeporteEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new DeporteEN ();



                        newinstance.Iddeporte = dto.Iddeporte;
                        newinstance.Nombre = dto.Nombre;
                        newinstance.Descripcion = dto.Descripcion;
                        if (dto.Pistas_oid != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IPistaRepository pistaCAD = new TFMGen.Infraestructure.Repository.TFM.PistaRepository ();

                                newinstance.Pistas = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.PistaEN>();
                                foreach (int entry in dto.Pistas_oid) {
                                        newinstance.Pistas.Add (pistaCAD.ReadOIDDefault (entry));
                                }
                        }

                        if (dto.Deporte_l10n != null) {
                                TFMGen.ApplicationCore.IRepository.TFM.IDeporte_l10nRepository deporte_l10nCAD = new TFMGen.Infraestructure.Repository.TFM.Deporte_l10nRepository ();

                                newinstance.Deporte_l10n = new System.Collections.Generic.List<TFMGen.ApplicationCore.EN.TFM.Deporte_l10nEN>();
                                foreach (Deporte_l10nDTO entry in dto.Deporte_l10n) {
                                        newinstance.Deporte_l10n.Add (Deporte_l10nAssemblerDTO.Convert (entry));
                                }
                        }
                        newinstance.Icono = dto.Icono;
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
